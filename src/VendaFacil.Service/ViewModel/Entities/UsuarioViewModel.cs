using VendaFacil.CrossCutting.Util.ExtensionMethods;

namespace VendaFacil.Service.ViewModel.Entities
{
    public class UsuarioViewModel
    {
        private string? _nome;
        private string? _email;
        private string? _senhaCriptografada;
        private string? _telefone;
        private string? _celular;
        private string? _cpf;
        private string? _endereco;
        private int? _codigoEmpresa;
        private int? _nivel;


        public int Codigo { get; set; } = 0;
        public string? Nome
        {
            get { return _nome; }
            set { _nome = value.RemoverAcentos(); }
        }
        public string? Email
        {
            get { return _email; }
            set { _email = value?.ToLower(); }
        }
        public string? Senha { get; set; } = "";
        public string? SenhaCriptografada
        {
            get { return _senhaCriptografada; }
            set { _senhaCriptografada = value; }
        }
        public string? Telefone
        {
            get { return _telefone; }
            set { _telefone = value.ApenasNumeros(); }
        }
        public string? Celular
        {
            get { return _celular; }
            set { _celular = value.ApenasNumeros(); }
        }
        public string? Cpf
        {
            get { return _cpf; }
            set { _cpf = value.ApenasNumeros(); }
        }
        public string? Endereco
        {
            get { return _endereco; }
            set { _endereco = value.RemoverAcentos(); }
        }
        public string? Foto { get; set; } = "";
        public int? CodigoEmpresa
        {
            get { return _codigoEmpresa; }
            set { _codigoEmpresa = value; }
        }
        public int? Nivel
        {
            get { return _nivel; }
            set { _nivel = value.Equals(null) ? 0 : value; }
        }
        public DateTime? DataCadastro { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public bool? Ativo { get; set; }
    }
}
