using VendaFacil.Service.ViewModel.Entities;
using VendaFacil.Service.ViewModel.Entities.Filtros;

namespace VendaFacil.Tests.PesentationTests.ControllersTests.EmpresaControllerTests
{
    public class EmpresaControllerBaseTests
    {
        public filtroEmpresaViewModel ObterFiltroEmpresa() => new filtroEmpresaViewModel()
        {
            Nome = "",
            CpfCnpj = "26965150000123",
            Telefone = "",
            Email = "",
            PaginaAtual = 1,
            QuantidadePorPagina = 50
        };

        public Task<IEnumerable<EmpresaViewModel>> ObterEmpresas() => new List<EmpresaViewModel>
        {
            new EmpresaViewModel()
            {
                Codigo = 1,
                Nome = "Noah e Nelson Locações de Automóveis Ltda",
                CpfCnpj = "26965150000123",
                Telefone = "(16) 3893-8071",
                Email = "juridico@noahenelsonlocacoesdeautomoveisltda.com.br",
                Endereco = "Rua João Lourenço, 591, Vila Prado, São Carlos",
                ValorMensal = 50,
                DataPagamento = 10,
                DataCadastro = new DateTime(2022, 11, 30),
                DataAtualizacao = new DateTime(2022, 11, 30),
                Ativo = true
            },
            new EmpresaViewModel()
            {
                Codigo = 1,
                Nome = "Giovanna e Lucca Buffet ME",
                CpfCnpj = "90599579000143",
                Telefone = "(11) 3954-7375",
                Email = "juridico@noahenelsonlocacoesdeautomoveisltda.com.br",
                Endereco = "Rua José Maria Schiavelli, 720, Vila Santa Catarina",
                ValorMensal = 50,
                DataPagamento = 10,
                DataCadastro = new DateTime(2022, 11, 30),
                DataAtualizacao = new DateTime(2022, 11, 30),
                Ativo = true
            }
        };
    }
}
