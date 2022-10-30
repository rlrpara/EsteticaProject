using VendaFacil.Service.ViewModel.Entities;
using VendaFacil.Service.ViewModel.Entities.Filtros;

namespace VendaFacil.Service.Interface
{
    public interface ICategoriaService : IBaseService
    {
        int ObterTotalRegistros(filtroCategoriaViewModel filtro);
        int Atualizar(CategoriaViewModel model);
        bool Deletar(CategoriaViewModel model);
        int Inserir(CategoriaViewModel model);
        bool ObterEntidade(CategoriaViewModel model);
        CategoriaViewModel ObterPorCodigo(int codigo);
        IEnumerable<CategoriaViewModel> ObterTodos(filtroCategoriaViewModel filtro);
    }
}
