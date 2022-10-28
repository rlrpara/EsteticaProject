using System.ComponentModel.DataAnnotations.Schema;
using VendaFacil.CrossCutting.Util.ExtensionMethods;
using VendaFacil.Domain.Entities.Base;

namespace VendaFacil.Domain.Entities
{
    [Table(name: "CATEGORIA")]
    public class Categoria : EntityBase
    {
        #region [Propriedades Privadas]
        private string? _nome;
        private string? _icone;
        #endregion

        [Nota()]
        [Column(name: "NOME", Order = 2)]
        public string? Nome
        {
            get { return _nome; }
            set { _nome = value.RemoverAcentos(); }
        }

        [Nota()]
        [Column(name: "ICONE", Order = 3)]
        public string? Icone
        {
            get { return _icone; }
            set { _icone = value.RemoverAcentos(); }
        }

        [Nota(ChaveEstrangeira = "TIPO", Indice = true)]
        [Column(name: "ID_TIPO", Order = 4)]
        public int CodigoTipo { get; set; }
    }
}
