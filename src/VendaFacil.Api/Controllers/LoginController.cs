using Microsoft.AspNetCore.Mvc;
using VendaFacil.Service.Interface;
using VendaFacil.Service.ViewModel;

namespace VendaFacil.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        #region [Propriedades Privadas]
        private readonly ILoginService _service;
        #endregion

        #region [Métodos Privados]
        private string GetToken(UsuarioAuthenticateRequestModel login)
        {
            if (string.IsNullOrWhiteSpace(login.Email) || string.IsNullOrWhiteSpace(login.Senha))
                return $"Usuário/Senha não preenchido";

            var resultado = _service.Authenticate(login);

            if (resultado is null)
                return $"Usuário não encontrado.";

            return resultado.Token;
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
