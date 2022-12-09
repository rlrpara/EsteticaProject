using AutoMapper;
using Estetica.Domain.Entities;
using Estetica.Domain.Interface;
using Estetica.Infra.Auth.Service;
using Estetica.Infra.Data.Repositories;
using Estetica.Service.Interface;
using Estetica.Service.ViewModel;
using Estetica.Service.ViewModel.Entities;

namespace Estetica.Service.Service
{
    public class LoginServices : BaseService, ILoginService
    {
        #region [Propriedades Privadas]
        private readonly IMapper _mapper;
        private readonly ILoginRepository _service;
        #endregion

        #region [Métodos Privados]
        private LoginViewModel ObterLogin(UsuarioAuthenticateRequestModel login) => new()
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

            var resultado = new UsuarioAuthenticateResponseModel(_mapper.Map<LoginViewModel>(usuario), TokenService.GenerateToken(usuario));

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
