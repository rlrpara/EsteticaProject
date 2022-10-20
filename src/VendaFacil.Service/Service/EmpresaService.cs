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
    public class EmpresaService : BaseService, IEmpresaService
    {
        #region[Pripriedades Privadas]
        private readonly IMapper _mapper;
        private readonly IEmpresaRepository _service;
        #endregion

        #region [Construtores]
        public EmpresaService(IBaseRepository baseRepository, IMapper mapper) : base(baseRepository)
        {
            _mapper = mapper;
            _service = new EmpresaRepository(baseRepository);
        }
        #endregion

        public int ObterTotalRegistros(filtroEmpresaViewModel filtro)
            => _mapper.Map<int>(_service.TotalRegistros(_mapper.Map<filtroEmpresa>(filtro)).Result);
        public EmpresaViewModel ObterPorCodigo(int codigo)
            => _mapper.Map<EmpresaViewModel>(_service.ObterPorCodigo(codigo).Result);
        public IEnumerable<EmpresaViewModel> ObterTodos(filtroEmpresaViewModel filtro)
            => _mapper.Map<IEnumerable<EmpresaViewModel>>(_service.ObterTodos(_mapper.Map<filtroEmpresa>(filtro)).Result);
        public bool ObterEntidade(EmpresaViewModel model)
            => _service.ObterEntidade(_mapper.Map<Empresa>(model)).Result;
        public bool Inserir(EmpresaViewModel model)
            => _service.Inserir(_mapper.Map<Empresa>(model)).Result;
        public bool Atualizar(EmpresaViewModel model)
        {
            model.Ativo ??= ObterPorCodigo(model.Codigo).Ativo;
            return _service.Atualizar(_mapper.Map<Empresa>(model)).Result;
        }
        public bool Deletar(EmpresaViewModel model)
        {
            model.Ativo = false;
            return _service.Atualizar(_mapper.Map<Empresa>(model)).Result;
        }

    }
}
