using Microsoft.AspNetCore.Mvc;

namespace VendaFacil.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        #region [Métodos Públicos]
        [HttpGet("healt-check")]
        public IActionResult Get() => Ok(new { Versao = "1.0", Servidor = Environment.GetEnvironmentVariable("SERVIDOR") });
        #endregion

    }
}
