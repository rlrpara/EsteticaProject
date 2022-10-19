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
        private IOrderedEnumerable<PropertyInfo> ObterListaPropriedadesClasse<T>() where T : class => typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance).OrderBy(p => (p.GetCustomAttributes(typeof(ColumnAttribute)).FirstOrDefault() as ColumnAttribute)?.Order);
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
        public string? RetornaCamposSelect<T>() where T : class
            => string.Join($", {Environment.NewLine}       ",ObterListaPropriedadesClasse<T>()
                .Where(x => ObterAtributoNota(x)?.UsarParaBuscar ?? false && ObterAtributoNota(x) is not null)
                .Select(x => $"{x.GetCustomAttribute<ColumnAttribute>()?.Name?.Trim()??""} AS {x.Name}")
                .ToList())?.Trim();
        public string? ObterInsert<T>(T entidade) where T : class
        {
            List<string> campos = new();
            List<string> valores = new();

            foreach (PropertyInfo item in ObterListaPropriedadesClasse<T>())
            {
                var tipoCampo = item.PropertyType;
                Nota? notaBase = item.GetCustomAttribute(typeof(Nota)) as Nota;

                if (notaBase is not null && notaBase.UsarNoBancoDeDados && (!notaBase.ChavePrimaria || item.GetCustomAttributes().FirstOrDefault() is not KeyAttribute))
                {
                    var valor = item.GetValue(entidade);

                    if (valor is not null && !notaBase.ChavePrimaria && item.GetCustomAttributes().FirstOrDefault() is not KeyAttribute)
                    {
                        campos.Add(item.GetCustomAttribute<ColumnAttribute>().Name);

                        if (tipoCampo.Name.ToLower().Contains("string"))
                            valores.Add($"'{valor?.ToString().Replace("'", "`")}'");

                        else if (tipoCampo.Name.ToLower().Contains("datetime"))
                            valores.Add($"'{Convert.ToDateTime(valor):yyyy-MM-dd HH:mm:ss}'");

                        else if (tipoCampo.Name.ToLower().Contains("nullable`1"))
                            if (tipoCampo.ToString().Contains("datetime"))
                                valores.Add($"'{Convert.ToDateTime(valor):yyyy-MM-dd HH:mm:ss}'");

                            else if (tipoCampo.Name.ToLower().Contains("int32"))
                                valores.Add($"{valor}");

                            else
                                valores.Add($"'{valor}'");

                        else
                            valores.Add($"{valor}");
                    }
                }
            }

            var sqlInsert = new StringBuilder();

            sqlInsert.AppendLine($"INSERT INTO {ObterNomeTabela<T>()} ({string.Join(", ", campos.ToArray())})");
            sqlInsert.AppendLine($"            VALUES ({string.Join(", ", valores.ToArray())});");

            return sqlInsert.ToString();
        }
        public string? RetornaUpdate<T>(int id, T entidade) where T : class
        {
            string campoChave = string.Empty;
            List<string> condicao = new();

            foreach (PropertyInfo item in entidade.GetType().GetProperties(BindingFlags.GetProperty | BindingFlags.Instance | BindingFlags.Public).OrderBy(p => ((ColumnAttribute)p.GetCustomAttributes(typeof(ColumnAttribute)).FirstOrDefault())?.Order))
            {
                Nota notaBase = (Nota)item.GetCustomAttribute(typeof(Nota));

                if (notaBase is not null && notaBase.UsarNoBancoDeDados && (!notaBase.ChavePrimaria || item.GetCustomAttributes().FirstOrDefault() is not KeyAttribute))
                {
                    var valor = item.GetValue(entidade);
                    var campo = item.GetCustomAttribute<ColumnAttribute>().Name;
                    var tipoCampo = item.PropertyType.Name.ToLower();

                    if (notaBase.ChavePrimaria || item.GetCustomAttributes().FirstOrDefault() is KeyAttribute)
                        campoChave = item.GetCustomAttribute<ColumnAttribute>().Name;

                    if (!string.IsNullOrWhiteSpace(valor?.ToString()) && !notaBase.ChavePrimaria && item.GetCustomAttributes().FirstOrDefault() is not KeyAttribute && !campo.ToLower().Equals("data_cadastro"))
                    {
                        if (tipoCampo.Contains("string"))
                            condicao.Add($"{campo} = '{valor}'");

                        else if (tipoCampo.Contains("datetime"))
                            condicao.Add($"{campo} = '{Convert.ToDateTime(valor):yyyy-MM-dd HH:mm:ss}'");

                        else if (tipoCampo.Contains("nullable`1"))
                            if (tipoCampo.ToString().Contains("datetime"))
                                condicao.Add($"{campo} = '{Convert.ToDateTime(valor):yyyy-MM-dd HH:mm:ss}'");

                            else if (tipoCampo.ToString().Contains("int32"))
                                condicao.Add($"{campo} = {valor}");

                            else
                                condicao.Add($"{campo} = '{valor}'");
                        else
                            condicao.Add($"{campo} = {valor}");
                    }
                }
                else if (notaBase is not null && (notaBase.ChavePrimaria || item.GetCustomAttributes().FirstOrDefault() is KeyAttribute))
                    campoChave = item.GetCustomAttribute<ColumnAttribute>().Name;
            }

            var sqlAtualizar = new StringBuilder();

            sqlAtualizar.AppendLine($"UPDATE {ObterNomeTabela<T>()}");
            sqlAtualizar.AppendLine($"   SET {(string.Join($",{Environment.NewLine}       ", condicao.ToArray()))}");
            sqlAtualizar.AppendLine($" WHERE {campoChave} = {id}");

            return sqlAtualizar.ToString();
        }
        public string? RetornaDelete<T>(int id) where T : class
        {
            string campoChave = string.Empty;

            foreach (PropertyInfo item in typeof(T).GetProperties(BindingFlags.GetProperty | BindingFlags.Instance | BindingFlags.Public).OrderBy(p => ((ColumnAttribute)p.GetCustomAttributes(typeof(ColumnAttribute)).FirstOrDefault())?.Order))
            {
                Nota notaBase = (Nota)item.GetCustomAttribute(typeof(Nota));

                if (notaBase != null && notaBase.UsarNoBancoDeDados && notaBase.ChavePrimaria)
                    campoChave = item.GetCustomAttribute<ColumnAttribute>().Name;
            }

            var sqlDelete = new StringBuilder();

            sqlDelete.AppendLine($"USE {_parametrosConexao.NomeBanco};");
            sqlDelete.AppendLine($"DELETE FROM {ObterNomeTabela<T>()}");
            sqlDelete.AppendLine($" WHERE {campoChave} = {id}");

            return sqlDelete.ToString();
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

            sqlPesquisa.AppendLine($"SELECT {RetornaCamposSelect<T>()}");
            sqlPesquisa.AppendLine($"  FROM {ObterNomeTabela<T>()}");
            sqlPesquisa.AppendLine($"{(sqlWhere.Trim() == string.Empty ? string.Empty : $"WHERE {sqlWhere}")}");

            return sqlPesquisa.ToString();
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
