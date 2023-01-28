using Estetica.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estetica.Domain.Entities
{
    [Table(name: "TIPO_PESSOA")]
    public class TipoPessoa : EntityBase
    {
        [Nota()]
        [Column("DESCRICAO", Order = 2)]
        public string? Descricao { get; set; }
    }
}
