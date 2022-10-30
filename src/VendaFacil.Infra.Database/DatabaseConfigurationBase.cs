using VendaFacil.Domain.Entities;

namespace VendaFacil.Infra.Database
{
    public class DatabaseConfigurationBase
    {
        public Empresa ObterEmpresaPadrao() => new Empresa
        {
            Nome = "Empresa padrão",
            CpfCnpj = "00000000000000",
            Telefone = "",
            Email = "",
            Endereco = "Endereço padrão",
            ValorMensal = 0,
            DataPagamento = 10,
            DataCadastro = DateTime.Now,
            DataAtualizacao = DateTime.Now,
            Ativo = true
        };
        public Usuario ObterUsuarioPadrao() => new Usuario
        {
            Nome = "Administrador",
            Email = "admin@email.com",
            Senha = "Postgres2022!",
            Cpf = "0".PadLeft(11, '0'),
            CodigoEmpresa = 1,
            DataCadastro = DateTime.Now,
            DataAtualizacao = DateTime.Now,
            Foto = null,
            Ativo = true,
            Nivel = 92
        };
    }
}
