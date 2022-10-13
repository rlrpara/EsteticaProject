using AutoMapper;
using Microsoft.AspNetCore.Components.RenderTree;
using Microsoft.AspNetCore.Mvc;
using VendaFacil.Api.Model;
using VendaFacil.Domain.Interface;
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
            try
            {
                var resultadConsulta = _service.ObterTodos(filtro);

                if (resultadConsulta is null)
                    return Ok(new { Resultado = "Nenhum registro encontrado." });

                var resultado = new ApiResult<UsuarioViewModel>(filtro.PaginaAtual, filtro.QuantidadePorPagina, resultadConsulta);

                return Ok(
                    new
                    { 
                        PaginaAtual = filtro.PaginaAtual,
                        QuantidadePorPagina = filtro.QuantidadePorPagina,
                        Dados = resultadConsulta
                    });
            }
            catch
            {
                return BadRequest();
            }
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

        [HttpPut]
        public IActionResult PutAtualizar([FromBody]UsuarioViewModel model)
        {

        }
        #endregion
    }
}
