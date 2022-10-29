namespace VendaFacil.Service.ViewModel.Entities
{
    public class CategoriaViewModel
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Icone { get; set; }
        public int CodigoTipo { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public bool Ativo { get; set; }
    }
}
