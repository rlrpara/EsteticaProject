using System.Text;
using Estetica.Domain.Entities;
using Estetica.Domain.Interface;

namespace Estetica.Infra.Data.Repositories
{
    public class LoginRepository : BaseRepository, ILoginRepository
    {
        #region [Propriedades Privadas]
        private readonly IBaseRepository _baseRepository;
        #endregion

        #region [Construtor]
        public LoginRepository(IBaseRepository baseRepository)
        {
            _baseRepository = baseRepository;
        }
        #endregion

        #region [Métodos Públicos]
        public async Task<Login> Logar(Login login)
        {
            var sqlPesquisa = new StringBuilder();

            sqlPesquisa.AppendLine($"EMAIL = '{login.Email}' AND SENHA = '{login.Senha}'");

            return await _baseRepository.BuscarPorQueryGeradorAsync<Login>(sqlPesquisa.ToString());
        }
        #endregion
    }
}
