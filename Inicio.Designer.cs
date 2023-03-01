namespace VistasSV
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            panel1 = new Panel();
            LNUsuario = new Label();
            label2 = new Label();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            MUser = new FontAwesome.Sharp.IconMenuItem();
            MConfig = new FontAwesome.Sharp.IconMenuItem();
            ConfigCategoria = new ToolStripMenuItem();
            ConfigProducto = new ToolStripMenuItem();
            MVentas = new FontAwesome.Sharp.IconMenuItem();
            MRegistarVenta = new ToolStripMenuItem();
            MDetalleVenta = new ToolStripMenuItem();
            MCompras = new FontAwesome.Sharp.IconMenuItem();
            registrarToolStripMenuItem1 = new ToolStripMenuItem();
            detalleDeCompraToolStripMenuItem = new ToolStripMenuItem();
            MClientes = new FontAwesome.Sharp.IconMenuItem();
            MProveedores = new FontAwesome.Sharp.IconMenuItem();
            MReporte = new FontAwesome.Sharp.IconMenuItem();
            MInfo = new FontAwesome.Sharp.IconMenuItem();
            ContenedorInicio = new Panel();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(LNUsuario);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(898, 50);
            panel1.TabIndex = 0;
            // 
            // LNUsuario
            // 
            LNUsuario.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            LNUsuario.ForeColor = SystemColors.ButtonHighlight;
            LNUsuario.Location = new Point(645, 9);
            LNUsuario.Name = "LNUsuario";
            LNUsuario.Size = new Size(107, 35);
            LNUsuario.TabIndex = 2;
            LNUsuario.Text = "xxxxxxxxxx";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(532, 9);
            label2.Name = "label2";
            label2.Size = new Size(107, 35);
            label2.TabIndex = 1;
            label2.Text = "USUARIO:";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(337, 35);
            label1.TabIndex = 0;
            label1.Text = "SISTEMA DE VENTAS EMBERTH OLAVE ZUÑIGA";
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.DarkGray;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { MUser, MConfig, MVentas, MCompras, MClientes, MProveedores, MReporte, MInfo });
            menuStrip1.Location = new Point(0, 44);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(966, 86);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // MUser
            // 
            MUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            MUser.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            MUser.IconColor = Color.DarkSlateGray;
            MUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MUser.IconSize = 80;
            MUser.ImageScaling = ToolStripItemImageScaling.None;
            MUser.Name = "MUser";
            MUser.Size = new Size(92, 82);
            MUser.Text = "User";
            MUser.TextImageRelation = TextImageRelation.ImageAboveText;
            MUser.Click += MUser_Click;
            // 
            // MConfig
            // 
            MConfig.DropDownItems.AddRange(new ToolStripItem[] { ConfigCategoria, ConfigProducto });
            MConfig.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            MConfig.IconChar = FontAwesome.Sharp.IconChar.Gear;
            MConfig.IconColor = Color.DarkSlateGray;
            MConfig.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MConfig.IconSize = 80;
            MConfig.ImageScaling = ToolStripItemImageScaling.None;
            MConfig.Name = "MConfig";
            MConfig.Size = new Size(92, 82);
            MConfig.Text = "Config";
            MConfig.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // ConfigCategoria
            // 
            ConfigCategoria.Name = "ConfigCategoria";
            ConfigCategoria.Size = new Size(127, 22);
            ConfigCategoria.Text = "Categoria";
            ConfigCategoria.Click += ConfigCategoria_Click;
            // 
            // ConfigProducto
            // 
            ConfigProducto.Name = "ConfigProducto";
            ConfigProducto.Size = new Size(127, 22);
            ConfigProducto.Text = "Producto";
            ConfigProducto.Click += ConfigProducto_Click;
            // 
            // MVentas
            // 
            MVentas.DropDownItems.AddRange(new ToolStripItem[] { MRegistarVenta, MDetalleVenta });
            MVentas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            MVentas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            MVentas.IconColor = Color.DarkSlateGray;
            MVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MVentas.IconSize = 80;
            MVentas.ImageScaling = ToolStripItemImageScaling.None;
            MVentas.Name = "MVentas";
            MVentas.Size = new Size(92, 82);
            MVentas.Text = "Ventas";
            MVentas.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // MRegistarVenta
            // 
            MRegistarVenta.Name = "MRegistarVenta";
            MRegistarVenta.Size = new Size(166, 22);
            MRegistarVenta.Text = "Registrar";
            MRegistarVenta.Click += MRegistarVenta_Click;
            // 
            // MDetalleVenta
            // 
            MDetalleVenta.Name = "MDetalleVenta";
            MDetalleVenta.Size = new Size(166, 22);
            MDetalleVenta.Text = "Detalle de venta";
            MDetalleVenta.Click += MDetalleVenta_Click;
            // 
            // MCompras
            // 
            MCompras.DropDownItems.AddRange(new ToolStripItem[] { registrarToolStripMenuItem1, detalleDeCompraToolStripMenuItem });
            MCompras.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            MCompras.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            MCompras.IconColor = Color.DarkSlateGray;
            MCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MCompras.IconSize = 80;
            MCompras.ImageScaling = ToolStripItemImageScaling.None;
            MCompras.Name = "MCompras";
            MCompras.Size = new Size(92, 82);
            MCompras.Text = "Compras";
            MCompras.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // registrarToolStripMenuItem1
            // 
            registrarToolStripMenuItem1.Name = "registrarToolStripMenuItem1";
            registrarToolStripMenuItem1.Size = new Size(176, 22);
            registrarToolStripMenuItem1.Text = "Registrar";
            registrarToolStripMenuItem1.Click += registrarToolStripMenuItem1_Click;
            // 
            // detalleDeCompraToolStripMenuItem
            // 
            detalleDeCompraToolStripMenuItem.Name = "detalleDeCompraToolStripMenuItem";
            detalleDeCompraToolStripMenuItem.Size = new Size(176, 22);
            detalleDeCompraToolStripMenuItem.Text = "Detalle de compra";
            detalleDeCompraToolStripMenuItem.Click += detalleDeCompraToolStripMenuItem_Click;
            // 
            // MClientes
            // 
            MClientes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            MClientes.IconChar = FontAwesome.Sharp.IconChar.Users;
            MClientes.IconColor = Color.DarkSlateGray;
            MClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MClientes.IconSize = 80;
            MClientes.ImageScaling = ToolStripItemImageScaling.None;
            MClientes.Name = "MClientes";
            MClientes.Size = new Size(92, 82);
            MClientes.Text = "Clientes";
            MClientes.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // MProveedores
            // 
            MProveedores.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            MProveedores.IconChar = FontAwesome.Sharp.IconChar.IdCardAlt;
            MProveedores.IconColor = Color.DarkSlateGray;
            MProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MProveedores.IconSize = 80;
            MProveedores.ImageScaling = ToolStripItemImageScaling.None;
            MProveedores.Name = "MProveedores";
            MProveedores.Size = new Size(92, 82);
            MProveedores.Text = "Proveedores";
            MProveedores.TextImageRelation = TextImageRelation.ImageAboveText;
            MProveedores.Click += MProveedores_Click;
            // 
            // MReporte
            // 
            MReporte.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            MReporte.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            MReporte.IconColor = Color.DarkSlateGray;
            MReporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MReporte.IconSize = 80;
            MReporte.ImageScaling = ToolStripItemImageScaling.None;
            MReporte.Name = "MReporte";
            MReporte.Size = new Size(92, 82);
            MReporte.Text = "Reportes";
            MReporte.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // MInfo
            // 
            MInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            MInfo.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            MInfo.IconColor = Color.DarkSlateGray;
            MInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MInfo.IconSize = 80;
            MInfo.ImageScaling = ToolStripItemImageScaling.None;
            MInfo.Name = "MInfo";
            MInfo.Size = new Size(92, 82);
            MInfo.Text = "Info";
            MInfo.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // ContenedorInicio
            // 
            ContenedorInicio.BackgroundImage = (Image)resources.GetObject("ContenedorInicio.BackgroundImage");
            ContenedorInicio.Location = new Point(3, 133);
            ContenedorInicio.Name = "ContenedorInicio";
            ContenedorInicio.Size = new Size(898, 453);
            ContenedorInicio.TabIndex = 2;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 586);
            Controls.Add(ContenedorInicio);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Name = "Inicio";
            Text = "Inicio";
            FormClosing += Inicio_FormClosing;
            Load += Inicio_Load;
            panel1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem MUser;
        private FontAwesome.Sharp.IconMenuItem MConfig;
        private ToolStripMenuItem categoriaToolStripMenuItem;
        private ToolStripMenuItem productoToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem MVentas;
        private ToolStripMenuItem MRegistarVenta;
        private ToolStripMenuItem MDetalleVenta;
        private FontAwesome.Sharp.IconMenuItem MCompras;
        private FontAwesome.Sharp.IconMenuItem MClientes;
        private FontAwesome.Sharp.IconMenuItem MProveedores;
        private FontAwesome.Sharp.IconMenuItem MInfo;
        private ToolStripMenuItem registrarToolStripMenuItem1;
        private ToolStripMenuItem detalleDeCompraToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem MReporte;
        private Panel ContenedorInicio;
        private ToolStripMenuItem ConfigCategoria;
        private ToolStripMenuItem ConfigProducto;
        private Label label1;
        private Label LNUsuario;
        private Label label2;
    }
}