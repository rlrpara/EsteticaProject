using AutoMapper;
using SempreDivas.Domain.Entities.Filtros;
using SempreDivas.Domain.Interface;
using SempreDivas.Infra.Data.Repositories;
using SempreDivas.Service.Interface;
using SempreDivas.Service.ViewModel.Entities;
using SempreDivas.Service.ViewModel.Entities.Filtros;

namespace SempreDivas.Service.Service
{
    public class UsuarioService : BaseService, IUsuarioService
    {
        #region [Pripriedades Privadas]
        private readonly IMapper _mapper;
        private readonly IUsuarioRepository _usuarioRepository;
        #endregion

        #region [Construtor]
        public UsuarioService(IBaseRepository baseRepository, IMapper mapper) : base(baseRepository)
        {
            _mapper = mapper;
            _usuarioRepository = new UsuarioRepository(baseRepository);
        }
        #endregion

        #region [Métodos Públicos]
        public IEnumerable<UsuarioViewModel> ObterTodos(filtroUsuarioViewModel filtro)
        {
            var filtroNovo = _mapper.Map<filtroUsuario>(filtro);

            return _mapper.Map<UsuarioViewModel>(_usuarioRepository.ObterTodos(filtroNovo));
        }

        #endregion
    }
}
