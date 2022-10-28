using System.ComponentModel.DataAnnotations.Schema;
using VendaFacil.CrossCutting.Util.ExtensionMethods;
using VendaFacil.Domain.Entities.Base;

namespace VendaFacil.Domain.Entities
{
    [Table(name: "PRODUTO_SERVICO")]
    public class ProdutoServico : EntityBase
    {
        private string _descricao;
        private int _numeroSessoes;


        [Nota(ChaveEstrangeira = "PRODUTO_SERVICO_CATEGORIA", Indice = true)]
        [Column(name: "ID_CATEGORIA", Order = 2)]
        public int CodigoCategoria { get; set; }

        [Nota()]
        [Column(name: "DESCRICAO", Order = 3)]
        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value.RemoverAcentos(); }
        }

        [Nota()]
        [Column(name: "NUMERO_SESSOES", Order = 4)]
        public int NumeroSessoes
        {
            get { return _numeroSessoes; }
            set { _numeroSessoes = value; }
        }


        [Nota()]
        [Column(name: "VALOR_UNITARIO", Order = 5)]
        public double ValorUnitario { get; set; }
    }
}
