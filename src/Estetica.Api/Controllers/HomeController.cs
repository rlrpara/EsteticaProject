using Microsoft.AspNetCore.Mvc;

namespace Estetica.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        #region [Métodos Públicos]
        [HttpGet("healt-check")]
        public IActionResult Get() => Ok(
            new {
                Versao = "1.0",
                Servidor = Environment.GetEnvironmentVariable("SERVIDOR"),
                Banco = Environment.GetEnvironmentVariable("BANCO"),
                Porta = Environment.GetEnvironmentVariable("PORTA"),
                Usuario = Environment.GetEnvironmentVariable("USUARIO"),
                Senha = Environment.GetEnvironmentVariable("SENHA"),
                TipoBanco = Environment.GetEnvironmentVariable("TIPOBANCO")
            }
        );
        #endregion

    }
}
