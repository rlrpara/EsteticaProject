namespace VendaFacil.Service.ViewModel.Entities
{
    public class ProdutoServicoViewModel
    {
        public int Codigo { get; set; }
        public int CodigoCategoria { get; set; }
        public string? Descricao { get; set; }
        public int? NumeroSessoes { get; set; }
        public double? ValorUnitario { get; set; }
        public DateTime? DataCadastro { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public bool? Ativo { get; set; }
    }
}
