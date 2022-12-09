using Estetica.Service.ViewModel;

namespace Estetica.Service.Interface
{
    public interface ILoginService : IBaseService
    {
        dynamic Authenticate(UsuarioAuthenticateRequestModel login);
    }
}
