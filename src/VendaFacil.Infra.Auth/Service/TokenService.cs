using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using VendaFacil.Domain.Entities;
using VendaFacil.Infra.Auth.Model;

namespace VendaFacil.Infra.Auth.Service
{
    public static class TokenService
    {
        public static string GenerateToken(Login login)
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes(ConfigAuth.Secret);
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim(ClaimTypes.Name, login.Nome),
                        new Claim(ClaimTypes.Email, login.Email),
                        new Claim(ClaimTypes.NameIdentifier, login.Codigo.ToString())
                    }),
                    Expires = DateTime.UtcNow.AddDays(3),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                };
                var token = tokenHandler.CreateToken(tokenDescriptor);
                return tokenHandler.WriteToken(token);
            }
            catch
            {
                return default(dynamic);
            }
        }
    }
}
