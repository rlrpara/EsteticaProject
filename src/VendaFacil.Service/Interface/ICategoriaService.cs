using VendaFacil.Service.ViewModel.Entities;
using VendaFacil.Service.ViewModel.Entities.Filtros;

namespace VendaFacil.Service.Interface
{
    public interface ICategoriaService : IBaseService
    {
        int ObterTotalRegistros(filtroCategoriaViewModel filtro);
        bool Atualizar(CategoriaViewModel model);
        bool Deletar(CategoriaViewModel model);
        bool Inserir(CategoriaViewModel model);
        bool ObterEntidade(CategoriaViewModel model);
        CategoriaViewModel ObterPorCodigo(int codigo);
        IEnumerable<CategoriaViewModel> ObterTodos(filtroCategoriaViewModel filtro);
    }
}
