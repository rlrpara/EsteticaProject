using SempreDivas.Service.ViewModel.Entities;
using SempreDivas.Service.ViewModel.Entities.Filtros;

namespace SempreDivas.Service.Interface
{
    public interface IUsuarioService : IBaseService
    {
        IEnumerable<UsuarioViewModel> ObterTodos(filtroUsuarioViewModel filtro);
    }
}
