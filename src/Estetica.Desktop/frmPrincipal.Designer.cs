namespace Estetica.Desktop
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            materialTabControl1 = new MaterialSkin2DotNet.Controls.MaterialTabControl();
            tabDashboard = new TabPage();
            tabAgenda = new TabPage();
            ucAgenda1 = new formularios.ucAgenda();
            tabClientes = new TabPage();
            ucCliente1 = new formularios.ucCliente();
            tabEmpresa = new TabPage();
            ucEmpresa1 = new formularios.ucEmpresa();
            tabEntradaSaida = new TabPage();
            ucEntradaSaida1 = new formularios.ucEntradaSaida();
            imgListIcones = new ImageList(components);
            materialTabControl1.SuspendLayout();
            tabAgenda.SuspendLayout();
            tabClientes.SuspendLayout();
            tabEmpresa.SuspendLayout();
            tabEntradaSaida.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tabDashboard);
            materialTabControl1.Controls.Add(tabAgenda);
            materialTabControl1.Controls.Add(tabClientes);
            materialTabControl1.Controls.Add(tabEmpresa);
            materialTabControl1.Controls.Add(tabEntradaSaida);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialTabControl1.ImageList = imgListIcones;
            materialTabControl1.Location = new Point(3, 64);
            materialTabControl1.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(1221, 641);
            materialTabControl1.TabIndex = 1;
            // 
            // tabDashboard
            // 
            tabDashboard.BackColor = Color.FromArgb(242, 242, 242);
            tabDashboard.ImageKey = "dashboard.png";
            tabDashboard.Location = new Point(4, 31);
            tabDashboard.Name = "tabDashboard";
            tabDashboard.Size = new Size(1213, 606);
            tabDashboard.TabIndex = 2;
            tabDashboard.Text = "Dashboard";
            // 
            // tabAgenda
            // 
            tabAgenda.BackColor = Color.FromArgb(242, 242, 242);
            tabAgenda.Controls.Add(ucAgenda1);
            tabAgenda.ImageKey = "agenda.png";
            tabAgenda.Location = new Point(4, 31);
            tabAgenda.Name = "tabAgenda";
            tabAgenda.Size = new Size(1213, 606);
            tabAgenda.TabIndex = 3;
            tabAgenda.Text = "Agenda";
            // 
            // ucAgenda1
            // 
            ucAgenda1.BackColor = Color.FromArgb(242, 242, 242);
            ucAgenda1.Dock = DockStyle.Fill;
            ucAgenda1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            ucAgenda1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            ucAgenda1.Location = new Point(0, 0);
            ucAgenda1.Name = "ucAgenda1";
            ucAgenda1.Padding = new Padding(3);
            ucAgenda1.Size = new Size(1213, 606);
            ucAgenda1.TabIndex = 0;
            // 
            // tabClientes
            // 
            tabClientes.BackColor = Color.FromArgb(242, 242, 242);
            tabClientes.Controls.Add(ucCliente1);
            tabClientes.ImageKey = "clientes.png";
            tabClientes.Location = new Point(4, 31);
            tabClientes.Name = "tabClientes";
            tabClientes.Size = new Size(1213, 606);
            tabClientes.TabIndex = 1;
            tabClientes.Text = "Clientes";
            // 
            // ucCliente1
            // 
            ucCliente1.BackColor = Color.FromArgb(242, 242, 242);
            ucCliente1.Dock = DockStyle.Fill;
            ucCliente1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            ucCliente1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            ucCliente1.Location = new Point(0, 0);
            ucCliente1.Margin = new Padding(0);
            ucCliente1.Name = "ucCliente1";
            ucCliente1.Padding = new Padding(3);
            ucCliente1.Size = new Size(1213, 606);
            ucCliente1.TabIndex = 0;
            // 
            // tabEmpresa
            // 
            tabEmpresa.BackColor = Color.FromArgb(242, 242, 242);
            tabEmpresa.Controls.Add(ucEmpresa1);
            tabEmpresa.ImageKey = "empresa.png";
            tabEmpresa.Location = new Point(4, 31);
            tabEmpresa.Name = "tabEmpresa";
            tabEmpresa.Padding = new Padding(3);
            tabEmpresa.Size = new Size(1213, 606);
            tabEmpresa.TabIndex = 0;
            tabEmpresa.Text = "Empresa";
            // 
            // ucEmpresa1
            // 
            ucEmpresa1.BackColor = Color.FromArgb(242, 242, 242);
            ucEmpresa1.Dock = DockStyle.Top;
            ucEmpresa1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            ucEmpresa1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            ucEmpresa1.Location = new Point(3, 3);
            ucEmpresa1.Name = "ucEmpresa1";
            ucEmpresa1.Padding = new Padding(3);
            ucEmpresa1.Size = new Size(1207, 615);
            ucEmpresa1.TabIndex = 0;
            // 
            // tabEntradaSaida
            // 
            tabEntradaSaida.BackColor = Color.FromArgb(242, 242, 242);
            tabEntradaSaida.Controls.Add(ucEntradaSaida1);
            tabEntradaSaida.ImageKey = "entradaSaida.png";
            tabEntradaSaida.Location = new Point(4, 31);
            tabEntradaSaida.Name = "tabEntradaSaida";
            tabEntradaSaida.Size = new Size(1213, 606);
            tabEntradaSaida.TabIndex = 4;
            tabEntradaSaida.Text = "Entrada/Saída";
            // 
            // ucEntradaSaida1
            // 
            ucEntradaSaida1.BackColor = Color.FromArgb(242, 242, 242);
            ucEntradaSaida1.Dock = DockStyle.Fill;
            ucEntradaSaida1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            ucEntradaSaida1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            ucEntradaSaida1.Location = new Point(0, 0);
            ucEntradaSaida1.Name = "ucEntradaSaida1";
            ucEntradaSaida1.Padding = new Padding(3);
            ucEntradaSaida1.Size = new Size(1213, 606);
            ucEntradaSaida1.TabIndex = 0;
            // 
            // imgListIcones
            // 
            imgListIcones.ColorDepth = ColorDepth.Depth16Bit;
            imgListIcones.ImageStream = (ImageListStreamer)resources.GetObject("imgListIcones.ImageStream");
            imgListIcones.TransparentColor = Color.Transparent;
            imgListIcones.Images.SetKeyName(0, "novo.png");
            imgListIcones.Images.SetKeyName(1, "editar.png");
            imgListIcones.Images.SetKeyName(2, "excluir.png");
            imgListIcones.Images.SetKeyName(3, "empresa.png");
            imgListIcones.Images.SetKeyName(4, "clientes.png");
            imgListIcones.Images.SetKeyName(5, "dashboard.png");
            imgListIcones.Images.SetKeyName(6, "agenda.png");
            imgListIcones.Images.SetKeyName(7, "entradaSaida.png");
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1227, 708);
            Controls.Add(materialTabControl1);
            DrawerAutoHide = false;
            DrawerAutoShow = true;
            DrawerBackgroundWithAccent = true;
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControl1;
            ForeColor = Color.FromArgb(222, 0, 0, 0);
            FormToManage = this;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "frmPrincipal";
            PrimaryColor = MaterialSkin2DotNet.Primary.BlueGrey600;
            PrimaryDarkColor = MaterialSkin2DotNet.Primary.Grey900;
            PrimaryLightColor = MaterialSkin2DotNet.Primary.Pink100;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estética Malato";
            Load += frmPrincipal_Load;
            materialTabControl1.ResumeLayout(false);
            tabAgenda.ResumeLayout(false);
            tabClientes.ResumeLayout(false);
            tabEmpresa.ResumeLayout(false);
            tabEntradaSaida.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private MaterialSkin2DotNet.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabEmpresa;
        private TabPage tabClientes;
        private ImageList imgListIcones;
        private TabPage tabDashboard;
        private TabPage tabAgenda;
        private TabPage tabEntradaSaida;
        private formularios.ucAgenda ucAgenda1;
        private formularios.ucEmpresa ucEmpresa1;
        private formularios.ucEntradaSaida ucEntradaSaida1;
        private formularios.ucCliente ucCliente1;
    }
}