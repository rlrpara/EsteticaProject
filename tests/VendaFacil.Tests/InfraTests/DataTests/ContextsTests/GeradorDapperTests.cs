using VendaFacil.Domain.Entities.Base;
using VendaFacil.Infra.Data.Context;
using VendaFacil.Infra.Data.Interface;

namespace VendaFacil.Tests.InfraTests.DataTests.ContextsTests
{
    [Trait("Data", "GeradorDapper")]
    public class GeradorDapperTests : GeradorDapperBaseTests
    {
        #region [Propriedades Privadas]
        private readonly IGeradorDapper _geradorDapper;
        #endregion

        #region [Construtor]
        public GeradorDapperTests() =>_geradorDapper = new GeradorDapper(new ParametrosConexao());
        #endregion

        #region [Métodos Públicos]
        [Fact(DisplayName = "Deve gerar um nova instância")]
        public void DeveGerarNovaInstacia() => Assert.True(_geradorDapper is not null);

        [Fact(DisplayName = "Deve obter a chave primária de uma classe")]
        public void DeveObterChavePrimariaUmaClasse() => Assert.Equal("ID", _geradorDapper.ObterChavePrimaria<Empresa>());

        [Fact(DisplayName = "Deve obter o nome da tabela na classe")]
        public void DeveObterNomeTabelaClasse() => Assert.Equal("EMPRESA", _geradorDapper.ObterNomeTabela<Empresa>());

        [Fact(DisplayName = "Deve retornar o insert de uma classe")]
        public void DeveRetornarInsertUmaClasse() => Assert.Equal(ObterSqlInsertEmpresaGerado(), _geradorDapper.GeralSqlInsertControles(ObterEmpresa()));

        #endregion
    }
}
