namespace Estetica.Service.ViewModel.Entities.Filtros
{
    public class filtroEmpresaViewModel : filtroPaginacaoViewModel
    {
        public string? Nome { get; set; } = "";
        public string? CpfCnpj { get; set; } = "";
        public string? Telefone { get; set; } = "";
        public string? Email { get; set; } = "";
    }
}
