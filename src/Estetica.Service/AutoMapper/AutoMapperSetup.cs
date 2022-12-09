using AutoMapper;
using Estetica.Domain.Entities;
using Estetica.Domain.Entities.Filtros;
using Estetica.Service.ViewModel.Entities;
using Estetica.Service.ViewModel.Entities.Filtros;

namespace Estetica.Service.AutoMapper
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
            CreateMap<LoginViewModel, Login>();
            #endregion



            #region [DomainToViewModel]
            CreateMap<filtroEmpresa, filtroEmpresaViewModel>();
            CreateMap<filtroPaginacao, filtroPaginacaoViewModel>();
            CreateMap<filtroUsuario, filtroUsuarioViewModel>();

            CreateMap<Empresa, EmpresaViewModel>();
            CreateMap<Usuario, UsuarioViewModel>();
            CreateMap<Login, LoginViewModel>();
            #endregion
        }
    }
}
