using AutoMapper;
using VendaFacil.Domain.Entities;
using VendaFacil.Domain.Entities.Filtros;
using VendaFacil.Domain.Interface;
using VendaFacil.Infra.Data.Repositories;
using VendaFacil.Service.Interface;
using VendaFacil.Service.ViewModel.Entities;
using VendaFacil.Service.ViewModel.Entities.Filtros;

namespace VendaFacil.Service.Service
{
    public class CartaoService : BaseService, ICartaoService
    {
        #region [Pripriedades Privadas]
        private readonly IMapper _mapper;
        private readonly ICartaoRepository _service;
        #endregion

        #region [Construtor]
        public CartaoService(IBaseRepository baseRepository, IMapper mapper) : base(baseRepository)
        {
            _mapper = mapper;
            _service = new CartaoRepository(baseRepository);
        }
        #endregion

        #region [Métodos Públicos]
        public int Atualizar(CartaoViewModel model) => _service.Atualizar(_mapper.Map<Cartao>(model)).Result;
        public int Deletar(CartaoViewModel model)
        {
            model.Ativo = false;
            return _service.Atualizar(_mapper.Map<Cartao>(model)).Result;
        }
        public int Inserir(CartaoViewModel model) => _service.Inserir(_mapper.Map<Cartao>(model)).Result;
        public bool ObterEntidade(CartaoViewModel model) => _service.ObterEntidade(_mapper.Map<Cartao>(model)).Result;
        public CartaoViewModel ObterPorCodigo(int codigo) => _mapper.Map<CartaoViewModel>(_service.ObterPorCodigo(_mapper.Map<int>(codigo)).Result);
        public IEnumerable<CartaoViewModel> ObterTodos(filtroCartaoViewModel filtro) => _mapper.Map<IEnumerable<CartaoViewModel>>(_service.ObterTodos(_mapper.Map<FiltroCartao>(filtro)).Result);
        public int ObterTotalRegistros(filtroCartaoViewModel filtro) => _service.ObterTotalRegistros(_mapper.Map<FiltroCartao>(filtro)).Result;

        #endregion
    }
}
