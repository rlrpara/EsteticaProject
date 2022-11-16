using System.ComponentModel.DataAnnotations.Schema;
using VendaFacil.CrossCutting.Util.ExtensionMethods;
using VendaFacil.Domain.Entities.Base;

namespace VendaFacil.Domain.Entities
{
	[Table(name: "CLIENTE")]
    public class Clientes : EntityBase
    {
		private string? _nome;
		private DateTime? _Nascimento;
		private string? _cpf;
		private string? _endereco;
		private string? _cidade;
        private string? _uf;
        private string? _cep;
        private string? _telefone;
        private string? _email;
        private string? _profissao;
        private string? _instagran;
        private int _estadoCivil;
        private int? numeroFilhos;
        private bool _conheceuPeloFacebook;
        private bool _conheceuPeloInstagran;
        private bool _conheceuPelaInternet;
        private bool _indicacao;
        private string? _indicacaoQuem;
        private bool _conheceuOutros;
        private string? _conheceuOutrosQual;
        private bool _jaFezTratamentoEstetico;
        private string? _jaFezTratamentoEsteticoQual;
        private bool _areaInteresseEsculpeDetox;
        private bool _areaInteresseEsculpe21;
        private bool _spaFacial;
        private bool _spaCorporal;
        private bool _aparelhoAplicacaoAtivos;



        [Nota(Indice = true)]
		[Column(name: "NOME", Order = 2)]
		public string? Nome
		{
			get { return _nome; }
			set { _nome = value.RemoverAcentos(); }
		}

        [Nota()]
        [Column(name: "DATA_NASCIMENTO", Order = 3)]
        public DateTime? Nascimento
		{
			get { return _Nascimento; }
			set { _Nascimento = value; }
		}

        [Nota(Indice = true)]
        [Column(name: "CPF", Order = 4)]
        public string? CPF
		{
			get { return _cpf; }
			set { _cpf = value.ApenasNumeros(); }
		}

        [Nota()]
        [Column(name: "ENDERECO", Order = 5)]
        public string? Endereco
		{
			get { return _endereco; }
			set { _endereco = value.RemoverAcentos() ; }
		}

        [Nota()]
        [Column(name: "CIDADE", Order = 6)]
        public string? Cidade
		{
			get { return _cidade; }
			set { _cidade = value.RemoverAcentos(); }
		}

        [Nota()]
        [Column(name: "UF", Order = 7)]
        public string? UF
		{
			get { return _uf; }
			set { _uf = value.RemoverAcentos(); }
		}

        [Nota()]
        [Column(name: "CEP", Order = 8)]
        public string? CEP
		{
			get { return _cep; }
			set { _cep = value.ApenasNumeros() ; }
		}

        [Nota()]
        [Column(name: "TELEFONE", Order = 9)]
        public string? Telefone
		{
			get { return _telefone; }
			set { _telefone = value.ApenasNumeros(); }
		}

        [Nota()]
        [Column(name: "EMAIL", Order = 10)]
        public string? Email
		{
			get { return _email; }
			set { _email = value?.ToLower(); }
		}

        [Nota()]
        [Column(name: "PROFISSAO", Order = 11)]
        public string? Profissao
		{
			get { return _profissao; }
			set { _profissao = value.RemoverAcentos(); }
		}

        [Nota()]
        [Column(name: "INSTAGRAN", Order = 12)]
        public string? Instagran
		{
			get { return _instagran; }
			set { _instagran = value; }
		}

        [Nota()]
        [Column(name: "ID_ESTADO_CIVIL", Order = 13)]
        public int EstadoCivil
		{
			get { return _estadoCivil; }
			set { _estadoCivil = value; }
		}

        [Nota()]
        [Column(name: "NUMERO_FILHOS", Order = 14)]
        public int? NumeroFilhos
		{
			get { return numeroFilhos; }
			set { numeroFilhos = value; }
		}

        [Nota()]
        [Column(name: "X_CONHECEU_FACEBOOK", Order = 15)]
        public bool ConheceuPeloFacebook
		{
			get { return _conheceuPeloFacebook; }
			set { _conheceuPeloFacebook = value; }
		}

        [Nota()]
        [Column(name: "X_CONHECEU_INSTAGRAN", Order = 16)]
        public bool ConheceuPeloInstagran
		{
			get { return _conheceuPeloInstagran; }
			set { _conheceuPeloInstagran = value; }
		}

