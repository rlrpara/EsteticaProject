namespace VendaFacil.Domain.Entities.Filtros
{
    public class filtroCartao : filtroPaginacao
    {
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public string? Bandeira { get; set; }
        public string? Numero { get; set; }
        public int? CodigoUsuario { get; set; }
        public bool? Ativo { get; set; }
    }
}
