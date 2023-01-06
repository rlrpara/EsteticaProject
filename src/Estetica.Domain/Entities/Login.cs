using System.ComponentModel.DataAnnotations.Schema;
using Estetica.CrossCutting.Util.ExtensionMethods;
using Estetica.Domain.Entities.Base;

namespace Estetica.Domain.Entities
{
    [Table(name: "USUARIO")]
    public class Login : EntityBase
    {
        private string? _nome;
        private string? _email;
        private string? _senha;


        [Nota(Indice = true)]
        [Column(name: "NOME", Order = 2)]
        public string? Nome
        {
            get { return _nome; }
            set { _nome = value.RemoverAcentos(); }
        }

        [Nota(Tamanho = 50, Indice = true)]
        [Column(name: "EMAIL", Order = 2)]
        public string? Email
        {
            get { return _email; }
            set { _email = value?.ToLower(); }
        }

        [Nota(Tamanho = 20)]
        [Column(name: "SENHA", Order = 3)]
        public string? Senha
        {
            get { return _senha; }
            set { _senha = value; }
        }
    }
}
