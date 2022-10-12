using Dapper;
using System.Data;
using System.Text;
using VendaFacil.Domain.Entities.Base;
using VendaFacil.Infra.Data.Context;
using VendaFacil.Infra.Data.Enumerables;

namespace VendaFacil.Infra.Database
{
    public static class DatabaseConfiguration
    {
        #region [Propriedades Privadas]
        private static ParametrosConexao _parametrosConexao;
        #endregion

        #region Métodos Privados
        private static ParametrosConexao ObterParametrosConexao(bool RemoverNomeBanco = false) => new()
        {
            Servidor = Environment.GetEnvironmentVariable("SERVIDOR"),
            NomeBanco = RemoverNomeBanco ? "" : Environment.GetEnvironmentVariable("BANCO").ToLower(),
            Porta = Environment.GetEnvironmentVariable("PORTA"),
            Usuario = Environment.GetEnvironmentVariable("USUARIO"),
            Senha = Environment.GetEnvironmentVariable("SENHA"),
            TipoBanco = Convert.ToInt32(Environment.GetEnvironmentVariable("TIPO_BANCO"))
        };
        private static string ObterProcedureDropConstraint(string nomeBanco)
        {
            var sqlPessquisa = new StringBuilder();

            switch ((ETipoBanco)_parametrosConexao.TipoBanco)
            {
                case ETipoBanco.MySql:
                    sqlPessquisa.AppendLine($"USE {nomeBanco};");
                    sqlPessquisa.AppendLine($"DROP PROCEDURE IF EXISTS PROC_DROP_FOREIGN_KEY;");
                    sqlPessquisa.AppendLine($"CREATE PROCEDURE PROC_DROP_FOREIGN_KEY(IN tableName VARCHAR(64), IN constraintName VARCHAR(64))");
                    sqlPessquisa.AppendLine($"BEGIN");
                    sqlPessquisa.AppendLine($"    IF EXISTS(");
                    sqlPessquisa.AppendLine($"        SELECT * FROM information_schema.table_constraints");
                    sqlPessquisa.AppendLine($"        WHERE ");
                    sqlPessquisa.AppendLine($"            table_schema    = DATABASE()     AND");
                    sqlPessquisa.AppendLine($"            table_name      = tableName      AND");
                    sqlPessquisa.AppendLine($"            constraint_name = constraintName AND");
                    sqlPessquisa.AppendLine($"            constraint_type = 'FOREIGN KEY')");
                    sqlPessquisa.AppendLine($"    THEN");
                    sqlPessquisa.AppendLine($"        SET @query = CONCAT('ALTER TABLE ', tableName, ' DROP FOREIGN KEY ', constraintName, ';');");
                    sqlPessquisa.AppendLine($"        PREPARE stmt FROM @query; ");
                    sqlPessquisa.AppendLine($"        EXECUTE stmt; ");
                    sqlPessquisa.AppendLine($"        DEALLOCATE PREPARE stmt; ");
                    sqlPessquisa.AppendLine($"    END IF; ");
                    sqlPessquisa.AppendLine($"END");
                    break;
                case ETipoBanco.SqlServer:
                    sqlPessquisa.AppendLine($"");
                    break;
                case ETipoBanco.Firebird:
                    sqlPessquisa.AppendLine($"");
                    break;
                case ETipoBanco.Postgresql:
                    sqlPessquisa.AppendLine($"");
                    break;
                case ETipoBanco.SqLite:
                    sqlPessquisa.AppendLine($"");
                    break;
                default:
                    break;
            }
            return sqlPessquisa.ToString();
        }
        private static string ObterSqlCriarBanco()
        {
            var parametro = ObterParametrosConexao();

            var sqlPesquisa = new StringBuilder();

            switch ((ETipoBanco)_parametrosConexao.TipoBanco)
            {
                case ETipoBanco.MySql:
                    sqlPesquisa.AppendLine($"CREATE DATABASE {parametro.NomeBanco}");
                    sqlPesquisa.AppendLine($"CHARACTER SET utf8");
                    sqlPesquisa.AppendLine($"COLLATE utf8_general_ci;");
                    break;
                case ETipoBanco.SqlServer:
                    sqlPesquisa.AppendLine($"CREATE DATABASE {parametro.NomeBanco};");
                    break;
                case ETipoBanco.Firebird:
                    break;
                case ETipoBanco.Postgresql:
                    sqlPesquisa.AppendLine($"CREATE DATABASE {parametro.NomeBanco};");
                    break;
                case ETipoBanco.SqLite:
                    var caminho = Path.Combine(Directory.GetCurrentDirectory(), parametro.NomeBanco??"");
                    if (!File.Exists(caminho))
                        File.Create(caminho).Close();
                    sqlPesquisa.AppendLine($"");
                    break;
                default:
                    break;
            }
            return sqlPesquisa.ToString();
        }
        private static bool ExisteBanco()
        {
            _parametrosConexao = ObterParametrosConexao();

            var sqlPesquisa = new StringBuilder();

            switch ((ETipoBanco)_parametrosConexao.TipoBanco)
            {
                case ETipoBanco.MySql:
                    sqlPesquisa.AppendLine($"SHOW DATABASES LIKE '{_parametrosConexao.NomeBanco}';");
                    break;
                case ETipoBanco.SqlServer:
                    sqlPesquisa.AppendLine($"SELECT NAME");
                    sqlPesquisa.AppendLine($"  FROM MASTER.DBO.SYSDATABASES");
                    sqlPesquisa.AppendLine($"WHERE NAME = N'{_parametrosConexao.NomeBanco}'");
                    break;
                case ETipoBanco.Firebird:
                    break;
                case ETipoBanco.Postgresql:
                    sqlPesquisa.AppendLine($"SELECT DATNAME");
                    sqlPesquisa.AppendLine($"  FROM PG_DATABASE");
                    sqlPesquisa.AppendLine($" WHERE DATISTEMPLATE = false");
                    sqlPesquisa.AppendLine($"   AND lower(DATNAME) = lower('{_parametrosConexao.NomeBanco}');");

                    break;
                case ETipoBanco.SqLite:
                    var caminho = Path.Combine(Directory.GetCurrentDirectory(), _parametrosConexao.NomeBanco);
                    if (!File.Exists(caminho))
                        sqlPesquisa.AppendLine($"");
                    else
                        sqlPesquisa.AppendLine($"SELECT 1;");
                    break;
                default:
                    break;
            }

            using var conexao = ConnectionConfiguration.AbrirConexao(ObterParametrosConexao(true));
            return conexao.Query<string>(sqlPesquisa.ToString()).ToList().Count > 0;
        }
        private static void Criar(ParametrosConexao parametrosConexao, string sqlCondicao)
        {
            using var conexao = ConnectionConfiguration.AbrirConexao(parametrosConexao);
            conexao.Execute(sqlCondicao);
        }
        private static bool ExisteDados<T>() where T : class
        {
            using var conexao = ConnectionConfiguration.AbrirConexao(ObterParametrosConexao());
            return conexao.QueryFirstOrDefault<int>($"SELECT COUNT(*) AS Total FROM {GeradorDapper.ObterNomeTabela<T>()};") > 0;
        }
        private static void CriaBaseDados()
        {
            Criar(ObterParametrosConexao(), ObterProcedureDropConstraint(_parametrosConexao.NomeBanco));
            Criar(ObterParametrosConexao(), GeradorDapper.CriaTabela<Usuario>(ObterParametrosConexao()));
        }
        private static void InsereDadosPadroes()
        {
            if (!ExisteDados<Usuario>())
                Criar(ObterParametrosConexao(), GeradorDapper.InserirDadosPadroes<Usuario>());
        }
        private static bool ServidorAtivo()
        {
            using var conexao = ConnectionConfiguration.AbrirConexao(ObterParametrosConexao(true));
            return conexao.State == ConnectionState.Open;
        }
        private static void ExecutarScripts()
        {
            using var conexao = ConnectionConfiguration.AbrirConexao(_parametrosConexao);

            foreach (var script in Directory.GetFiles(Path.Combine(Directory.GetCurrentDirectory(), "scripts"), "*.sql"))
            {
                foreach (var item in new StreamReader(script).ReadToEnd().Split("GO"))
                {
                    if (!string.IsNullOrWhiteSpace(item))
                    {
                        var linha = item.Split("|");
                        if (linha.Length > 0)
                            if (!conexao.QueryFirstOrDefault<bool>(linha[0]))
                                conexao.Query<string>(linha[1]);
                    }
                }
            }
        }
        #endregion

        #region Métodos Públicos
        public static void GerenciarBanco()
        {
            _parametrosConexao = ObterParametrosConexao();

            try
            {
                if (ServidorAtivo())
                {
                    if (!ExisteBanco())
                        Criar(ObterParametrosConexao(true), ObterSqlCriarBanco());

                    //Criar tabelas
                    CriaBaseDados();

                    //Adicionar registros base
                    InsereDadosPadroes();
                }
                else
                {
                    throw new Exception("Base de dados Offline.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
    }
}
