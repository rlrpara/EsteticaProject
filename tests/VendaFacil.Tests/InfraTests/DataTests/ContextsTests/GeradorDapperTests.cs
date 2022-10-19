using VendaFacil.Infra.Data.Context;
using VendaFacil.Infra.Data.Interface;

namespace VendaFacil.Tests.InfraTests.DataTests.ContextsTests
{
    [Trait("Data", "GeradorDapper")]
    public class GeradorDapperTests
    {
        private readonly IGeradorDapper _geradorDapper;

        #region [Construtor]
        public GeradorDapperTests() =>_geradorDapper = new GeradorDapper(new ParametrosConexao());
        #endregion

        [Fact(DisplayName = "Deve gerar um nova instância")]
        public void DeveGerarNovaInstacia()
        {
            var geradorDapper = new GeradorDapper(new ParametrosConexao());

            Assert.True(geradorDapper is not null);
        }
    }
}
