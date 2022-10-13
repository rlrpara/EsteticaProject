using System.Text;
using VendaFacil.Domain.Entities.Base;
using VendaFacil.Domain.Entities.Filtros;
using VendaFacil.Domain.Interface;

namespace VendaFacil.Infra.Data.Repositories
{
    public class UsuarioRepository : BaseRepository, IUsuarioRepository
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
        public UsuarioRepository(IBaseRepository baseRepository) => _baseRepository = baseRepository;
        #endregion

        #region [Métodos Públicos]
        public async Task<IEnumerable<Usuario>> ObterTodos(filtroUsuario filtro)
        {
            var sqlPesquisa = new StringBuilder();

            sqlPesquisa.AppendLine($"DO $$");
            sqlPesquisa.AppendLine($"DECLARE QtdPorPagina INTEGER;");
            sqlPesquisa.AppendLine($"        Pagina       INTEGER;");
            sqlPesquisa.AppendLine($"BEGIN");
            sqlPesquisa.AppendLine($"    SELECT {filtro.QuantidadePorPagina} INTO QtdPorPagina;");
            sqlPesquisa.AppendLine($"    SELECT {filtro.PaginaAtual} INTO Pagina;");
            sqlPesquisa.AppendLine($"	  DROP TABLE IF EXISTS TMP_TABLE;");
            sqlPesquisa.AppendLine($"	CREATE TEMP TABLE tmp_table AS");
            sqlPesquisa.AppendLine($"	SELECT id as Codigo,");
            sqlPesquisa.AppendLine($"	       nome as Nome,");
            sqlPesquisa.AppendLine($"	       email as Email,");
            sqlPesquisa.AppendLine($"	       senha as Senha,");
            sqlPesquisa.AppendLine($"	       senha_criptografada as SenhaCriptografada,");
            sqlPesquisa.AppendLine($"	       telefone as Telefone,");
            sqlPesquisa.AppendLine($"	       celular as Celular,");
            sqlPesquisa.AppendLine($"	       cpf as Cpf,");
            sqlPesquisa.AppendLine($"	       endereco as Endereco,");
            sqlPesquisa.AppendLine($"	       foto as Foto,");
            sqlPesquisa.AppendLine($"	       id_empresa as CodigoEmpresa,");
            sqlPesquisa.AppendLine($"	       id_nivel as CodigoNivel,");
            sqlPesquisa.AppendLine($"	       data_cadastro as DataCadastro,");
            sqlPesquisa.AppendLine($"	       data_atualizacao as DataAtualizacao,");
            sqlPesquisa.AppendLine($"	       ativo as Ativo");
            sqlPesquisa.AppendLine($"	  FROM usuario");
            sqlPesquisa.AppendLine(ObterFiltros(filtro));
            sqlPesquisa.AppendLine($"     LIMIT QtdPorPagina");
            sqlPesquisa.AppendLine($"    OFFSET (Pagina - 1) * QtdPorPagina;");
            sqlPesquisa.AppendLine($"END $$;");
            sqlPesquisa.AppendLine($"SELECT * FROM tmp_table;");

            return await _baseRepository.BuscarTodosPorQueryAsync<Usuario>(sqlPesquisa.ToString().Trim());
        }
        public async Task<bool> Inserir(Usuario usuario) => await _baseRepository.AdicionarAsync(usuario) > 0;
        public async Task<bool> JaCadastrado(Usuario usuario)
        {
            var sqlPesquisa = new StringBuilder();

            sqlPesquisa.AppendLine($"SELECT id as Codigo,");
            sqlPesquisa.AppendLine($"       nome as Nome,");
            sqlPesquisa.AppendLine($"       email as Email");
            sqlPesquisa.AppendLine($"  FROM usuario");
            sqlPesquisa.AppendLine($" WHERE (nome = '{usuario.Nome}' OR cpf = '{usuario.Cpf}' OR email = '{usuario.Email}')");
            sqlPesquisa.AppendLine($"   AND id_empresa = {usuario.CodigoEmpresa}");

            return await _baseRepository.BuscarPorQueryAsync<Usuario>(sqlPesquisa.ToString()) is not null;
        }
        public async Task<int> TotalRegistros(filtroUsuario filtro)
        {
            var sqlPesquisa = new StringBuilder();

            sqlPesquisa.AppendLine($"SELECT COUNT(ID) as Total");
            sqlPesquisa.AppendLine($"  FROM usuario");
            sqlPesquisa.AppendLine(ObterFiltros(filtro));

            return await _baseRepository.BuscarPorQueryAsync<int>(sqlPesquisa.ToString());
        }

        #endregion
    }
}
