using VendaFacil.Domain.Entities;
using VendaFacil.Domain.Entities.Filtros;

namespace VendaFacil.Domain.Interface
{
    public interface IUsuarioRepository : IBaseRepository
    {
        Task<Usuario> ObterPorCodigo(int Codigo);
        Task<bool> ObterEntidade(Usuario usuario);
        Task<IEnumerable<Usuario>> ObterTodos(filtroUsuario filtro);
        Task<int> TotalRegistros(filtroUsuario filtroUsuario);
        Task<bool> Atualizar(Usuario usuario);
        Task<bool> Inserir(Usuario usuario);
    }
}
