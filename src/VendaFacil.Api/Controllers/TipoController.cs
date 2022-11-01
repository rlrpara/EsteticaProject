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
    [Route("api/[controller]")]
    [ApiController]
    public class TipoController : ControllerBase
    {
        #region [Propriedades Privadas]
        private readonly IMapper _mapper;
        private readonly ITipoService _service;
        #endregion

        #region [Métodos Privados]
        private int ObterTotalPaginas(filtroTipoViewModel filtro)
        {
            var total = _service.ObterTotalRegistros(filtro) / filtro.QuantidadePorPagina;
            if ((_service.ObterTotalRegistros(filtro) % filtro.QuantidadePorPagina) > 0)
                total += 1;
            return total.Equals(0) ? 1 : total;
        }
        #endregion

        #region [Contrutor]
        public TipoController(IMapper mapper)
        {
            _mapper = mapper;
            _service = new TipoService(new BaseRepository(), _mapper);
        }
        #endregion

        #region [Propriedades Públicas]
        [HttpGet("ObterPorId/{id}")]
        public IActionResult GetObterPorId(int? id)
        {
            if (id is not null)
                return Ok(new { Resultado = _service.ObterPorCodigo(id ?? 0) });
            else
                return Ok(new { Resultado = "Código não informado." });
        }

        [HttpPost("ObterTodos")]
        public IActionResult PostObterTodos([FromBody] filtroTipoViewModel filtro)
        {
            List<TipoViewModel> dadosRetorno = _service.ObterTodos(filtro).ToList();

            if (dadosRetorno is null)
                return Ok(new { Resultado = "Registro não encontrado." });

            var resultado = new ApiResult<TipoViewModel>();
            resultado.AddPaginacao(filtro.PaginaAtual, filtro.QuantidadePorPagina, ObterTotalPaginas(filtro), _service.ObterTotalRegistros(filtro), dadosRetorno);

            return Ok(resultado);
        }

        [HttpPost("Inserir")]
        public IActionResult PostInserir([FromBody] TipoViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (_service.ObterEntidade(model))
                    return Ok(new { Resultado = "Registro já cadastrado." });

                return Created("", _service.Inserir(model));
            }
            return BadRequest(ModelState);
        }

        [HttpPut("Atualizar")]
        public IActionResult PutAtualizar([FromBody] TipoViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Codigo.Equals(0))
                    return Ok(new { Resultado = "Registro não encontrado" });

                var consulta = _service.ObterPorCodigo(model.Codigo);

                if (consulta is not null)

                    return Ok(_service.Atualizar(model));
                else
                    return BadRequest(new { Resultado = "Registro não encontrado" });
            }

            return BadRequest(ModelState);
        }

        [HttpDelete("Excluir/{id}")]
        public IActionResult DeleteExcluir(int id)
        {
            if (id.Equals(0))
                return Ok(new { Resultado = "Registro não encontrado" });

            var consulta = _service.ObterPorCodigo(id);

            if (consulta is not null)
            {
                if (!(consulta.Ativo ?? false))
                    return Ok(new { Resultado = "Registro ja deletado" });
                return Ok(_service.Deletar(consulta));
            }
            else
                return Ok(new { Resultado = "Registro não encontrado" });
        }
        #endregion
    }
}
