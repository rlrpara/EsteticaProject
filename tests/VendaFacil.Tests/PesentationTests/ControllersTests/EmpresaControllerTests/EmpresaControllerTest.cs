using AutoMapper;
using Moq;
using VendaFacil.Api.Controllers;
using VendaFacil.Domain.Interface;
using VendaFacil.Infra.Data.Repositories;
using VendaFacil.Service.ViewModel.Entities.Filtros;

namespace VendaFacil.Tests.PesentationTests.ControllersTests.EmpresaControllerTests;

[Trait("Controllers", "Empresa")]
public class EmpresaControllerTest
{
    private readonly IMapper _mapper;
    private readonly Mock<IBaseRepository> _baseRepository;

    public EmpresaControllerTest()
    {
        _baseRepository = new Mock<IBaseRepository>();
    }

    [Fact(DisplayName = "Deve gerar um nova instância")]
    public void Post_ObterTodos()
    {
        var filtro = new filtroEmpresaViewModel
        {
            Nome = "Rodrigo",
            CpfCnpj = "",
            Telefone = "",
            Email = ""
        };
        _baseRepository.Setup(x => x.BuscarTodosPorQueryAsync(x => x.))
        var controller = new EmpresasController(_baseRepository.Object, _mapper);

        var teste = controller.PostObterTodos(filtro);

        Assert.NotNull(teste);
    }
}