        [Nota()]
        [Column(name: "X_CONHECEU_INTERNET", Order = 17)]
        public bool ConheceuPelaInternet
		{
			get { return _conheceuPelaInternet; }
			set { _conheceuPelaInternet = value; }
		}

        [Nota()]
        [Column(name: "X_CONHECEU_INDICACAO", Order = 18)]
        public bool Indicacao
		{
			get { return _indicacao; }
			set { _indicacao = value; }
		}

        [Nota()]
        [Column(name: "CONHECEU_INDICACAO_QUEM", Order = 19)]
        public string? IndicacaoQuem
		{
			get { return _indicacaoQuem; }
			set { _indicacaoQuem = value.RemoverAcentos(); }
		}

        [Nota()]
        [Column(name: "X_CONHECEU_OUTROS", Order = 20)]
        public bool ConheceuOutros
		{
			get { return _conheceuOutros; }
			set { _conheceuOutros = value; }
		}

        [Nota()]
        [Column(name: "CONHECEU_OUTROS_QUAL", Order = 21)]
        public string? ConheceuOutrosQual
		{
			get { return _conheceuOutrosQual; }
			set { _conheceuOutrosQual = value; }
		}

        [Nota()]
        [Column(name: "X_JA_FEZ_TRATAMENTO_ESTETICO", Order = 22)]
        public bool JaFezTratamentoEstetico
		{
			get { return _jaFezTratamentoEstetico; }
			set { _jaFezTratamentoEstetico = value; }
		}

        [Nota()]
        [Column(name: "JA_FEZ_TRATAMENTO_ESTETICO_QUAL", Order = 23)]
        public string? JaFezTratamentoEsteticoQual
		{
			get { return _jaFezTratamentoEsteticoQual; }
			set { _jaFezTratamentoEsteticoQual = value.RemoverAcentos(); }
		}

        [Nota()]
        [Column(name: "X_AREA_INTERESSE_ESCULPE_DETOX", Order = 24)]
        public bool AreaInteresseEsculpeDetox
		{
			get { return _areaInteresseEsculpeDetox; }
			set { _areaInteresseEsculpeDetox = value; }
		}

        [Nota()]
        [Column(name: "X_AREA_INTERESSE_ESCULPE_21", Order = 25)]
        public bool AreaInteresseEsculpe21
		{
			get { return _areaInteresseEsculpe21; }
			set { _areaInteresseEsculpe21 = value; }
		}

        [Nota()]
        [Column(name: "X_AREA_INTERESSE_SPA_FACIAL", Order = 26)]
        public bool SpaFacial
		{
			get { return _spaFacial; }
			set { _spaFacial = value; }
		}

        [Nota()]
        [Column(name: "X_AREA_INTERESSE_SPA_CORPORAL", Order = 27)]
        public bool SpaCorporal
		{
			get { return _spaCorporal; }
			set { _spaCorporal = value; }
		}

        [Nota()]
        [Column(name: "X_AREA_INTERESSE_SPA_CORPORAL", Order = 28)]
        public bool AparelhoAplicacaoAtivos
		{
			get { return _aparelhoAplicacaoAtivos; }
			set { _aparelhoAplicacaoAtivos = value; }
		}

        [Nota()]
        [Column(name: "HABITOS_ALIMENTARES_FRITURA", Order = 29)]
        public int HabitosAlimentaresFritura { get; set; }

        [Nota()]
        [Column(name: "HABITOS_ALIMENTARES_FRUTA", Order = 30)]
        public int HabitosAlimentaresFruta { get; set; }

        [Nota()]
        [Column(name: "HABITOS_ALIMENTARES_FARINHA_BRANCA", Order = 31)]
        public int HabitosAlimentaresFarinhaBranca { get; set; }

        [Nota()]
        [Column(name: "HABITOS_ALIMENTARES_SEMENTE", Order = 32)]
        public int HabitosAlimentaresSemente { get; set; }

        [Nota()]
        [Column(name: "HABITOS_ALIMENTARES_LEITE", Order = 32)]
        public int HabitosAlimentaresLeite { get; set; }

        [Nota()]
        [Column(name: "HABITOS_ALIMENTARES_LEGUME", Order = 33)]
        public int HabitosAlimentaresLegume { get; set; }

        [Nota()]
        [Column(name: "HABITOS_ALIMENTARES_DERIVADO_LEITE", Order = 34)]
        public int HabitosAlimentaresDerivadoLeite { get; set; }

