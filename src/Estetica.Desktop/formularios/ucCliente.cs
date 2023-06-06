namespace Estetica.Desktop.formularios
{
    public partial class ucCliente : UserControl
    {
        #region [Constructor]
        public ucCliente()
        {
            InitializeComponent();
        }
        #endregion


        #region [Form Methods]
        private void btnNovo_Click(object sender, EventArgs e)
        {
            var janela = new frmCliente();
            janela.ShowDialog();
        }

        #endregion
    }
}
