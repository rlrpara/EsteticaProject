using VendaFacil.Service.ViewModel.Entities.Filtros;
using VendaFacil.Service.ViewModel.Entities;

namespace VendaFacil.Service.Interface
{
    public interface ITipoService : IBaseService
    {
        bool Atualizar(TipoViewModel model);
        bool Deletar(TipoViewModel model);
        bool Inserir(TipoViewModel model);
        bool ObterEntidade(TipoViewModel model);
        TipoViewModel ObterPorCodigo(int codigo);
        IEnumerable<TipoViewModel> ObterTodos(filtroTipoViewModel filtro);
        int ObterTotalRegistros(filtroTipoViewModel filtro);
    }
}
