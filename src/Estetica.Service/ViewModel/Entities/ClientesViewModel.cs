namespace Estetica.Service.ViewModel.Entities
{
    public class ClientesViewModel
    {
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public DateTime? Nascimento { get; set; }
        public int CodigoTipoPessoa { get; set; } = 1;
        public string? CPFCNPJ { get; set; }
        public string? OraoEmissor { get; set; }
        public int? InscricaoMunicipal { get; set; }
        public int? InscricaoEstadual { get; set; }
        public string? Whatsapp { get; set; }
        public string? Email { get; set; }
        public string? Celular { get; set; }
        public string? Foto { get; set; }
        public int? CEP { get; set; }
        public string? Bairro { get; set; }
        public string? Endereco { get; set; }
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
        public string? UF { get; set; }
        public string? Cidade { get; set; }
        public string? Observacao { get; set; }
        public string? Naturalidade { get; set; }
        public string? NomePai { get; set; }
        public string? NomeMae { get; set; }
        public string? Profissao { get; set; }
        public string? LocalTrabalho { get; set; }
        public int? CodigoSexo { get; set; }
        public int? CodigoEstadoCivil { get; set; }
        public int? CodigoTipoSanguineo { get; set; }
        public int? CodigoEmpresa { get; set; }
        public DateTime? DataCadastro { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public bool? Ativo { get; set; }
    }
}
