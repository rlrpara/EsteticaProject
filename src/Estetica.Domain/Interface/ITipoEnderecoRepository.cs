using Estetica.Domain.Entities;

namespace Estetica.Domain.Interface
{
    public interface ITipoEnderecoRepository : IBaseRepository
    {
        Task<IEnumerable<TipoEndereco>> ObterTodosAsync();
    }
}
