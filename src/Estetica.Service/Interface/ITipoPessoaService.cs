using Estetica.Service.ViewModel.Entities.Filtros;
using Estetica.Service.ViewModel.Entities;

namespace Estetica.Service.Interface
{
    public interface ITipoPessoaService : IBaseService
    {
        IEnumerable<TipoPessoaViewModel> ObterTodos(filtroTipoPessoaViewModel filtro);
    }
}
