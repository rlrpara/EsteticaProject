namespace Estetica.Domain.Entities.Filtros
{
    public class filtroUsuario : filtroPaginacao
    {
        public string Email { get; set; } = "";
        public string Nome { get; set; } = "";
    }
}
