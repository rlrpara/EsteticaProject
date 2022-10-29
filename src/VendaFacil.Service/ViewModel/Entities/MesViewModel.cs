namespace VendaFacil.Service.ViewModel.Entities
{
    public class MesViewModel
    {
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public DateTime? DataCadastro { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public bool? Ativo { get; set; }
    }
}
