using System.Text;
using VendaFacil.Domain.Entities;
using VendaFacil.Domain.Entities.Filtros;
using VendaFacil.Domain.Interface;

namespace VendaFacil.Infra.Data.Repositories
{
    public class CategoriaRepository : BaseRepository, ICategoriaRepository
    {
        #region [Propriedades Privadas]
        private readonly IBaseRepository _baseRepository;
        #endregion

        #region [Métodos Privados]
        private string ObterFiltros(filtroCategoria filtro)
        {
            var sqlPesquisa = new StringBuilder();

            sqlPesquisa.AppendLine($" WHERE email ILIKE '%{filtro.Nome}%'");

            return sqlPesquisa.ToString();
        }
        #endregion

        #region [Construtor]
        public CategoriaRepository(IBaseRepository baseRepository) =>_baseRepository = baseRepository;
        #endregion

        #region [Métodos Públicos]
        public async Task<int> ObterTotalRegistros(filtroCategoria filtro)
        {
            var sqlPesquisa = new StringBuilder();

            sqlPesquisa.AppendLine($"SELECT COUNT(ID) as Total");
            sqlPesquisa.AppendLine($"  FROM categoria");
            sqlPesquisa.AppendLine(ObterFiltros(filtro));

            return await _baseRepository.BuscarPorQueryAsync<int>(sqlPesquisa.ToString());
        }
        public async Task<Categoria> ObterPorCodigo(int codigo) => await _baseRepository.BuscarPorIdAsync<Categoria>(codigo);
        public async Task<IEnumerable<Categoria>> ObterTodos(filtroCategoria filtro)
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
            sqlPesquisa.AppendLine($"           icone as Icone,");
            sqlPesquisa.AppendLine($"           id_tipo as CodigoTipo,");
            sqlPesquisa.AppendLine($"           data_cadastro as DataCadastro,");
            sqlPesquisa.AppendLine($"           data_atualizacao as DataAtualizacao,");
            sqlPesquisa.AppendLine($"           ativo as Ativo");
            sqlPesquisa.AppendLine($"      FROM categoria");
            sqlPesquisa.AppendLine(ObterFiltros(filtro));
            sqlPesquisa.AppendLine($"     LIMIT QtdPorPagina");
            sqlPesquisa.AppendLine($"    OFFSET (Pagina - 1) * QtdPorPagina;");
            sqlPesquisa.AppendLine($"END $$;");
            sqlPesquisa.AppendLine($"");
            sqlPesquisa.AppendLine($"SELECT * FROM tmp_table;");

            return await _baseRepository.BuscarTodosPorQueryAsync<Categoria>(sqlPesquisa.ToString().Trim());
        }
        public async Task<bool> Atualizar(Categoria model) => await _baseRepository.AtualizarAsync(model.Codigo, model) > 0;
        public async Task<bool> Inserir(Categoria model) => await _baseRepository.AdicionarAsync(model) > 0;
        public async Task<bool> ObterEntidade(Categoria model) => await _baseRepository.BuscarPorQueryGeradorAsync<Categoria>(" nome = '{model.Nome}'") is not null;
        
        #endregion
    }
}
