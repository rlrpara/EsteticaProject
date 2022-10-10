using SempreDivas.Domain.Entities.Base;
using SempreDivas.Domain.Entities.Filtros;

namespace SempreDivas.Domain.Interface
{
    public interface IUsuarioRepository : IBaseRepository
    {
        IEnumerable<Usuario> ObterTodos(filtroUsuario filtroNovo);
    }
}
