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
    public class TipoService : BaseService, ITipoService
    {
        #region [Propriedades Privadas]
        private readonly IMapper _mapper;
        private readonly ITipoRepository _service;
        #endregion

        #region [Construtor]
        public TipoService(IBaseRepository baseRepository, IMapper _mapper) : base(baseRepository)
        {
            _mapper = _mapper;
            _service = new TipoRepository(baseRepository);
        }
        #endregion

        #region [Propriedade Públicas]
        public bool Atualizar(TipoViewModel model)
        {
            model.Ativo ??= ObterPorCodigo(model.Codigo).Ativo;
            return _service.Atualizar(_mapper.Map<Tipo>(model)).Result;
        }
        public bool Deletar(TipoViewModel model)
        {
            model.Ativo = false;
            return _service.Atualizar(_mapper.Map<Tipo>(model)).Result;
        }
        public bool Inserir(TipoViewModel model) => _service.Inserir(_mapper.Map<Tipo>(model)).Result;
        public bool ObterEntidade(TipoViewModel model) => _service.ObterEntidade(_mapper.Map<Tipo>(model)).Result;
        public TipoViewModel ObterPorCodigo(int codigo) => _mapper.Map<TipoViewModel>(_service.ObterPorCodigo(_mapper.Map<int>(codigo)).Result);
        public IEnumerable<TipoViewModel> ObterTodos(filtroTipoViewModel filtro) => _mapper.Map<IEnumerable<TipoViewModel>>(_service.ObterTodos(_mapper.Map<filtroTipo>(filtro)).Result);
        public int ObterTotalRegistros(filtroTipoViewModel filtro) => _service.ObterTotalRegistros(_mapper.Map<filtroTipo>(filtro)).Result;
        #endregion
    }
}
