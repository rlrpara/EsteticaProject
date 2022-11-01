using VendaFacil.Domain.Entities;
using VendaFacil.Domain.Entities.Filtros;

namespace VendaFacil.Domain.Interface
{
    public interface ITipoRepository : IBaseRepository
    {
        Task<bool> Atualizar(Tipo tipo);
        Task<bool> Inserir(Tipo tipo);
        Task<bool> ObterEntidade(Tipo tipo);
        Task<Tipo> ObterPorCodigo(int v);
        Task<IEnumerable<Tipo>> ObterTodos(filtroTipo filtroTipo);
        Task<int> ObterTotalRegistros(filtroTipo filtroTipo);
    }
}
