namespace VistasSV
{
    partial class VProveedor
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
            DGVProveedores = new DataGridView();
            label2 = new Label();
            TbdocumentoP = new TextBox();
            TbRazonSocialP = new TextBox();
            TbCorreoP = new TextBox();
            TbTelefonoP = new TextBox();
            TbIdP = new TextBox();
            AddP = new FontAwesome.Sharp.IconButton();
            UpdateP = new FontAwesome.Sharp.IconButton();
            DeleteP = new FontAwesome.Sharp.IconButton();
            CBActivo = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)DGVProveedores).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(197, 23);
            label1.Name = "label1";
            label1.Size = new Size(190, 25);
            label1.TabIndex = 0;
            label1.Text = "Lista De Proveedores";
            // 
            // DGVProveedores
            // 
            DGVProveedores.BackgroundColor = Color.DodgerBlue;
            DGVProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVProveedores.GridColor = Color.DodgerBlue;
            DGVProveedores.Location = new Point(4, 69);
            DGVProveedores.Name = "DGVProveedores";
            DGVProveedores.RowTemplate.Height = 25;
            DGVProveedores.Size = new Size(619, 300);
            DGVProveedores.TabIndex = 1;
            DGVProveedores.CellClick += DGVProveedores_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(639, 23);
            label2.Name = "label2";
            label2.Size = new Size(225, 25);
            label2.TabIndex = 2;
            label2.Text = "Configuracion Proveedor";
            // 
            // TbdocumentoP
            // 
            TbdocumentoP.Location = new Point(645, 112);
            TbdocumentoP.Name = "TbdocumentoP";
            TbdocumentoP.Size = new Size(203, 23);
            TbdocumentoP.TabIndex = 3;
            // 
            // TbRazonSocialP
            // 
            TbRazonSocialP.Location = new Point(645, 168);
            TbRazonSocialP.Name = "TbRazonSocialP";
            TbRazonSocialP.Size = new Size(203, 23);
            TbRazonSocialP.TabIndex = 4;
            // 
            // TbCorreoP
            // 
            TbCorreoP.Location = new Point(645, 225);
            TbCorreoP.Name = "TbCorreoP";
            TbCorreoP.Size = new Size(203, 23);
            TbCorreoP.TabIndex = 5;
            // 
            // TbTelefonoP
            // 
            TbTelefonoP.Location = new Point(645, 282);
            TbTelefonoP.Name = "TbTelefonoP";
            TbTelefonoP.Size = new Size(203, 23);
            TbTelefonoP.TabIndex = 6;
            // 
            // TbIdP
            // 
            TbIdP.Enabled = false;
            TbIdP.Location = new Point(645, 60);
            TbIdP.Name = "TbIdP";
            TbIdP.Size = new Size(100, 23);
            TbIdP.TabIndex = 7;
            // 
            // AddP
            // 
            AddP.BackColor = Color.DodgerBlue;
            AddP.ForeColor = Color.DodgerBlue;
            AddP.IconChar = FontAwesome.Sharp.IconChar.Plus;
            AddP.IconColor = Color.WhiteSmoke;
            AddP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            AddP.IconSize = 30;
            AddP.Location = new Point(645, 324);
            AddP.Name = "AddP";
            AddP.Size = new Size(45, 42);
            AddP.TabIndex = 8;
            AddP.UseVisualStyleBackColor = false;
            AddP.Click += AddP_Click;
            // 
            // UpdateP
            // 
            UpdateP.BackColor = Color.DodgerBlue;
            UpdateP.ForeColor = Color.DodgerBlue;
            UpdateP.IconChar = FontAwesome.Sharp.IconChar.Pen;
            UpdateP.IconColor = Color.WhiteSmoke;
            UpdateP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            UpdateP.IconSize = 30;
            UpdateP.Location = new Point(725, 324);
            UpdateP.Name = "UpdateP";
            UpdateP.Size = new Size(43, 42);
            UpdateP.TabIndex = 9;
            UpdateP.UseVisualStyleBackColor = false;
            UpdateP.Click += UpdateP_Click;
            // 
            // DeleteP
            // 
            DeleteP.BackColor = Color.DodgerBlue;
            DeleteP.ForeColor = Color.DodgerBlue;
            DeleteP.IconChar = FontAwesome.Sharp.IconChar.Trash;
            DeleteP.IconColor = Color.WhiteSmoke;
            DeleteP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            DeleteP.IconSize = 30;
            DeleteP.Location = new Point(806, 324);
            DeleteP.Name = "DeleteP";
            DeleteP.Size = new Size(42, 42);
            DeleteP.TabIndex = 10;
            DeleteP.UseVisualStyleBackColor = false;
            DeleteP.Click += DeleteP_Click;
            // 
            // CBActivo
            // 
            CBActivo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CBActivo.ForeColor = SystemColors.ControlLightLight;
            CBActivo.Location = new Point(760, 59);
            CBActivo.Name = "CBActivo";
            CBActivo.Size = new Size(97, 24);
            CBActivo.TabIndex = 11;
            CBActivo.Text = "Desactivado";
            CBActivo.UseVisualStyleBackColor = true;
            CBActivo.CheckedChanged += CBActivo_CheckedChanged;
            // 
            // VProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(876, 450);
            Controls.Add(CBActivo);
            Controls.Add(DeleteP);
            Controls.Add(UpdateP);
            Controls.Add(AddP);
            Controls.Add(TbIdP);
            Controls.Add(TbTelefonoP);
            Controls.Add(TbCorreoP);
            Controls.Add(TbRazonSocialP);
            Controls.Add(TbdocumentoP);
            Controls.Add(label2);
            Controls.Add(DGVProveedores);
            Controls.Add(label1);
            Name = "VProveedor";
            Text = "Proveedor";
            Load += VProveedor_Load;
            ((System.ComponentModel.ISupportInitialize)DGVProveedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView DGVProveedores;
        private Label label2;
        private TextBox TbdocumentoP;
        private TextBox TbRazonSocialP;
        private TextBox TbCorreoP;
        private TextBox TbTelefonoP;
        private TextBox TbIdP;
        private FontAwesome.Sharp.IconButton AddP;
        private FontAwesome.Sharp.IconButton UpdateP;
        private FontAwesome.Sharp.IconButton DeleteP;
        private CheckBox CBActivo;
    }
}