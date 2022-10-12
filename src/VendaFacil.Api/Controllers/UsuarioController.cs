using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using VendaFacil.Api.Model;
using VendaFacil.Domain.Interface;
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
        public UsuarioController(IBaseRepository baseRepository, IMapper mapper)
        {
            _mapper = mapper;
            _service = new UsuarioService(baseRepository, _mapper);
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

                var resultado = new ApiResult<UsuarioViewModel>(filtro.PaginaAtual, filtro.QuantidadePorPagina, resultadConsulta).Result;

                return Ok(resultado);
            }
            catch
            {
                return BadRequest();
            }
        }
        #endregion
    }
}
