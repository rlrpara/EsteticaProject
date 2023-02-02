using Estetica.Domain.Entities;
using Estetica.Domain.Entities.Filtros;
using Estetica.Domain.Interface;
using System.Text;

namespace Estetica.Infra.Data.Repositories
{
    public class ClientesRepository : BaseRepository, IClientesRepository
    {
        #region [Propriedades Privadas]
        private readonly IBaseRepository _baseRepository;
        #endregion

        #region [Métodos Privados]
        private string ObterFiltros(filtroClientes filtro)
        {
            var sqlPesquisa = new StringBuilder();

            sqlPesquisa.AppendLine($" WHERE nome ilike '%{filtro.Nome}%'");

            return sqlPesquisa.ToString();
        }
        #endregion

        #region [Construtor]
        public ClientesRepository(IBaseRepository baseRepository) => _baseRepository = baseRepository;
        #endregion

        #region [Métodos Públicos]
        public async Task<int> TotalRegistros(filtroClientes filtro)
        {
            var sqlPesquisa = new StringBuilder();

            sqlPesquisa.AppendLine($"SELECT COUNT(ID) as Total");
            sqlPesquisa.AppendLine($"  FROM cliente");
            sqlPesquisa.AppendLine(ObterFiltros(filtro));

            return await _baseRepository.BuscarPorQueryAsync<int>(sqlPesquisa.ToString());
        }
        public async Task<Cliente> ObterPorCodigo(int codigo) => await _baseRepository.BuscarPorIdAsync<Cliente>(codigo);
        public IEnumerable<Cliente> ObterTodos(filtroClientes filtro)
        {
            var sqlPesquisa = new StringBuilder();

            sqlPesquisa.AppendLine($" nome ilike '%{filtro.Nome}%'");
            sqlPesquisa.AppendLine($" AND ativo = true");

            return _baseRepository.BuscarTodosPorQueryGerador<Cliente>(sqlPesquisa.ToString());
        }
        public async Task<IEnumerable<Cliente>> ObterTodosAsync(filtroClientes filtro)
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
            sqlPesquisa.AppendLine($"           num_prontuario as NumeroProntuario,");
            sqlPesquisa.AppendLine($"           num_cartao_fidelidade as NumeroCartaoFidelidade,");
            sqlPesquisa.AppendLine($"           nome,");
            sqlPesquisa.AppendLine($"           nascimento,");
            sqlPesquisa.AppendLine($"           id_tipo_pessoa as CodigoTipoPessoa,");
            sqlPesquisa.AppendLine($"           cpfcnpj,");
            sqlPesquisa.AppendLine($"           orgao_emissor as OraoEmissor,");
            sqlPesquisa.AppendLine($"           im,");
            sqlPesquisa.AppendLine($"           ie,");
            sqlPesquisa.AppendLine($"           whatsapp,");
            sqlPesquisa.AppendLine($"           email,");
            sqlPesquisa.AppendLine($"           celular,");
            sqlPesquisa.AppendLine($"           foto,");
            sqlPesquisa.AppendLine($"           cep,");
            sqlPesquisa.AppendLine($"           id_tipo_endereco as CodigoTipoEndereco,");
            sqlPesquisa.AppendLine($"           endereco,");
            sqlPesquisa.AppendLine($"           numero,");
            sqlPesquisa.AppendLine($"           bairro,");
            sqlPesquisa.AppendLine($"           complemento,");
            sqlPesquisa.AppendLine($"           id_uf,");
            sqlPesquisa.AppendLine($"           cidade,");
            sqlPesquisa.AppendLine($"           observacao,");
            sqlPesquisa.AppendLine($"           x_origem_indicacao as OrigemIndicacao,");
            sqlPesquisa.AppendLine($"           x_origem_parcerias as OrigemParcerias,");
            sqlPesquisa.AppendLine($"           x_origem_profissional as OrigemProfissional,");
            sqlPesquisa.AppendLine($"           x_origem_cliente as OrigemCliente,");
            sqlPesquisa.AppendLine($"           x_origem_campanha as OrigemCampanha,");
            sqlPesquisa.AppendLine($"           id_estabelecimento_origem as CodigoEstabelecimentoOrigem,");
            sqlPesquisa.AppendLine($"           x_origem_marketing as OrigemMarketing,");
            sqlPesquisa.AppendLine($"           naturalidade,");
            sqlPesquisa.AppendLine($"           nome_pai as NomePai,");
            sqlPesquisa.AppendLine($"           nome_mae as NomeMae,");
            sqlPesquisa.AppendLine($"           profissao,");
            sqlPesquisa.AppendLine($"           local_trabalho as LocalTrabalho,");
            sqlPesquisa.AppendLine($"           id_sexo as CodigoSexo,");
            sqlPesquisa.AppendLine($"           id_estado_civil as CodigoEstadoCivil,");
            sqlPesquisa.AppendLine($"           id_tipo_sanguineo as CodigoTipoSnaguineo,");
            sqlPesquisa.AppendLine($"           data_cadastro as DataCadastro,");
            sqlPesquisa.AppendLine($"           data_atualizacao as DataAtualizacao,");
            sqlPesquisa.AppendLine($"           ativo");
            sqlPesquisa.AppendLine($"      FROM cliente");
            sqlPesquisa.AppendLine(ObterFiltros(filtro));
            sqlPesquisa.AppendLine($"     LIMIT QtdPorPagina");
            sqlPesquisa.AppendLine($"    OFFSET (Pagina - 1) * QtdPorPagina;");
            sqlPesquisa.AppendLine($"END $$;");
            sqlPesquisa.AppendLine($"");
            sqlPesquisa.AppendLine($"SELECT * FROM tmp_table;");

            return await _baseRepository.BuscarTodosPorQueryAsync<Cliente>(sqlPesquisa.ToString().Trim());
        }
        public async Task<bool> ObterEntidade(Cliente clientes)
        {
            var sqlPesquisa = new StringBuilder();

            sqlPesquisa.AppendLine($" nome = '{clientes.Nome}'");

            return await _baseRepository.BuscarPorQueryGeradorAsync<Usuario>(sqlPesquisa.ToString()) is not null;
        }
        public async Task<bool> Inserir(Cliente clientes)
        {
            clientes.DataCadastro ??= DateTime.Now;
            clientes.DataAtualizacao ??= DateTime.Now;

            return await _baseRepository.AdicionarAsync(clientes) > 0;
        }
        public async Task<bool> Atualizar(Cliente clientes) => await _baseRepository.AtualizarAsync(clientes.Codigo, clientes) > 0;
        #endregion
    }
}
