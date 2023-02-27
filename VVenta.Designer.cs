namespace VistasSV
{
    partial class VVenta
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
            this.TbCantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CbProducto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAgregarProducto = new FontAwesome.Sharp.IconButton();
            this.DGVVenta = new System.Windows.Forms.DataGridView();
            this.BtnVerificar = new FontAwesome.Sharp.IconButton();
            this.BtnVenta = new FontAwesome.Sharp.IconButton();
            this.TbNumeroDocumento = new System.Windows.Forms.TextBox();
            this.TbNombre = new System.Windows.Forms.TextBox();
            this.TbCorreo = new System.Windows.Forms.TextBox();
            this.TbTelefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TbTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TbPago = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TbCambio = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TbCantidad);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CbProducto);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnAgregarProducto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 52);
            this.panel1.TabIndex = 0;
            // 
            // TbCantidad
            // 
            this.TbCantidad.Location = new System.Drawing.Point(374, 20);
            this.TbCantidad.Name = "TbCantidad";
            this.TbCantidad.Size = new System.Drawing.Size(100, 23);
            this.TbCantidad.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(313, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cantidad";
            // 
            // CbProducto
            // 
            this.CbProducto.FormattingEnabled = true;
            this.CbProducto.Location = new System.Drawing.Point(629, 22);
            this.CbProducto.Name = "CbProducto";
            this.CbProducto.Size = new System.Drawing.Size(163, 23);
            this.CbProducto.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(532, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Producto";
            // 
            // BtnAgregarProducto
            // 
            this.BtnAgregarProducto.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnAgregarProducto.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            this.BtnAgregarProducto.IconColor = System.Drawing.Color.WhiteSmoke;
            this.BtnAgregarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAgregarProducto.IconSize = 30;
            this.BtnAgregarProducto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnAgregarProducto.Location = new System.Drawing.Point(805, 14);
            this.BtnAgregarProducto.Name = "BtnAgregarProducto";
            this.BtnAgregarProducto.Size = new System.Drawing.Size(41, 38);
            this.BtnAgregarProducto.TabIndex = 0;
            this.BtnAgregarProducto.UseVisualStyleBackColor = false;
            this.BtnAgregarProducto.Click += new System.EventHandler(this.BtnAgregarProducto_Click);
            // 
            // DGVVenta
            // 
            this.DGVVenta.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.DGVVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVVenta.Location = new System.Drawing.Point(0, 52);
            this.DGVVenta.Name = "DGVVenta";
            this.DGVVenta.RowTemplate.Height = 25;
            this.DGVVenta.Size = new System.Drawing.Size(590, 277);
            this.DGVVenta.TabIndex = 1;
            this.DGVVenta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVVenta_CellClick);
            // 
            // BtnVerificar
            // 
            this.BtnVerificar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnVerificar.IconChar = FontAwesome.Sharp.IconChar.CheckDouble;
            this.BtnVerificar.IconColor = System.Drawing.Color.WhiteSmoke;
            this.BtnVerificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnVerificar.IconSize = 30;
            this.BtnVerificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnVerificar.Location = new System.Drawing.Point(792, 95);
            this.BtnVerificar.Name = "BtnVerificar";
            this.BtnVerificar.Size = new System.Drawing.Size(41, 37);
            this.BtnVerificar.TabIndex = 2;
            this.BtnVerificar.UseVisualStyleBackColor = false;
            this.BtnVerificar.Click += new System.EventHandler(this.BtnVerificar_Click);
            // 
            // BtnVenta
            // 
            this.BtnVenta.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnVenta.IconChar = FontAwesome.Sharp.IconChar.BagShopping;
            this.BtnVenta.IconColor = System.Drawing.Color.WhiteSmoke;
            this.BtnVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnVenta.IconSize = 30;
            this.BtnVenta.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnVenta.Location = new System.Drawing.Point(629, 338);
            this.BtnVenta.Name = "BtnVenta";
            this.BtnVenta.Size = new System.Drawing.Size(203, 37);
            this.BtnVenta.TabIndex = 3;
            this.BtnVenta.UseVisualStyleBackColor = false;
            this.BtnVenta.Click += new System.EventHandler(this.BtnCompra_Click);
            // 
            // TbNumeroDocumento
            // 
            this.TbNumeroDocumento.Location = new System.Drawing.Point(630, 103);
            this.TbNumeroDocumento.Name = "TbNumeroDocumento";
            this.TbNumeroDocumento.Size = new System.Drawing.Size(156, 23);
            this.TbNumeroDocumento.TabIndex = 4;
            // 
            // TbNombre
            // 
            this.TbNombre.Location = new System.Drawing.Point(630, 167);
            this.TbNombre.Name = "TbNombre";
            this.TbNombre.Size = new System.Drawing.Size(203, 23);
            this.TbNombre.TabIndex = 5;
            // 
            // TbCorreo
            // 
            this.TbCorreo.Location = new System.Drawing.Point(630, 229);
            this.TbCorreo.Name = "TbCorreo";
            this.TbCorreo.Size = new System.Drawing.Size(203, 23);
            this.TbCorreo.TabIndex = 6;
            // 
            // TbTelefono
            // 
            this.TbTelefono.Location = new System.Drawing.Point(630, 294);
            this.TbTelefono.Name = "TbTelefono";
            this.TbTelefono.Size = new System.Drawing.Size(203, 23);
            this.TbTelefono.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(629, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(630, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Correo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(629, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(630, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "N° Documento";
            // 
            // TbTotal
            // 
            this.TbTotal.Location = new System.Drawing.Point(233, 352);
            this.TbTotal.Name = "TbTotal";
            this.TbTotal.Size = new System.Drawing.Size(135, 23);
            this.TbTotal.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(193, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Total";
            // 
            // TbPago
            // 
            this.TbPago.Location = new System.Drawing.Point(65, 352);
            this.TbPago.Name = "TbPago";
            this.TbPago.Size = new System.Drawing.Size(122, 23);
            this.TbPago.TabIndex = 14;
            this.TbPago.TextChanged += new System.EventHandler(this.TbPago_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(25, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Pago";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(389, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Cambio";
            // 
            // TbCambio
            // 
            this.TbCambio.Location = new System.Drawing.Point(453, 352);
            this.TbCambio.Name = "TbCambio";
            this.TbCambio.Size = new System.Drawing.Size(141, 23);
            this.TbCambio.TabIndex = 17;
            // 
            // VVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(883, 450);
            this.Controls.Add(this.TbCambio);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TbPago);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TbTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbTelefono);
            this.Controls.Add(this.TbCorreo);
            this.Controls.Add(this.TbNombre);
            this.Controls.Add(this.TbNumeroDocumento);
            this.Controls.Add(this.BtnVenta);
            this.Controls.Add(this.BtnVerificar);
            this.Controls.Add(this.DGVVenta);
            this.Controls.Add(this.panel1);
            this.Name = "VVenta";
            this.Text = "VVenta";
            this.Load += new System.EventHandler(this.VVenta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private DataGridView DGVVenta;
        private TextBox TbCantidad;
        private Label label2;
        private ComboBox CbProducto;
        private Label label1;
        private FontAwesome.Sharp.IconButton BtnAgregarProducto;
        private FontAwesome.Sharp.IconButton BtnVerificar;
        private FontAwesome.Sharp.IconButton BtnVenta;
        private TextBox TbNumeroDocumento;
        private TextBox TbNombre;
        private TextBox TbCorreo;
        private TextBox TbTelefono;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox TbTotal;
        private Label label7;
        private TextBox TbPago;
        private Label label8;
        private Label label9;
        private TextBox TbCambio;
    }
}