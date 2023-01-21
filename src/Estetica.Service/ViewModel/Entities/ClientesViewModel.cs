namespace Estetica.Service.ViewModel.Entities
{
    public class ClientesViewModel
    {
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public DateTime? Nascimento { get; set; }
        public string? CPF { get; set; }
        public string? Whatsapp { get; set; }
        public string? Email { get; set; }
        public string? Celular { get; set; }
        public string? Foto { get; set; }
        public DateTime? DataCadastro { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public bool? Ativo { get; set; }
    }
}
