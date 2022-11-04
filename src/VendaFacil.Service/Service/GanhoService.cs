using AutoMapper;
using FirebirdSql.Data.Services;
using VendaFacil.Domain.Entities;
using VendaFacil.Domain.Entities.Filtros;
using VendaFacil.Domain.Interface;
using VendaFacil.Infra.Data.Repositories;
using VendaFacil.Service.Interface;
using VendaFacil.Service.ViewModel.Entities;
using VendaFacil.Service.ViewModel.Entities.Filtros;

namespace VendaFacil.Service.Service
{
    public class GanhoService : BaseService, IGanhoService
    {
        #region [Propriedades Privadas]
        private readonly IMapper _mapper;
        private readonly IGanhoRepository _service;
        #endregion

        #region [Construtor]
        public GanhoService(IBaseRepository baseRepository, IMapper mapper) : base(baseRepository)
        {
            _mapper = mapper;
            _service = new GanhoRepository(baseRepository);
        }
        #endregion

        #region [Métodos Públicos]
        public int ObterTotalRegistros(filtroGanhoViewModel filtro) => _mapper.Map<int>(_service.TotalRegistros(_mapper.Map<filtroGanho>(filtro)).Result);
        public GanhoViewModel ObterPorCodigo(int codigo) => _mapper.Map<GanhoViewModel>(_service.ObterPorCodigo(codigo).Result);
        public IEnumerable<GanhoViewModel> ObterTodos(filtroGanhoViewModel filtro) => _mapper.Map<IEnumerable<GanhoViewModel>>(_service.ObterTodos(_mapper.Map<filtroGanho>(filtro)).Result);
        public bool ObterEntidade(GanhoViewModel model) => _service.ObterEntidade(_mapper.Map<Ganho>(model)).Result;
        public bool Inserir(GanhoViewModel model) => _service.Inserir(_mapper.Map<Ganho>(model)).Result;
        public bool Atualizar(GanhoViewModel model)
        {
            model.Ativo ??= ObterPorCodigo(model.Codigo).Ativo;
            return _service.Atualizar(_mapper.Map<Ganho>(model)).Result;
        }
        public bool Deletar(GanhoViewModel model)
        {
            model.Ativo = false;
            return _service.Atualizar(_mapper.Map<Ganho>(model)).Result;
        }

        #endregion
    }
}
