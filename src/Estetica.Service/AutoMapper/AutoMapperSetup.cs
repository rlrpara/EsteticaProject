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
            CreateMap<filtroClientesViewModel, filtroClientes>();
            CreateMap<filtroTipoPessoaViewModel, filtroTipoPessoa>();

            CreateMap<EmpresaViewModel, Empresa>();
            CreateMap<UsuarioViewModel, Usuario>();
            CreateMap<LoginViewModel, Login>();
            CreateMap<ClientesViewModel, Cliente>();
            CreateMap<TipoPessoaViewModel, TipoPessoa>();
            #endregion


            #region [DomainToViewModel]
            CreateMap<filtroEmpresa, filtroEmpresaViewModel>();
            CreateMap<filtroPaginacao, filtroPaginacaoViewModel>();
            CreateMap<filtroUsuario, filtroUsuarioViewModel>();
            CreateMap<filtroClientes, filtroClientesViewModel>();
            CreateMap<filtroTipoPessoa, filtroTipoPessoaViewModel>();

            CreateMap<Empresa, EmpresaViewModel>();
            CreateMap<Usuario, UsuarioViewModel>();
            CreateMap<Cliente, ClientesViewModel>();
            CreateMap<Login, LoginViewModel>();
            CreateMap<TipoPessoa, TipoPessoaViewModel>();
            #endregion
        }
    }
}
