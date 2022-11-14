using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using VendaFacil.Api;
using VendaFacil.Domain.Entities;
using VendaFacil.Domain.Interface;
using VendaFacil.Service.Interface;

namespace VendaFacil.Service.Service
{
    public class LoginServices : BaseService, ILoginService
    {
        public LoginServices(IBaseRepository baseRepository) : base(baseRepository)
        {
        }

        public string GenerateToken(Login login)
        {
            var TokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(Configuracao.JwtKey);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Expires= DateTime.UtcNow,
            };
            var token = TokenHandler.CreateToken(tokenDescriptor);
            return TokenHandler.WriteToken(token);
        }
    }
}
