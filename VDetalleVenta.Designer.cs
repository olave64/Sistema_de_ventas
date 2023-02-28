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
            label1 = new Label();
            label2 = new Label();
            TbBuscarVenta = new TextBox();
            DGVDetalleVenta = new DataGridView();
            BuscarDV = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            textBox1 = new TextBox();
            LUsuario = new Label();
            LCliente = new Label();
            LVUsuario = new Label();
            LVCliente = new Label();
            ((System.ComponentModel.ISupportInitialize)DGVDetalleVenta).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(800, 29);
            label1.TabIndex = 0;
            label1.Text = "Detalle De Venta";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(220, 59);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 1;
            label2.Text = "Buscar Venta";
            // 
            // TbBuscarVenta
            // 
            TbBuscarVenta.Location = new Point(326, 56);
            TbBuscarVenta.Name = "TbBuscarVenta";
            TbBuscarVenta.Size = new Size(198, 23);
            TbBuscarVenta.TabIndex = 2;
            // 
            // DGVDetalleVenta
            // 
            DGVDetalleVenta.BackgroundColor = Color.DodgerBlue;
            DGVDetalleVenta.BorderStyle = BorderStyle.Fixed3D;
            DGVDetalleVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVDetalleVenta.Location = new Point(78, 123);
            DGVDetalleVenta.Name = "DGVDetalleVenta";
            DGVDetalleVenta.RowTemplate.Height = 25;
            DGVDetalleVenta.Size = new Size(653, 220);
            DGVDetalleVenta.TabIndex = 3;
            // 
            // BuscarDV
            // 
            BuscarDV.BackColor = SystemColors.ControlLightLight;
            BuscarDV.ForeColor = SystemColors.ControlLightLight;
            BuscarDV.IconChar = FontAwesome.Sharp.IconChar.SearchDollar;
            BuscarDV.IconColor = Color.DodgerBlue;
            BuscarDV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BuscarDV.IconSize = 30;
            BuscarDV.Location = new Point(545, 49);
            BuscarDV.Name = "BuscarDV";
            BuscarDV.Size = new Size(42, 35);
            BuscarDV.TabIndex = 4;
            BuscarDV.UseVisualStyleBackColor = false;
            BuscarDV.Click += iconButton1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(396, 364);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 5;
            label3.Text = "Total Pagado";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(491, 361);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(204, 23);
            textBox1.TabIndex = 6;
            // 
            // LUsuario
            // 
            LUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LUsuario.ForeColor = SystemColors.ControlLightLight;
            LUsuario.Location = new Point(78, 89);
            LUsuario.Name = "LUsuario";
            LUsuario.Size = new Size(56, 23);
            LUsuario.TabIndex = 7;
            LUsuario.Text = "Usuario:";
            // 
            // LCliente
            // 
            LCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LCliente.ForeColor = SystemColors.ControlLightLight;
            LCliente.Location = new Point(396, 88);
            LCliente.Name = "LCliente";
            LCliente.Size = new Size(56, 23);
            LCliente.TabIndex = 8;
            LCliente.Text = "Cliente:";
            // 
            // LVUsuario
            // 
            LVUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LVUsuario.ForeColor = SystemColors.ControlLightLight;
            LVUsuario.Location = new Point(141, 88);
            LVUsuario.Name = "LVUsuario";
            LVUsuario.Size = new Size(249, 23);
            LVUsuario.TabIndex = 9;
            // 
            // LVCliente
            // 
            LVCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LVCliente.ForeColor = SystemColors.ControlLightLight;
            LVCliente.Location = new Point(458, 88);
            LVCliente.Name = "LVCliente";
            LVCliente.Size = new Size(273, 23);
            LVCliente.TabIndex = 10;
            // 
            // VDetalleVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(LVCliente);
            Controls.Add(LVUsuario);
            Controls.Add(LCliente);
            Controls.Add(LUsuario);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(BuscarDV);
            Controls.Add(DGVDetalleVenta);
            Controls.Add(TbBuscarVenta);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "VDetalleVenta";
            Text = "DetalleVenta";
            Load += VDetalleVenta_Load;
            ((System.ComponentModel.ISupportInitialize)DGVDetalleVenta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TbBuscarVenta;
        private DataGridView DGVDetalleVenta;
        private FontAwesome.Sharp.IconButton BuscarDV;
        private Label label3;
        private TextBox textBox1;
        private Label LUsuario;
        private Label LCliente;
        private Label LVUsuario;
        private Label LVCliente;
    }
}