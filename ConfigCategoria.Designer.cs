namespace VistasSV
{
    partial class ConfigCategoria
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVCategorias = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CCancelar = new FontAwesome.Sharp.IconButton();
            this.CModificar = new FontAwesome.Sharp.IconButton();
            this.CAgregar = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.CCEstado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CTId = new System.Windows.Forms.TextBox();
            this.CTDescrpcion = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCategorias)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 39);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONFIGURACION DE CATEGORIA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DGVCategorias
            // 
            this.DGVCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Aquamarine;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVCategorias.DefaultCellStyle = dataGridViewCellStyle1;
            this.DGVCategorias.Dock = System.Windows.Forms.DockStyle.Left;
            this.DGVCategorias.Location = new System.Drawing.Point(0, 39);
            this.DGVCategorias.Name = "DGVCategorias";
            this.DGVCategorias.RowHeadersWidth = 51;
            this.DGVCategorias.RowTemplate.Height = 25;
            this.DGVCategorias.Size = new System.Drawing.Size(499, 298);
            this.DGVCategorias.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.CCancelar);
            this.panel2.Controls.Add(this.CModificar);
            this.panel2.Controls.Add(this.CAgregar);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.CCEstado);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.CTId);
            this.panel2.Controls.Add(this.CTDescrpcion);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(499, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(301, 298);
            this.panel2.TabIndex = 2;
            // 
            // CCancelar
            // 
            this.CCancelar.BackColor = System.Drawing.Color.Red;
            this.CCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            this.CCancelar.IconColor = System.Drawing.Color.White;
            this.CCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CCancelar.IconSize = 30;
            this.CCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CCancelar.Location = new System.Drawing.Point(46, 255);
            this.CCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CCancelar.Name = "CCancelar";
            this.CCancelar.Size = new System.Drawing.Size(200, 30);
            this.CCancelar.TabIndex = 10;
            this.CCancelar.Text = "Cancelar";
            this.CCancelar.UseVisualStyleBackColor = false;
            this.CCancelar.Click += new System.EventHandler(this.CCancelar_Click);
            // 
            // CModificar
            // 
            this.CModificar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CModificar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CModificar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CModificar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.CModificar.IconColor = System.Drawing.Color.White;
            this.CModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CModificar.IconSize = 30;
            this.CModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CModificar.Location = new System.Drawing.Point(46, 214);
            this.CModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CModificar.Name = "CModificar";
            this.CModificar.Size = new System.Drawing.Size(200, 30);
            this.CModificar.TabIndex = 9;
            this.CModificar.Text = "Modificar";
            this.CModificar.UseVisualStyleBackColor = false;
            this.CModificar.Click += new System.EventHandler(this.CModificar_Click);
            // 
            // CAgregar
            // 
            this.CAgregar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CAgregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CAgregar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.CAgregar.IconColor = System.Drawing.Color.White;
            this.CAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CAgregar.IconSize = 30;
            this.CAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CAgregar.Location = new System.Drawing.Point(46, 174);
            this.CAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CAgregar.Name = "CAgregar";
            this.CAgregar.Size = new System.Drawing.Size(200, 30);
            this.CAgregar.TabIndex = 8;
            this.CAgregar.Text = "Agregar";
            this.CAgregar.UseVisualStyleBackColor = false;
            this.CAgregar.Click += new System.EventHandler(this.CAgregar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(43, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "ID";
            // 
            // CCEstado
            // 
            this.CCEstado.FormattingEnabled = true;
            this.CCEstado.Items.AddRange(new object[] {
            "true",
            "false"});
            this.CCEstado.Location = new System.Drawing.Point(43, 133);
            this.CCEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CCEstado.Name = "CCEstado";
            this.CCEstado.Size = new System.Drawing.Size(199, 23);
            this.CCEstado.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(43, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(43, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descripcion";
            // 
            // CTId
            // 
            this.CTId.Location = new System.Drawing.Point(187, 1);
            this.CTId.Name = "CTId";
            this.CTId.Size = new System.Drawing.Size(55, 23);
            this.CTId.TabIndex = 2;
            // 
            // CTDescrpcion
            // 
            this.CTDescrpcion.Location = new System.Drawing.Point(43, 77);
            this.CTDescrpcion.Name = "CTDescrpcion";
            this.CTDescrpcion.Size = new System.Drawing.Size(199, 23);
            this.CTDescrpcion.TabIndex = 1;
            // 
            // ConfigCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 337);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DGVCategorias);
            this.Controls.Add(this.panel1);
            this.Name = "ConfigCategoria";
            this.Text = "Config";
            this.Load += new System.EventHandler(this.ConfigCategoria_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCategorias)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView DGVCategorias;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private TextBox CTId;
        private TextBox CTDescrpcion;
        private FontAwesome.Sharp.IconButton CCancelar;
        private FontAwesome.Sharp.IconButton CModificar;
        private FontAwesome.Sharp.IconButton CAgregar;
        private Label label4;
        private ComboBox CCEstado;
    }
}