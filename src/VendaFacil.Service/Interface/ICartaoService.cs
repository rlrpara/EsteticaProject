using VendaFacil.Service.ViewModel.Entities;
using VendaFacil.Service.ViewModel.Entities.Filtros;

namespace VendaFacil.Service.Interface
{
    public interface ICartaoService : IBaseService
    {
        bool Atualizar(CartaoViewModel model);
        bool Deletar(CartaoViewModel model);
        bool Inserir(CartaoViewModel model);
        bool ObterEntidade(CartaoViewModel model);
        CartaoViewModel ObterPorCodigo(int codigo);
        IEnumerable<CartaoViewModel> ObterTodos(filtroCartaoViewModel filtro);
        int ObterTotalRegistros(filtroCartaoViewModel filtro);
    }
}
