using VendaFacil.Service.ViewModel.Entities.Filtros;
using VendaFacil.Service.ViewModel.Entities;

namespace VendaFacil.Service.Interface
{
    public interface IDespesaService : IBaseService
    {
        int ObterTotalRegistros(filtroDespesaViewModel filtro);
        bool Atualizar(DespesaViewModel model);
        bool Deletar(DespesaViewModel model);
        bool Inserir(DespesaViewModel model);
        bool ObterEntidade(DespesaViewModel model);
        DespesaViewModel ObterPorCodigo(int codigo);
        IEnumerable<DespesaViewModel> ObterTodos(filtroDespesaViewModel filtro);
    }
}
