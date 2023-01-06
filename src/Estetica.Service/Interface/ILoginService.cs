using Estetica.Service.ViewModel;
using Estetica.Service.ViewModel.Entities;

namespace Estetica.Service.Interface
{
    public interface ILoginService : IBaseService
    {
        UsuarioAuthenticateResponseModel Authenticate(UsuarioAuthenticateRequestModel login);
    }
}
