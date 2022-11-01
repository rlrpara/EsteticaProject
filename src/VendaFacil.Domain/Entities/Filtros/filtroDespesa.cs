namespace VendaFacil.Domain.Entities.Filtros
{
    public class filtroDespesa : filtroPaginacao
    {
        public string? Descricao { get; set; }
        public int? CodigoCategoria { get; set; }
    }
}
