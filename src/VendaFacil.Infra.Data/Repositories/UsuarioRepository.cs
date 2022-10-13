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

        #region [Construtor]
        public UsuarioRepository(IBaseRepository baseRepository) => _baseRepository = baseRepository;
        #endregion

        #region [Métodos Públicos]
        public async Task<IEnumerable<Usuario>> ObterTodos(filtroUsuario filtro)
        {
            var sqlPesquisa = new StringBuilder();

            sqlPesquisa.AppendLine($"DO $$");
            sqlPesquisa.AppendLine($"	DECLARE PaginaAtual integer;");
            sqlPesquisa.AppendLine($"	DECLARE QuantidadePorPagina integer;");
            sqlPesquisa.AppendLine($"BEGIN");
            sqlPesquisa.AppendLine($"");
            sqlPesquisa.AppendLine($"	PaginaAtual := {filtro.PaginaAtual};");
            sqlPesquisa.AppendLine($"	QuantidadePorPagina := {filtro.QuantidadePorPagina};");
            sqlPesquisa.AppendLine($"	");
            sqlPesquisa.AppendLine($"	DROP TABLE IF EXISTS TMP_TABLE;");
            sqlPesquisa.AppendLine($"");
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
            sqlPesquisa.AppendLine($"	 LIMIT QuantidadePorPagina");
            sqlPesquisa.AppendLine($"	OFFSET(PaginaAtual - 1) * 10;");
            sqlPesquisa.AppendLine($"END $$;");
            sqlPesquisa.AppendLine($"");
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

        #endregion
    }
}
