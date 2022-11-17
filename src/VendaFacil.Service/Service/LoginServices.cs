using AutoMapper;
using VendaFacil.Domain.Entities;
using VendaFacil.Domain.Interface;
using VendaFacil.Infra.Auth.Service;
using VendaFacil.Infra.Data.Repositories;
using VendaFacil.Service.Interface;
using VendaFacil.Service.ViewModel;
using VendaFacil.Service.ViewModel.Entities;

namespace VendaFacil.Service.Service
{
    public class LoginServices : BaseService, ILoginService
    {
        #region [Propriedades Privadas]
        private readonly IMapper _mapper;
        private readonly ILoginRepository _service;
        #endregion

        #region [Métodos Privados]
        private ViewModelLogin ObterLogin(UsuarioAuthenticateRequestModel login) => new()
        {
            Email = login.Email,
            Senha = login.Senha
        };
        #endregion

        #region [Construtor]
        public LoginServices(IBaseRepository baseRepository, IMapper mapper) : base(baseRepository)
        {
            _mapper = mapper;
            _service = new LoginRepository(baseRepository);
        }
        #endregion

        public dynamic Authenticate(UsuarioAuthenticateRequestModel login)
        {
            var usuario = _service.Logar(_mapper.Map<Login>(ObterLogin(login))).Result;

            if (usuario is null || !usuario.Ativo)
                return null;

            var resultado = new UsuarioAuthenticateResponseModel(_mapper.Map<ViewModelLogin>(usuario), TokenService.GenerateToken(usuario));

            var saida = new
            {
                Login = new
                {
                    usuario.Nome,
                    usuario.Email,
                },
                resultado.Token
            };

            return saida;
        }
    }
}
