using AutoMapper;
using VendaFacil.Domain.Entities.Base;
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
            CreateMap<filtroUsuarioViewModel, filtroUsuario>();

            CreateMap<UsuarioViewModel, Usuario>();
            CreateMap<EmpresaViewModel, Empresa>();
            #endregion



            #region [DomainToViewModel]
            CreateMap<filtroUsuario, filtroUsuarioViewModel>();

            CreateMap<Usuario, UsuarioViewModel>();
            CreateMap<Empresa, EmpresaViewModel>();
            #endregion
        }
    }
}
