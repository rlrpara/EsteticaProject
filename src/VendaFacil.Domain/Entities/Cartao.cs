using System.ComponentModel.DataAnnotations.Schema;
using VendaFacil.CrossCutting.Util.ExtensionMethods;
using VendaFacil.Domain.Entities.Base;

namespace VendaFacil.Domain.Entities
{
    [Table(name: "CARTAO")]
    public class Cartao
    {
		#region [Propriedades Privadas]
		private string? _nome;
        private string? _bandeira;
        private string? _numero;
        private double _limite;
        private int _codigoUsuario;
        #endregion

        [Nota()]
        [Column(name: "NOME", Order = 2)]
        public string? Nome
		{
			get { return _nome; }
			set { _nome = value; }
		}

        [Nota()]
        [Column(name: "BANDEIRA", Order = 3)]
        public string? Bandeira
		{
			get { return _bandeira; }
			set { _bandeira = value.RemoverAcentos(); }
		}

        [Nota()]
        [Column(name: "NUMER", Order = 4)]
        public string? Numero
		{
			get { return _numero; }
			set { _numero = value.ApenasNumeros(); }
		}

        [Nota()]
        [Column(name: "LIMITE", Order = 5)]
        public double Limite
		{
			get { return _limite; }
			set { _limite = value; }
		}

        [Nota(ChaveEstrangeira = "USUARIO", Indice = true)]
        [Column(name: "ID_USUARIO", Order = 6)]
		public int CodigoUsuario
		{
			get { return _codigoUsuario; }
			set { _codigoUsuario = value; }
		}
	}
}
