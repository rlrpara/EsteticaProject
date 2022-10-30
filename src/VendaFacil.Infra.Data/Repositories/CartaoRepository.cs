using System.Text;
using VendaFacil.Domain.Entities;
using VendaFacil.Domain.Entities.Filtros;
using VendaFacil.Domain.Interface;

namespace VendaFacil.Infra.Data.Repositories
{
    public class CartaoRepository : BaseRepository, ICartaoRepository
    {
        #region [Propriedades Privadas]
        private readonly IBaseRepository _baseRepository;
        #endregion

        #region [Métodos Privados]
        private string ObterFiltros(filtroCartao filtro)
        {
            var sqlPesquisa = new StringBuilder();

            sqlPesquisa.AppendLine($" WHERE nome ILIKE '%{filtro.Nome}%'");
            sqlPesquisa.AppendLine($"   OR bandeira ilike '%{filtro.Bandeira}%'");
            sqlPesquisa.AppendLine($"   OR numero ilike '%{filtro.Numero}%'");

            return sqlPesquisa.ToString();
        }
        #endregion

        #region [Construtor]
        public CartaoRepository(IBaseRepository baseRepository) => _baseRepository = baseRepository;
        #endregion

        #region [Métodos Públicos]
        public async Task<int> ObterTotalRegistros(filtroCartao filtro)
        {
            var sqlPesquisa = new StringBuilder();

            sqlPesquisa.AppendLine($"SELECT COUNT(ID) as Total");
            sqlPesquisa.AppendLine($"  FROM cartao");
            sqlPesquisa.AppendLine(ObterFiltros(filtro));

            return await _baseRepository.BuscarPorQueryAsync<int>(sqlPesquisa.ToString());
        }
        public async Task<Cartao> ObterPorCodigo(int codigo) => await _baseRepository.BuscarPorIdAsync<Cartao>(codigo);
        public async Task<IEnumerable<Cartao>> ObterTodos(filtroCartao filtro)
        {
            var sqlPesquisa = new StringBuilder();

            sqlPesquisa.AppendLine($"DO $$");
            sqlPesquisa.AppendLine($"DECLARE QtdPorPagina INTEGER;");
            sqlPesquisa.AppendLine($"        Pagina       INTEGER;");
            sqlPesquisa.AppendLine($"BEGIN");
            sqlPesquisa.AppendLine($"    SELECT {filtro.QuantidadePorPagina} INTO QtdPorPagina;");
            sqlPesquisa.AppendLine($"    SELECT {filtro.PaginaAtual} INTO Pagina;");
            sqlPesquisa.AppendLine($"");
            sqlPesquisa.AppendLine($"    DROP TABLE IF EXISTS TMP_TABLE;");
            sqlPesquisa.AppendLine($"    CREATE TEMP TABLE tmp_table AS");
            sqlPesquisa.AppendLine($"    SELECT id as Codigo,");
            sqlPesquisa.AppendLine($"           nome as Nome,");
            sqlPesquisa.AppendLine($"           bandeira as Bandeira,");
            sqlPesquisa.AppendLine($"           numero as Numero,");
            sqlPesquisa.AppendLine($"           limite as Limite,");
            sqlPesquisa.AppendLine($"           id_usuario as CodigoUsuario,");
            sqlPesquisa.AppendLine($"           data_cadastro as DataCadastro,");
            sqlPesquisa.AppendLine($"           data_atualizacao as DataAtualizacao,");
            sqlPesquisa.AppendLine($"           ativo as Ativo");
            sqlPesquisa.AppendLine($"      FROM cartao");
            sqlPesquisa.AppendLine(ObterFiltros(filtro));
            sqlPesquisa.AppendLine($"     LIMIT QtdPorPagina");
            sqlPesquisa.AppendLine($"    OFFSET (Pagina - 1) * QtdPorPagina;");
            sqlPesquisa.AppendLine($"END $$;");
            sqlPesquisa.AppendLine($"");
            sqlPesquisa.AppendLine($"SELECT * FROM tmp_table;");

            return await _baseRepository.BuscarTodosPorQueryAsync<Cartao>(sqlPesquisa.ToString().Trim());
        }
        public async Task<bool> Atualizar(Cartao cartao) => await _baseRepository.AtualizarAsync(cartao.Codigo, cartao) > 0;
        public async Task<bool> Inserir(Cartao cartao) => await _baseRepository.AdicionarAsync(cartao) > 0;
        public async Task<bool> ObterEntidade(Cartao cartao)
        {
            var sqlPesquisa = new StringBuilder();

            sqlPesquisa.AppendLine($" (nome = '{cartao.Nome}' AND bandeira = '{cartao.Bandeira}' AND numero = '{cartao.Numero}')");

            return await _baseRepository.BuscarPorQueryGeradorAsync<Cartao>(sqlPesquisa.ToString()) is not null;
        }

        #endregion
    }
}
