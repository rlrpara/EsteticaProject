using Estetica.Api.Model;
using Estetica.Service.Interface;
using Estetica.Service.ViewModel.Entities.Filtros;
using Estetica.Service.ViewModel.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Estetica.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoPessoaController : ControllerBase
    {
        #region [Propriedades Privadas]
        private readonly ITipoPessoaService _service;
        #endregion

        #region [Métodos Privados]

        #endregion

        #region [Contrutor]
        public TipoPessoaController(ITipoPessoaService TipoPessoaService) => _service = TipoPessoaService;
        #endregion

        #region [Propriedades Públicas]
        [HttpPost("ObterTodos")]
        public IActionResult PostObterTodos([FromBody] filtroTipoPessoaViewModel filtro)
        {
            var dadosRetorno = _service.ObterTodos(filtro);

            if (dadosRetorno is null)
                return Ok(new { Resultado = "Registro não encontrado." });

            return Ok(dadosRetorno);
        }

        #endregion
    }
}
