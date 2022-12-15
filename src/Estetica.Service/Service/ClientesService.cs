using AutoMapper;
using Estetica.Domain.Entities;
using Estetica.Domain.Entities.Filtros;
using Estetica.Domain.Interface;
using Estetica.Infra.Data.Repositories;
using Estetica.Service.Interface;
using Estetica.Service.ViewModel.Entities;
using Estetica.Service.ViewModel.Entities.Filtros;

namespace Estetica.Service.Service
{
    public class ClientesService : BaseService, IClientesService
    {
        #region[Pripriedades Privadas]
        private readonly IMapper _mapper;
        private readonly IClientesRepository _service;
        #endregion

        #region [Construtor]
        public ClientesService(IBaseRepository baseRepository, IMapper mapper) : base(baseRepository)
        {
            _mapper = mapper;
            _service = new ClientesRepository(baseRepository);
        }
        #endregion

        #region [Métodos Públicos]
        public int ObterTotalRegistros(filtroClientesViewModel filtro) => _mapper.Map<int>(_service.TotalRegistros(_mapper.Map<filtroClientes>(filtro)).Result);
        public ClientesViewModel ObterPorCodigo(int codigo) => _mapper.Map<ClientesViewModel>(_service.ObterPorCodigo(codigo).Result);
        public IEnumerable<ClientesViewModel> ObterTodos(filtroClientesViewModel filtro) => _mapper.Map<IEnumerable<ClientesViewModel>>(_service.ObterTodos(_mapper.Map<filtroClientes>(filtro)).Result);
        public bool ObterEntidade(ClientesViewModel model) => _service.ObterEntidade(_mapper.Map<Clientes>(model)).Result;
        public bool Inserir(ClientesViewModel model) => _service.Inserir(_mapper.Map<Clientes>(model)).Result;
        public bool Atualizar(ClientesViewModel model)
        {
            model.Ativo ??= ObterPorCodigo(model.Codigo).Ativo;
            return _service.Atualizar(_mapper.Map<Clientes>(model)).Result;
        }
        public bool Deletar(ClientesViewModel model)
        {
            model.Ativo = false;
            return _service.Atualizar(_mapper.Map<Clientes>(model)).Result;
        }
        #endregion
    }
}
