namespace VistasSV
{
    partial class VDetalleVenta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbBuscarVenta = new System.Windows.Forms.TextBox();
            this.DGVDetalleVenta = new System.Windows.Forms.DataGridView();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LUsuario = new System.Windows.Forms.Label();
            this.LCliente = new System.Windows.Forms.Label();
            this.LVUsuario = new System.Windows.Forms.Label();
            this.LVCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDetalleVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detalle De Venta";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(220, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar Venta";
            // 
            // TbBuscarVenta
            // 
            this.TbBuscarVenta.Location = new System.Drawing.Point(326, 56);
            this.TbBuscarVenta.Name = "TbBuscarVenta";
            this.TbBuscarVenta.Size = new System.Drawing.Size(198, 23);
            this.TbBuscarVenta.TabIndex = 2;
            // 
            // DGVDetalleVenta
            // 
            this.DGVDetalleVenta.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.DGVDetalleVenta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDetalleVenta.Location = new System.Drawing.Point(78, 143);
            this.DGVDetalleVenta.Name = "DGVDetalleVenta";
            this.DGVDetalleVenta.RowTemplate.Height = 25;
            this.DGVDetalleVenta.Size = new System.Drawing.Size(653, 220);
            this.DGVDetalleVenta.TabIndex = 3;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.SearchDollar;
            this.iconButton1.IconColor = System.Drawing.Color.DodgerBlue;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(545, 49);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(42, 35);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(396, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total Pagado";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(491, 381);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 23);
            this.textBox1.TabIndex = 6;
            // 
            // LUsuario
            // 
            this.LUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LUsuario.Location = new System.Drawing.Point(78, 109);
            this.LUsuario.Name = "LUsuario";
            this.LUsuario.Size = new System.Drawing.Size(56, 23);
            this.LUsuario.TabIndex = 7;
            this.LUsuario.Text = "Usuario:";
            // 
            // LCliente
            // 
            this.LCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LCliente.Location = new System.Drawing.Point(396, 108);
            this.LCliente.Name = "LCliente";
            this.LCliente.Size = new System.Drawing.Size(56, 23);
            this.LCliente.TabIndex = 8;
            this.LCliente.Text = "Cliente:";
            // 
            // LVUsuario
            // 
            this.LVUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LVUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LVUsuario.Location = new System.Drawing.Point(141, 108);
            this.LVUsuario.Name = "LVUsuario";
            this.LVUsuario.Size = new System.Drawing.Size(249, 23);
            this.LVUsuario.TabIndex = 9;
            // 
            // LVCliente
            // 
            this.LVCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LVCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LVCliente.Location = new System.Drawing.Point(458, 108);
            this.LVCliente.Name = "LVCliente";
            this.LVCliente.Size = new System.Drawing.Size(273, 23);
            this.LVCliente.TabIndex = 10;
            // 
            // VDetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LVCliente);
            this.Controls.Add(this.LVUsuario);
            this.Controls.Add(this.LCliente);
            this.Controls.Add(this.LUsuario);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.DGVDetalleVenta);
            this.Controls.Add(this.TbBuscarVenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VDetalleVenta";
            this.Text = "DetalleVenta";
            this.Load += new System.EventHandler(this.VDetalleVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDetalleVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TbBuscarVenta;
        private DataGridView DGVDetalleVenta;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label3;
        private TextBox textBox1;
        private Label LUsuario;
        private Label LCliente;
        private Label LVUsuario;
        private Label LVCliente;
    }
}