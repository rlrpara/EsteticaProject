using MaterialSkin2DotNet.Controls;

namespace Estetica.Desktop.formularios
{
    public partial class frmCliente : MaterialForm
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void btnCalendario_Click(object sender, EventArgs e)
        {
            mcCalendario.Visible = !mcCalendario.Visible;
        }

        private void mcCalendario_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (DateTime.TryParse(mcCalendario.SelectionEnd.ToString(), out DateTime value))
            {
                txtNascimento.Text = mcCalendario.SelectionStart.ToString();
                mcCalendario.Visible = false;
            }
        }

        private void mcCalendario_MouseLeave(object sender, EventArgs e)
        {
            mcCalendario.Visible = false;
        }
    }
}
