namespace Estetica.Service.ViewModel.Entities.Filtros
{
    public class filtroGanhoViewModel : filtroPaginacaoViewModel
    {
        public string? Descricao { get; set; }
        public int? CodigoCategoria { get; set; }
        public int? CodigoMes { get; set; }
        public int? Ano { get; set; }
        public int? CodigoUsuario { get; set; }
    }
}
