using System.ComponentModel.DataAnnotations.Schema;
using VendaFacil.CrossCutting.Util.ExtensionMethods;
using VendaFacil.Domain.Entities.Base;

namespace VendaFacil.Domain.Entities
{
    [Table(name: "PRODUTO_SERVICO_CATEGORIA")]
    public class ProdutoServicoCategoria : EntityBase
    {
        private string _descricao;


        [Nota()]
        [Column(name: "DESCRICAO", Order = 3)]
        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value.RemoverAcentos(); }
        }
    }
}
