using VendaFacil.Domain.Entities;
using VendaFacil.Domain.Entities.Filtros;

namespace VendaFacil.Domain.Interface
{
    public interface IDespesaRepository : IBaseRepository
    {
        Task<bool> Atualizar(Despesa model);
        Task<bool> Inserir(Despesa model);
        Task<bool> ObterEntidade(Despesa model);
        Task<Despesa> ObterPorCodigo(int codigo);
        Task<IEnumerable<Despesa>> ObterTodos(filtroDespesa filtro);
        Task<int> ObterTotalRegistros(filtroDespesa filtro);
    }
}
