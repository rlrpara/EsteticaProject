using VendaFacil.Infra.Data.Context;

namespace VendaFacil.Infra.Data.Interface
{
    public interface IGeradorDapper
    {
        string? ObterChavePrimaria<T>() where T : class;
        string? ObterNomeTabela<T>() where T : class;
        string? RetornaCamposSelect<T>() where T : class;
        string? RetornaInsert<T>(T entidade) where T : class;
        string? RetornaUpdate<T>(int id, T entidade) where T : class;
        string? RetornaDelete<T>(int id) where T : class;
        string? CriaTabela<T>() where T : class;
        string? GeralSqlSelecaoControles<T>(string? sqlWhere) where T : class;
        string? InserirDadosPadroes<T>() where T : class;
    }
}
