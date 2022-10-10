using Microsoft.AspNetCore.Mvc;
using SempreDivas.Infra.Data.Repositories;
using SempreDivas.Service.Interface;
using SempreDivas.Service.Service;
using SempreDivas.Service.ViewModel.Entities;
using SempreDivas.Service.ViewModel.Entities.Filtros;

namespace SempreDivas.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        #region [Propriedades Privadas]
        private readonly IUsuarioService _service;
        #endregion

        #region [Contrutor]
        public UsuarioController() => _service = new UsuarioService(new BaseRepository());
        #endregion

        #region [Propriedades Públicas]
        [HttpPost("ObterTodos")]
        public IActionResult PostObterTodos([FromBody] filtroUsuarioViewModel filtro)
        {
            IEnumerable<UsuarioViewModel> modelo = _service.ObterTodos(filtro)
        }
        #endregion
    }
}
