using Estetica.Desktop.formularios;
using Estetica.Infra.Database;
using MaterialSkin2DotNet;
using MaterialSkin2DotNet.Controls;

namespace Estetica.Desktop
{
    public partial class frmPrincipal : MaterialForm
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
            ObterConfiguracaoPadrao();
        }

        private void ObterConfiguracaoPadrao()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            var primaryColor = Primary.Pink800;
            var darkColor = Primary.Pink900;
            var lightColor = Primary.Pink50;
            var accentColor = Accent.LightBlue200;
            var textColor = TextShade.WHITE;
            materialSkinManager.ColorScheme = new ColorScheme(primaryColor, darkColor, lightColor, accentColor, textColor);
        }


        #endregion
    }
}