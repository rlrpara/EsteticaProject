using System.ComponentModel.DataAnnotations.Schema;

namespace VendaFacil.Domain.Entities.Base
{
    [Table(name: "EMPRESA")]
    public class Empresa : EntityBase
    {
        private string? _nome;

        [Nota()]
        [Column(name: "NOME", Order = 2)]
        public string? Nome
        {
            get { return _nome; }
            set { _nome = value.RemoverAcentos(); }
        }

        [Nota(Tamanho = 11)]
        [Column(name: "CPF_CNPJ", Order = 3)]
        public string CpfCnpj { get; set; }

        [Nota(Tamanho = 20)]
        [Column(name: "TELEFONE", Order = 4)]
        public string Telefone { get; set; }

        [Nota(Tamanho = 50)]
        [Column(name: "EMAIL", Order = 5)]
        public string Email { get; set; }

        [Nota()]
        [Column(name: "ENDERECO", Order = 6)]
        public string Endereco { get; set; }

        [Nota()]
        [Column(name: "VALOR_MENSAL", Order = 6)]
        public double ValorMensal { get; set; }

        [Nota()]
        [Column(name: "DATA_PAGAMENTO", Order = 7)]
        public int DataPagamento { get; set; }
    }
}
