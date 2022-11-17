using VendaFacil.Domain.Entities;

namespace VendaFacil.Domain.Interface
{
    public interface ILoginRepository : IBaseRepository
    {
        Task<Login> Logar(Login login);
    }
}