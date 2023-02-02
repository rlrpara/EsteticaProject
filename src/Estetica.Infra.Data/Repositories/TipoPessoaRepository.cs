using Estetica.Domain.Entities;
using Estetica.Domain.Entities.Filtros;
using Estetica.Domain.Interface;
using System.Text;

namespace Estetica.Infra.Data.Repositories
{
    public class TipoPessoaRepository : BaseRepository, ITipoPessoaRepository
    {
        #region [Propriedades Privadas]
        private readonly IBaseRepository _baseRepository;
        #endregion

        #region [Métodos Privados]
        private string ObterFiltros(filtroTipoPessoa filtro)
        {
            var sqlPesquisa = new StringBuilder();

            sqlPesquisa.AppendLine($" descricao ILIKE '%{filtro.Descricao}%'");

            return sqlPesquisa.ToString();
        }
        #endregion

        #region [Construtor]
        public TipoPessoaRepository(IBaseRepository baseRepository) => _baseRepository = baseRepository;
        #endregion

        #region [Métodos Públicos]
        public async Task<IEnumerable<TipoPessoa>> ObterTodos(filtroTipoPessoa filtro)
            => await _baseRepository.BuscarTodosPorQueryGeradorAsync<TipoPessoa>(ObterFiltros(filtro));
        
        #endregion
    }
}
