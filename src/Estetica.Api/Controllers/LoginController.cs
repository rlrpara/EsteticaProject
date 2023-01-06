using Microsoft.AspNetCore.Mvc;
using Estetica.Service.Interface;
using Estetica.Service.ViewModel;

namespace Estetica.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        #region [Propriedades Privadas]
        private readonly ILoginService _service;
        #endregion

        #region [Métodos Privados]
        private dynamic GetToken(UsuarioAuthenticateRequestModel login)
        {
            if (string.IsNullOrWhiteSpace(login.Email) || string.IsNullOrWhiteSpace(login.Senha))
                return BadRequest($"Usuário/Senha não preenchido");

            UsuarioAuthenticateResponseModel resultado = _service.Authenticate(login);

            if (resultado is null)
                return BadRequest($"Usuário não encontrado.");

            return new
            { 
                codigo = resultado.Login.Codigo,
                email = resultado.Login.Email,
                nome = resultado.Login.Nome,
                token = resultado.Token
            };
        }
        #endregion

        #region [Construtor]
        public LoginController(ILoginService loginService) => _service = loginService;
        #endregion

        #region [Métodos Públicos]
        [HttpPost]
        public IActionResult Authenticate(UsuarioAuthenticateRequestModel login)
        {
            if (ModelState.IsValid)
                return Ok(GetToken(login));

            return BadRequest($"Classe inválida: {ModelState}");
        }
        #endregion
    }
}
