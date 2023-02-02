using AutoMapper;
using Estetica.Domain.Entities.Filtros;
using Estetica.Domain.Entities;
using Estetica.Domain.Interface;
using Estetica.Service.Interface;
using Estetica.Infra.Data.Repositories;
using Estetica.Service.ViewModel.Entities;
using Estetica.Service.ViewModel.Entities.Filtros;

namespace Estetica.Service.Service
{
    public class TipoPessoaService : BaseService, ITipoPessoaService
    {
        #region[Pripriedades Privadas]
        private readonly IMapper _mapper;
        private readonly ITipoPessoaRepository _service;
        #endregion

        #region [Construtor]
        public TipoPessoaService(IBaseRepository baseRepository, IMapper mapper)
            : base(baseRepository)
        {
            _mapper = mapper;
            _service = new TipoPessoaRepository(baseRepository);
        }
        #endregion

        #region [Métodos Públicos]
        public IEnumerable<TipoPessoaViewModel> ObterTodos(filtroTipoPessoaViewModel filtro)
            => _mapper.Map<IEnumerable<TipoPessoaViewModel>>(_service.ObterTodos(_mapper.Map<filtroTipoPessoa>(filtro)).Result);

        #endregion
    }
}
