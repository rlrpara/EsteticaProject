using Dapper;
using System.Data;
using System.Text;
using Estetica.Domain.Interface;
using Estetica.Domain.ValueObject;
using Estetica.Infra.Data.Context;
using Estetica.Infra.Data.Interface;

namespace Estetica.Infra.Data.Repositories
{
    public class BaseRepository : IBaseRepository
    {
        #region [Propriedades Privadas]
        private ParametrosConexao _parametrosConexao;
        private readonly IGeradorDapper _geradorDapper;
        #endregion

        #region [Métodos Privados]
        private IDbConnection ObterConexao() => ConnectionConfiguration.AbrirConexao(_parametrosConexao);
        private ParametrosConexao ObterParametrosConexao() => new()
        {
            Servidor = Environment.GetEnvironmentVariable("SERVIDOR"),
            Porta = Environment.GetEnvironmentVariable("PORTA"),
            NomeBanco = Environment.GetEnvironmentVariable("BANCO"),
            Usuario = Environment.GetEnvironmentVariable("USUARIO"),
            Senha = Environment.GetEnvironmentVariable("SENHA"),
            TipoBanco = Convert.ToInt32(Environment.GetEnvironmentVariable("TIPOBANCO"))
        };
        #endregion

        #region [Construtor]
        public BaseRepository()
        {
            _parametrosConexao = ObterParametrosConexao();
            _geradorDapper = new GeradorDapper(_parametrosConexao);
        }
        #endregion

        #region [Métodos Públicos]
        public async Task<int> AdicionarAsync<T>(T entidade) where T : class
        {
            try
            {
                using var conn = ObterConexao();
                return await conn.ExecuteAsync(_geradorDapper.GeralSqlInsertControles(entidade));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<int> AtualizarAsync<T>(int id, T entidade) where T : class
        {
            using var conn = ObterConexao();
            return await conn.ExecuteAsync(_geradorDapper.GeralSqlUpdateControles(id, entidade), commandType: CommandType.Text);
        }
        public async Task<T> BuscarPorIdAsync<T>(int id) where T : class
        {
            var sqlPesquisa = new StringBuilder();

            sqlPesquisa.AppendLine($"SELECT {_geradorDapper.RetornaCamposSelect<T>()}");
            sqlPesquisa.AppendLine($"  FROM {_geradorDapper.ObterNomeTabela<T>()}");
            sqlPesquisa.AppendLine($" WHERE {_geradorDapper.ObterChavePrimaria<T>()} = {id}");

            using var conn = ObterConexao();
            return await conn.QueryFirstOrDefaultAsync<T>(sqlPesquisa.ToString(), commandType: CommandType.Text);
        }
        public async Task<T> BuscarPorQueryAsync<T>(string query)
        {
            using var conn = ObterConexao();
            return await conn.QueryFirstOrDefaultAsync<T>(query, commandType: CommandType.Text, transaction: null);
        }
        public async Task<T> BuscarPorQueryGeradorAsync<T>(string? sqlWhere = null) where T : class
        {
            try
            {
                using var conn = ObterConexao();
                return await conn.QueryFirstOrDefaultAsync<T>(_geradorDapper.GeralSqlSelecaoControles<T>(sqlWhere), commandType: CommandType.Text);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public IEnumerable<T> BuscarTodosPorQuery<T>(string? query = null) where T : class
        {
            using var conn = ObterConexao();
            return conn.Query<T>(query, commandType: CommandType.Text);
        }
        public async Task<IEnumerable<T>> BuscarTodosPorQueryAsync<T>(string? query = null) where T : class
        {
            using var conn = ObterConexao();
            return await conn.QueryAsync<T>(query, commandType: CommandType.Text);
        }
        public IEnumerable<T> BuscarTodosPorQueryGerador<T>(string? sqlWhere = null) where T : class
            => BuscarTodosPorQuery<T>(_geradorDapper.GeralSqlSelecaoControles<T>(sqlWhere));
        public async Task<IEnumerable<T>> BuscarTodosPorQueryGeradorAsync<T>(string? sqlWhere = null) where T : class
            => await BuscarTodosPorQueryAsync<T>(_geradorDapper.GeralSqlSelecaoControles<T>(sqlWhere));
        public async Task<int> ExcluirAsync<T>(int id) where T : class
        {
            using var conn = ObterConexao();
            return await conn.ExecuteAsync($"{_geradorDapper.ObterDelete<T>(id)}", commandType: CommandType.Text);
        }
        public async Task<int?> ObterUltimoRegistroAsync<T>() where T : class
        {
            var sqlPesquisa = new StringBuilder();
            sqlPesquisa.AppendLine($"  SELECT TOP 1 {_geradorDapper.ObterChavePrimaria<T>()}");
            sqlPesquisa.AppendLine($"    FROM {_geradorDapper.ObterNomeTabela<T>()}");
            sqlPesquisa.AppendLine($"ORDER BY {_geradorDapper.ObterChavePrimaria<T>()} DESC");

            using var conn = ObterConexao();
            return await conn.QueryFirstOrDefaultAsync<int?>(sqlPesquisa.ToString(), commandType: CommandType.Text);
        }
        public void QueryAsync(string sql)
        {
            using var conn = ObterConexao();
            conn.QueryAsync(sql, commandType: CommandType.Text);
        }
        public async Task<IEnumerable<T>> QueryAsync<T>(string where) where T : class
        {
            using var conn = ObterConexao();
            return await conn.QueryAsync<T>(where, commandType: CommandType.Text);
        }

        #endregion
    }
}
