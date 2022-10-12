using System.Data;

namespace VendaFacil.Infra.Data.Interface
{
    public interface IConnectionFactory
    {
        IDbConnection Conexao();
    }
}
