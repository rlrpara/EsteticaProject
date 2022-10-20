using System.ComponentModel.DataAnnotations.Schema;
using VendaFacil.CrossCutting.Util.ExtensionMethods;
using VendaFacil.Domain.Entities.Base;

namespace VendaFacil.Domain.Entities
{
    [Table(name: "EMPRESA")]
    public class Empresa : EntityBase
    {
        private string? _nome;
        private string? _cpfCnpj;
        private string? _telefone;
        private string? _email;
        private string? _endereco;
        private int? _dataPagamento;

        [Nota()]
        [Column(name: "NOME", Order = 2)]
        public string? Nome
        {
            get { return _nome; }
            set { _nome = value.RemoverAcentos(); }
        }

        [Nota(Tamanho = 11)]
        [Column(name: "CPF_CNPJ", Order = 3)]
        public string? CpfCnpj
        {
            get { return _cpfCnpj; }
            set { _cpfCnpj = value.ApenasNumeros(); }
        }

        [Nota(Tamanho = 20)]
        [Column(name: "TELEFONE", Order = 4)]
        public string? Telefone
        {
            get { return _telefone; }
            set { _telefone = value.ApenasNumeros(); }
        }

        [Nota(Tamanho = 50)]
        [Column(name: "EMAIL", Order = 5)]
        public string? Email
        {
            get { return _email; }
            set { _email = value?.ToLower(); }
        }


        [Nota()]
        [Column(name: "ENDERECO", Order = 6)]
        public string? Endereco
        {
            get { return _endereco; }
            set { _endereco = value.RemoverAcentos(); }
        }

        [Nota()]
        [Column(name: "VALOR_MENSAL", Order = 6)]
        public double ValorMensal { get; set; }

        [Nota()]
        [Column(name: "DATA_PAGAMENTO", Order = 7)]
        public int? DataPagamento
        {
            get { return _dataPagamento; }
            set { _dataPagamento = value; }
        }

    }
}
