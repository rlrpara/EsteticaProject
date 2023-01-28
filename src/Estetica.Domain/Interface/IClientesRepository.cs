using Estetica.Domain.Entities;
using Estetica.Domain.Entities.Filtros;

namespace Estetica.Domain.Interface
{
    public interface IClientesRepository : IBaseRepository
    {
        Task<Cliente> ObterPorCodigo(int codigo);
        Task<int> TotalRegistros(filtroClientes filtro);
        IEnumerable<Cliente> ObterTodos(filtroClientes filtro);
        Task<IEnumerable<Cliente>> ObterTodosAsync(filtroClientes filtro);
        Task<bool> ObterEntidade(Cliente Clientes);
        Task<bool> Inserir(Cliente Clientes);
        Task<bool> Atualizar(Cliente Clientes);
    }
}
