namespace VendaFacil.Service.ViewModel.Entities
{
    public class CartaoViewModel
    {
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public string? Bandeira { get; set; }
        public string? Numero { get; set; }
        public double Limite { get; set; }
        public int CodigoUsuario { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public bool Ativo { get; set; }
    }
}
