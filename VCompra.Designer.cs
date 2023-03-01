namespace VistasSV
{
    partial class VCompra
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
            DGVCompra = new DataGridView();
            label2 = new Label();
            TbDocumentoC = new TextBox();
            TbRazonC = new TextBox();
            label3 = new Label();
            TbCorreoC = new TextBox();
            label4 = new Label();
            BtnBuscarP = new FontAwesome.Sharp.IconButton();
            label5 = new Label();
            label6 = new Label();
            BtnCompra = new FontAwesome.Sharp.IconButton();
            TbTotalC = new TextBox();
            label7 = new Label();
            label8 = new Label();
            CbPC = new ComboBox();
            NCantidad = new NumericUpDown();
            label9 = new Label();
            AddPCompra = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)DGVCompra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NCantidad).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(861, 33);
            label1.TabIndex = 0;
            label1.Text = "Vista Compra";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DGVCompra
            // 
            DGVCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVCompra.Location = new Point(22, 63);
            DGVCompra.Name = "DGVCompra";
            DGVCompra.RowTemplate.Height = 25;
            DGVCompra.Size = new Size(577, 271);
            DGVCompra.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(643, 73);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 2;
            label2.Text = "Documento";
            // 
            // TbDocumentoC
            // 
            TbDocumentoC.Location = new Point(643, 91);
            TbDocumentoC.Name = "TbDocumentoC";
            TbDocumentoC.Size = new Size(189, 23);
            TbDocumentoC.TabIndex = 3;
            // 
            // TbRazonC
            // 
            TbRazonC.Location = new Point(643, 144);
            TbRazonC.Name = "TbRazonC";
            TbRazonC.Size = new Size(189, 23);
            TbRazonC.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(643, 126);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 4;
            label3.Text = "Razon social";
            // 
            // TbCorreoC
            // 
            TbCorreoC.Location = new Point(643, 199);
            TbCorreoC.Name = "TbCorreoC";
            TbCorreoC.Size = new Size(189, 23);
            TbCorreoC.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(643, 181);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 6;
            label4.Text = "Correo";
            // 
            // BtnBuscarP
            // 
            BtnBuscarP.BackColor = Color.DodgerBlue;
            BtnBuscarP.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            BtnBuscarP.ForeColor = SystemColors.ControlLightLight;
            BtnBuscarP.IconChar = FontAwesome.Sharp.IconChar.SearchPlus;
            BtnBuscarP.IconColor = SystemColors.ControlLightLight;
            BtnBuscarP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnBuscarP.IconSize = 40;
            BtnBuscarP.ImageAlign = ContentAlignment.MiddleRight;
            BtnBuscarP.Location = new Point(643, 240);
            BtnBuscarP.Name = "BtnBuscarP";
            BtnBuscarP.Size = new Size(185, 44);
            BtnBuscarP.TabIndex = 8;
            BtnBuscarP.Text = "Buscar Proveedor";
            BtnBuscarP.TextAlign = ContentAlignment.MiddleLeft;
            BtnBuscarP.UseVisualStyleBackColor = false;
            BtnBuscarP.Click += BtnBuscarP_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(22, 33);
            label5.Name = "label5";
            label5.Size = new Size(124, 23);
            label5.TabIndex = 9;
            label5.Text = "Lista Productos";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(697, 37);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 10;
            label6.Text = "Proveedor";
            // 
            // BtnCompra
            // 
            BtnCompra.BackColor = Color.DodgerBlue;
            BtnCompra.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCompra.ForeColor = SystemColors.ControlLightLight;
            BtnCompra.IconChar = FontAwesome.Sharp.IconChar.CartArrowDown;
            BtnCompra.IconColor = SystemColors.ControlLightLight;
            BtnCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnCompra.IconSize = 40;
            BtnCompra.ImageAlign = ContentAlignment.MiddleRight;
            BtnCompra.Location = new Point(643, 307);
            BtnCompra.Name = "BtnCompra";
            BtnCompra.Size = new Size(185, 44);
            BtnCompra.TabIndex = 11;
            BtnCompra.Text = "Comprar";
            BtnCompra.TextAlign = ContentAlignment.MiddleLeft;
            BtnCompra.UseVisualStyleBackColor = false;
            BtnCompra.Click += BtnCompra_Click;
            // 
            // TbTotalC
            // 
            TbTotalC.Location = new Point(433, 340);
            TbTotalC.Name = "TbTotalC";
            TbTotalC.Size = new Size(166, 23);
            TbTotalC.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(349, 343);
            label7.Name = "label7";
            label7.Size = new Size(68, 15);
            label7.TabIndex = 13;
            label7.Text = "Total Pagar";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(172, 40);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
            label8.TabIndex = 14;
            label8.Text = "Producto:";
            // 
            // CbPC
            // 
            CbPC.FormattingEnabled = true;
            CbPC.Location = new Point(236, 34);
            CbPC.Name = "CbPC";
            CbPC.Size = new Size(198, 23);
            CbPC.TabIndex = 15;
            // 
            // NCantidad
            // 
            NCantidad.Location = new Point(481, 35);
            NCantidad.Name = "NCantidad";
            NCantidad.Size = new Size(66, 23);
            NCantidad.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(440, 41);
            label9.Name = "label9";
            label9.Size = new Size(35, 15);
            label9.TabIndex = 17;
            label9.Text = "Cant:";
            // 
            // AddPCompra
            // 
            AddPCompra.BackColor = Color.DodgerBlue;
            AddPCompra.Cursor = Cursors.Hand;
            AddPCompra.FlatAppearance.BorderColor = Color.Black;
            AddPCompra.IconChar = FontAwesome.Sharp.IconChar.CheckDouble;
            AddPCompra.IconColor = Color.White;
            AddPCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            AddPCompra.IconSize = 20;
            AddPCompra.Location = new Point(562, 33);
            AddPCompra.Name = "AddPCompra";
            AddPCompra.Size = new Size(37, 27);
            AddPCompra.TabIndex = 18;
            AddPCompra.UseVisualStyleBackColor = false;
            AddPCompra.Click += AddPCompra_Click_1;
            // 
            // VCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(861, 409);
            Controls.Add(AddPCompra);
            Controls.Add(label9);
            Controls.Add(NCantidad);
            Controls.Add(CbPC);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(TbTotalC);
            Controls.Add(BtnCompra);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(BtnBuscarP);
            Controls.Add(TbCorreoC);
            Controls.Add(label4);
            Controls.Add(TbRazonC);
            Controls.Add(label3);
            Controls.Add(TbDocumentoC);
            Controls.Add(label2);
            Controls.Add(DGVCompra);
            Controls.Add(label1);
            Name = "VCompra";
            Text = "Compra";
            Load += VCompra_Load;
            ((System.ComponentModel.ISupportInitialize)DGVCompra).EndInit();
            ((System.ComponentModel.ISupportInitialize)NCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView DGVCompra;
        private Label label2;
        private TextBox TbDocumentoC;
        private TextBox TbRazonC;
        private Label label3;
        private TextBox TbCorreoC;
        private Label label4;
        private FontAwesome.Sharp.IconButton BtnBuscarP;
        private Label label5;
        private Label label6;
        private FontAwesome.Sharp.IconButton iconButton2;
        private TextBox TbTotalC;
        private Label label7;
        private Label label8;
        private ComboBox CbPC;
        private NumericUpDown NCantidad;
        private Label label9;
        private FontAwesome.Sharp.IconButton AddPCompra;
        private FontAwesome.Sharp.IconButton BtnCompra;
    }
}