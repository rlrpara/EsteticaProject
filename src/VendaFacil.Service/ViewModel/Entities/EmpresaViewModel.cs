namespace VendaFacil.Service.ViewModel.Entities
{
    public class EmpresaViewModel
    {
        public int Codigo { get; set; } = 0;
        public string? Nome { get; set; } = "";
        public string? CpfCnpj { get; set; } = "";
        public string? Telefone { get; set; } = "";
        public string? Email { get; set; } = "";
        public string? Endereco { get; set; } = "";
        public double ValorMensal { get; set; } = 50.00;
        public DateTime? DataPagamento { get; set; } = DateTime.Now;
        public DateTime? DataCadastro { get; set; } = DateTime.Now;
        public DateTime? DataAtualizacao { get; set; } = DateTime.Now;
        public bool? Ativo { get; set; } = true;
    }
}
