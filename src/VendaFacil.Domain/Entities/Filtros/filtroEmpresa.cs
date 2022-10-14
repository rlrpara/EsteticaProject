namespace VendaFacil.Domain.Entities.Filtros
{
    public class filtroEmpresa : filtroPaginacao
    {
        public string? Nome { get; set; } = "";
        public string? CpfCnpj { get; set; } = "";
        public string? Telefone { get; set; } = "";
        public string? Email { get; set; } = "";
    }
}
