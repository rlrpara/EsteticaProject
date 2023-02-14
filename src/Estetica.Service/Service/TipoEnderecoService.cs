using AutoMapper;
using Estetica.Domain.Interface;
using Estetica.Infra.Data.Repositories;
using Estetica.Service.Interface;
using Estetica.Service.ViewModel.Entities;

namespace Estetica.Service.Service
{
    public class TipoEnderecoService : BaseService, ITipoEnderecoService
    {
        #region[Pripriedades Privadas]
        private readonly IMapper _mapper;
        private readonly ITipoEnderecoRepository _service;
        #endregion

        #region [Construtor]
        public TipoEnderecoService(IBaseRepository baseRepository, IMapper mapper) : base(baseRepository)
        {
            _mapper = mapper;
            _service = new TipoEnderecoRepository(baseRepository);
        }
        public TipoEnderecoService(IBaseRepository baseRepository) : base(baseRepository) => _service = new TipoEnderecoRepository(baseRepository);
        #endregion

        #region [Métodos Públicos]
        public IEnumerable<TipoEnderecoViewModel> ObterTodos()
            => _mapper.Map<IEnumerable<TipoEnderecoViewModel>>(_service.ObterTodosAsync().Result);
        #endregion
    }
}
