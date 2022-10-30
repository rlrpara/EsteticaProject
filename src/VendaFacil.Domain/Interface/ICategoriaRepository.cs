using VendaFacil.Domain.Entities;
using VendaFacil.Domain.Entities.Filtros;

namespace VendaFacil.Domain.Interface
{
    public interface ICategoriaRepository : IBaseRepository
    {
        Task<bool> Atualizar(Categoria model);
        Task<bool> Inserir(Categoria model);
        Task<bool> ObterEntidade(Categoria model);
        Task<Categoria> ObterPorCodigo(int codigo);
        Task<IEnumerable<Categoria>> ObterTodos(filtroCategoria filtro);
        Task<int> ObterTotalRegistros(filtroCategoria filtro);
    }
}
