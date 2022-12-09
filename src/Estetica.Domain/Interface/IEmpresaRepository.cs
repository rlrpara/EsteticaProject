using Estetica.Domain.Entities;
using Estetica.Domain.Entities.Filtros;

namespace Estetica.Domain.Interface
{
    public interface IEmpresaRepository : IBaseRepository
    {
        Task<Empresa> ObterPorCodigo(int codigo);
        Task<int> TotalRegistros(filtroEmpresa filtro);
        Task<IEnumerable<Empresa>> ObterTodos(filtroEmpresa filtro);
        Task<bool> ObterEntidade(Empresa empresa);
        Task<bool> Inserir(Empresa empresa);
        Task<bool> Atualizar(Empresa empresa);
    }
}
