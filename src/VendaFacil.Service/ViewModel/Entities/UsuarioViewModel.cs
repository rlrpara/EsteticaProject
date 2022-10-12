namespace VendaFacil.Service.ViewModel.Entities
{
    public class UsuarioViewModel
    {
        public int Codigo { get; set; } = 0;
        public string Nome { get; set; } = "";
        public string Email { get; set; } = "";
        public string Senha { get; set; } = "";
        public DateTime DataCadastro { get; set; } = DateTime.Now;
        public DateTime DataAtualizacao { get; set; }
        public bool Ativo { get; set; }
    }
}
