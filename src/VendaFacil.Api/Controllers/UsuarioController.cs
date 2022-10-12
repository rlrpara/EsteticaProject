using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using VendaFacil.Domain.Interface;
using VendaFacil.Service.Interface;
using VendaFacil.Service.Service;
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
            //IEnumerable<UsuarioViewModel> modelo = _service.ObterTodos(filtro)
            return Ok();
        }
        #endregion
    }
}
