using Estetica.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estetica.Domain.Entities
{
    [Table(name: "TIPO_ESTADO_CIVIL")]
    public class TipoEstadoCivil : EntityBase
    {
        [Nota()]
        [Column("DESCRICAO", Order = 2)]
        public string? Descricao { get; set; }
    }
}
