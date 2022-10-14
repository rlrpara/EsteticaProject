using System.ComponentModel.DataAnnotations.Schema;

namespace VendaFacil.Domain.Entities.Base
{
    [Table(name: "USUARIO")]
    public class Usuario : EntityBase
    {
        [Nota()]
        [Column(name: "NOME", Order = 2)]
        public string? Nome { get; set; }

        [Nota(Tamanho = 50)]
        [Column(name: "EMAIL", Order = 3)]
        public string? Email { get; set; }

        [Nota(Tamanho = 20)]
        [Column(name: "SENHA", Order = 4)]
        public string? Senha { get; set; }

        [Nota(Tamanho = 100)]
        [Column(name: "SENHA_CRIPTOGRAFADA", Order = 5)]
        public string? SenhaCriptografada { get; set; }

        [Nota(Tamanho = 20)]
        [Column(name: "TELEFONE", Order = 6)]
        public string? Telefone { get; set; }

        [Nota(Tamanho = 20)]
        [Column(name: "CELULAR", Order = 7)]
        public string? Celular { get; set; }

        [Nota(Tamanho = 11)]
        [Column(name: "CPF", Order = 8)]
        public string? Cpf { get; set; }

        [Nota()]
        [Column(name: "ENDERECO", Order = 9)]
        public string? Endereco { get; set; }

        [Nota()]
        [Column(name: "FOTO", Order = 10)]
        public string? Foto { get; set; }

        [Nota(Indice = true)]
        [Column(name: "ID_EMPRESA", Order = 11)]
        public int? CodigoEmpresa { get; set; }

        [Nota(Indice = true)]
        [Column(name: "ID_NIVEL", Order = 12)]
        public int? Nivel { get; set; }

    }
}
