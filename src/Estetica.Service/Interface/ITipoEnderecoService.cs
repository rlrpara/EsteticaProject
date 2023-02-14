using Estetica.Service.ViewModel.Entities;

namespace Estetica.Service.Interface
{
    public interface ITipoEnderecoService : IBaseService
    {
        IEnumerable<TipoEnderecoViewModel> ObterTodos();

    }
}
