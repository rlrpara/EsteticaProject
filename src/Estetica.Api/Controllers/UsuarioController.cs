using Microsoft.AspNetCore.Mvc;
using Estetica.Api.Model;
using Estetica.Service.Interface;
using Estetica.Service.ViewModel.Entities;
using Estetica.Service.ViewModel.Entities.Filtros;
using Microsoft.AspNetCore.Authorization;

namespace Estetica.Api.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        #region [Propriedades Privadas]
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
        public UsuarioController(IUsuarioService usuarioService) => _service = usuarioService;
        #endregion

        #region [Propriedades Públicas]
        [HttpPost("ObterTodos")]
        public IActionResult PostObterTodos([FromBody] filtroUsuarioViewModel filtro)
        {
            var dadosRetorno = _service.ObterTodos(filtro).ToList();

            if (dadosRetorno is null)
                return Ok(new { Resultado = "Registro não encontrado." });

            var resultado = new ApiResult<UsuarioViewModel>();
            resultado.AddPaginacao(filtro.PaginaAtual, filtro.QuantidadePorPagina, ObterTotalPaginas(filtro), _service.ObterTotalRegistros(filtro), dadosRetorno);

            return Ok(resultado);
        }

        [HttpPost("Inserir")]
        public IActionResult PostInserir([FromBody] UsuarioViewModel model)
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
        public IActionResult PutAtualizar([FromBody] UsuarioViewModel model)
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
            
            if(consulta is null)
                return Ok(new { Resultado = "Registro não encontrado" });
            else
            {
                if (consulta is null && consulta?.Ativo is not null && !(consulta.Ativo ?? false))
                    return Ok(new { Resultado = "Registro ja deletado" });

                if (consulta is not null)
                    return Ok(_service.Deletar(consulta));
            }

            return BadRequest(new { Resultado = "Registro não encontrado" });
        }
        #endregion
    }
}
