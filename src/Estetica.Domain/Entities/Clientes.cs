using Estetica.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estetica.Domain.Entities
{
    [Table(name: "CLIENTE")]
    public class Clientes : EntityBase
    {
        [Key]
        [Nota()]
        [Column("ID", Order = 2)]
        public int Codigo { get; set; }

        [Nota()]
        [Column("NOME", Order = 3)]
        public string? Nome { get; set; }

        [Nota()]
        [Column("NASCIMENTO", Order = 3)]
        public DateTime Nascimento { get; set; }

        [Nota()]
        [Column("CPF", Order = 4)]
        public string? CPF { get; set; }

        [Nota()]
        [Column("ENDERECO", Order = 5)]
        public string? Endereco { get; set; }

        [Nota()]
        [Column("CIDADE", Order = 6)]
        public string? Cidade { get; set; }

        [Nota()]
        [Column("UF", Order = 7)]
        public string? UF { get; set; }

        [Nota()]
        [Column("CEP", Order = 8)]
        public string? CEP { get; set; }

        [Nota()]
        [Column("TELEFONE", Order = 9)]
        public string? Telefone { get; set; }

        [Nota()]
        [Column("EMAIL", Order = 10)]
        public string? Email { get; set; }

        [Nota()]
        [Column("PROFISSAO", Order = 11)]
        public string? Profissao { get; set; }

        [Nota()]
        [Column("INSTAGRAM", Order = 12)]
        public string? Instagram { get; set; }

        [Nota()]
        [Column("ESTADO_CIVIL", Order = 13)]
        public int EstadoCivil { get; set; }

        [Nota()]
        [Column("NUMERO_FILHOS", Order = 14)]
        public int NumeroFilhos { get; set; }

        [Nota()]
        [Column("CONHECEU_FACEBOOK", Order = 15)]
        public bool ConheceuFacebook { get; set; }

        [Nota()]
        [Column("CONHECEU_INSTAGRAM", Order = 16)]
        public bool ConheceuInstagram { get; set; }

        [Nota()]
        [Column("CONHECEU_INTERNET", Order = 17)]
        public bool ConheceuInternet { get; set; }

        [Nota()]
        [Column("CONHECEU_INDICACAO", Order = 18)]
        public bool ConheceuIndicacao { get; set; }

        [Nota(Tamanho = 150)]
        [Column("CONHECEU_INDICACAO_QUEM", Order = 19)]
        public string? ConheceuIndicacaoQuem { get; set; }

        [Nota()]
        [Column("CONHECEU_OUTRO", Order = 20)]
        public bool ConheceuOutro { get; set; }

        [Nota()]
        [Column("CONHECEU_OUTRO_QUAL", Order = 21)]
        public string? ConheceuOutroQual { get; set; }

        [Nota()]
        [Column("TRATAMENTO_ESTETICO_SIM", Order = 22)]
        public bool TratamentoEstetixoSim { get; set; }

        [Nota()]
        [Column("TRATAMENTO_ESTETICO_SIM_QUAL", Order = 23)]
        public string TratamentoEstetixoSimQual { get; set; }

        [Nota()]
        [Column("TRATAMENTO_ESTETICO_NAO", Order = 23)]
        public bool TratamentoEstetixoNao { get; set; }

        [Nota()]
        [Column("INTERESSE_ESCULPE_DETOX", Order = 24)]
        public bool InteresseEsculpeDetox { get; set; }

        [Nota()]
        [Column("INTERESSE_TRATAMENTOS_FACIAIS", Order = 25)]
        public bool InteresseTratamentosFaciais { get; set; }

        [Nota()]
        [Column("INTERESSE_APARELHOS_APLICACAO", Order = 26)]
        public bool InteresseAparelhosAplicacao { get; set; }

        [Nota()]
        [Column("HABITOS_ALIMENTARES_FRITURA", Order = 27)]
        public int HabitosHalimentaresFritura { get; set; }

        [Nota()]
        [Column("HABITOS_ALIMENTARES_FARINHA_BRANCA", Order = 28)]
        public int HabitosHalimentaresFarinhaBranca { get; set; }

        [Nota()]
        [Column("HABITOS_ALIMENTARES_LEITE", Order = 29)]
        public int HabitosHalimentaresLeite { get; set; }

        [Nota()]
        [Column("HABITOS_ALIMENTARES_ACUCAR", Order = 30)]
        public int HabitosHalimentaresAcucar { get; set; }

        [Nota()]
        [Column("HABITOS_ALIMENTARES_FRUTAS", Order = 31)]
        public int HabitosHalimentaresFrutas { get; set; }

        [Nota()]
        [Column("HABITOS_ALIMENTARES_SEMENTES", Order = 32)]
        public int HabitosHalimentaresSementes { get; set; }

        [Nota()]
        [Column("HABITOS_ALIMENTARES_LEGUMES", Order = 33)]
        public int HabitosHalimentaresLegumes { get; set; }

        [Nota()]
        [Column("HABITOS_ALIMENTARES_FARINHAS_INTEGRAIS", Order = 34)]
        public int HabitosHalimentaresFarinhasIntegrais { get; set; }

        [Nota()]
        [Column("LIQUIDOS_CHAS", Order = 35)]
        public int LiquidosChas { get; set; }

        [Nota()]
        [Column("LIQUIDOS_CHIMARRAO", Order = 36)]
        public int LiquidosChimarrao { get; set; }

        [Nota()]
        [Column("LIQUIDOS_SUCOS_NATURAIS", Order = 37)]
        public int LiquidosSucosNaturais { get; set; }

        [Nota()]
        [Column("LIQUIDOS_AGUA", Order = 38)]
        public bool LiquidosAgua { get; set; }

        [Nota()]
        [Column("LIQUIDOS_AGUA_QUANTIDADE_DIARIA", Order = 39)]
        public int LiquidosAguaQuantidadeDiaria { get; set; }

        [Nota()]
        [Column("LIQUIDOS_ALCOOL", Order = 40)]
        public int LiquidosAlcool { get; set; }

        [Nota()]
        [Column("LIQUIDOS_REFRIGERANTE", Order = 41)]
        public int LiquidosRefrigerante { get; set; }

        [Nota()]
        [Column("LIQUIDOS_SUCOS_INDUSTRIALIZADOS", Order = 42)]
        public int LiquidosSucosIndustrializados { get; set; }

        [Nota()]
        [Column("ATIVIDADE_FISICA_PRATICO_REGULARMENTE", Order = 43)]
        public bool AtividadeFisicaPraticoRegularmente { get; set; }

        [Nota()]
        [Column("ATIVIDADE_FISICA_QUANTAS_VEZES", Order = 44)]
        public int AtividadeFisicaQuantasVezes { get; set; }

        [Nota()]
        [Column("ATIVIDADE_FISICA_QUANTAS_VEZES_QUAIS_ATIVIDADES", Order = 45)]
        public string? AtividadeFisicaQuantasVezesQuaisAtividades { get; set; }

        [Nota()]
        [Column("ATIVIDADE_FISICA_NAO_PRATICO", Order = 46)]
        public bool AtividadeFisicaNaoPraticoMomento { get; set; }

        [Nota()]
        [Column("ATIVIDADE_FISICA_NUNCA_PRATIQUEI", Order = 47)]
        public bool AtividadeFisicaNuncaPratiquei { get; set; }

        [Nota()]
        [Column("SONO_MANOS_6_HORAS", Order = 48)]
        public bool SonoMenos6Horas { get; set; }

        [Nota()]
        [Column("SONO_8_HORAS", Order = 49)]
        public bool Sono8Horas { get; set; }

        [Nota()]
        [Column("SONO_MAIS_8_HORAS", Order = 50)]
        public bool SonoMais8Horas { get; set; }

        [Nota()]
        [Column("FUNCIONAMENTO_INTESTINO_TODOS_DIAS", Order = 51)]
        public bool FuncionamentoIntestinoTodosDias { get; set; }

        [Nota()]
        [Column("FUNCIONAMENTO_INTESTINO_30_OU_MAIS", Order = 52)]
        public bool FuncionamentoIntestino3OuMais { get; set; }

        [Nota()]
        [Column("FUNCIONAMENTO_INTESTINO_1_SEMANA", Order = 52)]
        public bool FuncionamentoIntestino1Semana { get; set; }

        [Nota()]
        [Column("URINAR_2X_DIA", Order = 53)]
        public bool Urinar2xDia { get; set; }

        [Nota()]
        [Column("URINAR_MAIS_2X_DIA", Order = 54)]
        public bool UrinarMais2xDia { get; set; }

        [Nota()]
        [Column("URINAR_MAIS_5X_DIA", Order = 55)]
        public bool UrinarMais5xDia { get; set; }

        [Nota()]
        [Column("CONTRACEPTIVO_NENHUMA", Order = 56)]
        public bool ContraceptivoNenhum { get; set; }

        [Nota()]
        [Column("CONTRACEPTIVO_PILULA", Order = 57)]
        public bool ContraceptivoPilula { get; set; }

        [Nota()]
        [Column("CONTRACEPTIVO_ADESIVO", Order = 58)]
        public bool ContraceptivoAdesivo { get; set; }

        [Nota()]
        [Column("CONTRACEPTIVO_IMPLANTE", Order = 59)]
        public bool ContraceptivoImplante { get; set; }

        [Nota()]
        [Column("CONTRACEPTIVO_DIU", Order = 60)]
        public bool ContraceptivoDiu { get; set; }

        [Nota()]
        [Column("CONTRACEPTIVO_MIRENA", Order = 61)]
        public bool ContraceptivoMirena { get; set; }

        [Nota()]
        [Column("CONTRACEPTIVO_MENOPAUSA", Order = 62)]
        public bool ContraceptivoMenopausa { get; set; }

        [Nota()]
        [Column("CONTRACEPTIVO_CIRURGIA", Order = 63)]
        public string? ContraceptivoCirurgia { get; set; }

        [Nota()]
        [Column("ACOMPANHAMENTO_CARDIOLOGISTA", Order = 64)]
        public bool AcompanhamentoCardiologista { get; set; }

        [Nota()]
        [Column("ACOMPANHAMENTO_NUTROLOGO", Order = 65)]
        public bool AcompanhamentoNutrologo { get; set; }

        [Nota()]
        [Column("ACOMPANHAMENTO_PSIQUIATRA", Order = 66)]
        public bool AcompanhamentoPsiquiatra { get; set; }

        [Nota()]
        [Column("ACOMPANHAMENTO_GINECOLOGISTA", Order = 67)]
        public bool AcompanhamentoGinecologista { get; set; }

        [Nota()]
        [Column("ACOMPANHAMENTO_TRAUMATOLOGISTA", Order = 68)]
        public bool AcompanhamentoTraumatologista { get; set; }

        [Nota()]
        [Column("ACOMPANHAMENTO_DERMATOLOGISTA", Order = 69)]
        public bool AcompanhamentoDermatologista { get; set; }

        [Nota()]
        [Column("ACOMPANHAMENTO_PSICOLOGO", Order = 70)]
        public bool AcompanhamentoPsicologo { get; set; }

        [Nota()]
        [Column("ACOMPANHAMENTO_COACH", Order = 71)]
        public bool AcompanhamentoCoach { get; set; }

        [Nota()]
        [Column("ACOMPANHAMENTO_PERSONAL_TRAINER", Order = 72)]
        public bool AcompanhamentoPersonalTrainer { get; set; }

        [Nota()]
        [Column("ACOMPANHAMENTO_NUTRICIONISTA", Order = 73)]
        public bool AcompanhamentoNutricionista { get; set; }

        [Nota()]
        [Column("ACOMPANHAMENTO_MEDICAMENTO_USO_CONTINUO", Order = 74)]
        public string? AcompanhamentoMedicamentoUsoContinuo { get; set; }

        [Nota()]
        [Column("PESO_A_QUANTO_TEMPO_TEVE_PESO_IDEAL", Order = 75)]
        public string? PesoAQuantoTempoTevePesoIdeal { get; set; }

        [Column("PESO_ATUAL", Order = 76)]
        public string? PesoAtual { get; set; }

        [Column("PESO_IDEAL", Order = 77)]
        public string? PesoIdeal { get; set; }
    }
}
