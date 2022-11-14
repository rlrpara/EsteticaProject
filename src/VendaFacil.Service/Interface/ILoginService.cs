using VendaFacil.Domain.Entities;

namespace VendaFacil.Service.Interface
{
    public interface ILoginService : IBaseService
    {
        string GenerateToken(Login login);
    }
}