        [Nota()]
        [Column(name: "HABITOS_ALIMENTARES_VERDURA", Order = 35)]
        public int HabitosAlimentaresVerdura { get; set; }

        [Nota()]
        [Column(name: "HABITOS_ALIMENTARES_ACUCAR", Order = 36)]
        public int HabitosAlimentaresAcucar { get; set; }

        [Nota()]
        [Column(name: "HABITOS_ALIMENTARES_FARINHA_INTEGRAL", Order = 37)]
        public int HabitosAlimentaresFarinhaIntegral { get; set; }

        [Nota()]
        [Column(name: "LIQUIDO_REFRIGERANTE", Order = 38)]
        public int LiquidoRefrigerante { get; set; }

        [Nota()]
        [Column(name: "LIQUIDO_BEBIDA_ALCOOLICA", Order = 39)]
        public int LiquidoBebidaAlcolica { get; set; }

        [Nota()]
        [Column(name: "LIQUIDO_SUCO_INDUSTRIALIZADO", Order = 40)]
        public int LiquidoSucoIndustrializado { get; set; }

        [Nota()]
        [Column(name: "LIQUIDO_CHA", Order = 41)]
        public int LiquidoCha { get; set; }

        [Nota()]
        [Column(name: "LIQUIDO_SUCO_NATURAL", Order = 42)]
        public int LiquidoSucoNatural { get; set; }

        [Nota()]
        [Column(name: "LIQUIDO_CHIMARRAO", Order = 43)]
        public int LiquidoChimarrao { get; set; }

        [Nota()]
        [Column(name: "LIQUIDO_AGUA", Order = 44)]
        public int LiquidoAgua { get; set; }

        [Nota()]
        [Column(name: "LIQUIDO_AGUA_QUANTIDADE_DIARIA", Order = 45)]
        public int LiquidoAguaQuantidadeDiaria { get; set; }

        [Nota()]
        [Column(name: "ATIVIDADE_FISICA_PRATICA_REGULARMENTE", Order = 46)]
        public bool AtividadeFisicaPraticaRegularmente { get; set; }

        [Nota()]
        [Column(name: "ATIVIDADE_FISICA_PRATICA_REGULARMENTE_QUANTAS_VEZES_SEMANA", Order = 47)]
        public int AtividadeFisicaPraticaRegularmenteQuantasVezesSemana { get; set; }

        [Nota()]
        [Column(name: "ATIVIDADE_FISICA_PRATICA_REGULARMENTE_QUAIS_ATIVIDADES", Order = 48)]
        public string? AtividadeFisicaPraticaRegularmenteQuaisAtividades { get; set; }

        [Nota()]
        [Column(name: "ATIVIDADE_FISICA_NAO_PRATICA", Order = 49)]
        public bool AtividadeFisicaNaoPratica { get; set; }

        [Nota()]
        [Column(name: "ATIVIDADE_FISICA_NUNCA_PRATICOU", Order = 50)]
        public bool AtividadeFisicaNuncaPraticou { get; set; }

        [Nota()]
        [Column(name: "SONO_MENOS_6_HORAS", Order = 51)]
        public bool SonoMenos6Horas { get; set; }

        [Nota()]
        [Column(name: "SONO_6_HORAS", Order = 52)]
        public bool Sono6Horas { get; set; }

        [Nota()]
        [Column(name: "SONO_8_HORAS_MAIS", Order = 53)]
        public bool Sono8HorasOuMais { get; set; }

        [Nota()]
        [Column(name: "FUNCIONAMENTO_INTESTINO_TODOS_DIAS", Order = 54)]
        public bool FuncionamentoIntestinoTodosDias { get; set; }

        [Nota()]
        [Column(name: "FUNCIONAMENTO_INTESTINO_3_MAIS_SEMANAS", Order = 55)]
        public bool FuncionamentoIntestino3MaisSemana { get; set; }

        [Nota()]
        [Column(name: "FUNCIONAMENTO_INTESTINO_1_SEMANA", Order = 56)]
        public bool FuncionamentoIntestino1Semana { get; set; }

        [Nota()]
        [Column(name: "RETENCAO_LIQUIDO_2_DIA", Order = 57)]
        public bool RetencaoLiquido2Dia { get; set; }

        [Nota()]
        [Column(name: "RETENCAO_LIQUIDO_MAIS_2_DIA", Order = 58)]
        public bool RetencaoLiquidoMais2Dia { get; set; }

