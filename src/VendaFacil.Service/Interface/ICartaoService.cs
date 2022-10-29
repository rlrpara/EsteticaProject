using VendaFacil.Service.ViewModel.Entities;
using VendaFacil.Service.ViewModel.Entities.Filtros;

namespace VendaFacil.Service.Interface
{
    public interface ICartaoService : IBaseService
    {
        int Atualizar(CartaoViewModel model);
        int Deletar(CartaoViewModel model);
        int Inserir(CartaoViewModel model);
        bool ObterEntidade(CartaoViewModel model);
        CartaoViewModel ObterPorCodigo(int codigo);
        IEnumerable<CartaoViewModel> ObterTodos(filtroCartaoViewModel filtro);
        int ObterTotalRegistros(filtroCartaoViewModel filtro);
    }
}
