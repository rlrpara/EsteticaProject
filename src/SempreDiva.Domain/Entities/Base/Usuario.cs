using System.ComponentModel.DataAnnotations.Schema;

namespace SempreDivas.Domain.Entities.Base
{
    [Table(name: "USUARIO")]
    public class Usuario : EntityBase
    {
        [Nota()]
        [Column(name: "NOME", Order = 2)]
        public string Nome { get; set; }

        [Nota()]
        [Column(name: "EMAIL", Order = 3)]
        public string Email { get; set; }

        [Nota()]
        [Column(name: "SENHA", Order = 4)]
        public string Senha { get; set; }

    }
}
