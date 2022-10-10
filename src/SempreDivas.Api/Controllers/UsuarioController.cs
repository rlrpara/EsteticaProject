using Microsoft.AspNetCore.Mvc;

namespace SempreDivas.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        #region [Propriedades Privadas]

        #endregion

        [HttpGet("")]
        public IActionResult ObterTodos() => Ok("");
    }
}
