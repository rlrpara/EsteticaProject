using VendaFacil.Domain.Entities;
using VendaFacil.Domain.Entities.Filtros;

namespace VendaFacil.Domain.Interface
{
    public interface ICartaoRepository : IBaseRepository
    {
        Task<int> Atualizar(Cartao cartao);
        Task<int> Inserir(Cartao cartao);
        Task<bool> ObterEntidade(Cartao cartao);
        Task<Cartao> ObterPorCodigo(int Codigo);
        Task<IEnumerable<Cartao>> ObterTodos(FiltroCartao filtroCartao);
        Task<int> ObterTotalRegistros(FiltroCartao filtroCartao);
    }
}
