using Estetica.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Estetica.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TipoEnderecoController : ControllerBase
{
    #region [Propriedades Privadas]
    private readonly ITipoEnderecoService _service;
    #endregion

    #region [Métodos Privados]

    #endregion

    #region [Contrutor]
    public TipoEnderecoController(ITipoEnderecoService TipoEnderecoService) => _service = TipoEnderecoService;
    #endregion

    #region [Propriedades Públicas]
    [HttpGet("")]
    public IActionResult PostObterTodos()
    {
        var dadosRetorno = _service.ObterTodos();

        if (dadosRetorno is null)
            return NotFound(new { Resultado = "Registro não encontrado." });

        return Ok(dadosRetorno);
    }

    #endregion
}
