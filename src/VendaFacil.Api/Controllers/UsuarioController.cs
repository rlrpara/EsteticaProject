using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using VendaFacil.Api.Model;
using VendaFacil.Infra.Data.Repositories;
using VendaFacil.Service.Interface;
using VendaFacil.Service.Service;
using VendaFacil.Service.ViewModel.Entities;
using VendaFacil.Service.ViewModel.Entities.Filtros;

namespace VendaFacil.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        #region [Propriedades Privadas]
        private readonly IMapper _mapper;
        private readonly IUsuarioService _service;
        #endregion

        #region [Métodos Privados]
        private int ObterTotalPaginas(filtroUsuarioViewModel filtro)
        {
            var total = _service.ObterTotalRegistros(filtro) / filtro.QuantidadePorPagina;
            if ((_service.ObterTotalRegistros(filtro) % filtro.QuantidadePorPagina) > 0)
                total += 1;
            return total.Equals(0) ? 1 : total;
        }
        #endregion

        #region [Contrutor]
        public UsuarioController(IMapper mapper)
        {
            _mapper = mapper;
            _service = new UsuarioService(new BaseRepository(), _mapper);
        }
        #endregion

        #region [Propriedades Públicas]
        [HttpPost("ObterTodos")]
        public IActionResult PostObterTodos([FromBody] filtroUsuarioViewModel filtro)
        {
            var dadosRetorno = _service.ObterTodos(filtro).ToList();

            if (dadosRetorno is null)
                return Ok(new { Resultado = "Nenhum registro encontrado." });

            var resultado = new ApiResult<UsuarioViewModel>();
            resultado.AddPaginacao(filtro.PaginaAtual, filtro.QuantidadePorPagina, ObterTotalPaginas(filtro), _service.ObterTotalRegistros(filtro), dadosRetorno);

            return Ok(resultado);
        }

        [HttpPost("")]
        public IActionResult PostInserir([FromBody]UsuarioViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (_service.JaCadastrado(model))
                    return Ok(new { Resultado = "Usuário já cadastrado." });

                return Created("", _service.Inserir(model));
            }
            return BadRequest(ModelState);
        }

        //[HttpPut]
        //public IActionResult PutAtualizar([FromBody]UsuarioViewModel model)
        //{

        //}
        #endregion
    }
}
