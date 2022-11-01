using System.Text;
using VendaFacil.Domain.Entities;
using VendaFacil.Domain.Entities.Filtros;
using VendaFacil.Domain.Interface;

namespace VendaFacil.Infra.Data.Repositories
{
    public class DespesaRepository : BaseRepository, IDespesaRepository
    {
        #region [Propriedades Privadas]
        private readonly IBaseRepository _baseRepository;
        #endregion

        #region [Métodos Privados]
        private string ObterFiltros(filtroDespesa filtro)
        {
            var sqlPesquisa = new StringBuilder();

            sqlPesquisa.AppendLine($" WHERE descricao ILIKE '%{filtro.Descricao}%'");

            return sqlPesquisa.ToString();
        }
        #endregion

        #region [Construtor]
        public DespesaRepository(IBaseRepository baseRepository) => _baseRepository = baseRepository;
        #endregion

        #region [Propriedades Públicas]
        public async Task<int> ObterTotalRegistros(filtroDespesa filtro)
        {
            var sqlPesquisa = new StringBuilder();

            sqlPesquisa.AppendLine($"SELECT COUNT(ID) as Total");
            sqlPesquisa.AppendLine($"  FROM despesa");
            sqlPesquisa.AppendLine(ObterFiltros(filtro));

            return await _baseRepository.BuscarPorQueryAsync<int>(sqlPesquisa.ToString());
        }
        public async Task<Despesa> ObterPorCodigo(int codigo) => await _baseRepository.BuscarPorIdAsync<Despesa>(codigo);
        public async Task<IEnumerable<Despesa>> ObterTodos(filtroDespesa filtro)
        {
            var sqlPesquisa = new StringBuilder();

            sqlPesquisa.AppendLine($"DO $$");
            sqlPesquisa.AppendLine($"DECLARE QtdPorPagina INTEGER;");
            sqlPesquisa.AppendLine($"        Pagina       INTEGER;");
            sqlPesquisa.AppendLine($"BEGIN");
            sqlPesquisa.AppendLine($"    SELECT {filtro.QuantidadePorPagina} INTO QtdPorPagina;");
            sqlPesquisa.AppendLine($"    SELECT {filtro.PaginaAtual} INTO Pagina;");
            sqlPesquisa.AppendLine($"    ");
            sqlPesquisa.AppendLine($"    DROP TABLE IF EXISTS TMP_TABLE;");
            sqlPesquisa.AppendLine($"    CREATE TEMP TABLE tmp_table AS");
            sqlPesquisa.AppendLine($"    SELECT id as Codigo,");
            sqlPesquisa.AppendLine($"           id_cartao as CodigoCartao,");
            sqlPesquisa.AppendLine($"           descricao as Descricao,");
            sqlPesquisa.AppendLine($"           id_categoria as CodigoCategoria,");
            sqlPesquisa.AppendLine($"           valor as Valor,");
            sqlPesquisa.AppendLine($"           id_mes as CodigoMes,");
            sqlPesquisa.AppendLine($"           ano as Ano,");
            sqlPesquisa.AppendLine($"           id_usuario as CodigoUsuario,");
            sqlPesquisa.AppendLine($"           data_cadastro as DataCadastro,");
            sqlPesquisa.AppendLine($"           data_atualizacao as DataAtualizacao,");
            sqlPesquisa.AppendLine($"           ativo as Ativo");
            sqlPesquisa.AppendLine($"      FROM despesa");
            sqlPesquisa.AppendLine($"     LIMIT QtdPorPagina");
            sqlPesquisa.AppendLine($"    OFFSET (Pagina - 1) * QtdPorPagina;");
            sqlPesquisa.AppendLine($"END $$;");
            sqlPesquisa.AppendLine($"");
            sqlPesquisa.AppendLine($"SELECT * FROM tmp_table;");

            return await _baseRepository.BuscarTodosPorQueryAsync<Despesa>(sqlPesquisa.ToString().Trim());
        }
        public async Task<bool> Atualizar(Despesa model) => await _baseRepository.AtualizarAsync(model.Codigo, model) > 0;
        public async Task<bool> Inserir(Despesa model) => await _baseRepository.AdicionarAsync(model) > 0;
        public async Task<bool> ObterEntidade(Despesa model) => await _baseRepository.BuscarPorQueryGeradorAsync<Despesa>($" descricao = '{model.Descricao}'") is not null;

        #endregion
    }
}
