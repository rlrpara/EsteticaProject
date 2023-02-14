using Estetica.Domain.Entities;
using Estetica.Domain.Interface;

namespace Estetica.Infra.Data.Repositories
{
    public class TipoEnderecoRepository : BaseRepository, ITipoEnderecoRepository
    {
        #region [Propriedades Privadas]
        private readonly IBaseRepository _baseRepository;
        #endregion

        #region [Métodos Privados]
        #endregion

        #region [Construtor]
        public TipoEnderecoRepository(IBaseRepository baseRepository) => _baseRepository = baseRepository;
        #endregion

        #region [Métodos Públicos]
        public async Task<IEnumerable<TipoEndereco>> ObterTodosAsync()
            => await _baseRepository.BuscarTodosPorQueryGeradorAsync<TipoEndereco>();

        #endregion
    }
}
