using System.Text;
using VendaFacil.Domain.Entities;
using VendaFacil.Domain.Entities.Filtros;
using VendaFacil.Domain.Interface;

namespace VendaFacil.Infra.Data.Repositories
{
    public class GanhoRepository : BaseRepository, IGanhoRepository
    {
        #region [Propriedades Privadas]
        private readonly IBaseRepository _baseRepository;
        #endregion

        #region [Métodos Privados]
        private string ObterFiltros(filtroGanho filtro)
        {
            var sqlPesquisa = new StringBuilder();

            sqlPesquisa.AppendLine($" WHERE descricao ILIKE '%{filtro.Descricao}%'");
            if(filtro.CodigoCategoria is not null)
                sqlPesquisa.AppendLine($"   AND id_categoria = {filtro.CodigoCategoria}");
            if (filtro.CodigoMes is not null)
                sqlPesquisa.AppendLine($"   AND id_mes = {filtro.CodigoMes}");
            if (filtro.Ano is not null)
                sqlPesquisa.AppendLine($"   AND ano = {filtro.Ano}");
            if (filtro.CodigoUsuario is not null)
                sqlPesquisa.AppendLine($"   AND id_usuario = {filtro.CodigoUsuario}");

            return sqlPesquisa.ToString();
        }
        #endregion

        #region [Construtor]
        public GanhoRepository(IBaseRepository baseRepository) => _baseRepository = baseRepository;
        #endregion

        #region [Métodos Públicos]
        public async Task<int> TotalRegistros(filtroGanho filtro)
        {
            var sqlPesquisa = new StringBuilder();

            sqlPesquisa.AppendLine($"SELECT COUNT(ID) as Total");
            sqlPesquisa.AppendLine($"  FROM ganho");
            sqlPesquisa.AppendLine(ObterFiltros(filtro));

            return await _baseRepository.BuscarPorQueryAsync<int>(sqlPesquisa.ToString());
        }
        public async Task<Ganho> ObterPorCodigo(int codigo) => await _baseRepository.BuscarPorIdAsync<Ganho>(codigo);
        public Task<IEnumerable<Ganho>> ObterTodos(filtroGanho filtroGanho)
        {
            throw new NotImplementedException();
        }
        public async Task<bool> ObterEntidade(Ganho ganho)
        {
            var sqlPesquisa = new StringBuilder();

            sqlPesquisa.AppendLine($" (descricao = '{ganho.Descricao}')");

            return await _baseRepository.BuscarPorQueryGeradorAsync<Ganho>(sqlPesquisa.ToString()) is not null;
        }
        public async Task<bool> Inserir(Ganho ganho) => await _baseRepository.AdicionarAsync(ganho) > 0;
        public async Task<bool> Atualizar(Ganho ganho) => await _baseRepository.AtualizarAsync(ganho.Codigo, ganho) > 0;

        #endregion
    }
}
