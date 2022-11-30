using AutoMapper;
using Moq;
using VendaFacil.Domain.Entities;
using VendaFacil.Domain.Interface;
using VendaFacil.Service.Service;

namespace VendaFacil.Tests.PesentationTests.ControllersTests.EmpresaControllerTests;

[Trait("Controllers", "Empresa")]
public class EmpresaControllerTest : EmpresaControllerBaseTests
{
    #region [Propriedades Privadas]
    private readonly IMapper _mapper;
    #endregion

    #region [Construtor]
    public EmpresaControllerTest() { }
    #endregion

    #region [Métodos Públicos]
    [Fact(DisplayName = "Quando invocado deve obter um Ok Result")]
    public void Post_QuandoInvocadoDeveObterOkResult()
    {
        var _mockervice = new Mock<IBaseRepository>();
        _mockervice.Setup(x => x.BuscarTodosPorQueryAsync<Empresa>(It.Is<string>(x => x.Contains("SELECT id as Codigo,")))).Returns(ObterEmpresas());

        var service = new EmpresaService(_mockervice.Object, _mapper);

        var teste = service.ObterTodos(ObterFiltroEmpresa());
    }

    #endregion
}
