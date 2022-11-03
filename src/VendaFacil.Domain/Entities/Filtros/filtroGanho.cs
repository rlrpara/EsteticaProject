namespace VendaFacil.Domain.Entities.Filtros
{
    public class filtroGanho : filtroPaginacao
    {
        public string? Descricao { get; set; }
        public int? CodigoCategoria { get; set; }
        public int? CodigoMes { get; set; }
        public int? Ano { get; set; }
        public int? CodigoUsuario { get; set; }
    }
}
