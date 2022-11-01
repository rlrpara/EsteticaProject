using AutoMapper;
using VendaFacil.Domain.Entities;
using VendaFacil.Domain.Entities.Filtros;
using VendaFacil.Domain.Interface;
using VendaFacil.Service.Interface;
using VendaFacil.Service.ViewModel.Entities;
using VendaFacil.Service.ViewModel.Entities.Filtros;

namespace VendaFacil.Service.Service
{
    public class DespesaService : BaseService, IDespesaService
    {
        #region [Propriedade Privadas]
        private readonly IMapper _mapper;
        private readonly IDespesaRepository _service;
        #endregion

        #region [Construtor]
        public DespesaService(IBaseRepository baseRepository, IMapper mapper) : base(baseRepository)
        {
            _mapper = mapper;
            _baseRepository = baseRepository;
        }
        #endregion

        #region [Métodos Públicos]
        public bool Atualizar(DespesaViewModel model)
        {
            model.Ativo ??= ObterPorCodigo(model.Codigo).Ativo;
            return _service.Atualizar(_mapper.Map<Despesa>(model)).Result;
        }
        public bool Deletar(DespesaViewModel model)
        {
            model.Ativo = false;
            return _service.Atualizar(_mapper.Map<Despesa>(model)).Result;
        }
        public bool Inserir(DespesaViewModel model) => _service.Inserir(_mapper.Map<Despesa>(model)).Result;
        public bool ObterEntidade(DespesaViewModel model) => _service.ObterEntidade(_mapper.Map<Despesa>(model)).Result;
        public DespesaViewModel ObterPorCodigo(int codigo) => _mapper.Map<DespesaViewModel>(_service.ObterPorCodigo(_mapper.Map<int>(codigo)).Result);
        public IEnumerable<DespesaViewModel> ObterTodos(filtroDespesaViewModel filtro) => _mapper.Map<IEnumerable<DespesaViewModel>>(_service.ObterTodos(_mapper.Map<filtroDespesa>(filtro)).Result);
        public int ObterTotalRegistros(filtroDespesaViewModel filtro)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
