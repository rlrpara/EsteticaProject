using AutoMapper;
using VendaFacil.Domain.Entities;
using VendaFacil.Domain.Entities.Filtros;
using VendaFacil.Service.ViewModel.Entities;
using VendaFacil.Service.ViewModel.Entities.Filtros;

namespace VendaFacil.Service.AutoMapper
{
    public class AutoMapperSetup : Profile
    {
        public AutoMapperSetup()
        {
            #region [ViewModelToDomain]
            CreateMap<filtroCartaoViewModel, filtroCartao>();
            CreateMap<filtroCategoriaViewModel, filtroCategoria>();
            CreateMap<filtroEmpresaViewModel, filtroEmpresa>();
            CreateMap<filtroPaginacaoViewModel, filtroPaginacao>();
            CreateMap<filtroUsuarioViewModel, filtroUsuario>();

            CreateMap<CartaoViewModel, Cartao>();
            CreateMap<CategoriaViewModel, Categoria>();
            CreateMap<DespesaViewModel, Despesa>();
            CreateMap<EmpresaViewModel, Empresa>();
            CreateMap<GanhoViewModel, Ganho>();
            CreateMap<MesViewModel, Mes>();
            CreateMap<ProdutoServicoCategoriaViewModel, ProdutoServicoCategoria>();
            CreateMap<ProdutoServicoViewModel, ProdutoServico>();
            CreateMap<TipoViewModel, Tipo>();
            CreateMap<UsuarioViewModel, Usuario>();
            #endregion



            #region [DomainToViewModel]
            CreateMap<filtroCartao, filtroCartaoViewModel>();
            CreateMap<filtroCategoria, filtroCategoriaViewModel>();
            CreateMap<filtroEmpresa, filtroEmpresaViewModel>();
            CreateMap<filtroPaginacao, filtroPaginacaoViewModel>();
            CreateMap<filtroUsuario, filtroUsuarioViewModel>();

            CreateMap<Cartao, CartaoViewModel>();
            CreateMap<Categoria, CategoriaViewModel>();
            CreateMap<Despesa, DespesaViewModel>();
            CreateMap<Empresa, EmpresaViewModel>();
            CreateMap<Ganho, GanhoViewModel>();
            CreateMap<Mes, MesViewModel>();
            CreateMap<ProdutoServicoCategoria, ProdutoServicoCategoriaViewModel>();
            CreateMap<ProdutoServico, ProdutoServicoViewModel>();
            CreateMap<Tipo, TipoViewModel>();
            CreateMap<Usuario, UsuarioViewModel>();
            #endregion
        }
    }
}
