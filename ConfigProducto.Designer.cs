namespace VistasSV
{
    partial class ConfigProducto
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.DGVProductos = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PCategoria = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PVenta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LId = new System.Windows.Forms.Label();
            this.PCodigo = new System.Windows.Forms.TextBox();
            this.PNombre = new System.Windows.Forms.TextBox();
            this.TIdProducto = new System.Windows.Forms.TextBox();
            this.PCompra = new System.Windows.Forms.TextBox();
            this.PStock = new System.Windows.Forms.TextBox();
            this.PDescripcion = new System.Windows.Forms.TextBox();
            this.CrearP = new FontAwesome.Sharp.IconButton();
            this.EditarP = new FontAwesome.Sharp.IconButton();
            this.CancelarP = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProductos)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 32);
            this.panel1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(260, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(386, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "Pagina De Configuracion De Producto";
            // 
            // DGVProductos
            // 
            this.DGVProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVProductos.Location = new System.Drawing.Point(0, 0);
            this.DGVProductos.Name = "DGVProductos";
            this.DGVProductos.RowTemplate.Height = 25;
            this.DGVProductos.Size = new System.Drawing.Size(832, 365);
            this.DGVProductos.TabIndex = 2;
            this.DGVProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVProductos_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PCategoria);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.PVenta);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.LId);
            this.panel2.Controls.Add(this.PCodigo);
            this.panel2.Controls.Add(this.PNombre);
            this.panel2.Controls.Add(this.TIdProducto);
            this.panel2.Controls.Add(this.PCompra);
            this.panel2.Controls.Add(this.PStock);
            this.panel2.Controls.Add(this.PDescripcion);
            this.panel2.Controls.Add(this.CrearP);
            this.panel2.Controls.Add(this.EditarP);
            this.panel2.Controls.Add(this.CancelarP);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(832, 53);
            this.panel2.TabIndex = 3;
            // 
            // PCategoria
            // 
            this.PCategoria.FormattingEnabled = true;
            this.PCategoria.Location = new System.Drawing.Point(357, 23);
            this.PCategoria.Name = "PCategoria";
            this.PCategoria.Size = new System.Drawing.Size(63, 23);
            this.PCategoria.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(592, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "$ Venta";
            // 
            // PVenta
            // 
            this.PVenta.Location = new System.Drawing.Point(592, 23);
            this.PVenta.Name = "PVenta";
            this.PVenta.Size = new System.Drawing.Size(82, 23);
            this.PVenta.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(494, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "$ Compra";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(427, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Stock";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Categoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Codigo";
            // 
            // LId
            // 
            this.LId.AutoSize = true;
            this.LId.Location = new System.Drawing.Point(3, 6);
            this.LId.Name = "LId";
            this.LId.Size = new System.Drawing.Size(18, 15);
            this.LId.TabIndex = 10;
            this.LId.Text = "ID";
            this.LId.Visible = false;
            // 
            // PCodigo
            // 
            this.PCodigo.Location = new System.Drawing.Point(75, 23);
            this.PCodigo.Name = "PCodigo";
            this.PCodigo.Size = new System.Drawing.Size(78, 23);
            this.PCodigo.TabIndex = 9;
            // 
            // PNombre
            // 
            this.PNombre.Location = new System.Drawing.Point(159, 23);
            this.PNombre.Name = "PNombre";
            this.PNombre.Size = new System.Drawing.Size(117, 23);
            this.PNombre.TabIndex = 8;
            // 
            // TIdProducto
            // 
            this.TIdProducto.Enabled = false;
            this.TIdProducto.Location = new System.Drawing.Point(3, 23);
            this.TIdProducto.Name = "TIdProducto";
            this.TIdProducto.Size = new System.Drawing.Size(66, 23);
            this.TIdProducto.TabIndex = 7;
            this.TIdProducto.Visible = false;
            // 
            // PCompra
            // 
            this.PCompra.Location = new System.Drawing.Point(498, 24);
            this.PCompra.Name = "PCompra";
            this.PCompra.Size = new System.Drawing.Size(88, 23);
            this.PCompra.TabIndex = 6;
            // 
            // PStock
            // 
            this.PStock.Location = new System.Drawing.Point(427, 24);
            this.PStock.Name = "PStock";
            this.PStock.Size = new System.Drawing.Size(65, 23);
            this.PStock.TabIndex = 5;
            // 
            // PDescripcion
            // 
            this.PDescripcion.Location = new System.Drawing.Point(282, 23);
            this.PDescripcion.Name = "PDescripcion";
            this.PDescripcion.Size = new System.Drawing.Size(69, 23);
            this.PDescripcion.TabIndex = 3;
            // 
            // CrearP
            // 
            this.CrearP.BackColor = System.Drawing.Color.DodgerBlue;
            this.CrearP.ForeColor = System.Drawing.Color.DodgerBlue;
            this.CrearP.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.CrearP.IconColor = System.Drawing.Color.WhiteSmoke;
            this.CrearP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CrearP.IconSize = 30;
            this.CrearP.Location = new System.Drawing.Point(680, 7);
            this.CrearP.Name = "CrearP";
            this.CrearP.Size = new System.Drawing.Size(43, 41);
            this.CrearP.TabIndex = 2;
            this.CrearP.UseVisualStyleBackColor = false;
            this.CrearP.Click += new System.EventHandler(this.CrearP_Click);
            // 
            // EditarP
            // 
            this.EditarP.BackColor = System.Drawing.Color.DodgerBlue;
            this.EditarP.IconChar = FontAwesome.Sharp.IconChar.PenSquare;
            this.EditarP.IconColor = System.Drawing.Color.WhiteSmoke;
            this.EditarP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EditarP.IconSize = 30;
            this.EditarP.Location = new System.Drawing.Point(729, 7);
            this.EditarP.Name = "EditarP";
            this.EditarP.Size = new System.Drawing.Size(44, 40);
            this.EditarP.TabIndex = 1;
            this.EditarP.UseVisualStyleBackColor = false;
            // 
            // CancelarP
            // 
            this.CancelarP.BackColor = System.Drawing.Color.Red;
            this.CancelarP.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            this.CancelarP.IconColor = System.Drawing.Color.WhiteSmoke;
            this.CancelarP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CancelarP.IconSize = 30;
            this.CancelarP.Location = new System.Drawing.Point(779, 7);
            this.CancelarP.Name = "CancelarP";
            this.CancelarP.Size = new System.Drawing.Size(42, 40);
            this.CancelarP.TabIndex = 0;
            this.CancelarP.UseVisualStyleBackColor = false;
            this.CancelarP.Click += new System.EventHandler(this.CancelarP_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DGVProductos);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 85);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(832, 365);
            this.panel3.TabIndex = 4;
            // 
            // ConfigProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ConfigProducto";
            this.Text = "ConfigProducto";
            this.Load += new System.EventHandler(this.ConfigProducto_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVProductos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private DataGridView DGVProductos;
        private Panel panel2;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton CrearP;
        private FontAwesome.Sharp.IconButton EditarP;
        private FontAwesome.Sharp.IconButton CancelarP;
        private Label label8;
        private TextBox PVenta;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label LId;
        private TextBox PCodigo;
        private TextBox PNombre;
        private TextBox TIdProducto;
        private TextBox PCompra;
        private TextBox PStock;
        private TextBox PDescripcion;
        private Label label9;
        private ComboBox PCategoria;
    }
}