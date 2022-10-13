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
            CreateMap<UsuarioViewModel, Usuario>();
            CreateMap<filtroUsuarioViewModel, filtroUsuario>();
            #endregion



            #region [DomainToViewModel]
            CreateMap<Usuario, UsuarioViewModel>();
            CreateMap<filtroUsuario, filtroUsuarioViewModel>();
            #endregion
        }
    }
}
