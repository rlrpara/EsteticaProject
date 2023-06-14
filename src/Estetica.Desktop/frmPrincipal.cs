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

        #region [Private Methods]
        private void ObterConfiguracaoPadrao()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            var primaryColor = Primary.Amber800;
            var darkColor = Primary.Amber900;
            var lightColor = Primary.Amber50;
            Accent accentColor = Accent.DeepOrange200;
            var textColor = TextShade.WHITE;
            materialSkinManager.ColorScheme = new ColorScheme(primaryColor, darkColor, lightColor, accentColor, textColor);
        }
        #endregion

        #region [Constructor]
        public frmPrincipal()
        {
            InitializeComponent();
            ConfiguracaoPadrao();
        }

        #endregion

        #region [Public Form Methods]
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            ObterConfiguracaoPadrao();
        }

        #endregion
    }
}