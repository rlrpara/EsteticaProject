namespace VendaFacil.Service.ViewModel.Entities
{
    public class UsuarioViewModel
    {
        public int Codigo { get; set; } = 0;
        public string Nome { get; set; } = "";
        public string Email { get; set; } = "";
        public string Senha { get; set; } = "";
        public string SenhaCriptografada { get; set; } = "";
        public string Telefone { get; set; } = "";
        public string Celular { get; set; } = "";
        public string Cpf { get; set; } = "";
        public string Endereco { get; set; } = "";
        public string Foto { get; set; } = "";
        public DateTime DataCadastro { get; set; } = DateTime.Now;
        public DateTime DataAtualizacao { get; set; }
        public bool Ativo { get; set; }
    }
}
