using VendaFacil.Service.ViewModel.Entities;
using VendaFacil.Service.ViewModel.Entities.Filtros;

namespace VendaFacil.Service.Interface
{
    public interface IUsuarioService : IBaseService
    {
        bool JaCadastrado(UsuarioViewModel model);
        IEnumerable<UsuarioViewModel> ObterTodos(filtroUsuarioViewModel filtro);
        bool Inserir(UsuarioViewModel model);
    }
}
