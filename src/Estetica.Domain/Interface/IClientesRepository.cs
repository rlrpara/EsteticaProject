using Estetica.Domain.Entities;
using Estetica.Domain.Entities.Filtros;

namespace Estetica.Domain.Interface
{
    public interface IClientesRepository : IBaseRepository
    {
        Task<Clientes> ObterPorCodigo(int codigo);
        Task<int> TotalRegistros(filtroClientes filtro);
        IEnumerable<Clientes> ObterTodos(filtroClientes filtro);
        Task<IEnumerable<Clientes>> ObterTodosAsync(filtroClientes filtro);
        Task<bool> ObterEntidade(Clientes Clientes);
        Task<bool> Inserir(Clientes Clientes);
        Task<bool> Atualizar(Clientes Clientes);
    }
}
