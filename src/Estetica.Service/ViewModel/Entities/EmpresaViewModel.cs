namespace Estetica.Service.ViewModel.Entities
{
    public class EmpresaViewModel
    {
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public string? CpfCnpj { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
        public string? Endereco { get; set; }
        public double? ValorMensal { get; set; }
        public int? DataPagamento { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public bool? Ativo { get; set; }
    }
}
