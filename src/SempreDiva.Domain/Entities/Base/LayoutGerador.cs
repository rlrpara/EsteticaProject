using SempreDiva.Domain.Enumerables;

namespace SempreDiva.Domain.Entities.Base
{
    public class LayoutRana : Attribute
    {
        public int IniciarEm { get; set; }
        public int TerminarEm { get; set; }
        public string Formatacao { get; set; }
        public string ValorPadrao { get; set; }
        public EAlinhamento Alinhamento { get; set; }
    }
}
