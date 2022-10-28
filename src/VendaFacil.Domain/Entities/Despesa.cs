using System.ComponentModel.DataAnnotations.Schema;
using VendaFacil.CrossCutting.Util.ExtensionMethods;
using VendaFacil.Domain.Entities.Base;

namespace VendaFacil.Domain.Entities
{
    [Table(name: "DESPESA")]
    public class Despesa : EntityBase
    {
		#region [Propriedades Privadas]
		private int _codigoCartao;
        private string? _descricao;
        private int _codigoCategoria;
        private double _valor;
        private int codigoMes;
        private int _ano;
        private int _codigoUsuario;
        #endregion

        [Nota(ChaveEstrangeira = "CARTAO", Indice = true)]
        [Column(name: "ID_CARTAO", Order = 2)]
        public int CodigoCartao
		{
			get { return _codigoCartao; }
			set { _codigoCartao = value; }
		}

        [Nota()]
        [Column(name: "DESCRICAO", Order = 3)]
        public string? Descricao
		{
			get { return _descricao; }
			set { _descricao = value.RemoverAcentos(); }
		}

        [Nota(ChaveEstrangeira = "CATEGORIA", Indice = true)]
        [Column(name: "ID_CATEGORIA", Order = 4)]
        public int CodigoCategoria
		{
			get { return _codigoCategoria; }
			set { _codigoCategoria = value; }
		}

        [Nota()]
        [Column(name: "VALOR", Order = 5)]
        public double Valor
		{
			get { return _valor; }
			set { _valor = value; }
		}

        [Nota(ChaveEstrangeira = "MES", Indice = true)]
        [Column(name: "ID_MES", Order = 6)]
        public int CodigoMes
		{
			get { return codigoMes; }
			set { codigoMes = value; }
		}

        [Nota()]
        [Column(name: "ANO", Order = 7)]
        public int Ano
		{
			get { return _ano; }
			set { _ano = value; }
		}

        [Nota(ChaveEstrangeira = "USUARIO", Indice = true)]
        [Column(name: "ID_USUARIO", Order = 8)]
        public int CodigoUsuario
		{
			get { return _codigoUsuario; }
			set { _codigoUsuario = value; }
		}

	}
}
