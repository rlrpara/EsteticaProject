namespace VendaFacil.Domain.Entities.Filtros
{
    public class filtroCategoria : filtroPaginacao
    {
        public int Codigo { get; set; }
        public string? Nome { get; set; }
    }
}
