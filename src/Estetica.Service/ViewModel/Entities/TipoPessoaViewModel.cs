namespace Estetica.Service.ViewModel.Entities
{
    public class TipoPessoaViewModel
    {
        public int Codigo { get; set; }
        public string? Descricao { get; set; }
        public DateTime? DataCadastro { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public bool? Ativo { get; set; }
    }
}
