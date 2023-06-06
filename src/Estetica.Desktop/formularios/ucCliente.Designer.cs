namespace Estetica.Desktop.formularios
{
    partial class ucCliente
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucCliente));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            materialCard1 = new MaterialSkin2DotNet.Controls.MaterialCard();
            materialTextBox21 = new MaterialSkin2DotNet.Controls.MaterialTextBox2();
            panel1 = new Panel();
            materialCard2 = new MaterialSkin2DotNet.Controls.MaterialCard();
            dtCliente = new MaterialSkin2DotNet.Controls.MaterialDataTable();
            panel3 = new Panel();
            materialCard3 = new MaterialSkin2DotNet.Controls.MaterialCard();
            btnExcluir = new MaterialSkin2DotNet.Controls.MaterialButton();
            btnEditar = new MaterialSkin2DotNet.Controls.MaterialButton();
            btnNovo = new MaterialSkin2DotNet.Controls.MaterialButton();
            materialDivider2 = new MaterialSkin2DotNet.Controls.MaterialDivider();
            materialDivider1 = new MaterialSkin2DotNet.Controls.MaterialDivider();
            panel2 = new Panel();
            materialLabel1 = new MaterialSkin2DotNet.Controls.MaterialLabel();
            materialCard1.SuspendLayout();
            panel1.SuspendLayout();
            materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtCliente).BeginInit();
            panel3.SuspendLayout();
            materialCard3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(materialTextBox21);
            materialCard1.Depth = 0;
            materialCard1.Dock = DockStyle.Top;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(0, 45);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(1082, 78);
            materialCard1.TabIndex = 0;
            // 
            // materialTextBox21
            // 
            materialTextBox21.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            materialTextBox21.AnimateReadOnly = false;
            materialTextBox21.AutoCompleteMode = AutoCompleteMode.None;
            materialTextBox21.AutoCompleteSource = AutoCompleteSource.None;
            materialTextBox21.BackgroundImageLayout = ImageLayout.None;
            materialTextBox21.CharacterCasing = CharacterCasing.Normal;
            materialTextBox21.Depth = 0;
            materialTextBox21.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox21.HideSelection = true;
            materialTextBox21.Hint = "Informe um NOME para pesquisa";
            materialTextBox21.LeadingIcon = null;
            materialTextBox21.Location = new Point(17, 17);
            materialTextBox21.MaxLength = 500;
            materialTextBox21.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            materialTextBox21.Name = "materialTextBox21";
            materialTextBox21.PasswordChar = '\0';
            materialTextBox21.PrefixSuffixText = null;
            materialTextBox21.ReadOnly = false;
            materialTextBox21.RightToLeft = RightToLeft.No;
            materialTextBox21.SelectedText = "";
            materialTextBox21.SelectionLength = 0;
            materialTextBox21.SelectionStart = 0;
            materialTextBox21.ShortcutsEnabled = true;
            materialTextBox21.Size = new Size(1048, 48);
            materialTextBox21.TabIndex = 0;
            materialTextBox21.TabStop = false;
            materialTextBox21.TextAlign = HorizontalAlignment.Left;
            materialTextBox21.TrailingIcon = (Image)resources.GetObject("materialTextBox21.TrailingIcon");
            materialTextBox21.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(materialCard2);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(materialDivider1);
            panel1.Controls.Add(materialCard1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1082, 618);
            panel1.TabIndex = 1;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(dtCliente);
            materialCard2.Depth = 0;
            materialCard2.Dock = DockStyle.Fill;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(0, 129);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(1082, 424);
            materialCard2.TabIndex = 2;
            // 
            // dtCliente
            // 
            dtCliente.AllowUserToDeleteRows = false;
            dtCliente.AllowUserToResizeRows = false;
            dtCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtCliente.BackgroundColor = Color.FromArgb(255, 255, 255);
            dtCliente.BorderStyle = BorderStyle.None;
            dtCliente.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            dtCliente.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtCliente.ColumnHeadersHeight = 56;
            dtCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(236, 64, 122);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtCliente.DefaultCellStyle = dataGridViewCellStyle2;
            dtCliente.Depth = 0;
            dtCliente.Dock = DockStyle.Fill;
            dtCliente.EnableHeadersVisualStyles = false;
            dtCliente.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dtCliente.GridColor = Color.FromArgb(239, 239, 239);
            dtCliente.Location = new Point(14, 14);
            dtCliente.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            dtCliente.Name = "dtCliente";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtCliente.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            dtCliente.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dtCliente.RowTemplate.Height = 52;
            dtCliente.ScrollBars = ScrollBars.None;
            dtCliente.ShowVerticalScroll = false;
            dtCliente.Size = new Size(1054, 396);
            dtCliente.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(materialCard3);
            panel3.Controls.Add(materialDivider2);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 553);
            panel3.Name = "panel3";
            panel3.Size = new Size(1082, 65);
            panel3.TabIndex = 6;
            // 
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Controls.Add(btnExcluir);
            materialCard3.Controls.Add(btnEditar);
            materialCard3.Controls.Add(btnNovo);
            materialCard3.Depth = 0;
            materialCard3.Dock = DockStyle.Top;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(0, 6);
            materialCard3.Margin = new Padding(14);
            materialCard3.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(14);
            materialCard3.Size = new Size(1082, 57);
            materialCard3.TabIndex = 6;
            // 
            // btnExcluir
            // 
            btnExcluir.AutoSize = false;
            btnExcluir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExcluir.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnExcluir.Depth = 0;
            btnExcluir.Enabled = false;
            btnExcluir.HighEmphasis = true;
            btnExcluir.Icon = (Image)resources.GetObject("btnExcluir.Icon");
            btnExcluir.Location = new Point(103, 9);
            btnExcluir.Margin = new Padding(4, 6, 4, 6);
            btnExcluir.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.NoAccentTextColor = Color.Empty;
            btnExcluir.Size = new Size(38, 36);
            btnExcluir.TabIndex = 2;
            btnExcluir.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            btnExcluir.UseAccentColor = true;
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.AutoSize = false;
            btnEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditar.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditar.Depth = 0;
            btnEditar.Enabled = false;
            btnEditar.HighEmphasis = true;
            btnEditar.Icon = (Image)resources.GetObject("btnEditar.Icon");
            btnEditar.Location = new Point(60, 9);
            btnEditar.Margin = new Padding(4, 6, 4, 6);
            btnEditar.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            btnEditar.Name = "btnEditar";
            btnEditar.NoAccentTextColor = Color.Empty;
            btnEditar.Size = new Size(38, 36);
            btnEditar.TabIndex = 1;
            btnEditar.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEditar.UseAccentColor = true;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            btnNovo.AutoSize = false;
            btnNovo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNovo.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNovo.Depth = 0;
            btnNovo.HighEmphasis = true;
            btnNovo.Icon = (Image)resources.GetObject("btnNovo.Icon");
            btnNovo.Location = new Point(17, 9);
            btnNovo.Margin = new Padding(4, 6, 4, 6);
            btnNovo.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            btnNovo.Name = "btnNovo";
            btnNovo.NoAccentTextColor = Color.Empty;
            btnNovo.Size = new Size(38, 36);
            btnNovo.TabIndex = 0;
            btnNovo.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNovo.UseAccentColor = true;
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // materialDivider2
            // 
            materialDivider2.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider2.Depth = 0;
            materialDivider2.Dock = DockStyle.Top;
            materialDivider2.Location = new Point(0, 0);
            materialDivider2.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialDivider2.Name = "materialDivider2";
            materialDivider2.Size = new Size(1082, 6);
            materialDivider2.TabIndex = 5;
            materialDivider2.Text = "materialDivider2";
            // 
            // materialDivider1
            // 
            materialDivider1.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider1.Depth = 0;
            materialDivider1.Dock = DockStyle.Top;
            materialDivider1.Location = new Point(0, 123);
            materialDivider1.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialDivider1.Name = "materialDivider1";
            materialDivider1.Size = new Size(1082, 6);
            materialDivider1.TabIndex = 1;
            materialDivider1.Text = "materialDivider1";
            // 
            // panel2
            // 
            panel2.Controls.Add(materialLabel1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1082, 45);
            panel2.TabIndex = 3;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin2DotNet.MaterialSkinManager.fontType.H6;
            materialLabel1.HighEmphasis = true;
            materialLabel1.Location = new Point(17, 12);
            materialLabel1.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(74, 24);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "Clientes";
            materialLabel1.UseAccent = true;
            // 
            // ucCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(0);
            Name = "ucCliente";
            Padding = new Padding(3);
            Size = new Size(1088, 624);
            materialCard1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            materialCard2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtCliente).EndInit();
            panel3.ResumeLayout(false);
            materialCard3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin2DotNet.Controls.MaterialCard materialCard1;
        private Panel panel1;
        private MaterialSkin2DotNet.Controls.MaterialTextBox2 materialTextBox21;
        private MaterialSkin2DotNet.Controls.MaterialDivider materialDivider1;
        private MaterialSkin2DotNet.Controls.MaterialCard materialCard2;
        private MaterialSkin2DotNet.Controls.MaterialDataTable dtCliente;
        private Panel panel2;
        private MaterialSkin2DotNet.Controls.MaterialLabel materialLabel1;
        private Panel panel3;
        private MaterialSkin2DotNet.Controls.MaterialCard materialCard3;
        private MaterialSkin2DotNet.Controls.MaterialButton btnExcluir;
        private MaterialSkin2DotNet.Controls.MaterialButton btnEditar;
        private MaterialSkin2DotNet.Controls.MaterialButton btnNovo;
        private MaterialSkin2DotNet.Controls.MaterialDivider materialDivider2;
    }
}
