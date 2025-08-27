using Estetica.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estetica.Domain.Entities
{
    [Table(name: "CLIENTE")]
    public class Cliente : EntityBase
    {
        [Nota(Indice = true)]
        [Column("NOME", Order = 2)]
        public string? Nome { get; set; }

        [Nota()]
        [Column("NASCIMENTO", Order = 3)]
        public DateTime? Nascimento { get; set; }

        [Nota(Indice = true)]
        [Column("CPFCNPJ", Order = 4)]
        public string? CPFCNPJ { get; set; }

        [Nota()]
        [Column("IM_RG", Order = 5)]
        public int? InscricaoMunicipalRG { get; set; }

        [Nota()]
        [Column("RG_DATA_EXPEDICAO", Order = 6)]
        public DateTime? RgExpedicao { get; set; }

        [Nota()]
        [Column("RG_ORGAO_EMISSOR", Order = 7)]
        public string? OraoEmissor { get; set; }

        [Nota()]
        [Column("IE", Order = 8)]
        public int? InscricaoEstadual { get; set; }

        [Nota(Indice = true)]
        [Column("WHATSAPP", Order = 9)]
        public string? Whatsapp { get; set; }

        [Nota(Indice = true)]
        [Column("EMAIL", Order = 10)]
        public string? Email { get; set; }

        [Nota()]
        [Column("CELULAR", Order = 11)]
        public string? Celular { get; set; }

        [Nota(Tamanho = 8000)]
        [Column("FOTO_LOGO", Order = 12)]
        public string? Foto { get; set; }

        [Nota()]
        [Column("CEP", Order = 13)]
        public int? CEP { get; set; }

        [Nota()]
        [Column("BAIRRO", Order = 14)]
        public string? Bairro { get; set; }

        [Nota()]
        [Column("ENDERECO", Order = 15)]
        public string? Endereco { get; set; }

        [Nota()]
        [Column("NUMERO", Order = 16)]
        public string? Numero { get; set; }

        [Nota()]
        [Column("COMPLEMENTO", Order = 17)]
        public string? Complemento { get; set; }

        [Nota()]
        [Column("UF", Order = 18)]
        public string? UF { get; set; }

        [Nota()]
        [Column("CIDADE", Order = 19)]
        public string? Cidade { get; set; }

        [Nota()]
        [Column("OBSERVACAO", Order = 20)]
        public string? Observacao { get; set; }

        [Nota()]
        [Column("NATURALIDADE", Order = 21)]
        public string? Naturalidade { get; set; }

        [Nota()]
        [Column("NOME_PAI", Order = 22)]
        public string? NomePai { get; set; }

        [Nota()]
        [Column("NOME_MAE", Order = 23)]
        public string? NomeMae { get; set; }

        [Nota()]
        [Column("PROFISSAO", Order = 24)]
        public string? Profissao { get; set; }

        [Nota()]
        [Column("LOCAL_TRABALHO", Order = 25)]
        public string? LocalTrabalho { get; set; }

        [Nota(Indice = true, ChaveEstrangeira = "TIPO_SEXO")]
        [Column("ID_SEXO", Order = 26)]
        public int? CodigoSexo { get; set; }

        [Nota(Indice = true, ChaveEstrangeira = "TIPO_ESTADO_CIVIL")]
        [Column("ID_ESTADO_CIVIL", Order = 27)]
        public int? CodigoEstadoCivil { get; set; }

        [Nota(Indice = true, ChaveEstrangeira = "TIPO_SANGUINEO")]
        [Column("ID_TIPO_SANGUINEO", Order = 28)]
        public int? CodigoTipoSanguineo { get; set; }

        [Nota(Indice = true, ChaveEstrangeira = "EMPRESA")]
        [Column("ID_EMPRESA", Order = 29)]
        public int? CodigoEmpresa { get; set; }
    }
}
