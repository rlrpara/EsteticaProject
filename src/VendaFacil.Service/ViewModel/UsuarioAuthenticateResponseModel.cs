using VendaFacil.Service.ViewModel.Entities;

namespace VendaFacil.Service.ViewModel
{
    public class UsuarioAuthenticateResponseModel
    {
        #region [Propriedades Privadas]
        public ViewModelLogin Login { get; set; }
        public string Token { get; set; }
        #endregion

        #region [Construtor]
        public UsuarioAuthenticateResponseModel(ViewModelLogin login, string token)
        {
            Login = login;
            Token = token;
        }
        #endregion
    }
}
