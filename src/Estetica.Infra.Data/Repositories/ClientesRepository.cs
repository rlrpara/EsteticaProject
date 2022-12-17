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
        public async Task<IEnumerable<Clientes>> ObterTodos(filtroClientes filtro)
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
            sqlPesquisa.AppendLine($"           nome,");
            sqlPesquisa.AppendLine($"           data_nascimento as Nascimento,");
            sqlPesquisa.AppendLine($"           cpf,");
            sqlPesquisa.AppendLine($"           endereco,");
            sqlPesquisa.AppendLine($"           cidade,");
            sqlPesquisa.AppendLine($"           uf,");
            sqlPesquisa.AppendLine($"           cep,");
            sqlPesquisa.AppendLine($"           telefone,");
            sqlPesquisa.AppendLine($"           email,");
            sqlPesquisa.AppendLine($"           profissao,");
            sqlPesquisa.AppendLine($"           instagran,");
            sqlPesquisa.AppendLine($"           id_estado_civil as EstadoCivil,");
            sqlPesquisa.AppendLine($"           numero_filhos as NumeroFilhos,");
            sqlPesquisa.AppendLine($"           x_conheceu_facebook as ConheceuPeloFacebook,");
            sqlPesquisa.AppendLine($"           x_conheceu_instagran as ConheceuPeloInstagran,");
            sqlPesquisa.AppendLine($"           x_conheceu_internet as ConheceuPelaInternet,");
            sqlPesquisa.AppendLine($"           x_conheceu_indicacao as Indicacao,");
            sqlPesquisa.AppendLine($"           conheceu_indicacao_quem as IndicacaoQuem,");
            sqlPesquisa.AppendLine($"           x_conheceu_outros as ConheceuOutros,");
            sqlPesquisa.AppendLine($"           conheceu_outros_qual as ConheceuOutrosQual,");
            sqlPesquisa.AppendLine($"           x_ja_fez_tratamento_estetico as JaFezTratamentoEstetico,");
            sqlPesquisa.AppendLine($"           ja_fez_tratamento_estetico_qual as JaFezTratamentoEsteticoQual,");
            sqlPesquisa.AppendLine($"           x_area_interesse_esculpe_detox as AreaInteresseEsculpeDetox,");
            sqlPesquisa.AppendLine($"           x_area_interesse_esculpe_21 as AreaInteresseEsculpe21,");
            sqlPesquisa.AppendLine($"           x_area_interesse_spa_facial as SpaFacial,");
            sqlPesquisa.AppendLine($"           x_area_interesse_spa_corporal as SpaCorporal,");
            sqlPesquisa.AppendLine($"           x_aparelho_aplicacao_ativo as AparelhoAplicacaoAtivos,");
            sqlPesquisa.AppendLine($"           habitos_alimentares_fritura as HabitosAlimentaresFritura,");
            sqlPesquisa.AppendLine($"           habitos_alimentares_fruta as HabitosAlimentaresFruta,");
            sqlPesquisa.AppendLine($"           habitos_alimentares_farinha_branca as HabitosAlimentaresFarinhaBranca,");
            sqlPesquisa.AppendLine($"           habitos_alimentares_semente as HabitosAlimentaresSemente,");
            sqlPesquisa.AppendLine($"           habitos_alimentares_leite as HabitosAlimentaresLeite,");
            sqlPesquisa.AppendLine($"           habitos_alimentares_legume as HabitosAlimentaresLegume,");
            sqlPesquisa.AppendLine($"           habitos_alimentares_derivado_leite as HabitosAlimentaresDerivadoLeite,");
            sqlPesquisa.AppendLine($"           habitos_alimentares_verdura as HabitosAlimentaresVerdura,");
            sqlPesquisa.AppendLine($"           habitos_alimentares_acucar as HabitosAlimentaresAcucar,");
            sqlPesquisa.AppendLine($"           habitos_alimentares_farinha_integral as HabitosAlimentaresFarinhaIntegral,");
            sqlPesquisa.AppendLine($"           liquido_refrigerante as LiquidoRefrigerante,");
            sqlPesquisa.AppendLine($"           liquido_bebida_alcoolica as LiquidoBebidaAlcolica,");
            sqlPesquisa.AppendLine($"           liquido_suco_industrializado as LiquidoSucoIndustrializado,");
            sqlPesquisa.AppendLine($"           liquido_cha as LiquidoCha,");
            sqlPesquisa.AppendLine($"           liquido_suco_natural as LiquidoSucoNatural,");
            sqlPesquisa.AppendLine($"           liquido_chimarrao as LiquidoChimarrao,");
            sqlPesquisa.AppendLine($"           liquido_agua as LiquidoAgua,");
            sqlPesquisa.AppendLine($"           liquido_agua_quantidade_diaria as LiquidoAguaQuantidadeDiaria,");
            sqlPesquisa.AppendLine($"           atividade_fisica_pratica_regularmente as AtividadeFisicaPraticaRegularmente,");
            sqlPesquisa.AppendLine($"           atividade_fisica_pratica_regularmente_quantas_vezes_semana as AtividadeFisicaPraticaRegularmenteQuantasVezesSemana,");
            sqlPesquisa.AppendLine($"           atividade_fisica_pratica_regularmente_quais_atividades as AtividadeFisicaPraticaRegularmenteQuaisAtividades,");
            sqlPesquisa.AppendLine($"           atividade_fisica_nao_pratica as AtividadeFisicaNaoPratica,");
            sqlPesquisa.AppendLine($"           atividade_fisica_nunca_praticou as AtividadeFisicaNuncaPraticou,");
            sqlPesquisa.AppendLine($"           sono_menos_6_horas as SonoMenos6Horas,");
            sqlPesquisa.AppendLine($"           sono_6_horas as Sono6Horas,");
            sqlPesquisa.AppendLine($"           sono_8_horas_mais as Sono8HorasOuMais,");
            sqlPesquisa.AppendLine($"           funcionamento_intestino_todos_dias as FuncionamentoIntestinoTodosDias,");
            sqlPesquisa.AppendLine($"           funcionamento_intestino_3_mais_semanas as FuncionamentoIntestino3MaisSemana,");
            sqlPesquisa.AppendLine($"           funcionamento_intestino_1_semana as FuncionamentoIntestino1Semana,");
            sqlPesquisa.AppendLine($"           retencao_liquido_2_dia as RetencaoLiquido2Dia,");
            sqlPesquisa.AppendLine($"           retencao_liquido_mais_2_dia as RetencaoLiquidoMais2Dia,");
            sqlPesquisa.AppendLine($"           retencao_liquido_mais_5_dia as RetencaoLiquidoMais5Dia,");
            sqlPesquisa.AppendLine($"           metodo_contraceptivo_nenhum as MetodoContraceptivoNenhum,");
            sqlPesquisa.AppendLine($"           metodo_contraceptivo_mirena as MetodoContraceptivoMirena,");
            sqlPesquisa.AppendLine($"           metodo_contraceptivo_pilula as MetodoContraceptivoPilula,");
            sqlPesquisa.AppendLine($"           metodo_contraceptivo_meno_pausa as MetodoContraceptivoMenopausa,");
            sqlPesquisa.AppendLine($"           metodo_contraceptivo_adesivo as MetodoContraceptivoAdesivo,");
            sqlPesquisa.AppendLine($"           metodo_contraceptivo_implante as MetodoContraceptivoImplante,");
            sqlPesquisa.AppendLine($"           metodo_contraceptivo_diu as MetodoContraceptivoDiu,");
            sqlPesquisa.AppendLine($"           metodo_contraceptivo_alguma_cirurgia as MetodoContraceptivoAlgumaCirurgia,");
            sqlPesquisa.AppendLine($"           acompanhamento_continuo_cardiologista as AcompanhamentoContinuoCardiologista,");
            sqlPesquisa.AppendLine($"           acompanhamento_continuo_dermatologista as AcompanhamentoContinuoDermatologista,");
            sqlPesquisa.AppendLine($"           acompanhamento_continuo_nutrologo as AcompanhamentoContinuoNutrologo,");
            sqlPesquisa.AppendLine($"           acompanhamento_continuo_psicologo as AcompanhamentoContinuoPsicologo,");
            sqlPesquisa.AppendLine($"           acompanhamento_continuo_psiquiatra as AcompanhamentoContinuoPsiquiatra,");
            sqlPesquisa.AppendLine($"           acompanhamento_continuo_coach as AcompanhamentoContinuoCoach,");
            sqlPesquisa.AppendLine($"           acompanhamento_continuo_ginecologista as AcompanhamentoContinuoGinecologista,");
            sqlPesquisa.AppendLine($"           acompanhamento_continuo_personal_trainer as AcompanhamentoContinuoPersonalTrainer,");
            sqlPesquisa.AppendLine($"           acompanhamento_continuo_traumatologista as AcompanhamentoContinuoTraumatologista,");
            sqlPesquisa.AppendLine($"           acompanhamento_continuo_nutricionista as AcompanhamentoContinuoNutricionista,");
            sqlPesquisa.AppendLine($"           medicamento_uso_continuo as MedicamentoUsoContinuo,");
            sqlPesquisa.AppendLine($"           quanto_tempo_peso_ideal as QuantoTempoPesoIdeal,");
            sqlPesquisa.AppendLine($"           peso_atual as PesoAtual,");
            sqlPesquisa.AppendLine($"           peso_ideal as PesoIdeal,");
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
