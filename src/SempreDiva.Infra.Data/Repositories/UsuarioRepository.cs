using SempreDivas.Domain.Entities.Base;
using SempreDivas.Domain.Entities.Filtros;
using SempreDivas.Domain.Interface;

namespace SempreDivas.Infra.Data.Repositories
{
    public class UsuarioRepository : BaseRepository, IUsuarioRepository
    {
        #region [Propriedades Privadas]
        private readonly IBaseRepository _baseRepository;
        #endregion

        #region [Construtor]
        public UsuarioRepository(IBaseRepository baseRepository) => _baseRepository = baseRepository;
        #endregion

        #region [Métodos Públicos]
        public IEnumerable<Usuario> ObterTodos(filtroUsuario filtroNovo)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
