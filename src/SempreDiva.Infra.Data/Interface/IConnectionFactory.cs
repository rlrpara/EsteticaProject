using System.Data;

namespace SempreDiva.Infra.Data.Interface
{
    public interface IConnectionFactory
    {
        IDbConnection Conexao();
    }
}
