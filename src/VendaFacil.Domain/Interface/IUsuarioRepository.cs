using VendaFacil.Domain.Entities.Base;
using VendaFacil.Domain.Entities.Filtros;

namespace VendaFacil.Domain.Interface
{
    public interface IUsuarioRepository : IBaseRepository
    {
        IEnumerable<Usuario> ObterTodos(filtroUsuario filtroNovo);
    }
}
