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
    public class CategoriaServie : BaseService, ICategoriaService
    {
        #region [Propriedades Pricads]
        private readonly IMapper _mapper;
        private readonly ICategoriaRepository _service;
        #endregion

        #region [Construtor]
        public CategoriaServie(IBaseRepository baseRepository, IMapper mapper) : base(baseRepository)
        {
            _mapper = mapper;
            _service = new CategoriaRepository(baseRepository);
        }
        #endregion

        #region [Métodos Públivos]
        public bool Atualizar(CategoriaViewModel model)
        {
            model.Ativo ??= ObterPorCodigo(model.Codigo).Ativo;
            return _service.Atualizar(_mapper.Map<Categoria>(model)).Result;
        }
        public bool Deletar(CategoriaViewModel model)
        {
            model.Ativo = false;
            return _service.Atualizar(_mapper.Map<Categoria>(model)).Result;
        }
        public bool Inserir(CategoriaViewModel model) => _service.Inserir(_mapper.Map<Categoria>(model)).Result;
        public bool ObterEntidade(CategoriaViewModel model) => _service.ObterEntidade(_mapper.Map<Categoria>(model)).Result;
        public CategoriaViewModel ObterPorCodigo(int codigo) => _mapper.Map<CategoriaViewModel>(_service.ObterPorCodigo(_mapper.Map<int>(codigo)).Result);
        public IEnumerable<CategoriaViewModel> ObterTodos(filtroCategoriaViewModel filtro) => _mapper.Map<IEnumerable<CategoriaViewModel>>(_service.ObterTodos(_mapper.Map<filtroCategoria>(filtro)).Result);
        public int ObterTotalRegistros(filtroCategoriaViewModel filtro) => _service.ObterTotalRegistros(_mapper.Map<filtroCategoria>(filtro)).Result;

        #endregion
    }
}
