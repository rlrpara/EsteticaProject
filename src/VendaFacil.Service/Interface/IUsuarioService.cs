using VendaFacil.Service.ViewModel.Entities;
using VendaFacil.Service.ViewModel.Entities.Filtros;

namespace VendaFacil.Service.Interface
{
    public interface IUsuarioService : IBaseService
    {
        IEnumerable<UsuarioViewModel> ObterTodos(filtroUsuarioViewModel filtro);
    }
}
