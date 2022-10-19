using System.Text;
using VendaFacil.Domain.Entities.Base;

namespace VendaFacil.Tests.InfraTests.DataTests.ContextsTests
{
    public class GeradorDapperBaseTests
    {
        public Empresa ObterEmpresa() => new Empresa
        {
            Nome = "Estética Malato",
            CpfCnpj = "430.919.032-49",
            Telefone = "(49) 99945-8768",
            Email = "rosemalato@gmail.com",
            Endereco = "R. Brasília, 187-d, nº 105 - Jardim Itália, Chapecó - SC, 89802-320",
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
            sqlPesquisa.AppendLine($"                     VALUES (0, 'ESTETICA MALATO', '43091903249', '49999458768', 'rosemalato@gmail.com', 'R. BRASILIA, 187-D, N 105 - JARDIM ITALIA, CHAPECO - SC, 89802-320', 70, 10, '2022-10-18 23:25:45', '2022-10-18 23:25:45', True)");

            return sqlPesquisa?.ToString()?.Trim();
        }
    }
}
