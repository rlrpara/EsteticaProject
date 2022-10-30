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
            sqlPesquisa.AppendLine($"   AND nome ilike '%{filtro.Nome}%'");

            return sqlPesquisa.ToString();
        }
        #endregion

        #region [Construtor]
        public CategoriaRepository(IBaseRepository baseRepository) =>_baseRepository = baseRepository;
        #endregion

        #region [Métodos Públicos]
        public Task<int> Atualizar(Categoria model)
        {
            throw new NotImplementedException();
        }

        public Task<int> Inserir(Categoria model)
        {
            throw new NotImplementedException();
        }

        public Task<int> ObterEntidade(Categoria model)
        {
            throw new NotImplementedException();
        }

        public Task<Categoria> ObterPorCodigo(int codigo)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Categoria>> ObterTodos(filtroCategoria filtro)
        {
            throw new NotImplementedException();
        }

        public Task<int> ObterTotalRegistros(filtroCategoria filtro)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
