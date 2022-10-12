using AutoMapper;
using VendaFacil.Domain.Entities.Base;
using VendaFacil.Service.ViewModel.Entities;

namespace VendaFacil.Service.AutoMapper
{
    public class AutoMapperSetup : Profile
    {
        public AutoMapperSetup()
        {
            #region [ViewModelToDomain]
            CreateMap<UsuarioViewModel, Usuario>();
            #endregion



            #region [DomainToViewModel]
            CreateMap<Usuario, UsuarioViewModel>();
            #endregion
        }
    }
}
