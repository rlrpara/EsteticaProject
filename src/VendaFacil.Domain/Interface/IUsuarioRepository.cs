using VendaFacil.Domain.Entities.Base;
using VendaFacil.Domain.Entities.Filtros;

namespace VendaFacil.Domain.Interface
{
    public interface IUsuarioRepository : IBaseRepository
    {
        Task<bool> Inserir(Usuario usuario);
        Task<bool> JaCadastrado(Usuario usuario);
        Task<IEnumerable<Usuario>> ObterTodos(filtroUsuario filtro);
        Task<int> TotalRegistros(filtroUsuario filtroUsuarioViewModel);
    }
}
