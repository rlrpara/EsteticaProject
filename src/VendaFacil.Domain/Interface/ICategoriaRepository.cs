using VendaFacil.Domain.Entities;
using VendaFacil.Domain.Entities.Filtros;

namespace VendaFacil.Domain.Interface
{
    public interface ICategoriaRepository : IBaseRepository
    {
        Task<int> Atualizar(Categoria model);
        Task<int> Inserir(Categoria model);
        Task<int> ObterEntidade(Categoria model);
        Task<Categoria> ObterPorCodigo(int codigo);
        Task<IEnumerable<Categoria>> ObterTodos(filtroCategoria filtro);
        Task<int> ObterTotalRegistros(filtroCategoria filtro);
    }
}
