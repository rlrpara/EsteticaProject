using VendaFacil.Service.ViewModel;

namespace VendaFacil.Service.Interface
{
    public interface ILoginService : IBaseService
    {
        dynamic Authenticate(UsuarioAuthenticateRequestModel login);
    }
}
