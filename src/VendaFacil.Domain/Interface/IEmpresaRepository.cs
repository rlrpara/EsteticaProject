﻿using VendaFacil.Domain.Entities.Base;
using VendaFacil.Domain.Entities.Filtros;

namespace VendaFacil.Domain.Interface
{
    public interface IEmpresaRepository : IBaseRepository
    {
        Task<int> ObterPorCodigo(int codigo);
        Task<int> TotalRegistros(filtroEmpresa filtro);
        Task<IEnumerable<Empresa>> ObterTodos(filtroEmpresa filtro);
        Task<bool> ObterEntidade(Empresa empresa);
        Task<bool> Inserir(Empresa empresa);
        Task<bool> Atualizar(Empresa empresa);
    }
}
