namespace VendaFacil.Api.Model
{
    public class ApiResult<T> where T : class
    {
        #region [Propriedades Públicas]
        public IEnumerable<T> Dados { get; private set; }
        public int PaginaAtual { get; private set; }
        public int QuantidadePorPagina { get; private set; }
        #endregion

        #region [Construtor]
        public ApiResult(int paginaAtual, int quantidadePorPagina, IEnumerable<T> dados)
        {
            PaginaAtual = paginaAtual;
            QuantidadePorPagina = quantidadePorPagina;
            Dados = dados;
        }
        #endregion

        #region [Métodos Públicos]
        public dynamic Result() => new { PaginaAtual, QuantidadePorPagina, Dados };
        #endregion
    }
}
