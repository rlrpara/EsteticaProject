using System.Text;
using VendaFacil.Domain.Entities;
using VendaFacil.Domain.Entities.Filtros;
using VendaFacil.Domain.Interface;

namespace VendaFacil.Infra.Data.Repositories
{
    public class EmpresaRepository : BaseRepository, IEmpresaRepository
    {
        #region [Propriedades Privadas]
        private readonly IBaseRepository _baseRepository;
        #endregion

        #region [Métodos Privados]
        private string ObterFiltros(filtroUsuario filtro)
        {
            var sqlPesquisa = new StringBuilder();

            sqlPesquisa.AppendLine($" WHERE email ILIKE '%{filtro.Email}%'");
            sqlPesquisa.AppendLine($"   AND nome ilike '%{filtro.Nome}%'");

            return sqlPesquisa.ToString();
        }
        #endregion

        #region [Construtor]
        public EmpresaRepository(IBaseRepository baseRepository) => _baseRepository = baseRepository;
        #endregion

        #region [Métodos Públicos]
        public Task<int> ObterPorCodigo(int codigo)
        {
            throw new NotImplementedException();
        }

        public Task<int> TotalRegistros(filtroEmpresa filtro)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Empresa>> ObterTodos(filtroEmpresa filtro)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ObterEntidade(Empresa empresa)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Inserir(Empresa empresa)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Atualizar(Empresa empresa)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
