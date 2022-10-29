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
        private string ObterFiltros(filtroEmpresa filtro)
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
        public async Task<int> TotalRegistros(filtroEmpresa filtro)
        {
            var sqlPesquisa = new StringBuilder();

            sqlPesquisa.AppendLine($"SELECT COUNT(ID) as Total");
            sqlPesquisa.AppendLine($"  FROM empresa");
            sqlPesquisa.AppendLine(ObterFiltros(filtro));

            return await _baseRepository.BuscarPorQueryAsync<int>(sqlPesquisa.ToString());
        }
        public async Task<Empresa> ObterPorCodigo(int Codigo) => await _baseRepository.BuscarPorIdAsync<Empresa>(Codigo);
        public async Task<IEnumerable<Empresa>> ObterTodos(filtroEmpresa filtro)
        {
            var sqlPesquisa = new StringBuilder();

            sqlPesquisa.AppendLine($"DO $$");
            sqlPesquisa.AppendLine($"DECLARE QtdPorPagina INTEGER;");
            sqlPesquisa.AppendLine($"        Pagina       INTEGER;");
            sqlPesquisa.AppendLine($"BEGIN");
            sqlPesquisa.AppendLine($"    SELECT {filtro.QuantidadePorPagina} INTO QtdPorPagina;");
            sqlPesquisa.AppendLine($"    SELECT {filtro.PaginaAtual} INTO Pagina;");
            sqlPesquisa.AppendLine($"      DROP TABLE IF EXISTS TMP_TABLE;");
            sqlPesquisa.AppendLine($"    CREATE TEMP TABLE tmp_table AS");
            sqlPesquisa.AppendLine($"    SELECT id as Codigo,");
            sqlPesquisa.AppendLine($"           nome as Nome,");
            sqlPesquisa.AppendLine($"           cpf_cnpj as CpfCnpj,");
            sqlPesquisa.AppendLine($"           telefone as Telefone,");
            sqlPesquisa.AppendLine($"           email as Email,");
            sqlPesquisa.AppendLine($"           endereco as Endereco,");
            sqlPesquisa.AppendLine($"           valor_mensal as ValorMensal,");
            sqlPesquisa.AppendLine($"           data_pagamento as DataPagamento,");
            sqlPesquisa.AppendLine($"           data_cadastro as DataCadastro,");
            sqlPesquisa.AppendLine($"           data_atualizacao as DataAtualizacao,");
            sqlPesquisa.AppendLine($"           ativo as Ativo");
            sqlPesquisa.AppendLine($"      FROM empresa");
            sqlPesquisa.AppendLine(ObterFiltros(filtro));
            sqlPesquisa.AppendLine($"     LIMIT QtdPorPagina");
            sqlPesquisa.AppendLine($"    OFFSET (Pagina - 1) * QtdPorPagina;");
            sqlPesquisa.AppendLine($"END $$;");
            sqlPesquisa.AppendLine($"");
            sqlPesquisa.AppendLine($"SELECT * FROM tmp_table;");

            return await _baseRepository.BuscarTodosPorQueryAsync<Empresa>(sqlPesquisa.ToString().Trim());
        }
        public async Task<bool> ObterEntidade(Empresa empresa)
        {
            var sqlPesquisa = new StringBuilder();

            sqlPesquisa.AppendLine($" (nome = '{empresa.Nome}' OR cpf = '{empresa.CpfCnpj}')");

            return await _baseRepository.BuscarPorQueryGeradorAsync<Usuario>(sqlPesquisa.ToString()) is not null;
        }
        public async Task<bool> Inserir(Empresa empresa) => await _baseRepository.AdicionarAsync(empresa) > 0;
        public async Task<bool> Atualizar(Empresa empresa) => await _baseRepository.AtualizarAsync(empresa.Codigo, empresa) > 0;
        #endregion
    }
}
