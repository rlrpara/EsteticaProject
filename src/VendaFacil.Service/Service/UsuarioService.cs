using AutoMapper;
using VendaFacil.Domain.Entities.Base;
using VendaFacil.Domain.Entities.Filtros;
using VendaFacil.Domain.Interface;
using VendaFacil.Infra.Data.Repositories;
using VendaFacil.Service.Interface;
using VendaFacil.Service.ViewModel.Entities;
using VendaFacil.Service.ViewModel.Entities.Filtros;

namespace VendaFacil.Service.Service
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
            => _mapper.Map<IEnumerable<UsuarioViewModel>>(_usuarioRepository.ObterTodos(_mapper.Map<filtroUsuario>(filtro)).Result);
        public bool JaCadastrado(UsuarioViewModel model) =>  _usuarioRepository.JaCadastrado(_mapper.Map<Usuario>(model)).Result;
        public bool Inserir(UsuarioViewModel model) => _usuarioRepository.Inserir(_mapper.Map<Usuario>(model)).Result;

        #endregion
    }
}
