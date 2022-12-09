using System.Data;

namespace Estetica.Infra.Data.Interface
{
    public interface IConnectionFactory
    {
        IDbConnection Conexao();
    }
}
