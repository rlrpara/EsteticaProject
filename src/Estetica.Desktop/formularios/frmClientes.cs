using AutoMapper;
using Estetica.Domain.Entities;
using Estetica.Domain.Entities.Filtros;
using Estetica.Domain.Interface;
using Estetica.Infra.Data.Repositories;
using Estetica.Service.Interface;
using Estetica.Service.Service;

namespace Estetica.Desktop.formularios
{
    public partial class frmClientes : Form
    {
        private IBaseRepository _baseRepository;
        private IClientesService _clientesService;
        private IMapper _mapper;

        private void ObterConfiguracoesServices()
        {
            _baseRepository = new BaseRepository();
            _clientesService = new ClientesService(_baseRepository);
        }

        public frmClientes()
        {
            InitializeComponent();
            ObterConfiguracoesServices();
        }

        

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var filtro = new filtroClientes()
            {
                Nome = ""
            };
            var listaClientes = _clientesService.ObterTodos(filtro);

            dgvDados.DataSource = "";
            dgvDados.DataSource = listaClientes;

        }
    }
}
