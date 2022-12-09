using Estetica.Service.ViewModel;

namespace Estetica.Service.Interface
{
    public interface ILoginService : IBaseService
    {
        UsuarioAuthenticateResponseModel Authenticate(UsuarioAuthenticateRequestModel login);
    }
}
