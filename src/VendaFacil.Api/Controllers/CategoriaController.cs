﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using VendaFacil.Api.Model;
using VendaFacil.Infra.Data.Repositories;
using VendaFacil.Service.Interface;
using VendaFacil.Service.Service;
using VendaFacil.Service.ViewModel.Entities;
using VendaFacil.Service.ViewModel.Entities.Filtros;

namespace VendaFacil.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        #region [Propriedades Privadas]
        private readonly IMapper _mapper;
        private readonly ICategoriaService _service;
        #endregion

        #region [Métodos Privados]
        private int ObterTotalPaginas(filtroCategoriaViewModel filtro)
        {
            int total = _service.ObterTotalRegistros(filtro) / filtro.QuantidadePorPagina;
            if ((_service.ObterTotalRegistros(filtro) % filtro.QuantidadePorPagina) > 0)
                total += 1;
            return total.Equals(0) ? 1 : total;
        }
        #endregion

        #region [Contrutor]
        public CategoriaController(IMapper mapper)
        {
            _mapper = mapper;
            _service = new CategoriaServie(new BaseRepository(), _mapper);
        }
        #endregion

        #region [Propriedades Públicas]
        [HttpPost("ObterTodos")]
        public IActionResult PostObterTodos([FromBody] filtroCategoriaViewModel filtro)
        {
            List<CategoriaViewModel> dadosRetorno = _service.ObterTodos(filtro).ToList();

            if (dadosRetorno is null)
                return Ok(new { Resultado = "Registro não encontrado." });

            var resultado = new ApiResult<CategoriaViewModel>();
            resultado.AddPaginacao(filtro.PaginaAtual, filtro.QuantidadePorPagina, ObterTotalPaginas(filtro), _service.ObterTotalRegistros(filtro), dadosRetorno);

            return Ok(resultado);
        }

        [HttpPost("Inserir")]
        public IActionResult PostInserir([FromBody] CategoriaViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (_service.ObterEntidade(model))
                    return Ok(new { Resultado = "Registro já cadastrado." });

                return Created("", _service.Inserir(model));
            }
            return BadRequest(ModelState);
        }

        [HttpPut("Atualizar")]
        public IActionResult PutAtualizar([FromBody] CategoriaViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Codigo.Equals(0))
                    return Ok(new { Resultado = "Registro não encontrado" });

                var consulta = _service.ObterPorCodigo(model.Codigo);

                if (consulta is not null)

                    return Ok(_service.Atualizar(model));
                else
                    return BadRequest(new { Resultado = "Registro não encontrado" });
            }

            return BadRequest(ModelState);
        }

        [HttpDelete("Excluir")]
        public IActionResult DeleteExcluir(int Codigo)
        {
            if (Codigo.Equals(0))
                return Ok(new { Resultado = "Registro não encontrado" });

            var consulta = _service.ObterPorCodigo(Codigo);

            if (consulta.Ativo is not null && !(consulta.Ativo ?? false))
                return Ok(new { Resultado = "Registro ja deletado" });

            if (consulta is not null)
                return Ok(_service.Deletar(consulta));
            else
                return BadRequest(new { Resultado = "Registro não encontrado" });
        }

        #endregion
    }
}