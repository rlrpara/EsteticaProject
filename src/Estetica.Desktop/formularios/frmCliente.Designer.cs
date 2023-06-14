namespace Estetica.Desktop.formularios
{
    partial class frmCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            materialTabControl1 = new MaterialSkin2DotNet.Controls.MaterialTabControl();
            tabFichaCadastral = new TabPage();
            panel3 = new Panel();
            panel7 = new Panel();
            txtWhatsapp = new MaterialSkin2DotNet.Controls.MaterialMaskedTextBox();
            panel6 = new Panel();
            txtIE = new MaterialSkin2DotNet.Controls.MaterialTextBox2();
            txtOrgaoExpedicao = new MaterialSkin2DotNet.Controls.MaterialTextBox2();
            txtRgExpedicao = new MaterialSkin2DotNet.Controls.MaterialMaskedTextBox();
            txtIERG = new MaterialSkin2DotNet.Controls.MaterialTextBox2();
            panel5 = new Panel();
            imgCpfValido = new PictureBox();
            txtCpfCnpj = new MaterialSkin2DotNet.Controls.MaterialMaskedTextBox();
            cmbTipoPessoa = new MaterialSkin2DotNet.Controls.MaterialComboBox();
            panel2 = new Panel();
            txtNome = new MaterialSkin2DotNet.Controls.MaterialTextBox2();
            panel1 = new Panel();
            txtCodigo = new MaterialSkin2DotNet.Controls.MaterialTextBox2();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            tabDebitos = new TabPage();
            imageList1 = new ImageList(components);
            materialTabControl1.SuspendLayout();
            tabFichaCadastral.SuspendLayout();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgCpfValido).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tabFichaCadastral);
            materialTabControl1.Controls.Add(tabDebitos);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialTabControl1.ImageList = imageList1;
            materialTabControl1.Location = new Point(3, 64);
            materialTabControl1.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(1408, 683);
            materialTabControl1.TabIndex = 0;
            // 
            // tabFichaCadastral
            // 
            tabFichaCadastral.AutoScroll = true;
            tabFichaCadastral.BackColor = Color.FromArgb(242, 242, 242);
            tabFichaCadastral.Controls.Add(panel3);
            tabFichaCadastral.ImageKey = "dados_pessoais.png";
            tabFichaCadastral.Location = new Point(4, 31);
            tabFichaCadastral.Name = "tabFichaCadastral";
            tabFichaCadastral.Padding = new Padding(3);
            tabFichaCadastral.Size = new Size(1400, 648);
            tabFichaCadastral.TabIndex = 0;
            tabFichaCadastral.Text = "Ficha cadastral";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(242, 242, 242);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Top;
            panel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            panel3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1394, 261);
            panel3.TabIndex = 2;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(242, 242, 242);
            panel7.Controls.Add(txtWhatsapp);
            panel7.Dock = DockStyle.Top;
            panel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            panel7.ForeColor = Color.FromArgb(222, 0, 0, 0);
            panel7.Location = new Point(0, 208);
            panel7.Name = "panel7";
            panel7.Size = new Size(1142, 52);
            panel7.TabIndex = 8;
            // 
            // txtWhatsapp
            // 
            txtWhatsapp.AllowPromptAsInput = true;
            txtWhatsapp.AnimateReadOnly = false;
            txtWhatsapp.AsciiOnly = false;
            txtWhatsapp.BackColor = Color.FromArgb(242, 242, 242);
            txtWhatsapp.BackgroundImageLayout = ImageLayout.None;
            txtWhatsapp.BeepOnError = false;
            txtWhatsapp.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtWhatsapp.Depth = 0;
            txtWhatsapp.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtWhatsapp.HidePromptOnLeave = false;
            txtWhatsapp.HideSelection = true;
            txtWhatsapp.Hint = "Whatsapp";
            txtWhatsapp.InsertKeyMode = InsertKeyMode.Default;
            txtWhatsapp.LeadingIcon = null;
            txtWhatsapp.Location = new Point(8, 2);
            txtWhatsapp.Mask = "(999)99999-9999";
            txtWhatsapp.MaxLength = 32767;
            txtWhatsapp.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            txtWhatsapp.Name = "txtWhatsapp";
            txtWhatsapp.PasswordChar = '\0';
            txtWhatsapp.PrefixSuffixText = null;
            txtWhatsapp.PromptChar = '_';
            txtWhatsapp.ReadOnly = false;
            txtWhatsapp.RejectInputOnFirstFailure = false;
            txtWhatsapp.ResetOnPrompt = true;
            txtWhatsapp.ResetOnSpace = true;
            txtWhatsapp.RightToLeft = RightToLeft.No;
            txtWhatsapp.SelectedText = "";
            txtWhatsapp.SelectionLength = 0;
            txtWhatsapp.SelectionStart = 0;
            txtWhatsapp.ShortcutsEnabled = true;
            txtWhatsapp.Size = new Size(193, 48);
            txtWhatsapp.SkipLiterals = true;
            txtWhatsapp.TabIndex = 3;
            txtWhatsapp.TabStop = false;
            txtWhatsapp.Text = "(   )     -";
            txtWhatsapp.TextAlign = HorizontalAlignment.Left;
            txtWhatsapp.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtWhatsapp.TrailingIcon = null;
            txtWhatsapp.UseSystemPasswordChar = false;
            txtWhatsapp.ValidatingType = null;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(242, 242, 242);
            panel6.Controls.Add(txtIE);
            panel6.Controls.Add(txtOrgaoExpedicao);
            panel6.Controls.Add(txtRgExpedicao);
            panel6.Controls.Add(txtIERG);
            panel6.Dock = DockStyle.Top;
            panel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            panel6.ForeColor = Color.FromArgb(222, 0, 0, 0);
            panel6.Location = new Point(0, 156);
            panel6.Name = "panel6";
            panel6.Size = new Size(1142, 52);
            panel6.TabIndex = 7;
            // 
            // txtIE
            // 
            txtIE.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtIE.AnimateReadOnly = false;
            txtIE.AutoCompleteMode = AutoCompleteMode.None;
            txtIE.AutoCompleteSource = AutoCompleteSource.None;
            txtIE.BackColor = Color.FromArgb(242, 242, 242);
            txtIE.BackgroundImageLayout = ImageLayout.None;
            txtIE.CharacterCasing = CharacterCasing.Upper;
            txtIE.Depth = 0;
            txtIE.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtIE.HideSelection = true;
            txtIE.Hint = "IE";
            txtIE.LeadingIcon = null;
            txtIE.Location = new Point(707, 2);
            txtIE.MaxLength = 32767;
            txtIE.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            txtIE.Name = "txtIE";
            txtIE.PasswordChar = '\0';
            txtIE.PrefixSuffixText = null;
            txtIE.ReadOnly = false;
            txtIE.RightToLeft = RightToLeft.No;
            txtIE.SelectedText = "";
            txtIE.SelectionLength = 0;
            txtIE.SelectionStart = 0;
            txtIE.ShortcutsEnabled = true;
            txtIE.Size = new Size(243, 48);
            txtIE.TabIndex = 4;
            txtIE.TabStop = false;
            txtIE.TextAlign = HorizontalAlignment.Left;
            txtIE.TrailingIcon = null;
            txtIE.UseSystemPasswordChar = false;
            // 
            // txtOrgaoExpedicao
            // 
            txtOrgaoExpedicao.AnimateReadOnly = false;
            txtOrgaoExpedicao.AutoCompleteMode = AutoCompleteMode.None;
            txtOrgaoExpedicao.AutoCompleteSource = AutoCompleteSource.None;
            txtOrgaoExpedicao.BackColor = Color.FromArgb(242, 242, 242);
            txtOrgaoExpedicao.BackgroundImageLayout = ImageLayout.None;
            txtOrgaoExpedicao.CharacterCasing = CharacterCasing.Normal;
            txtOrgaoExpedicao.Depth = 0;
            txtOrgaoExpedicao.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtOrgaoExpedicao.HideSelection = true;
            txtOrgaoExpedicao.Hint = "Órgão Expedição";
            txtOrgaoExpedicao.LeadingIcon = null;
            txtOrgaoExpedicao.Location = new Point(451, 2);
            txtOrgaoExpedicao.MaxLength = 32767;
            txtOrgaoExpedicao.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            txtOrgaoExpedicao.Name = "txtOrgaoExpedicao";
            txtOrgaoExpedicao.PasswordChar = '\0';
            txtOrgaoExpedicao.PrefixSuffixText = null;
            txtOrgaoExpedicao.ReadOnly = false;
            txtOrgaoExpedicao.RightToLeft = RightToLeft.No;
            txtOrgaoExpedicao.SelectedText = "";
            txtOrgaoExpedicao.SelectionLength = 0;
            txtOrgaoExpedicao.SelectionStart = 0;
            txtOrgaoExpedicao.ShortcutsEnabled = true;
            txtOrgaoExpedicao.Size = new Size(250, 48);
            txtOrgaoExpedicao.TabIndex = 3;
            txtOrgaoExpedicao.TabStop = false;
            txtOrgaoExpedicao.TextAlign = HorizontalAlignment.Left;
            txtOrgaoExpedicao.TrailingIcon = null;
            txtOrgaoExpedicao.UseSystemPasswordChar = false;
            // 
            // txtRgExpedicao
            // 
            txtRgExpedicao.AllowPromptAsInput = true;
            txtRgExpedicao.AnimateReadOnly = false;
            txtRgExpedicao.AsciiOnly = false;
            txtRgExpedicao.BackColor = Color.FromArgb(242, 242, 242);
            txtRgExpedicao.BackgroundImageLayout = ImageLayout.None;
            txtRgExpedicao.BeepOnError = false;
            txtRgExpedicao.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtRgExpedicao.Depth = 0;
            txtRgExpedicao.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtRgExpedicao.HidePromptOnLeave = false;
            txtRgExpedicao.HideSelection = true;
            txtRgExpedicao.Hint = "Data Expedição";
            txtRgExpedicao.InsertKeyMode = InsertKeyMode.Default;
            txtRgExpedicao.LeadingIcon = null;
            txtRgExpedicao.Location = new Point(252, 2);
            txtRgExpedicao.Mask = "99/99/9999";
            txtRgExpedicao.MaxLength = 32767;
            txtRgExpedicao.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            txtRgExpedicao.Name = "txtRgExpedicao";
            txtRgExpedicao.PasswordChar = '\0';
            txtRgExpedicao.PrefixSuffixText = null;
            txtRgExpedicao.PromptChar = '_';
            txtRgExpedicao.ReadOnly = false;
            txtRgExpedicao.RejectInputOnFirstFailure = false;
            txtRgExpedicao.ResetOnPrompt = true;
            txtRgExpedicao.ResetOnSpace = true;
            txtRgExpedicao.RightToLeft = RightToLeft.No;
            txtRgExpedicao.SelectedText = "";
            txtRgExpedicao.SelectionLength = 0;
            txtRgExpedicao.SelectionStart = 0;
            txtRgExpedicao.ShortcutsEnabled = true;
            txtRgExpedicao.Size = new Size(193, 48);
            txtRgExpedicao.SkipLiterals = true;
            txtRgExpedicao.TabIndex = 2;
            txtRgExpedicao.TabStop = false;
            txtRgExpedicao.Text = "  /  /";
            txtRgExpedicao.TextAlign = HorizontalAlignment.Left;
            txtRgExpedicao.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtRgExpedicao.TrailingIcon = null;
            txtRgExpedicao.UseSystemPasswordChar = false;
            txtRgExpedicao.ValidatingType = null;
            // 
            // txtIERG
            // 
            txtIERG.AnimateReadOnly = false;
            txtIERG.AutoCompleteMode = AutoCompleteMode.None;
            txtIERG.AutoCompleteSource = AutoCompleteSource.None;
            txtIERG.BackColor = Color.FromArgb(242, 242, 242);
            txtIERG.BackgroundImageLayout = ImageLayout.None;
            txtIERG.CharacterCasing = CharacterCasing.Upper;
            txtIERG.Depth = 0;
            txtIERG.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtIERG.HideSelection = true;
            txtIERG.Hint = "RG";
            txtIERG.LeadingIcon = null;
            txtIERG.Location = new Point(7, 2);
            txtIERG.MaxLength = 32767;
            txtIERG.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            txtIERG.Name = "txtIERG";
            txtIERG.PasswordChar = '\0';
            txtIERG.PrefixSuffixText = null;
            txtIERG.ReadOnly = false;
            txtIERG.RightToLeft = RightToLeft.No;
            txtIERG.SelectedText = "";
            txtIERG.SelectionLength = 0;
            txtIERG.SelectionStart = 0;
            txtIERG.ShortcutsEnabled = true;
            txtIERG.Size = new Size(239, 48);
            txtIERG.TabIndex = 1;
            txtIERG.TabStop = false;
            txtIERG.TextAlign = HorizontalAlignment.Left;
            txtIERG.TrailingIcon = null;
            txtIERG.UseSystemPasswordChar = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(242, 242, 242);
            panel5.Controls.Add(imgCpfValido);
            panel5.Controls.Add(txtCpfCnpj);
            panel5.Controls.Add(cmbTipoPessoa);
            panel5.Dock = DockStyle.Top;
            panel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            panel5.ForeColor = Color.FromArgb(222, 0, 0, 0);
            panel5.Location = new Point(0, 104);
            panel5.Name = "panel5";
            panel5.Size = new Size(1142, 52);
            panel5.TabIndex = 6;
            // 
            // imgCpfValido
            // 
            imgCpfValido.BackColor = Color.FromArgb(242, 242, 242);
            imgCpfValido.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            imgCpfValido.ForeColor = Color.FromArgb(222, 0, 0, 0);
            imgCpfValido.Image = Properties.Resources.ok_cinza;
            imgCpfValido.Location = new Point(600, 11);
            imgCpfValido.Name = "imgCpfValido";
            imgCpfValido.Size = new Size(29, 30);
            imgCpfValido.TabIndex = 2;
            imgCpfValido.TabStop = false;
            // 
            // txtCpfCnpj
            // 
            txtCpfCnpj.AllowPromptAsInput = true;
            txtCpfCnpj.AnimateReadOnly = false;
            txtCpfCnpj.AsciiOnly = false;
            txtCpfCnpj.BackColor = Color.FromArgb(242, 242, 242);
            txtCpfCnpj.BackgroundImageLayout = ImageLayout.None;
            txtCpfCnpj.BeepOnError = false;
            txtCpfCnpj.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtCpfCnpj.Depth = 0;
            txtCpfCnpj.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCpfCnpj.HidePromptOnLeave = false;
            txtCpfCnpj.HideSelection = true;
            txtCpfCnpj.Hint = "CPF";
            txtCpfCnpj.InsertKeyMode = InsertKeyMode.Default;
            txtCpfCnpj.LeadingIcon = null;
            txtCpfCnpj.Location = new Point(252, 2);
            txtCpfCnpj.Mask = "";
            txtCpfCnpj.MaxLength = 32767;
            txtCpfCnpj.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            txtCpfCnpj.Name = "txtCpfCnpj";
            txtCpfCnpj.PasswordChar = '\0';
            txtCpfCnpj.PrefixSuffixText = null;
            txtCpfCnpj.PromptChar = '_';
            txtCpfCnpj.ReadOnly = false;
            txtCpfCnpj.RejectInputOnFirstFailure = false;
            txtCpfCnpj.ResetOnPrompt = true;
            txtCpfCnpj.ResetOnSpace = true;
            txtCpfCnpj.RightToLeft = RightToLeft.No;
            txtCpfCnpj.SelectedText = "";
            txtCpfCnpj.SelectionLength = 0;
            txtCpfCnpj.SelectionStart = 0;
            txtCpfCnpj.ShortcutsEnabled = true;
            txtCpfCnpj.Size = new Size(342, 48);
            txtCpfCnpj.SkipLiterals = true;
            txtCpfCnpj.TabIndex = 1;
            txtCpfCnpj.TabStop = false;
            txtCpfCnpj.TextAlign = HorizontalAlignment.Left;
            txtCpfCnpj.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtCpfCnpj.TrailingIcon = null;
            txtCpfCnpj.UseSystemPasswordChar = false;
            txtCpfCnpj.ValidatingType = null;
            txtCpfCnpj.Validating += txtCpfCnpj_Validating;
            // 
            // cmbTipoPessoa
            // 
            cmbTipoPessoa.AutoResize = false;
            cmbTipoPessoa.BackColor = Color.FromArgb(242, 242, 242);
            cmbTipoPessoa.Depth = 0;
            cmbTipoPessoa.DrawMode = DrawMode.OwnerDrawVariable;
            cmbTipoPessoa.DropDownHeight = 174;
            cmbTipoPessoa.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoPessoa.DropDownWidth = 121;
            cmbTipoPessoa.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbTipoPessoa.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbTipoPessoa.FormattingEnabled = true;
            cmbTipoPessoa.IntegralHeight = false;
            cmbTipoPessoa.ItemHeight = 43;
            cmbTipoPessoa.Items.AddRange(new object[] { "FÍSICA", "JURÍDICA" });
            cmbTipoPessoa.Location = new Point(8, 1);
            cmbTipoPessoa.MaxDropDownItems = 4;
            cmbTipoPessoa.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            cmbTipoPessoa.Name = "cmbTipoPessoa";
            cmbTipoPessoa.Size = new Size(238, 49);
            cmbTipoPessoa.StartIndex = 0;
            cmbTipoPessoa.TabIndex = 0;
            cmbTipoPessoa.TextChanged += cmbTipoPessoa_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(242, 242, 242);
            panel2.Controls.Add(txtNome);
            panel2.Dock = DockStyle.Top;
            panel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            panel2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            panel2.Location = new Point(0, 52);
            panel2.Name = "panel2";
            panel2.Size = new Size(1142, 52);
            panel2.TabIndex = 5;
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNome.AnimateReadOnly = false;
            txtNome.AutoCompleteMode = AutoCompleteMode.None;
            txtNome.AutoCompleteSource = AutoCompleteSource.None;
            txtNome.BackColor = Color.FromArgb(242, 242, 242);
            txtNome.BackgroundImageLayout = ImageLayout.None;
            txtNome.CharacterCasing = CharacterCasing.Upper;
            txtNome.Depth = 0;
            txtNome.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNome.HideSelection = true;
            txtNome.Hint = "Nome";
            txtNome.LeadingIcon = null;
            txtNome.Location = new Point(8, 3);
            txtNome.MaxLength = 32767;
            txtNome.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            txtNome.Name = "txtNome";
            txtNome.PasswordChar = '\0';
            txtNome.PrefixSuffixText = null;
            txtNome.ReadOnly = false;
            txtNome.RightToLeft = RightToLeft.No;
            txtNome.SelectedText = "";
            txtNome.SelectionLength = 0;
            txtNome.SelectionStart = 0;
            txtNome.ShortcutsEnabled = true;
            txtNome.Size = new Size(1128, 48);
            txtNome.TabIndex = 0;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(242, 242, 242);
            panel1.Controls.Add(txtCodigo);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            panel1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1142, 52);
            panel1.TabIndex = 4;
            // 
            // txtCodigo
            // 
            txtCodigo.AnimateReadOnly = false;
            txtCodigo.AutoCompleteMode = AutoCompleteMode.None;
            txtCodigo.AutoCompleteSource = AutoCompleteSource.None;
            txtCodigo.BackColor = Color.FromArgb(242, 242, 242);
            txtCodigo.BackgroundImageLayout = ImageLayout.None;
            txtCodigo.CharacterCasing = CharacterCasing.Upper;
            txtCodigo.Depth = 0;
            txtCodigo.Enabled = false;
            txtCodigo.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCodigo.HideSelection = true;
            txtCodigo.Hint = "Código";
            txtCodigo.LeadingIcon = null;
            txtCodigo.Location = new Point(8, 3);
            txtCodigo.MaxLength = 32767;
            txtCodigo.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.PasswordChar = '\0';
            txtCodigo.PrefixSuffixText = null;
            txtCodigo.ReadOnly = false;
            txtCodigo.RightToLeft = RightToLeft.No;
            txtCodigo.SelectedText = "";
            txtCodigo.SelectionLength = 0;
            txtCodigo.SelectionStart = 0;
            txtCodigo.ShortcutsEnabled = true;
            txtCodigo.Size = new Size(178, 48);
            txtCodigo.TabIndex = 0;
            txtCodigo.TabStop = false;
            txtCodigo.TextAlign = HorizontalAlignment.Left;
            txtCodigo.TrailingIcon = null;
            txtCodigo.UseSystemPasswordChar = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(242, 242, 242);
            panel4.Controls.Add(pictureBox1);
            panel4.Dock = DockStyle.Right;
            panel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            panel4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            panel4.Location = new Point(1142, 0);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(10);
            panel4.Size = new Size(252, 261);
            panel4.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(242, 242, 242);
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            pictureBox1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            pictureBox1.Location = new Point(10, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(232, 241);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabDebitos
            // 
            tabDebitos.BackColor = Color.FromArgb(242, 242, 242);
            tabDebitos.Location = new Point(4, 31);
            tabDebitos.Name = "tabDebitos";
            tabDebitos.Padding = new Padding(3);
            tabDebitos.Size = new Size(1400, 648);
            tabDebitos.TabIndex = 1;
            tabDebitos.Text = "Débitos";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "dados_pessoais.png");
            imageList1.Images.SetKeyName(1, "ok_cinza.png");
            imageList1.Images.SetKeyName(2, "ok_green.png");
            imageList1.Images.SetKeyName(3, "ok_red.png");
            // 
            // frmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1414, 750);
            Controls.Add(materialTabControl1);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControl1;
            ForeColor = Color.FromArgb(222, 0, 0, 0);
            FormToManage = this;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCliente";
            ShowInTaskbar = false;
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            Load += frmCliente_Load;
            materialTabControl1.ResumeLayout(false);
            tabFichaCadastral.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgCpfValido).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin2DotNet.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabFichaCadastral;
        private TabPage tabDebitos;
        private ImageList imageList1;
        private Panel panel3;
        private Panel panel2;
        private MaterialSkin2DotNet.Controls.MaterialTextBox2 txtNome;
        private Panel panel1;
        private MaterialSkin2DotNet.Controls.MaterialTextBox2 txtCodigo;
        private Panel panel4;
        private PictureBox pictureBox1;
        private Panel panel5;
        private MaterialSkin2DotNet.Controls.MaterialComboBox cmbTipoPessoa;
        private Panel panel6;
        private MaterialSkin2DotNet.Controls.MaterialMaskedTextBox txtCpfCnpj;
        private PictureBox imgCpfValido;
        private MaterialSkin2DotNet.Controls.MaterialTextBox2 txtIERG;
        private MaterialSkin2DotNet.Controls.MaterialMaskedTextBox txtRgExpedicao;
        private MaterialSkin2DotNet.Controls.MaterialTextBox2 txtOrgaoExpedicao;
        private MaterialSkin2DotNet.Controls.MaterialTextBox2 txtIE;
        private Panel panel7;
        private MaterialSkin2DotNet.Controls.MaterialMaskedTextBox txtWhatsapp;
    }
}