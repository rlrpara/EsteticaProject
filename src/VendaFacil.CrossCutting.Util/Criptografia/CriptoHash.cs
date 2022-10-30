using System.Security.Cryptography;
using System.Text;

namespace VendaFacil.CrossCutting.Util.Criptografia
{
    public class CriptoHash
    {
        private HashAlgorithm _algoritmo;

        public CriptoHash(HashAlgorithm algoritmo)
        {
            _algoritmo = algoritmo;
        }

        public string CriptografarSenha(string senha)
        {
            var encodedValue = Encoding.UTF8.GetBytes(senha);
            var encryptedPassword = _algoritmo.ComputeHash(encodedValue);

            var sb = new StringBuilder();
            encryptedPassword.ToList().ForEach(x => sb.Append(x.ToString("X2")));
            return sb.ToString();
        }

        public bool VerificarSenha(string senhaDigitada, string senhaCadastrada)
        {
            if (string.IsNullOrEmpty(senhaCadastrada))
                return false;

            var encryptedPassword = _algoritmo.ComputeHash(Encoding.UTF8.GetBytes(senhaDigitada));

            var stringBuilder = new StringBuilder();
            encryptedPassword.ToList().ForEach(x => stringBuilder.Append(x.ToString("X2")));
            return stringBuilder.ToString() == senhaCadastrada;
        }
    }
}
