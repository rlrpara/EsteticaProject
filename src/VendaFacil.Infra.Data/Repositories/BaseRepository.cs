using Dapper;
using System.Data;
using System.Text;
using VendaFacil.Domain.Interface;
using VendaFacil.Infra.Data.Context;

namespace VendaFacil.Infra.Data.Repositories
{
    public class BaseRepository : IBaseRepository
    {
        #region [Propriedades Privadas]
        private ParametrosConexao _parametrosConexao;
        #endregion

        #region [Métodos Privados]
        private static string ObterNomeTabela<T>()
        {
            return TableNameMapper(typeof(T));
        }
        private static string TableNameMapper(Type type)
        {
            dynamic tableattr = type.GetCustomAttributes(false).SingleOrDefault(attr => attr.GetType().Name == "TableAttribute");
            return tableattr != null ? tableattr.Name : string.Empty;
        }
        private IDbConnection ObterConexao() => ConnectionConfiguration.AbrirConexao(_parametrosConexao);
        private ParametrosConexao ObterParametrosConexao() => new()
        {
            Servidor = string.IsNullOrWhiteSpace(Environment.GetEnvironmentVariable("DB_PRODUCAO")) ? Environment.GetEnvironmentVariable("DB_HOMOLOGACAO") : Environment.GetEnvironmentVariable("DB_PRODUCAO"),
            Porta = Environment.GetEnvironmentVariable("DB_PORTA"),
            NomeBanco = Environment.GetEnvironmentVariable("DB_BANCO"),
            Usuario = Environment.GetEnvironmentVariable("DB_USUARIO"),
            Senha = Environment.GetEnvironmentVariable("DB_SENHA")
        };
        #endregion

        #region [Construtor]
        public BaseRepository() => _parametrosConexao = ObterParametrosConexao();
        #endregion

        #region [Métodos Públicos]
        public async Task<int> AdicionarAsync<T>(T entidade) where T : class
        {
            try
            {
                using var conn = ObterConexao();
                return await conn.ExecuteAsync(GeradorDapper.RetornaInsert(entidade));
            }
            catch
            {
                return default;
            }
        }

        public async Task<int> AtualizarAsync<T>(int id, T entidade) where T : class
        {
            try
            {
                using var conn = ObterConexao();
                return await conn.ExecuteAsync(GeradorDapper.RetornaUpdate(id, entidade), commandType: CommandType.Text);
            }
            catch
            {
                return default;
            }
        }

        public async Task<T> BuscarPorIdAsync<T>(int id) where T : class
        {
            try
            {
                var sqlPesquisa = new StringBuilder();

                sqlPesquisa.AppendLine($"SELECT {GeradorDapper.RetornaSelect<T>(_parametrosConexao.NomeBanco)}");
                sqlPesquisa.AppendLine($"  FROM {ObterNomeTabela<T>()}");
                sqlPesquisa.AppendLine($" WHERE {GeradorDapper.ObterChavePrimaria<T>()} = {id}");

                using var conn = ObterConexao();
                return await conn.QueryFirstOrDefaultAsync<T>(sqlPesquisa.ToString(), commandType: CommandType.Text);
            }
            catch
            {
                return default;
            }
        }

        public async Task<T> BuscarPorQueryAsync<T>(string query)
        {
            try
            {
                using var conn = ObterConexao();
                return await conn.QueryFirstOrDefaultAsync<T>(query, commandType: CommandType.Text, transaction: null);
            }
            catch
            {
                return default;
            }
        }

        public async Task<T> BuscarPorQueryGeradorAsync<T>(string? sqlWhere = null) where T : class
        {
            try
            {
                using var conn = ObterConexao();
                return await conn.QueryFirstOrDefaultAsync<T>(GeradorDapper.GeralSqlSelecaoControles<T>(sqlWhere, _parametrosConexao.NomeBanco), commandType: CommandType.Text);
            }
            catch
            {
                return default;
            }
        }

        public async Task<IEnumerable<T>> BuscarTodosPorQueryAsync<T>(string? query = null) where T : class
        {
            try
            {
                using var conn = ObterConexao();
                return await conn.QueryAsync<T>(query, commandType: CommandType.Text);
            }
            catch
            {
                return default;
            }
        }

        public async Task<IEnumerable<T>> BuscarTodosPorQueryGeradorAsync<T>(string? sqlWhere = null) where T : class
        {
            try
            {
                return await BuscarTodosPorQueryAsync<T>(GeradorDapper.GeralSqlSelecaoControles<T>(sqlWhere, _parametrosConexao.NomeBanco));
            }
            catch
            {
                return default;
            }
        }

        public async Task<int> ExcluirAsync<T>(int id) where T : class
        {
            try
            {
                using var conn = ObterConexao();
                return await conn.ExecuteAsync($"{GeradorDapper.RetornaDelete<T>(id)}", commandType: CommandType.Text);
            }
            catch
            {
                return default;
            }
        }

        public async Task<int?> ObterUltimoRegistroAsync<T>() where T : class
        {
            try
            {
                var sqlPesquisa = new StringBuilder();
                sqlPesquisa.AppendLine($"  SELECT TOP 1 {GeradorDapper.ObterChavePrimaria<T>()}");
                sqlPesquisa.AppendLine($"    FROM {ObterNomeTabela<T>()}");
                sqlPesquisa.AppendLine($"ORDER BY {GeradorDapper.ObterChavePrimaria<T>()} DESC");

                using var conn = ObterConexao();
                return await conn.QueryFirstOrDefaultAsync<int?>(sqlPesquisa.ToString(), commandType: CommandType.Text);
            }
            catch
            {
                return default;
            }
        }

        public void QueryAsync(string sql)
        {
            try
            {
                using var conn = ObterConexao();
                conn.QueryAsync(sql, commandType: CommandType.Text);
            }
            catch
            {
                throw;
            }
        }

        public async Task<IEnumerable<T>> QueryAsync<T>(string where) where T : class
        {
            try
            {
                using var conn = ObterConexao();
                return await conn.QueryAsync<T>(where, commandType: CommandType.Text);
            }
            catch
            {
                return default;
            }
        }
        #endregion
    }
}
