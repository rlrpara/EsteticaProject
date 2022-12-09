using Estetica.Service.ViewModel.Entities;
using Estetica.Service.ViewModel.Entities.Filtros;

namespace Estetica.Service.Interface
{
    public interface IEmpresaService : IBaseService
    {
        int ObterTotalRegistros(filtroEmpresaViewModel filtro);
        bool ObterEntidade(EmpresaViewModel model);
        EmpresaViewModel ObterPorCodigo(int codigo);
        IEnumerable<EmpresaViewModel> ObterTodos(filtroEmpresaViewModel filtro);
        bool Inserir(EmpresaViewModel model);
        bool Atualizar(EmpresaViewModel model);
        bool Deletar(EmpresaViewModel model);
    }
}