        [Nota()]
        [Column(name: "RETENCAO_LIQUIDO_MAIS_5_DIA", Order = 59)]
        public bool RetencaoLiquidoMais5Dia { get; set; }

        [Nota()]
        [Column(name: "METODO_CONTRACEPTIVO_NENHUM", Order = 60)]
        public bool MetodoContraceptivoNenhum { get; set; }

        [Nota()]
        [Column(name: "METODO_CONTRACEPTIVO_MIRENA", Order = 61)]
        public bool MetodoContraceptivoMirena { get; set; }

        [Nota()]
        [Column(name: "METODO_CONTRACEPTIVO_PILULA", Order = 62)]
        public bool MetodoContraceptivoPilula { get; set; }

        [Nota()]
        [Column(name: "METODO_CONTRACEPTIVO_MENO_PAUSA", Order = 63)]
        public bool MetodoContraceptivoMenopausa { get; set; }

        [Nota()]
        [Column(name: "METODO_CONTRACEPTIVO_ADESIVO", Order = 64)]
        public bool MetodoContraceptivoAdesivo { get; set; }

        [Nota()]
        [Column(name: "METODO_CONTRACEPTIVO_IMPLANTE", Order = 65)]
        public bool MetodoContraceptivoImplante { get; set; }

        [Nota()]
        [Column(name: "METODO_CONTRACEPTIVO_DIU", Order = 66)]
        public bool MetodoContraceptivoDiu { get; set; }

        [Nota()]
        [Column(name: "METODO_CONTRACEPTIVO_ALGUMA_CIRURGIA", Order = 67)]
        public string? MetodoContraceptivoAlgumaCirurgia { get; set; }

        [Nota()]
        [Column(name: "ACOMPANHAMENTO_CONTINUO_CARDIOLOGISTA", Order = 68)]
        public bool AcompanhamentoContinuoCardiologista { get; set; }

        [Nota()]
        [Column(name: "ACOMPANHAMENTO_CONTINUO_DERMATOLOGISTA", Order = 69)]
        public bool AcompanhamentoContinuoDermatologista { get; set; }

        [Nota()]
        [Column(name: "ACOMPANHAMENTO_CONTINUO_NUTROLOGO", Order = 70)]
        public bool AcompanhamentoContinuoNutrologo { get; set; }

        [Nota()]
        [Column(name: "ACOMPANHAMENTO_CONTINUO_PSICOLOGO", Order = 71)]
        public bool AcompanhamentoContinuoPsicologo { get; set; }

        [Nota()]
        [Column(name: "ACOMPANHAMENTO_CONTINUO_PSIQUIATRA", Order = 72)]
        public bool AcompanhamentoContinuoPsiquiatra { get; set; }

        [Nota()]
        [Column(name: "ACOMPANHAMENTO_CONTINUO_COACH", Order = 73)]
        public bool AcompanhamentoContinuoCoach { get; set; }

        [Nota()]
        [Column(name: "ACOMPANHAMENTO_CONTINUO_GINECOLOGISTA", Order = 74)]
        public bool AcompanhamentoContinuoGinecologista { get; set; }

        [Nota()]
        [Column(name: "ACOMPANHAMENTO_CONTINUO_PERSONAL_TRAINER", Order = 75)]
        public bool AcompanhamentoContinuoPersonalTrainer { get; set; }

        [Nota()]
        [Column(name: "ACOMPANHAMENTO_CONTINUO_TRAUMATOLOGISTA", Order = 76)]
        public bool AcompanhamentoContinuoTraumatologista { get; set; }

        [Nota()]
        [Column(name: "ACOMPANHAMENTO_CONTINUO_NUTRICIONISTA", Order = 77)]
        public bool AcompanhamentoContinuoNutricionista { get; set; }

        [Nota()]
        [Column(name: "MEDICAMENTO_USO_CONTINUO", Order = 78)]
        public string? MedicamentoUsoContinuo { get; set; }

        [Nota()]
        [Column(name: "QUANTO_TEMPO_PESO_IDEAL", Order = 79)]
        public string? QuantoTempoPesoIdeal { get; set; }

        [Nota()]
        [Column(name: "PESO_ATUAL", Order = 80)]
        public decimal PesoAtual { get; set; }

        [Nota()]
        [Column(name: "PESO_IDEAL", Order = 81)]
        public decimal PesoIdeal { get; set; }
	}
}
