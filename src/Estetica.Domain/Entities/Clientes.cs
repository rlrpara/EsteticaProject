using Estetica.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estetica.Domain.Entities
{
    [Table(name: "CLIENTE")]
    public class Clientes : EntityBase
    {
        [Nota()]
        [Column("NUM_PRONTUARIO", Order = 2)]
        public string? NumeroProntuario { get; set; }

        [Nota()]
        [Column("NUM_CARTAO_FIDELIDADE", Order = 3)]
        public string? NumeroCartaoFidelidade { get; set; }

        [Nota()]
        [Column("NOME", Order = 4)]
        public string? Nome { get; set; }

        [Nota()]
        [Column("NASCIMENTO", Order = 5)]
        public DateTime? Nascimento { get; set; }

        [Nota()]
        [Column("ID_TIPO_PESSOA", Order = 6)]
        public int CodigoTipoPessoa { get; set; } = 1;

        [Nota()]
        [Column("CPFCNPJ", Order = 7)]
        public string? CPFCNPJ { get; set; }

        [Nota()]
        [Column("ORGAO_EMISSOR", Order = 8)]
        public string? OraoEmissor { get; set; }

        [Nota()]
        [Column("IM", Order = 9)]
        public int? InscricaoMunicipal { get; set; }

        [Nota()]
        [Column("IE", Order = 10)]
        public int? InscricaoEstadual { get; set; }

        [Nota()]
        [Column("WHATSAPP", Order = 11)]
        public string? Whatsapp { get; set; }

        [Nota()]
        [Column("EMAIL", Order = 12)]
        public string? Email { get; set; }

        [Nota()]
        [Column("CELULAR", Order = 13)]
        public string? Celular { get; set; }

        [Nota(Tamanho = 8000)]
        [Column("FOTO", Order = 14)]
        public string? Foto { get; set; }

        [Nota()]
        [Column("CEP", Order = 15)]
        public int? CEP { get; set; }

        [Nota()]
        [Column("ID_TIPO_ENDERECO", Order = 16)]
        public int? CodigoTipoEndereco { get; set; }

        [Nota()]
        [Column("ENDERECO", Order = 17)]
        public string? Endereco { get; set; }

        [Nota()]
        [Column("NUMERO", Order = 18)]
        public string? Numero { get; set; }

        [Nota()]
        [Column("BAIRRO", Order = 19)]
        public string? Bairro { get; set; }

        [Nota()]
        [Column("COMPLEMENTO", Order = 20)]
        public string? Complemento { get; set; }

        [Nota()]
        [Column("ID_UF", Order = 21)]
        public int? CodigoUf { get; set; }

        [Nota()]
        [Column("CIDADE", Order = 22)]
        public string? Cidade { get; set; }

        [Nota()]
        [Column("OBSERVACAO", Order = 23)]
        public string? Observacao { get; set; }

        [Nota()]
        [Column("X_ORIGEM_INDICACAO", Order = 24)]
        public bool OrigemIndicacao { get; set; } = false;

        [Nota()]
        [Column("X_ORIGEM_PARCERIAS", Order = 25)]
        public bool OrigemParcerias { get; set; } = false;

        [Nota()]
        [Column("X_ORIGEM_PROFISSIONAL", Order = 26)]
        public bool OrigemProfissional { get; set; } = false;

        [Nota()]
        [Column("X_ORIGEM_CLIENTE", Order = 27)]
        public bool OrigemCliente { get; set; } = false;

        [Nota()]
        [Column("X_ORIGEM_CAMPANHA", Order = 28)]
        public bool OrigemCampanha { get; set; } = false;

        [Nota()]
        [Column("ID_ESTABELECIMENTO_ORIGEM", Order = 29)]
        public int CodigoEstabelecimentoOrigem { get; set; } = 1;

        [Nota()]
        [Column("X_ORIGEM_MARKETING", Order = 30)]
        public bool OrigemMarketing { get; set; } = false;

        [Nota()]
        [Column("NATURALIDADE", Order = 31)]
        public string? Naturalidade { get; set; }

        [Nota()]
        [Column("NOME_PAI", Order = 32)]
        public string? NomePai { get; set; }

        [Nota()]
        [Column("NOME_MAE", Order = 33)]
        public string? NomeMae { get; set; }

        [Nota()]
        [Column("PROFISSAO", Order = 34)]
        public string? Profissao { get; set; }

        [Nota()]
        [Column("LOCAL_TRABALHO", Order = 35)]
        public string? LocalTrabalho { get; set; }

        [Nota()]
        [Column("ID_SEXO", Order = 36)]
        public int? CodigoSexo { get; set; }

        [Nota()]
        [Column("ID_ESTADO_CIVIL", Order = 37)]
        public int? CodigoEstadoCivil { get; set; }

        [Nota()]
        [Column("ID_TIPO_SANGUINEO", Order = 38)]
        public int? CodigoTipoSnaguineo { get; set; }

        [Nota()]
        [Column("ID_TIPO_CLIENTE", Order = 39)]
        public int? CodigoTipoCliente { get; set; }
    }
}
