using System.ComponentModel.DataAnnotations.Schema;
using VendaFacil.CrossCutting.Util.ExtensionMethods;
using VendaFacil.Domain.Entities.Base;

namespace VendaFacil.Domain.Entities
{
    [Table(name: "TIPO")]
    public class Tipo : EntityBase
    {
        #region [Propriedades Privadas]
        private string? _nome;
        #endregion


        [Nota()]
        [Column(name: "NOME", Order = 2)]
        public string? Nome
        {
            get { return _nome; }
            set { _nome = value.RemoverAcentos(); }
        }


    }
}
