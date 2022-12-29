using Estetica.Desktop.formularios;
using Estetica.Infra.Database;

namespace Estetica.Desktop
{
    public partial class frmPrincipal : Form
    {
        #region [Private Properties]
        private void ConfiguracaoPadrao()
        {
            DotEnvLoad.Load();
            this.WindowState = FormWindowState.Maximized;
            new DatabaseConfiguration().GerenciarBanco();
        }
        #endregion

        #region [Constructor]
        public frmPrincipal()
        {
            InitializeComponent();
            ConfiguracaoPadrao();
        }

        #endregion

        #region [Públic Form Methods]
        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var formulario = new frmClientes();
            formulario.ShowDialog();
        }


        #endregion
    }
}