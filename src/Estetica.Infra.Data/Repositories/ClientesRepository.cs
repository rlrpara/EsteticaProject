using Estetica.Domain.Entities;
using Estetica.Domain.Entities.Filtros;
using Estetica.Domain.Interface;
using System.Text;

namespace Estetica.Infra.Data.Repositories
{
    public class ClientesRepository : BaseRepository, IClientesRepository
    {
        #region [Propriedades Privadas]
        private readonly IBaseRepository _baseRepository;
        #endregion

        #region [Métodos Privados]
        private string ObterFiltros(filtroClientes filtro)
        {
            var sqlPesquisa = new StringBuilder();

            sqlPesquisa.AppendLine($" WHERE nome ilike '%{filtro.Nome}%'");
            sqlPesquisa.AppendLine($"   AND ativo = true");

            return sqlPesquisa.ToString();
        }
        #endregion

        #region [Construtor]
        public ClientesRepository(IBaseRepository baseRepository) => _baseRepository = baseRepository;
        #endregion

        #region [Métodos Públicos]
        public async Task<int> TotalRegistros(filtroClientes filtro)
        {
            var sqlPesquisa = new StringBuilder();

            sqlPesquisa.AppendLine($"SELECT COUNT(ID) as Total");
            sqlPesquisa.AppendLine($"  FROM cliente");
            sqlPesquisa.AppendLine(ObterFiltros(filtro));

            return await _baseRepository.BuscarPorQueryAsync<int>(sqlPesquisa.ToString());
        }
        public async Task<Clientes> ObterPorCodigo(int codigo) => await _baseRepository.BuscarPorIdAsync<Clientes>(codigo);
        public IEnumerable<Clientes> ObterTodos(filtroClientes filtro)
        {
            var sqlPesquisa = new StringBuilder();

            sqlPesquisa.AppendLine($" nome ilike '%{filtro.Nome}%'");
            sqlPesquisa.AppendLine($" AND ativo = true");

            return _baseRepository.BuscarTodosPorQueryGerador<Clientes>(sqlPesquisa.ToString());
        }
        public async Task<IEnumerable<Clientes>> ObterTodosAsync(filtroClientes filtro)
        {
            var sqlPesquisa = new StringBuilder();

            sqlPesquisa.AppendLine($"DO $$");
            sqlPesquisa.AppendLine($"DECLARE QtdPorPagina INTEGER;");
            sqlPesquisa.AppendLine($"        Pagina       INTEGER;");
            sqlPesquisa.AppendLine($"BEGIN");
            sqlPesquisa.AppendLine($"    SELECT {filtro.QuantidadePorPagina} INTO QtdPorPagina;");
            sqlPesquisa.AppendLine($"    SELECT {filtro.PaginaAtual} INTO Pagina;");
            sqlPesquisa.AppendLine($"      DROP TABLE IF EXISTS TMP_TABLE;");
            sqlPesquisa.AppendLine($"    CREATE TEMP TABLE tmp_table AS");
            sqlPesquisa.AppendLine($"    SELECT id as Codigo,");
            sqlPesquisa.AppendLine($"           nome,");
            sqlPesquisa.AppendLine($"           nascimento,");
            sqlPesquisa.AppendLine($"           cpf,");
            sqlPesquisa.AppendLine($"           whatsapp,");
            sqlPesquisa.AppendLine($"           email,");
            sqlPesquisa.AppendLine($"           celular,");
            sqlPesquisa.AppendLine($"           foto,");
            sqlPesquisa.AppendLine($"           data_cadastro as DataCadastro,");
            sqlPesquisa.AppendLine($"           data_atualizacao as DataAtualizacao,");
            sqlPesquisa.AppendLine($"           ativo");
            sqlPesquisa.AppendLine($"      FROM cliente");
            sqlPesquisa.AppendLine(ObterFiltros(filtro));
            sqlPesquisa.AppendLine($"     LIMIT QtdPorPagina");
            sqlPesquisa.AppendLine($"    OFFSET (Pagina - 1) * QtdPorPagina;");
            sqlPesquisa.AppendLine($"END $$;");
            sqlPesquisa.AppendLine($"");
            sqlPesquisa.AppendLine($"SELECT * FROM tmp_table;");

            return await _baseRepository.BuscarTodosPorQueryAsync<Clientes>(sqlPesquisa.ToString().Trim());
        }
        public async Task<bool> ObterEntidade(Clientes clientes)
        {
            var sqlPesquisa = new StringBuilder();

            sqlPesquisa.AppendLine($" (nome = '{clientes.Nome}'");

            return await _baseRepository.BuscarPorQueryGeradorAsync<Usuario>(sqlPesquisa.ToString()) is not null;
        }
        public async Task<bool> Inserir(Clientes clientes) => await _baseRepository.AdicionarAsync(clientes) > 0;
        public async Task<bool> Atualizar(Clientes clientes) => await _baseRepository.AtualizarAsync(clientes.Codigo, clientes) > 0;
        #endregion
    }
}
