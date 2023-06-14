using Estetica.Domain.Entities;

namespace Estetica.Infra.Database
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
        public EstabelecimentoOrigem ObterEstabelecimentoOrigemPadrao() => new()
        {
            Descricao = "EMPRESA PADRAO",
            DataCadastro = DateTime.Now,
            DataAtualizacao = DateTime.Now,
            Ativo = true
        };
        public List<UF> ObterUFPadrao() => new List<UF>()
        {
            new UF() { Descricao = "Acre", Sigla = "AC", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new UF() { Descricao = "Alagoas", Sigla = "AL", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new UF() { Descricao = "Amapa", Sigla = "AP", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new UF() { Descricao = "Amazonas", Sigla = "AM", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new UF() { Descricao = "Bahia", Sigla = "BA", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new UF() { Descricao = "Ceara", Sigla = "CE", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new UF() { Descricao = "Distrito Federal", Sigla = "DF", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new UF() { Descricao = "Espirito Santo", Sigla = "ES", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new UF() { Descricao = "Goiás", Sigla = "GO", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new UF() { Descricao = "Maranhão", Sigla = "MA", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new UF() { Descricao = "Mato Grosso", Sigla = "MT", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new UF() { Descricao = "Mato Grosso do Sul", Sigla = "MS", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new UF() { Descricao = "Minas Gerais", Sigla = "MG", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new UF() { Descricao = "Pará", Sigla = "PA", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new UF() { Descricao = "Paraíba", Sigla = "PB", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new UF() { Descricao = "Paraná", Sigla = "PR", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new UF() { Descricao = "Pernambuco", Sigla = "PE", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new UF() { Descricao = "Piauí", Sigla = "PI", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new UF() { Descricao = "Rio de Janeiro", Sigla = "RJ", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new UF() { Descricao = "Rio Grande do Norte", Sigla = "RN", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new UF() { Descricao = "Rio Grande do Sul", Sigla = "RS", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new UF() { Descricao = "Rondônia", Sigla = "RO", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new UF() { Descricao = "Roraima", Sigla = "RR", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new UF() { Descricao = "Santa Catarina", Sigla = "SC", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new UF() { Descricao = "São Paulo", Sigla = "SP", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new UF() { Descricao = "Sergipe", Sigla = "SE", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new UF() { Descricao = "Tocantins", Sigla = "TO", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
        };

        public List<TipoSexo> ObterTipoSexoPadrao() => new()
        {
            new TipoSexo()
            {
                Descricao = "Masculino",
                Sigla = "M",
                DataCadastro = DateTime.Now,
                DataAtualizacao = DateTime.Now,
                Ativo = true
            },
            new TipoSexo()
            {
                Descricao = "Feminino",
                Sigla = "F",
                DataCadastro = DateTime.Now,
                DataAtualizacao = DateTime.Now,
                Ativo = true
            },
        };

        public List<TipoEstadoCivil> ObterTipoEstadoCivilPadrao() => new()
        {
            new TipoEstadoCivil() { Descricao = "Solteiro(a)", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new TipoEstadoCivil() { Descricao = "Casado(a)", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new TipoEstadoCivil() { Descricao = "Divorciado(a)", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new TipoEstadoCivil() { Descricao = "Uniao Estavel", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new TipoEstadoCivil() { Descricao = "Viuvo(a)", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
        };

        public List<TipoSanguineo> ObterTipoSanguineoPadrao() => new()
        {
            new TipoSanguineo() { Descricao = "A+", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new TipoSanguineo() { Descricao = "A-", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new TipoSanguineo() { Descricao = "B+", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new TipoSanguineo() { Descricao = "B-", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new TipoSanguineo() { Descricao = "AB+", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new TipoSanguineo() { Descricao = "AB-", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new TipoSanguineo() { Descricao = "O+", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new TipoSanguineo() { Descricao = "O-", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
        };
    }
}
