﻿using AutoMapper;
using Estetica.Domain.Entities;
using Estetica.Domain.Entities.Filtros;
using Estetica.Domain.Interface;
using Estetica.Infra.Data.Repositories;
using Estetica.Service.Interface;
using Estetica.Service.ViewModel.Entities;
using Estetica.Service.ViewModel.Entities.Filtros;

namespace Estetica.Service.Service
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

        public int ObterTotalRegistros(filtroEmpresaViewModel filtro) => _mapper.Map<int>(_service.TotalRegistros(_mapper.Map<filtroEmpresa>(filtro)).Result);
        public EmpresaViewModel ObterPorCodigo(int codigo) => _mapper.Map<EmpresaViewModel>(_service.ObterPorCodigo(codigo).Result);
        public IEnumerable<EmpresaViewModel> ObterTodos(filtroEmpresaViewModel filtro) => _mapper.Map<IEnumerable<EmpresaViewModel>>(_service.ObterTodos(_mapper.Map<filtroEmpresa>(filtro)).Result);
        public bool ObterEntidade(EmpresaViewModel model) => _service.ObterEntidade(_mapper.Map<Empresa>(model)).Result;
        public bool Inserir(EmpresaViewModel model) => _service.Inserir(_mapper.Map<Empresa>(model)).Result;
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
