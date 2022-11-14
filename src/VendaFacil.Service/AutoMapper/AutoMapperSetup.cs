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
            CreateMap<filtroEmpresaViewModel, filtroEmpresa>();
            CreateMap<filtroPaginacaoViewModel, filtroPaginacao>();
            CreateMap<filtroUsuarioViewModel, filtroUsuario>();

            CreateMap<EmpresaViewModel, Empresa>();
            CreateMap<UsuarioViewModel, Usuario>();
            #endregion



            #region [DomainToViewModel]
            CreateMap<filtroEmpresa, filtroEmpresaViewModel>();
            CreateMap<filtroPaginacao, filtroPaginacaoViewModel>();
            CreateMap<filtroUsuario, filtroUsuarioViewModel>();

            CreateMap<Empresa, EmpresaViewModel>();
            CreateMap<Usuario, UsuarioViewModel>();
            #endregion
        }
    }
}
