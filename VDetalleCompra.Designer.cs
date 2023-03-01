namespace VistasSV
{
    partial class VDetalleCompra
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
            LVUsuario = new Label();
            LCliente = new Label();
            LUsuario = new Label();
            label3 = new Label();
            BtnBuscarCompra = new FontAwesome.Sharp.IconButton();
            DGVDetalleCompra = new DataGridView();
            TbBuscarCompra = new TextBox();
            label2 = new Label();
            label1 = new Label();
            LTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)DGVDetalleCompra).BeginInit();
            SuspendLayout();
            // 
            // LVUsuario
            // 
            LVUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LVUsuario.ForeColor = SystemColors.ControlLightLight;
            LVUsuario.Location = new Point(141, 121);
            LVUsuario.Name = "LVUsuario";
            LVUsuario.Size = new Size(220, 23);
            LVUsuario.TabIndex = 20;
            // 
            // LCliente
            // 
            LCliente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LCliente.ForeColor = SystemColors.ControlLightLight;
            LCliente.Location = new Point(377, 121);
            LCliente.Name = "LCliente";
            LCliente.Size = new Size(73, 23);
            LCliente.TabIndex = 19;
            LCliente.Text = "Proveedor:";
            // 
            // LUsuario
            // 
            LUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LUsuario.ForeColor = SystemColors.ControlLightLight;
            LUsuario.Location = new Point(78, 122);
            LUsuario.Name = "LUsuario";
            LUsuario.Size = new Size(56, 23);
            LUsuario.TabIndex = 18;
            LUsuario.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(396, 397);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 16;
            label3.Text = "Total Pagado   $";
            // 
            // BtnBuscarCompra
            // 
            BtnBuscarCompra.BackColor = SystemColors.ControlLightLight;
            BtnBuscarCompra.ForeColor = SystemColors.ControlLightLight;
            BtnBuscarCompra.IconChar = FontAwesome.Sharp.IconChar.SearchDollar;
            BtnBuscarCompra.IconColor = Color.DodgerBlue;
            BtnBuscarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnBuscarCompra.IconSize = 30;
            BtnBuscarCompra.Location = new Point(545, 82);
            BtnBuscarCompra.Name = "BtnBuscarCompra";
            BtnBuscarCompra.Size = new Size(42, 35);
            BtnBuscarCompra.TabIndex = 15;
            BtnBuscarCompra.UseVisualStyleBackColor = false;
            BtnBuscarCompra.Click += BtnBuscarCompra_Click;
            // 
            // DGVDetalleCompra
            // 
            DGVDetalleCompra.BackgroundColor = Color.DodgerBlue;
            DGVDetalleCompra.BorderStyle = BorderStyle.Fixed3D;
            DGVDetalleCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVDetalleCompra.Location = new Point(78, 156);
            DGVDetalleCompra.Name = "DGVDetalleCompra";
            DGVDetalleCompra.RowTemplate.Height = 25;
            DGVDetalleCompra.Size = new Size(653, 220);
            DGVDetalleCompra.TabIndex = 14;
            // 
            // TbBuscarCompra
            // 
            TbBuscarCompra.Location = new Point(326, 89);
            TbBuscarCompra.Name = "TbBuscarCompra";
            TbBuscarCompra.Size = new Size(198, 23);
            TbBuscarCompra.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(220, 92);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 12;
            label2.Text = "Buscar Compra";
            // 
            // label1
            // 
            label1.BackColor = Color.DodgerBlue;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(800, 29);
            label1.TabIndex = 11;
            label1.Text = "Detalle De Compra";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LTotal
            // 
            LTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LTotal.ForeColor = SystemColors.ControlLightLight;
            LTotal.Location = new Point(505, 379);
            LTotal.Name = "LTotal";
            LTotal.Size = new Size(182, 33);
            LTotal.TabIndex = 22;
            // 
            // VDetalleCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(LTotal);
            Controls.Add(LVUsuario);
            Controls.Add(LCliente);
            Controls.Add(LUsuario);
            Controls.Add(label3);
            Controls.Add(BtnBuscarCompra);
            Controls.Add(DGVDetalleCompra);
            Controls.Add(TbBuscarCompra);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "VDetalleCompra";
            Text = "DetalleCompra";
            Load += VDetalleCompra_Load;
            ((System.ComponentModel.ISupportInitialize)DGVDetalleCompra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LVCliente;

        public Label LBProveedor { get; private set; }

        private Label LVUsuario;
        private Label LCliente;
        private Label LUsuario;
        private TextBox textBox1;
        private Label label3;
        private FontAwesome.Sharp.IconButton BtnBuscarCompra;
        private DataGridView DGVDetalleCompra;
        private TextBox TbBuscarCompra;
        private Label label2;
        private Label label1;
        private Label LTotal;
    }
}