using System.ComponentModel.DataAnnotations.Schema;
using VendaFacil.CrossCutting.Util.ExtensionMethods;
using VendaFacil.Domain.Entities.Base;

namespace VendaFacil.Domain.Entities
{
    [Table(name: "GANHO")]
    public class Ganho :EntityBase
    {
		#region [Propriedades Privadas]
		private string? _descricao;
        private int _codigoCategoria;
        private double _valor;
        private int _dia;
        private int _codigoMes;
        private int _ano;
        private int _codigoUsuario;
        #endregion

        [Nota()]
        [Column(name: "DESCRICAO", Order = 2)]
        public string? Descricao
		{
			get { return _descricao; }
			set { _descricao = value.RemoverAcentos(); }
		}

        [Nota(ChaveEstrangeira = "CATEGORIA", Indice = true)]
        [Column(name: "ID_CATEGORIA", Order = 3)]
        public int CodigoCategoria
		{
			get { return _codigoCategoria; }
			set { _codigoCategoria = value; }
		}

        [Nota()]
        [Column(name: "VALOR", Order = 4)]
        public double Valor
		{
			get { return _valor; }
			set { _valor = value; }
		}

        [Nota(Indice = true)]
        [Column(name: "DIA", Order = 5)]
        public int Dia
		{
			get { return _dia; }
			set { _dia = value; }
		}

        [Nota(ChaveEstrangeira = "MES", Indice = true)]
        [Column(name: "ID_MES", Order = 6)]
        public int CodigoMes
		{
			get { return _codigoMes; }
			set { _codigoMes = value; }
		}

        [Nota(Indice = true)]
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
