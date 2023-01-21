using Estetica.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estetica.Domain.Entities
{
    [Table(name: "CLIENTE")]
    public class Clientes : EntityBase
    {
        [Nota()]
        [Column("NOME", Order = 2)]
        public string? Nome { get; set; }

        [Nota()]
        [Column("NASCIMENTO", Order = 3)]
        public DateTime? Nascimento { get; set; }

        [Nota()]
        [Column("CPF", Order = 4)]
        public string? CPF { get; set; }

        [Nota()]
        [Column("WHATSAPP", Order = 5)]
        public string? Whatsapp { get; set; }

        [Nota()]
        [Column("EMAIL", Order = 6)]
        public string? Email { get; set; }

        [Nota()]
        [Column("CELULAR", Order = 7)]
        public string? Celular { get; set; }

        [Nota(Tamanho = 8000)]
        [Column("FOTO", Order = 8)]
        public string? Foto { get; set; }
    }
}
