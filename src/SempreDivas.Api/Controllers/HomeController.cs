using Microsoft.AspNetCore.Mvc;

namespace SempreDivas.Api.Controllers
{
    [ApiController]
    [Route("")]
    public class HomeController : ControllerBase
    {

        #region [Métodos Públicos]
        [HttpGet("healt-check")]
        public IActionResult Get() => Ok(new { Versao = "1.0" });
        #endregion
        
    }
}
