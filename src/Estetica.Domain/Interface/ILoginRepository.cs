using Estetica.Domain.Entities;

namespace Estetica.Domain.Interface
{
    public interface ILoginRepository : IBaseRepository
    {
        Task<Login> Logar(Login login);
    }
}