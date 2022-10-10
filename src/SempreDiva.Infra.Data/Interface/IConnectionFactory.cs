using System.Data;

namespace SempreDivas.Infra.Data.Interface
{
    public interface IConnectionFactory
    {
        IDbConnection Conexao();
    }
}
