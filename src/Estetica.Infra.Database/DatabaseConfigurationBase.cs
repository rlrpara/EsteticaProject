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

        public List<TipoPessoa> ObterTipoPessoaPadrao() => new()
        {
            new TipoPessoa() { Descricao = "FÍSICA", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new TipoPessoa() { Descricao = "JURÍDICA", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true }
        };

        public List<TipoEndereco> ObterTipoEnderecoPadrao() => new()
        {
            new TipoEndereco() { Descricao = "AEROPORTO", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new TipoEndereco() { Descricao = "ALAMEDA", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new TipoEndereco() { Descricao = "AREA", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new TipoEndereco() { Descricao = "AVENIDA", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new TipoEndereco() { Descricao = "CAMPO", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new TipoEndereco() { Descricao = "CHACARA", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new TipoEndereco() { Descricao = "COLONIA", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new TipoEndereco() { Descricao = "CONDOMINIO", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new TipoEndereco() { Descricao = "CONJUNTO", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new TipoEndereco() { Descricao = "DISTRITO", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new TipoEndereco() { Descricao = "ESPLANADA", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new TipoEndereco() { Descricao = "ESTACAO", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new TipoEndereco() { Descricao = "ESTRADA", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new TipoEndereco() { Descricao = "FAVELA", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new TipoEndereco() { Descricao = "FAZENDA", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new TipoEndereco() { Descricao = "FEIRA", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new TipoEndereco() { Descricao = "JARDIM", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new TipoEndereco() { Descricao = "LADEIRA", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new TipoEndereco() { Descricao = "LAGO", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new TipoEndereco() { Descricao = "LAGOA", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new TipoEndereco() { Descricao = "LARGO", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new TipoEndereco() { Descricao = "LOTEAMENTO", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new TipoEndereco() { Descricao = "MORRO", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new TipoEndereco() { Descricao = "NUCLEO", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new TipoEndereco() { Descricao = "PARQUE", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new TipoEndereco() { Descricao = "PASSARELA" , DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true},
            new TipoEndereco() { Descricao = "PATIO", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new TipoEndereco() { Descricao = "PRACA", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new TipoEndereco() { Descricao = "QUADRA", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new TipoEndereco() { Descricao = "RECANTO", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new TipoEndereco() { Descricao = "RESIDENCIAL", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new TipoEndereco() { Descricao = "RODOVIA", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new TipoEndereco() { Descricao = "RUA", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new TipoEndereco() { Descricao = "SETOR" , DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true},
            new TipoEndereco() { Descricao = "SITIO", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new TipoEndereco() { Descricao = "TRAVESSA", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new TipoEndereco() { Descricao = "TRECHO", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new TipoEndereco() { Descricao = "TREVO", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new TipoEndereco() { Descricao = "VALE", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new TipoEndereco() { Descricao = "VEREDA", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new TipoEndereco() { Descricao = "VIA", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new TipoEndereco() { Descricao = "VIADUTO", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new TipoEndereco() { Descricao = "VIELA", DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true },
            new TipoEndereco() { Descricao = "VILA" , DataCadastro = DateTime.Now, DataAtualizacao = DateTime.Now, Ativo = true},
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
    }
}
