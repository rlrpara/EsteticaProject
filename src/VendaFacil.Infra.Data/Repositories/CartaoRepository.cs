using VendaFacil.Domain.Entities;
using VendaFacil.Domain.Entities.Filtros;
using VendaFacil.Domain.Interface;

namespace VendaFacil.Infra.Data.Repositories
{
    public class CartaoRepository : BaseRepository, ICartaoRepository
    {
        #region [Propriedades Privadas]
        private readonly IBaseRepository _baseRepository;
        #endregion

        #region [Construtor]
        public CartaoRepository(IBaseRepository baseRepository) => _baseRepository = baseRepository;
        #endregion
        
        #region [Métodos Públicos]
        public Task<int> Atualizar(Cartao cartao)
        {
            throw new NotImplementedException();
        }

        public Task<int> Inserir(Cartao cartao)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ObterEntidade(Cartao cartao)
        {
            throw new NotImplementedException();
        }

        public Task<Cartao> ObterPorCodigo(int Codigo)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Cartao>> ObterTodos(FiltroCartao filtroCartao)
        {
            throw new NotImplementedException();
        }

        public Task<int> ObterTotalRegistros(FiltroCartao filtroCartao)
        {
            throw new NotImplementedException();
        }
        
        #endregion
    }
}
