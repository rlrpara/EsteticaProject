using System.ComponentModel.DataAnnotations.Schema;
using Estetica.CrossCutting.Util.ExtensionMethods;
using Estetica.Domain.Entities.Base;

namespace Estetica.Domain.Entities
{
    [Table(name: "USUARIO")]
    public class Usuario : EntityBase
    {
        #region [Propriedades Privadas]
        private string? _nome;
        private string? _email;
        private string? _senha;
        #endregion


        [Nota(Indice = true)]
        [Column(name: "NOME", Order = 2)]
        public string? Nome
        {
            get { return _nome; }
            set { _nome = value.RemoverAcentos(); }
        }

        [Nota(Tamanho = 50, Indice = true)]
        [Column(name: "EMAIL", Order = 3)]
        public string? Email
        {
            get { return _email; }
            set { _email = value?.ToLower(); }
        }

        [Nota(Tamanho = 30)]
        [Column(name: "SENHA", Order = 4)]
        public string? Senha
        {
            get { return _senha; }
            set { _senha = value; }
        }

        [Nota(Tamanho = 20)]
        [Column(name: "TELEFONE", Order = 5)]
        public string? Telefone { get; set; }

        [Nota(Tamanho = 20)]
        [Column(name: "CELULAR", Order = 6)]
        public string? Celular { get; set; }

        [Nota(Tamanho = 11, Indice = true)]
        [Column(name: "CPF", Order = 7)]
        public string? Cpf { get; set; }

        [Nota()]
        [Column(name: "ENDERECO", Order = 8)]
        public string? Endereco { get; set; }

        [Nota()]
        [Column(name: "FOTO", Order = 9)]
        public string? Foto { get; set; }

        [Nota(ChaveEstrangeira = "EMPRESA", Indice = true)]
        [Column(name: "ID_EMPRESA", Order = 10)]
        public int? CodigoEmpresa { get; set; }

        [Nota(Indice = true)]
        [Column(name: "ID_NIVEL", Order = 11)]
        public int? Nivel { get; set; }

        [Nota(Indice = true)]
        [Column(name: "PROFISSAO", Order = 11)]
        public string? Profissao { get; set; }
    }
}
