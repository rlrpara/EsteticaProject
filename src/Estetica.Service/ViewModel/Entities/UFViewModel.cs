namespace Estetica.Service.ViewModel.Entities
{
    public class UFViewModel
    {
        public int Codigo { get; set; }
        public string? Descricao { get; set; }
        public string? Sigla { get; set; }
        public DateTime? DataCadastro { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public bool? Ativo { get; set; }
    }
}
