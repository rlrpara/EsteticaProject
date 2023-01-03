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
            sqlPesquisa.AppendLine($"   AND ativo = true");

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
        public async Task<Clientes> ObterPorCodigo(int codigo) => await _baseRepository.BuscarPorIdAsync<Clientes>(codigo);
        public IEnumerable<Clientes> ObterTodos(filtroClientes filtro)
        {
            var sqlPesquisa = new StringBuilder();

            sqlPesquisa.AppendLine($" nome ilike '%{filtro.Nome}%'");
            sqlPesquisa.AppendLine($" AND ativo = true");

            return _baseRepository.BuscarTodosPorQueryGerador<Clientes>(sqlPesquisa.ToString());
        }
        public async Task<IEnumerable<Clientes>> ObterTodosAsync(filtroClientes filtro)
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
            sqlPesquisa.AppendLine($"           nascimento as Nascimento,");
            sqlPesquisa.AppendLine($"           cpf as Cpf,");
            sqlPesquisa.AppendLine($"           endereco as Endereco,");
            sqlPesquisa.AppendLine($"           cidade as Cidade,");
            sqlPesquisa.AppendLine($"           uf as Uf,");
            sqlPesquisa.AppendLine($"           cep as cep,");
            sqlPesquisa.AppendLine($"           telefone as Telefone,");
            sqlPesquisa.AppendLine($"           email as Email,");
            sqlPesquisa.AppendLine($"           profissao as Profissao,");
            sqlPesquisa.AppendLine($"           instagram as Instagram,");
            sqlPesquisa.AppendLine($"           estado_civil as EstadoCivil,");
            sqlPesquisa.AppendLine($"           numero_filhos as NumeroFilhos,");
            sqlPesquisa.AppendLine($"           conheceu_facebook as ConheceuFacebook,");
            sqlPesquisa.AppendLine($"           conheceu_instagram as ConhceuInstagram,");
            sqlPesquisa.AppendLine($"           conheceu_internet as ConheceuInternet,");
            sqlPesquisa.AppendLine($"           conheceu_indicacao as ConheceuIndicacao,");
            sqlPesquisa.AppendLine($"           conheceu_indicacao_quem as ConheceuIndicacaoQuem,");
            sqlPesquisa.AppendLine($"           conheceu_outro as ConheceuOutro,");
            sqlPesquisa.AppendLine($"           conheceu_outro_qual as ConheceuOutroQual,");
            sqlPesquisa.AppendLine($"           tratamento_estetico_sim as TratamentoEsteticoSim,");
            sqlPesquisa.AppendLine($"           tratamento_estetico_sim_qual as TratamentoEsteticoSimQual,");
            sqlPesquisa.AppendLine($"           tratamento_estetico_nao as TratamentoEsteticoNao,");
            sqlPesquisa.AppendLine($"           interesse_esculpe_detox as InteresseEsculpeDetox,");
            sqlPesquisa.AppendLine($"           interesse_tratamentos_faciais as InteresseTratamentoFaciais,");
            sqlPesquisa.AppendLine($"           interesse_aparelhos_aplicacao as InteresseAparelhosAplicacao,");
            sqlPesquisa.AppendLine($"           habitos_alimentares_fritura as HabitosAlimentaresFritura,");
            sqlPesquisa.AppendLine($"           habitos_alimentares_farinha_branca as HabitosAlimentaresFarinhaBranca,");
            sqlPesquisa.AppendLine($"           habitos_alimentares_leite  as HabitosAlimentaresLeite,");
            sqlPesquisa.AppendLine($"           habitos_alimentares_acucar as HabitosAlimentaresAcucar,");
            sqlPesquisa.AppendLine($"           habitos_alimentares_frutas as HabitosAlimentaresFrutas,");
            sqlPesquisa.AppendLine($"           habitos_alimentares_sementes as HabitosAlimentaresSementes,");
            sqlPesquisa.AppendLine($"           habitos_alimentares_legumes as HabitosAlimentaresLegumes,");
            sqlPesquisa.AppendLine($"           habitos_alimentares_farinhas_integrais as HabitosAlimentaresFarinhasIntegrais,");
            sqlPesquisa.AppendLine($"           liquidos_chas as LiquidosChas,");
            sqlPesquisa.AppendLine($"           liquidos_chimarrao as LiquidosChimarrao,");
            sqlPesquisa.AppendLine($"           liquidos_sucos_naturais as LiquidosSucosNaturais,");
            sqlPesquisa.AppendLine($"           liquidos_agua as LiquidosAgua,");
            sqlPesquisa.AppendLine($"           liquidos_agua_quantidade_diaria as LiquidosAguaQuantidadeDiaria,");
            sqlPesquisa.AppendLine($"           liquidos_alcool as LiquidoAlcool,");
            sqlPesquisa.AppendLine($"           liquidos_refrigerante as LiquidoRefrigeranta,");
            sqlPesquisa.AppendLine($"           liquidos_sucos_industrializados as LiquidoSucosIndustrializados,");
            sqlPesquisa.AppendLine($"           atividade_fisica_pratico_regularmente as AtividadeFisicaPatricoRegularmente,");
            sqlPesquisa.AppendLine($"           atividade_fisica_quantas_vezes as AtividadeFisicaQuantasVezes,");
            sqlPesquisa.AppendLine($"           atividade_fisica_quantas_vezes_quais_atividades as AtividadeFisicaQuantasVezesQuaisAtividades,");
            sqlPesquisa.AppendLine($"           atividade_fisica_nao_pratico as AtividadeFisicaNaoPratico,");
            sqlPesquisa.AppendLine($"           atividade_fisica_nunca_pratiquei as AtividadeFisicaNuncaPratiquei,");
            sqlPesquisa.AppendLine($"           sono_manos_6_horas as Sono6Horas,");
            sqlPesquisa.AppendLine($"           sono_8_horas as Sono8Horas,");
            sqlPesquisa.AppendLine($"           sono_mais_8_horas as SonoMais8Horas,");
            sqlPesquisa.AppendLine($"           funcionamento_intestino_todos_dias as FuncionamentoIntestinoTodosDias,");
            sqlPesquisa.AppendLine($"           funcionamento_intestino_30_ou_mais as FuncionamentoIntestino30OuMais,");
            sqlPesquisa.AppendLine($"           funcionamento_intestino_1_semana as FuncionamentoIntestino1Semana,");
            sqlPesquisa.AppendLine($"           urinar_2x_dia as Urina2xDia,");
            sqlPesquisa.AppendLine($"           urinar_mais_2x_dia as UrinaMAis2xDia,");
            sqlPesquisa.AppendLine($"           urinar_mais_5x_dia as UrinaMais5xDia,");
            sqlPesquisa.AppendLine($"           contraceptivo_nenhuma as ContraceptivoNenhum,");
            sqlPesquisa.AppendLine($"           contraceptivo_pilula as ContraceptivoPilula,");
            sqlPesquisa.AppendLine($"           contraceptivo_adesivo as ContraceptivoAdesivo,");
            sqlPesquisa.AppendLine($"           contraceptivo_implante as ContraceptivoImplante,");
            sqlPesquisa.AppendLine($"           contraceptivo_diu as ContraceptivoDiu,");
            sqlPesquisa.AppendLine($"           contraceptivo_mirena as ContraceptivoMirena,");
            sqlPesquisa.AppendLine($"           contraceptivo_menopausa as ContraceptivoMenupausa,");
            sqlPesquisa.AppendLine($"           contraceptivo_cirurgia as ContraceptivoCirurgia,");
            sqlPesquisa.AppendLine($"           acompanhamento_cardiologista as AcompanhamentoCardiologista,");
            sqlPesquisa.AppendLine($"           acompanhamento_nutrologo as AcompanhamentoNutrologo,");
            sqlPesquisa.AppendLine($"           acompanhamento_psiquiatra as AcompanhamentoPsiquiatra,");
            sqlPesquisa.AppendLine($"           acompanhamento_ginecologista as AcompanhamentoGinecologista,");
            sqlPesquisa.AppendLine($"           acompanhamento_traumatologista as AcompanhamentoTraumatologista,");
            sqlPesquisa.AppendLine($"           acompanhamento_dermatologista as AcompanhamentoDermatologista,");
            sqlPesquisa.AppendLine($"           acompanhamento_psicologo as AcompanhamentoPsicologo,");
            sqlPesquisa.AppendLine($"           acompanhamento_coach as AcompanhamentoCiach,");
            sqlPesquisa.AppendLine($"           acompanhamento_personal_trainer as AcompanhamentoPersonalTrainer,");
            sqlPesquisa.AppendLine($"           acompanhamento_nutricionista as AcompanhamentoNutricionista,");
            sqlPesquisa.AppendLine($"           acompanhamento_medicamento_uso_continuo as AcompanhamentoMedicamentoUsoContinuo,");
            sqlPesquisa.AppendLine($"           peso_a_quanto_tempo_teve_peso_ideal as PesoAQuantoTempoTevePesoIdeial,");
            sqlPesquisa.AppendLine($"           data_cadastro as DataCadastro,");
            sqlPesquisa.AppendLine($"           data_atualizacao as DataAtualizacao,");
            sqlPesquisa.AppendLine($"           ativo as Ativo");
            sqlPesquisa.AppendLine($"      FROM cliente");
            sqlPesquisa.AppendLine(ObterFiltros(filtro));
            sqlPesquisa.AppendLine($"     LIMIT QtdPorPagina");
            sqlPesquisa.AppendLine($"    OFFSET (Pagina - 1) * QtdPorPagina;");
            sqlPesquisa.AppendLine($"END $$;");
            sqlPesquisa.AppendLine($"");
            sqlPesquisa.AppendLine($"SELECT * FROM tmp_table;");

            return await _baseRepository.BuscarTodosPorQueryAsync<Clientes>(sqlPesquisa.ToString().Trim());
        }
        public async Task<bool> ObterEntidade(Clientes clientes)
        {
            var sqlPesquisa = new StringBuilder();

            sqlPesquisa.AppendLine($" (nome = '{clientes.Nome}'");

            return await _baseRepository.BuscarPorQueryGeradorAsync<Usuario>(sqlPesquisa.ToString()) is not null;
        }
        public async Task<bool> Inserir(Clientes clientes) => await _baseRepository.AdicionarAsync(clientes) > 0;
        public async Task<bool> Atualizar(Clientes clientes) => await _baseRepository.AtualizarAsync(clientes.Codigo, clientes) > 0;
        #endregion
    }
}
