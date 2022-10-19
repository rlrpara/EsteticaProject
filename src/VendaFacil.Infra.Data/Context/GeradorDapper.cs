using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using System.Text;
using VendaFacil.Domain.Entities.Base;
using VendaFacil.Infra.Data.Enumerables;
using VendaFacil.Infra.Data.Interface;

namespace VendaFacil.Infra.Data.Context
{
    public class GeradorDapper : IGeradorDapper
    {
        #region [Propriedades Privadas]
        private  ParametrosConexao _parametrosConexao;
        #endregion

        #region [Construtor]
        public GeradorDapper(ParametrosConexao parametrosConexao) => _parametrosConexao = parametrosConexao;
        #endregion

        #region Métodos Privados
        private Nota? ObterAtributoNota(PropertyInfo x) => x.GetCustomAttribute(typeof(Nota)) as Nota;
        private IOrderedEnumerable<PropertyInfo> ObterListaPropriedadesClasse<T>(T entidade = null) where T : class
        {
            if (entidade is null)
                return typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance).OrderBy(p => ((ColumnAttribute)p.GetCustomAttributes(typeof(ColumnAttribute)).FirstOrDefault())?.Order);
            else
                return entidade.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance).OrderBy(p => ((ColumnAttribute)p.GetCustomAttributes(typeof(ColumnAttribute)).FirstOrDefault())?.Order);
        }
        private string? TipoPropriedade(PropertyInfo item, Nota nota)
            => item.PropertyType.Name.ToLower() switch
        {
            "int32" => ObterParaInteiro(nota),
            "int64" => "bigint DEFAULT NULL",
            "double" => "decimal(18,2)",
            "single" => "float",
            "guid" => "integer DEFAULT NULL",
            "datetime" => ObterParaData(),
            "boolean" => ObtemParaBoleando(),
            "nullable`1" => ObtemParaTipoNulo(item.PropertyType.FullName, nota),
            _ => $"varchar({nota.Tamanho}) default null",
        };
        private string? ObterParaData() => (ETipoBanco)_parametrosConexao.TipoBanco switch
        {
            ETipoBanco.Postgresql => "timestamp DEFAULT CURRENT_TIMESTAMP",
            _ => "datetime DEFAULT CURRENT_TIMESTAMP"
        };
        private string? ObterParaInteiro(Nota nota) => (ETipoBanco)_parametrosConexao.TipoBanco switch
        {
            ETipoBanco.SqlServer => "int(11) DEFAULT NULL",
            ETipoBanco.MySql => "int(11) DEFAULT NULL",
            ETipoBanco.Firebird => "int(11) DEFAULT NULL",
            ETipoBanco.Postgresql => "integer DEFAULT NULL",
            ETipoBanco.SqLite => "integer DEFAULT NULL",
            ETipoBanco.SqlAnywhere => "int(11) DEFAULT NULL",
            _ => "int(11) DEFAULT NULL",
        };
        private string? ObtemParaBoleando() => (ETipoBanco)_parametrosConexao.TipoBanco switch
        {
            ETipoBanco.SqlServer => "tinyint(1) NOT NULL DEFAULT 1",
            ETipoBanco.MySql => "tinyint(1) NOT NULL DEFAULT 1",
            ETipoBanco.Firebird => "bit NOT NULL DEFAULT 1",
            ETipoBanco.Postgresql => "bool NOT NULL DEFAULT true",
            ETipoBanco.SqLite => "INTEGER NOT NULL DEFAULT 1",
            ETipoBanco.SqlAnywhere => "tinyint(1) NOT NULL DEFAULT 1",
            _ => "tinyint(1) NOT NULL DEFAULT 1",
        };
        private string? ObtemParaTipoNulo(string? fullName, Nota nota)
        {
            if (fullName.ToLower().Contains("int32"))
                return ObterParaInteiro(nota);
            else if (fullName.ToLower().Contains("datetime"))
                return ObterParaData();
            else
                return (ETipoBanco)_parametrosConexao.TipoBanco switch
                {
                    ETipoBanco.SqLite => "TEXT NULL",
                    _ => $"varchar({nota.Tamanho}) NULL",
                };
        }
        private string FormataValor<T>(PropertyInfo x, T entidade) where T : class
        {
            var propriedade = x.PropertyType.Name.ToLower();

            if (propriedade.Contains("string"))
                return $"'{x.GetValue(entidade)}'";
            else if (propriedade.Contains("datetime"))
                return $"'{Convert.ToDateTime(x.GetValue(entidade)):yyyy-MM-dd HH:mm:ss}'";
            else if (propriedade.Contains("nullable`1"))
                if (propriedade.Contains("datetime"))
                    return $"'{Convert.ToDateTime(x.GetValue(entidade)):yyyy-MM-dd HH:mm:ss}'";
                else if (propriedade.Contains("string"))
                    return $"'{x.GetValue(entidade)}'";
                else
                    return $"{x.GetValue(entidade)}";
            else
                return $"{x.GetValue(entidade)}";
        }
        private string ObterValorInsert<T>(T entidade) where T : class
            => string.Join($", ", ObterListaPropriedadesClasse(entidade)
                    .Where(x => ObterAtributoNota(x)?.UsarParaBuscar??false && !string.IsNullOrWhiteSpace(x.GetCustomAttribute<ColumnAttribute>().Name))
                    .Select(x => $"{FormataValor(x, entidade)}")
                    .ToList());
        private string ObterColunasInsert<T>() where T : class
            => string.Join($", ", ObterListaPropriedadesClasse<T>()
                    .Where(x => ObterAtributoNota(x).UsarParaBuscar && !ObterAtributoNota(x).ChavePrimaria && x.GetCustomAttributes().FirstOrDefault() is not KeyAttribute)
                    .Select(x => $"{x.GetCustomAttribute<ColumnAttribute>()?.Name}")
                    .ToList());
        private string ObterUseNomeBanco()
            => _parametrosConexao.TipoBanco.Equals(ETipoBanco.MySql) ? $"USE {_parametrosConexao.NomeBanco};" : "";
        #endregion

        #region Métodos Públicos
        public string? ObterChavePrimaria<T>() where T : class => ObterListaPropriedadesClasse<T>()
            .Where(x => ObterAtributoNota(x) is not null && (ObterAtributoNota(x).ChavePrimaria || x.GetCustomAttributes().FirstOrDefault() is KeyAttribute))
            .Select(x => x.GetCustomAttribute<ColumnAttribute>()?.Name ?? "")
            .FirstOrDefault();
        public string? ObterNomeTabela<T>() where T : class
        {
            dynamic nomeTabela = typeof(T).GetCustomAttributes(false).SingleOrDefault(attr => attr.GetType().Name == "TableAttribute");

            return nomeTabela?.Name;
        }
        public string ObterColunasSelect<T>(bool paraGrid = false, T? entidade = null, bool quebraLinha = true) where T : class
        {
            if (!paraGrid && entidade is null)
                return string.Join($", {(quebraLinha ? Environment.NewLine : "")}       ", ObterListaPropriedadesClasse<T>()
                    .Where(x => ObterAtributoNota(x)?.UsarParaBuscar ?? false && (x.GetCustomAttribute(typeof(Nota)) is not null))
                    .Select(x => $"{x.GetCustomAttribute<ColumnAttribute>()?.Name?.Trim()} AS {x.Name}")
                    .ToList());
            else
                return string.Join($", {Environment.NewLine}       ", ObterListaPropriedadesClasse(entidade)
                    .Where(x => ObterAtributoNota(x)?.UsarParaBuscar ?? false && !string.IsNullOrWhiteSpace(x.GetCustomAttribute<ColumnAttribute>().Name))
                    .Select(x => $"{x.GetCustomAttribute<ColumnAttribute>()?.Name?.Trim()} = {FormataValor(x, entidade)}")
                    .ToList());
        }
        public string? RetornaCamposSelect<T>() where T : class
            => string.Join($", {Environment.NewLine}       ",ObterListaPropriedadesClasse<T>()
                .Where(x => ObterAtributoNota(x)?.UsarParaBuscar ?? false && ObterAtributoNota(x) is not null)
                .Select(x => $"{x.GetCustomAttribute<ColumnAttribute>()?.Name?.Trim()??""} AS {x.Name}")
                .ToList())?.Trim();
        public string? ObterDelete<T>(int id) where T : class
        {
            var sqlDelete = new StringBuilder();

            sqlDelete.AppendLine(ObterUseNomeBanco());
            sqlDelete.AppendLine($"DELETE FROM {ObterNomeTabela<T>()}");
            sqlDelete.AppendLine($" WHERE {ObterChavePrimaria<T>()} = {id}");

            return sqlDelete?.ToString()?.Trim();
        }
        public string? CriaTabela<T>() where T : class
        {
            string chavePrimaria = string.Empty;
            List<string> campos = new();
            StringBuilder sqlConstraint = new();
            StringBuilder sqlIndice = new();

            foreach (PropertyInfo item in typeof(T).GetProperties(BindingFlags.GetProperty | BindingFlags.Instance | BindingFlags.Public))
            {
                var nota = ObterAtributoNota(item);

                if (nota is not null && nota.UsarParaBuscar)
                {
                    var nomeCampo = item.GetCustomAttribute<ColumnAttribute>()?.Name;

                    if (nota.UsarNoBancoDeDados)
                    {
                        if (nota.ChavePrimaria || item.GetCustomAttributes().FirstOrDefault() is KeyAttribute)
                            chavePrimaria = $"{nomeCampo}";

                        else if (nomeCampo != "")
                            campos.Add($"{nomeCampo} {TipoPropriedade(item, nota)}");
                    }

                    if (!string.IsNullOrEmpty(nota.ChaveEstrangeira))
                    {
                        string tabelaChaveEstrangeira = $"{nota.ChaveEstrangeira.ToLower()}";
                        string campoChaveEstrangeira = $"{nomeCampo}";
                        string nomeChave = $"FK_{ObterNomeTabela<T>()}_{campoChaveEstrangeira}".ToUpper();
                        switch ((ETipoBanco)_parametrosConexao.TipoBanco)
                        {
                            case ETipoBanco.MySql:
                                sqlConstraint.AppendLine($"CALL PROC_DROP_FOREIGN_KEY('{ObterNomeTabela<T>()}', '{nomeChave}');");
                                sqlConstraint.AppendLine($"ALTER TABLE {_parametrosConexao.NomeBanco}.{ObterNomeTabela<T>()}");
                                sqlConstraint.AppendLine($"ADD CONSTRAINT {nomeChave} FOREIGN KEY ({campoChaveEstrangeira})");
                                sqlConstraint.AppendLine($"REFERENCES {_parametrosConexao.NomeBanco}.{tabelaChaveEstrangeira} (ID) ON DELETE NO ACTION ON UPDATE NO ACTION;{Environment.NewLine}");
                                break;

                            case ETipoBanco.SqlServer:
                                sqlConstraint.AppendLine($"");
                                break;

                            case ETipoBanco.Firebird:
                                sqlConstraint.AppendLine($"");
                                break;

                            case ETipoBanco.Postgresql:
                                sqlConstraint.AppendLine($"ALTER TABLE {ObterNomeTabela<T>()}");
                                sqlConstraint.AppendLine($"ADD CONSTRAINT {nomeChave} FOREIGN KEY ({campoChaveEstrangeira})");
                                sqlConstraint.AppendLine($"REFERENCES {_parametrosConexao.NomeBanco}.{tabelaChaveEstrangeira} (ID) ON DELETE NO ACTION ON UPDATE NO ACTION;{Environment.NewLine}");
                                break;

                            case ETipoBanco.SqLite:
                                sqlConstraint.AppendLine($"");
                                break;

                            default:
                                sqlConstraint.AppendLine($"");
                                break;
                        }
                    }

                    if (nota.Indice)
                        sqlIndice.AppendLine($"CREATE INDEX IF NOT EXISTS {ObterNomeTabela<T>().ToLower()}_{nomeCampo.ToLower()}_idx ON {ObterNomeTabela<T>()} ({nomeCampo.ToLower()});");
                }
            }

            var sqlPesquisa = new StringBuilder();

            switch ((ETipoBanco)_parametrosConexao.TipoBanco)
            {
                case ETipoBanco.MySql:
                    sqlPesquisa.AppendLine($"USE {_parametrosConexao.NomeBanco};");
                    sqlPesquisa.AppendLine($"CREATE TABLE IF NOT EXISTS {_parametrosConexao.NomeBanco}.{ObterNomeTabela<T>()} (");
                    sqlPesquisa.AppendLine($"  {ObterChavePrimaria<T>()} int(11) NOT NULL AUTO_INCREMENT,");
                    sqlPesquisa.AppendLine($"  {string.Join($",{Environment.NewLine}   ", campos.ToArray())},");
                    sqlPesquisa.AppendLine($"  PRIMARY KEY ({ObterChavePrimaria<T>()})");
                    sqlPesquisa.AppendLine($")");
                    sqlPesquisa.AppendLine($"ENGINE = INNODB,");
                    sqlPesquisa.AppendLine($"CHARACTER SET utf8,");
                    sqlPesquisa.AppendLine($"COLLATE utf8_general_ci;{Environment.NewLine}");
                    if (!string.IsNullOrEmpty(sqlConstraint.ToString()))
                        sqlPesquisa.AppendLine(sqlConstraint.ToString());
                    break;

                case ETipoBanco.SqlServer:
                    sqlPesquisa.AppendLine($"USE {_parametrosConexao.NomeBanco};");
                    sqlPesquisa.AppendLine($"IF NOT EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = '{ObterNomeTabela<T>()}')");
                    sqlPesquisa.AppendLine($"BEGIN");
                    sqlPesquisa.AppendLine($"   CREATE TABLE {ObterNomeTabela<T>()}(");
                    sqlPesquisa.AppendLine($"        {ObterChavePrimaria<T>()} int IDENTITY(1,1) NOT NULL,");
                    sqlPesquisa.AppendLine($"        {string.Join($",{Environment.NewLine}   ", campos.ToArray())},");
                    sqlPesquisa.AppendLine($"  CONSTRAINT [PK_{ObterNomeTabela<T>()}] PRIMARY KEY CLUSTERED ");
                    sqlPesquisa.AppendLine($"(");
                    sqlPesquisa.AppendLine($"   {ObterChavePrimaria<T>()} ASC");
                    sqlPesquisa.AppendLine($")WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]");
                    sqlPesquisa.AppendLine($") ON [PRIMARY]");
                    sqlPesquisa.AppendLine($"END");
                    break;

                case ETipoBanco.Firebird:
                    sqlPesquisa.AppendLine($"");
                    break;

                case ETipoBanco.Postgresql:
                    sqlPesquisa.AppendLine($"CREATE TABLE IF NOT EXISTS {ObterNomeTabela<T>()} (");
                    sqlPesquisa.AppendLine($"  {ObterChavePrimaria<T>()} int NOT NULL GENERATED ALWAYS AS IDENTITY,");
                    sqlPesquisa.AppendLine($"  {string.Join($",{Environment.NewLine}   ", campos.ToArray())},");
                    sqlPesquisa.AppendLine($"  PRIMARY KEY ({ObterChavePrimaria<T>()})");
                    sqlPesquisa.AppendLine($");");
                    sqlPesquisa.AppendLine(sqlIndice.ToString());
                    break;

                case ETipoBanco.SqLite:
                    sqlPesquisa.AppendLine($"CREATE TABLE IF NOT EXISTS {ObterNomeTabela<T>()} (");
                    sqlPesquisa.AppendLine($"  {ObterChavePrimaria<T>()} INTEGER PRIMARY KEY AUTOINCREMENT,");
                    sqlPesquisa.AppendLine($"  {string.Join($",{Environment.NewLine}   ", campos.ToArray())}");
                    sqlPesquisa.AppendLine($")");
                    break;

                default:
                    sqlPesquisa.AppendLine($"");
                    break;
            }

            return sqlPesquisa.ToString().Trim();
        }
        public string? GeralSqlSelecaoControles<T>(string? sqlWhere) where T : class
        {
            var sqlPesquisa = new StringBuilder();

            sqlPesquisa.AppendLine($"SELECT {ObterColunasSelect<T>()}");
            sqlPesquisa.AppendLine($"  FROM {ObterNomeTabela<T>()}");
            sqlPesquisa.AppendLine($"{(string.IsNullOrWhiteSpace(sqlWhere?.Trim()) ? string.Empty : $"WHERE {sqlWhere}")}");

            return sqlPesquisa?.ToString()?.Trim();
        }
        public string? GeralSqlUpdateControles<T>(int id, T entidade) where T : class
        {
            var sqlPesquisa = new StringBuilder();

            sqlPesquisa.AppendLine(ObterUseNomeBanco());
            sqlPesquisa.AppendLine($"UPDATE {ObterNomeTabela<T>()}");
            sqlPesquisa.AppendLine($"   SET {string.Join($",{Environment.NewLine}       ", ObterColunasSelect(true, entidade))}");
            sqlPesquisa.AppendLine($" WHERE {ObterChavePrimaria<T>()} = {id}");

            return sqlPesquisa?.ToString()?.Trim();
        }
        public string? GeralSqlInsertControles<T>(T entidade) where T : class
        {
            var sqlPesquisa = new StringBuilder();

            sqlPesquisa.AppendLine(ObterUseNomeBanco());
            sqlPesquisa.AppendLine($"INSERT INTO {ObterNomeTabela<T>()} ({ObterColunasInsert<T>()})");
            sqlPesquisa.AppendLine($"                     VALUES ({string.Join($", ", ObterValorInsert(entidade))})");

            return sqlPesquisa?.ToString()?.Trim();
        }
        public string? InserirDadosPadroes<T>() where T : class
        {
            var sqlPesquisa = new StringBuilder();

            switch (typeof(T).Name.ToLower())
            {
                case "usuario":
                    sqlPesquisa.AppendLine($"INSERT INTO usuario (                nome,             email,           senha, senha_criptografada,           cpf, id_empresa,     data_cadastro,  data_atualizacao, foto, ativo, id_nivel)");
                    sqlPesquisa.AppendLine($"             VALUES ('Administrador SAAS', 'admin@email.com', 'Postgres2022!',     'Postgres2022!', '00000000000',          0, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP,   '',  true,       92);");
                    return sqlPesquisa.ToString();
                default:
                    return "";
            }
        }

        #endregion
    }
}
