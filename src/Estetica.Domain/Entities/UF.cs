using Estetica.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estetica.Domain.Entities
{
    [Table(name: "UF")]
    public class UF : EntityBase
    {
        [Nota()]
        [Column("DESCRICAO", Order = 2)]
        public string? Descricao { get; set; }

        [Nota(Indice = true)]
        [Column("SIGLA", Order = 3)]
        public string? Sigla { get; set; }
    }
}
