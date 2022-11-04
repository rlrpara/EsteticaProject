using System.Text;
using VendaFacil.Domain.Entities;

namespace VendaFacil.Tests.InfraTests.DataTests.ContextsTests
{
    public class GeradorDapperBaseTests
    {
        public Empresa ObterEmpresa() => new Empresa
        {
            Nome = "Estética Teste",
            CpfCnpj = "386.485.813-54",
            Telefone = "(69) 98887-3627",
            Email = "fulanoo@gmail.com",
            Endereco = "Rua Dom Helder Câmara, 465, Belo Horizonte/MG - 31870-440",
            ValorMensal = 70,
            DataPagamento = 10,
            DataCadastro = Convert.ToDateTime("2022-10-18 23:25:45"),
            DataAtualizacao = Convert.ToDateTime("2022-10-18 23:25:45"),
            Ativo = true
        };

        public string? ObterSqlInsertEmpresaGerado()
        {
            var sqlPesquisa = new StringBuilder();

            sqlPesquisa.AppendLine($"INSERT INTO EMPRESA (NOME, CPF_CNPJ, TELEFONE, EMAIL, ENDERECO, VALOR_MENSAL, DATA_PAGAMENTO, DATA_CADASTRO, DATA_ATUALIZACAO, ATIVO)");
            sqlPesquisa.AppendLine($"                     VALUES ('ESTETICA TESTE', '38648581354', '69988873627', 'fulanoo@gmail.com', 'RUA DOM HELDER CAMARA, 465, BELO HORIZONTEMG - 31870-440', 70, 10, '2022-10-18 23:25:45', '2022-10-18 23:25:45', True)");

            return sqlPesquisa?.ToString()?.Trim();
        }
    }
}
