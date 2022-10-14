using VendaFacil.Service.ViewModel.Entities;
using VendaFacil.Service.ViewModel.Entities.Filtros;

namespace VendaFacil.Service.Interface
{
    public interface IUsuarioService : IBaseService
    {
        bool ObterEntidade(UsuarioViewModel model);
        UsuarioViewModel ObterPorCodigo(int Codigo);
        IEnumerable<UsuarioViewModel> ObterTodos(filtroUsuarioViewModel filtro);
        int ObterTotalRegistros(filtroUsuarioViewModel filtro);
        bool Inserir(UsuarioViewModel model);
        bool Atualizar(UsuarioViewModel model);
        bool Deletar(UsuarioViewModel model);
    }
}
