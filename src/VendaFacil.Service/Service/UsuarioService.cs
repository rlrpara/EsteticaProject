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
    public class UsuarioService : BaseService, IUsuarioService
    {
        #region [Pripriedades Privadas]
        private readonly IMapper _mapper;
        private readonly IUsuarioRepository _service;
        #endregion

        #region [Construtor]
        public UsuarioService(IBaseRepository baseRepository, IMapper mapper) : base(baseRepository)
        {
            _mapper = mapper;
            _service = new UsuarioRepository(baseRepository);
        }
        #endregion

        #region [Métodos Públicos]
        public int ObterTotalRegistros(filtroUsuarioViewModel filtro)
            => _mapper.Map<int>(_service.TotalRegistros(_mapper.Map<filtroUsuario>(filtro)).Result);
        public UsuarioViewModel ObterPorCodigo(int codigo)
            => _mapper.Map<UsuarioViewModel>(_service.ObterPorCodigo(codigo).Result);
        public IEnumerable<UsuarioViewModel> ObterTodos(filtroUsuarioViewModel filtro)
            => _mapper.Map<IEnumerable<UsuarioViewModel>>(_service.ObterTodos(_mapper.Map<filtroUsuario>(filtro)).Result);
        public bool ObterEntidade(UsuarioViewModel model)
            => _service.ObterEntidade(_mapper.Map<Usuario>(model)).Result;
        public bool Inserir(UsuarioViewModel model)
            => _service.Inserir(_mapper.Map<Usuario>(model)).Result;
        public bool Atualizar(UsuarioViewModel model)
        {
            model.Ativo ??= ObterPorCodigo(model.Codigo).Ativo;
            model.DataAtualizacao = DateTime.Now;
            return _service.Atualizar(_mapper.Map<Usuario>(model)).Result;
        }
        public bool Deletar(UsuarioViewModel model)
        {
            model.Ativo = false;
            return _service.Atualizar(_mapper.Map<Usuario>(model)).Result;
        }

        #endregion
    }
}
