using System.Security.Cryptography;
using System.Text.RegularExpressions;
using VendaFacil.CrossCutting.Util.Criptografia;

namespace VendaFacil.CrossCutting.Util.ExtensionMethods
{
    public static class StringExtension
    {
        public static string SepararTitulo(this string? valor)
        {
            var texto = "";

            foreach (var item in valor.ToCharArray().ToList())
                texto += char.IsUpper(item) ? $" {item}" : $"{item}";

            return texto.Trim();
        }
        public static string RemoverAcentos(this string? texto)
        {
            /** Troca os caracteres acentuados por não acentuados **/
            string[] acentos = new string[] { "ç", "Ç", "á", "é", "í", "ó", "ú", "ý", "Á", "É", "Í", "Ó", "Ú", "Ý", "à", "è", "ì", "ò", "ù", "À", "È", "Ì", "Ò", "Ù", "ã", "õ", "ñ", "ä", "ë", "ï", "ö", "ü", "ÿ", "Ä", "Ë", "Ï", "Ö", "Ü", "Ã", "Õ", "Ñ", "â", "ê", "î", "ô", "û", "Â", "Ê", "Î", "Ô", "Û" };
            string[] semAcento = new string[] { "c", "C", "a", "e", "i", "o", "u", "y", "A", "E", "I", "O", "U", "Y", "a", "e", "i", "o", "u", "A", "E", "I", "O", "U", "a", "o", "n", "a", "e", "i", "o", "u", "y", "A", "E", "I", "O", "U", "A", "O", "N", "a", "e", "i", "o", "u", "A", "E", "I", "O", "U" };

            for (int i = 0; i < acentos.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(texto))
                    texto = texto.Replace(acentos[i], semAcento[i]);
            }
            /** Troca os caracteres especiais da string por "" **/
            string[] caracteresEspeciais = { "¹", "²", "³", "£", "¢", "¬", "º", "¨", "\"", "'", ":", "(", ")", "ª", "|", "\\\\", "°", "_", "@", "#", "!", "$", "%", "&", "*", ";", "/", "<", ">", "?", "[", "]", "{", "}", "=", "+", "§", "´", "`", "^", "~" };

            for (int i = 0; i < caracteresEspeciais.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(texto))
                    texto = texto.Replace(caracteresEspeciais[i], "");
            }

            return texto?.Trim().ToUpper() ?? "";
        }
        public static string ApenasTexto(this string? valor) => (valor == null) ? "" : new Regex(@"[^a-zA-Z]").Replace(valor, "").ToString();
        public static string ApenasNumeros(this string? valor, string valorPadrao = "0")
        {
            if (!string.IsNullOrEmpty(valor?.Trim()))
            {
                var valorAlterado = new Regex(@"[^0-9]").Replace(valor, "").ToString();
                return string.IsNullOrEmpty(valorAlterado) ? valorPadrao : valorAlterado;
            }
            else
                return "0";
        }
        public static DateTime? DataPadrao(this string valor, string dataPadrao) => Convert.ToDateTime(string.IsNullOrWhiteSpace(valor) ? dataPadrao : valor);
        public static bool PisValido(this string numeroPis)
        {
            int[] multiplicador = new int[10] { 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            if (numeroPis?.Trim().ApenasNumeros().Length != 11)
                return false;
            numeroPis = numeroPis.Trim();
            numeroPis = numeroPis.Replace("-", "").Replace(".", "").PadLeft(11, '0');

            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(numeroPis[i].ToString()) * multiplicador[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            return numeroPis.EndsWith(resto.ToString());
        }
        public static string AplicarCriptografia(this string valor)
        {
            if (!string.IsNullOrWhiteSpace(valor))
                return new CriptoHash(SHA512.Create()).CriptografarSenha(valor);
            return valor;
        }
    }
}
