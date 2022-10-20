using VendaFacil.Domain.Entities;

namespace VendaFacil.Infra.Database
{
    public class DatabaseConfigurationBase
    {
        public Usuario ObterUsuarioPadrao() => new Usuario
        {
            Nome = "Administrador",
            Email = "admin@email.com",
            Senha = "Postgres2022!",
            Cpf = "0".PadLeft(11, '0'),
            CodigoEmpresa = 0,
            DataCadastro = DateTime.Now,
            DataAtualizacao = DateTime.Now,
            Foto = null,
            Ativo = true,
            Nivel = 92
        };
    }
}
