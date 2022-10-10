namespace SempreDivas.Domain.Entities.Base
{
    public class Nota : LayoutRana
    {
        public bool ChavePrimaria { get; set; } = false;
        public bool UsarNoBancoDeDados { get; set; } = true;
        public bool UsarParaBuscar { get; set; } = true;
        public string ChaveEstrangeira { get; set; } = "";
        public int Tamanho { get; set; } = 255;
    }
}
