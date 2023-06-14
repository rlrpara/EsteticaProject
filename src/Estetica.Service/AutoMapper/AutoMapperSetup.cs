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
            CreateMap<filtroEmpresaViewModel, filtroEmpresa>().ReverseMap();
            CreateMap<filtroPaginacaoViewModel, filtroPaginacao>().ReverseMap();
            CreateMap<filtroUsuarioViewModel, filtroUsuario>().ReverseMap();
            CreateMap<filtroClientesViewModel, filtroClientes>().ReverseMap();
            CreateMap<filtroTipoPessoaViewModel, filtroTipoPessoa>().ReverseMap();

            CreateMap<EmpresaViewModel, Empresa>().ReverseMap();
            CreateMap<UsuarioViewModel, Usuario>().ReverseMap();
            CreateMap<LoginViewModel, Login>().ReverseMap();
            CreateMap<ClientesViewModel, Cliente>().ReverseMap();
        }
    }
}
