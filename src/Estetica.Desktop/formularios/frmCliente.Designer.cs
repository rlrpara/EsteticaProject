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
            tabDadosPrincipais = new TabPage();
            mcCalendario = new MonthCalendar();
            panel3 = new Panel();
            btnCalendario = new MaterialSkin2DotNet.Controls.MaterialButton();
            txtNascimento = new MaterialSkin2DotNet.Controls.MaterialMaskedTextBox();
            panel2 = new Panel();
            txtNome = new MaterialSkin2DotNet.Controls.MaterialTextBox2();
            panel1 = new Panel();
            txtCodigo = new MaterialSkin2DotNet.Controls.MaterialTextBox2();
            tabPage2 = new TabPage();
            imageList1 = new ImageList(components);
            materialTabControl1.SuspendLayout();
            tabDadosPrincipais.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tabDadosPrincipais);
            materialTabControl1.Controls.Add(tabPage2);
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
            // tabDadosPrincipais
            // 
            tabDadosPrincipais.AutoScroll = true;
            tabDadosPrincipais.BackColor = Color.FromArgb(242, 242, 242);
            tabDadosPrincipais.Controls.Add(mcCalendario);
            tabDadosPrincipais.Controls.Add(panel3);
            tabDadosPrincipais.Controls.Add(panel2);
            tabDadosPrincipais.Controls.Add(panel1);
            tabDadosPrincipais.ImageKey = "dados_pessoais.png";
            tabDadosPrincipais.Location = new Point(4, 31);
            tabDadosPrincipais.Name = "tabDadosPrincipais";
            tabDadosPrincipais.Padding = new Padding(3);
            tabDadosPrincipais.Size = new Size(1400, 648);
            tabDadosPrincipais.TabIndex = 0;
            tabDadosPrincipais.Text = "Dados Principais";
            // 
            // mcCalendario
            // 
            mcCalendario.BackColor = Color.FromArgb(242, 242, 242);
            mcCalendario.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            mcCalendario.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mcCalendario.Location = new Point(34, 158);
            mcCalendario.MinDate = new DateTime(1915, 1, 1, 0, 0, 0, 0);
            mcCalendario.Name = "mcCalendario";
            mcCalendario.TabIndex = 2;
            mcCalendario.Visible = false;
            mcCalendario.DateSelected += mcCalendario_DateSelected;
            mcCalendario.MouseLeave += mcCalendario_MouseLeave;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(242, 242, 242);
            panel3.Controls.Add(btnCalendario);
            panel3.Controls.Add(txtNascimento);
            panel3.Dock = DockStyle.Top;
            panel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            panel3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            panel3.Location = new Point(3, 107);
            panel3.Name = "panel3";
            panel3.Size = new Size(1394, 52);
            panel3.TabIndex = 2;
            // 
            // btnCalendario
            // 
            btnCalendario.AutoSize = false;
            btnCalendario.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCalendario.BackColor = Color.FromArgb(242, 242, 242);
            btnCalendario.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCalendario.Depth = 0;
            btnCalendario.ForeColor = Color.FromArgb(222, 0, 0, 0);
            btnCalendario.HighEmphasis = true;
            btnCalendario.Icon = (Image)resources.GetObject("btnCalendario.Icon");
            btnCalendario.Location = new Point(220, 8);
            btnCalendario.Margin = new Padding(4, 6, 4, 6);
            btnCalendario.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            btnCalendario.Name = "btnCalendario";
            btnCalendario.NoAccentTextColor = Color.Empty;
            btnCalendario.Size = new Size(38, 36);
            btnCalendario.TabIndex = 1;
            btnCalendario.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCalendario.UseAccentColor = true;
            btnCalendario.UseVisualStyleBackColor = false;
            btnCalendario.Click += btnCalendario_Click;
            // 
            // txtNascimento
            // 
            txtNascimento.AllowPromptAsInput = true;
            txtNascimento.AnimateReadOnly = false;
            txtNascimento.AsciiOnly = false;
            txtNascimento.BackColor = Color.FromArgb(242, 242, 242);
            txtNascimento.BackgroundImageLayout = ImageLayout.None;
            txtNascimento.BeepOnError = false;
            txtNascimento.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtNascimento.Depth = 0;
            txtNascimento.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNascimento.HidePromptOnLeave = false;
            txtNascimento.HideSelection = true;
            txtNascimento.Hint = "Nscimento";
            txtNascimento.InsertKeyMode = InsertKeyMode.Default;
            txtNascimento.LeadingIcon = null;
            txtNascimento.Location = new Point(8, 3);
            txtNascimento.Mask = "99/99/9999";
            txtNascimento.MaxLength = 32767;
            txtNascimento.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            txtNascimento.Name = "txtNascimento";
            txtNascimento.PasswordChar = '\0';
            txtNascimento.PrefixSuffixText = null;
            txtNascimento.PromptChar = '_';
            txtNascimento.ReadOnly = false;
            txtNascimento.RejectInputOnFirstFailure = false;
            txtNascimento.ResetOnPrompt = true;
            txtNascimento.ResetOnSpace = true;
            txtNascimento.RightToLeft = RightToLeft.No;
            txtNascimento.SelectedText = "";
            txtNascimento.SelectionLength = 0;
            txtNascimento.SelectionStart = 0;
            txtNascimento.ShortcutsEnabled = true;
            txtNascimento.Size = new Size(205, 48);
            txtNascimento.SkipLiterals = true;
            txtNascimento.TabIndex = 0;
            txtNascimento.TabStop = false;
            txtNascimento.Text = "  /  /";
            txtNascimento.TextAlign = HorizontalAlignment.Left;
            txtNascimento.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtNascimento.TrailingIcon = null;
            txtNascimento.UseSystemPasswordChar = false;
            txtNascimento.ValidatingType = null;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(242, 242, 242);
            panel2.Controls.Add(txtNome);
            panel2.Dock = DockStyle.Top;
            panel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            panel2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            panel2.Location = new Point(3, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(1394, 52);
            panel2.TabIndex = 1;
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
            txtNome.Size = new Size(1380, 48);
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
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1394, 52);
            panel1.TabIndex = 0;
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
            txtCodigo.Size = new Size(250, 48);
            txtCodigo.TabIndex = 0;
            txtCodigo.TabStop = false;
            txtCodigo.TextAlign = HorizontalAlignment.Left;
            txtCodigo.TrailingIcon = null;
            txtCodigo.UseSystemPasswordChar = false;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(242, 242, 242);
            tabPage2.Location = new Point(4, 31);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1400, 648);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "dados_pessoais.png");
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
            materialTabControl1.ResumeLayout(false);
            tabDadosPrincipais.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin2DotNet.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabDadosPrincipais;
        private TabPage tabPage2;
        private ImageList imageList1;
        private Panel panel1;
        private MaterialSkin2DotNet.Controls.MaterialTextBox2 txtCodigo;
        private Panel panel2;
        private MaterialSkin2DotNet.Controls.MaterialTextBox2 txtNome;
        private Panel panel3;
        private MaterialSkin2DotNet.Controls.MaterialMaskedTextBox txtNascimento;
        private MaterialSkin2DotNet.Controls.MaterialButton btnCalendario;
        private MonthCalendar mcCalendario;
    }
}