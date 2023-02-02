using Estetica.Domain.Entities.Filtros;
using Estetica.Domain.Entities;

namespace Estetica.Domain.Interface
{
    public interface ITipoPessoaRepository : IBaseRepository
    {
        Task<IEnumerable<TipoPessoa>> ObterTodos(filtroTipoPessoa filtro);
    }
}
