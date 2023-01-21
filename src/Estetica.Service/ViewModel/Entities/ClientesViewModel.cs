namespace Estetica.Service.ViewModel.Entities
{
    public class ClientesViewModel
    {
        public int Codigo { get; set; }
        public string? NumeroProntuario { get; set; }
        public string? NumeroCartaoFidelidade { get; set; }
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
        public int? CodigoTipoEndereco { get; set; }
        public string? Endereco { get; set; }
        public string? Numero { get; set; }
        public string? Bairro { get; set; }
        public string? Complemento { get; set; }
        public int? CodigoUf { get; set; }
        public string? Cidade { get; set; }
        public string? Observacao { get; set; }
        public bool OrigemIndicacao { get; set; } = false;
        public bool OrigemParcerias { get; set; } = false;
        public bool OrigemProfissional { get; set; } = false;
        public bool OrigemCliente { get; set; } = false;
        public bool OrigemCampanha { get; set; } = false;
        public int CodigoEstabelecimentoOrigem { get; set; } = 1;
        public bool OrigemMarketing { get; set; } = false;
        public string? Naturalidade { get; set; }
        public string? NomePai { get; set; }
        public string? NomeMae { get; set; }
        public string? Profissao { get; set; }
        public string? LocalTrabalho { get; set; }
        public int? CodigoSexo { get; set; }
        public int? CodigoEstadoCivil { get; set; }
        public int? CodigoTipoSnaguineo { get; set; }
        public int? CodigoTipoCliente { get; set; }
        public DateTime? DataCadastro { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public bool? Ativo { get; set; }
    }
}
