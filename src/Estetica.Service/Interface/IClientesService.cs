using Estetica.Domain.Entities;
using Estetica.Domain.Entities.Filtros;
using Estetica.Service.ViewModel.Entities;
using Estetica.Service.ViewModel.Entities.Filtros;

namespace Estetica.Service.Interface
{
    public interface IClientesService : IBaseService
    {
        int ObterTotalRegistros(filtroClientesViewModel filtro);
        bool ObterEntidade(ClientesViewModel model);
        ClientesViewModel ObterPorCodigo(int codigo);
        IEnumerable<Cliente> ObterTodos(filtroClientes filtro);
        IEnumerable<ClientesViewModel> ObterTodos(filtroClientesViewModel filtro);
        bool Inserir(ClientesViewModel model);
        bool Atualizar(ClientesViewModel model);
        bool Deletar(ClientesViewModel model);
    }
}
