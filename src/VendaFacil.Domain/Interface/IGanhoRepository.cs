using VendaFacil.Domain.Entities;
using VendaFacil.Domain.Entities.Filtros;

namespace VendaFacil.Domain.Interface
{
    public interface IGanhoRepository : IBaseRepository
    {
        Task<bool> Atualizar(Ganho ganho);
        Task<bool> Inserir(Ganho ganho);
        Task<bool> ObterEntidade(Ganho ganho);
        Task<Ganho> ObterPorCodigo(int codigo);
        Task<IEnumerable<Ganho>> ObterTodos(filtroGanho filtroGanho);
        Task<int> TotalRegistros(filtroGanho filtroGanho);
    }
}
