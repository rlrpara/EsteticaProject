using VendaFacil.Service.ViewModel.Entities;
using VendaFacil.Service.ViewModel.Entities.Filtros;

namespace VendaFacil.Service.Interface
{
    public interface IGanhoService : IBaseService
    {
        int ObterTotalRegistros(filtroGanhoViewModel filtro);
        bool Atualizar(GanhoViewModel model);
        bool Inserir(GanhoViewModel model);
        bool Deletar(EmpresaViewModel model);
        bool ObterEntidade(GanhoViewModel model);
        GanhoViewModel ObterPorCodigo(int codigo);
        IEnumerable<GanhoViewModel> ObterTodos(filtroGanhoViewModel filtro);
    }
}
