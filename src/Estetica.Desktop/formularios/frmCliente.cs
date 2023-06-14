using Estetica.CrossCutting.Util.ExtensionMethods;
using MaterialSkin2DotNet.Controls;

namespace Estetica.Desktop.formularios
{
    public partial class frmCliente : MaterialForm
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            cmbTipoPessoa_TextChanged(sender, e);
        }

        private void cmbTipoPessoa_TextChanged(object sender, EventArgs e)
        {
            var valor = txtCpfCnpj.Text;

            txtCpfCnpj.Clear();

            if (cmbTipoPessoa.SelectedIndex == 0)
            {
                txtIERG.Hint = "RG";
                txtCpfCnpj.Hint = "CPF";
                txtIE.Visible = false;
                txtCpfCnpj.Mask = "999,999,999-99";
            }
            else
            {
                txtIERG.Hint = "IE";
                txtCpfCnpj.Hint = "CNPJ";
                txtIE.Visible = true;
                txtCpfCnpj.Mask = "99,999,999/9999-99";
            }

            txtCpfCnpj.Text = valor;

            txtCpfCnpj_Validating(sender, new System.ComponentModel.CancelEventArgs());
        }

        private void txtCpfCnpj_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCpfCnpj.Text))
            {
                if (cmbTipoPessoa.SelectedIndex == 0)
                {
                    if (txtCpfCnpj.Text.ApenasNumeros().Length <= 11 && txtCpfCnpj.Text.ApenasNumeros().IsCpf())
                        imgCpfValido.Image = Properties.Resources.ok_green;
                    else
                        imgCpfValido.Image = Properties.Resources.ok_red;
                }
                else
                {
                    if (txtCpfCnpj.Text.ApenasNumeros().Length <= 14 && txtCpfCnpj.Text.ApenasNumeros().IsCnpj())
                        imgCpfValido.Image = Properties.Resources.ok_green;
                    else
                        imgCpfValido.Image = Properties.Resources.ok_red;
                }
            }
        }
    }
}
