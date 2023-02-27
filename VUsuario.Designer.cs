namespace VistasSV
{
    partial class VUsuario
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
            this.CrudConteiner = new System.Windows.Forms.Panel();
            this.BuscarB = new FontAwesome.Sharp.IconButton();
            this.LimpiarU = new FontAwesome.Sharp.IconButton();
            this.IDUsuario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddNombre = new System.Windows.Forms.Label();
            this.TBNombreU = new System.Windows.Forms.TextBox();
            this.TBDocumentoU = new System.Windows.Forms.TextBox();
            this.TBCorreoU = new System.Windows.Forms.TextBox();
            this.TBClaveU = new System.Windows.Forms.TextBox();
            this.TBRClaveU = new System.Windows.Forms.TextBox();
            this.CBRolU = new System.Windows.Forms.ComboBox();
            this.CBEstadoU = new System.Windows.Forms.ComboBox();
            this.BtnCancelarUsuario = new FontAwesome.Sharp.IconButton();
            this.BtnAddUsuario = new FontAwesome.Sharp.IconButton();
            this.DGVUsuarios = new System.Windows.Forms.DataGridView();
            this.CrudConteiner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Configuracion De Usuarios";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CrudConteiner
            // 
            this.CrudConteiner.AutoSize = true;
            this.CrudConteiner.Controls.Add(this.BuscarB);
            this.CrudConteiner.Controls.Add(this.LimpiarU);
            this.CrudConteiner.Controls.Add(this.IDUsuario);
            this.CrudConteiner.Controls.Add(this.label8);
            this.CrudConteiner.Controls.Add(this.label7);
            this.CrudConteiner.Controls.Add(this.label6);
            this.CrudConteiner.Controls.Add(this.label5);
            this.CrudConteiner.Controls.Add(this.label4);
            this.CrudConteiner.Controls.Add(this.label3);
            this.CrudConteiner.Controls.Add(this.AddNombre);
            this.CrudConteiner.Controls.Add(this.TBNombreU);
            this.CrudConteiner.Controls.Add(this.TBDocumentoU);
            this.CrudConteiner.Controls.Add(this.TBCorreoU);
            this.CrudConteiner.Controls.Add(this.TBClaveU);
            this.CrudConteiner.Controls.Add(this.TBRClaveU);
            this.CrudConteiner.Controls.Add(this.CBRolU);
            this.CrudConteiner.Controls.Add(this.CBEstadoU);
            this.CrudConteiner.Controls.Add(this.BtnCancelarUsuario);
            this.CrudConteiner.Controls.Add(this.BtnAddUsuario);
            this.CrudConteiner.Dock = System.Windows.Forms.DockStyle.Left;
            this.CrudConteiner.Location = new System.Drawing.Point(0, 34);
            this.CrudConteiner.Name = "CrudConteiner";
            this.CrudConteiner.Size = new System.Drawing.Size(187, 396);
            this.CrudConteiner.TabIndex = 1;
            // 
            // BuscarB
            // 
            this.BuscarB.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BuscarB.IconColor = System.Drawing.Color.Black;
            this.BuscarB.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BuscarB.Location = new System.Drawing.Point(61, 13);
            this.BuscarB.Name = "BuscarB";
            this.BuscarB.Size = new System.Drawing.Size(34, 25);
            this.BuscarB.TabIndex = 18;
            this.BuscarB.Text = "B";
            this.BuscarB.UseVisualStyleBackColor = true;
            // 
            // LimpiarU
            // 
            this.LimpiarU.IconChar = FontAwesome.Sharp.IconChar.None;
            this.LimpiarU.IconColor = System.Drawing.Color.Black;
            this.LimpiarU.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LimpiarU.Location = new System.Drawing.Point(15, 13);
            this.LimpiarU.Name = "LimpiarU";
            this.LimpiarU.Size = new System.Drawing.Size(36, 25);
            this.LimpiarU.TabIndex = 17;
            this.LimpiarU.Text = "L";
            this.LimpiarU.UseVisualStyleBackColor = true;
            this.LimpiarU.Click += new System.EventHandler(this.LimpiarU_Click);
            // 
            // IDUsuario
            // 
            this.IDUsuario.Enabled = false;
            this.IDUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IDUsuario.Location = new System.Drawing.Point(101, 15);
            this.IDUsuario.Name = "IDUsuario";
            this.IDUsuario.Size = new System.Drawing.Size(83, 23);
            this.IDUsuario.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Rol";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Repetir clave";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Clave";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Correo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Documento";
            // 
            // AddNombre
            // 
            this.AddNombre.AutoSize = true;
            this.AddNombre.Location = new System.Drawing.Point(12, 41);
            this.AddNombre.Name = "AddNombre";
            this.AddNombre.Size = new System.Drawing.Size(51, 15);
            this.AddNombre.TabIndex = 9;
            this.AddNombre.Text = "Nombre";
            // 
            // TBNombreU
            // 
            this.TBNombreU.Location = new System.Drawing.Point(11, 59);
            this.TBNombreU.Name = "TBNombreU";
            this.TBNombreU.Size = new System.Drawing.Size(169, 23);
            this.TBNombreU.TabIndex = 8;
            // 
            // TBDocumentoU
            // 
            this.TBDocumentoU.Location = new System.Drawing.Point(13, 103);
            this.TBDocumentoU.Name = "TBDocumentoU";
            this.TBDocumentoU.Size = new System.Drawing.Size(169, 23);
            this.TBDocumentoU.TabIndex = 7;
            // 
            // TBCorreoU
            // 
            this.TBCorreoU.Location = new System.Drawing.Point(12, 147);
            this.TBCorreoU.Name = "TBCorreoU";
            this.TBCorreoU.Size = new System.Drawing.Size(169, 23);
            this.TBCorreoU.TabIndex = 6;
            // 
            // TBClaveU
            // 
            this.TBClaveU.Location = new System.Drawing.Point(11, 191);
            this.TBClaveU.Name = "TBClaveU";
            this.TBClaveU.Size = new System.Drawing.Size(169, 23);
            this.TBClaveU.TabIndex = 5;
            // 
            // TBRClaveU
            // 
            this.TBRClaveU.Location = new System.Drawing.Point(12, 235);
            this.TBRClaveU.Name = "TBRClaveU";
            this.TBRClaveU.Size = new System.Drawing.Size(169, 23);
            this.TBRClaveU.TabIndex = 4;
            // 
            // CBRolU
            // 
            this.CBRolU.FormattingEnabled = true;
            this.CBRolU.Items.AddRange(new object[] {
            "Admin",
            "Empleado"});
            this.CBRolU.Location = new System.Drawing.Point(12, 279);
            this.CBRolU.Name = "CBRolU";
            this.CBRolU.Size = new System.Drawing.Size(172, 23);
            this.CBRolU.TabIndex = 3;
            // 
            // CBEstadoU
            // 
            this.CBEstadoU.FormattingEnabled = true;
            this.CBEstadoU.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.CBEstadoU.Location = new System.Drawing.Point(11, 323);
            this.CBEstadoU.Name = "CBEstadoU";
            this.CBEstadoU.Size = new System.Drawing.Size(173, 23);
            this.CBEstadoU.TabIndex = 2;
            // 
            // BtnCancelarUsuario
            // 
            this.BtnCancelarUsuario.BackColor = System.Drawing.Color.Red;
            this.BtnCancelarUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCancelarUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCancelarUsuario.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnCancelarUsuario.IconColor = System.Drawing.Color.Black;
            this.BtnCancelarUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCancelarUsuario.Location = new System.Drawing.Point(109, 361);
            this.BtnCancelarUsuario.Name = "BtnCancelarUsuario";
            this.BtnCancelarUsuario.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelarUsuario.TabIndex = 1;
            this.BtnCancelarUsuario.Text = "CANCELAR";
            this.BtnCancelarUsuario.UseVisualStyleBackColor = false;
            // 
            // BtnAddUsuario
            // 
            this.BtnAddUsuario.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnAddUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAddUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAddUsuario.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnAddUsuario.IconColor = System.Drawing.Color.Black;
            this.BtnAddUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAddUsuario.Location = new System.Drawing.Point(11, 361);
            this.BtnAddUsuario.Name = "BtnAddUsuario";
            this.BtnAddUsuario.Size = new System.Drawing.Size(75, 23);
            this.BtnAddUsuario.TabIndex = 0;
            this.BtnAddUsuario.Text = "GUARDAR";
            this.BtnAddUsuario.UseVisualStyleBackColor = false;
            this.BtnAddUsuario.Click += new System.EventHandler(this.BtnAddUsuario_Click);
            // 
            // DGVUsuarios
            // 
            this.DGVUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVUsuarios.Location = new System.Drawing.Point(187, 34);
            this.DGVUsuarios.Name = "DGVUsuarios";
            this.DGVUsuarios.RowTemplate.Height = 25;
            this.DGVUsuarios.Size = new System.Drawing.Size(613, 396);
            this.DGVUsuarios.TabIndex = 2;
            this.DGVUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVUsuarios_CellClick_1);
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 430);
            this.Controls.Add(this.DGVUsuarios);
            this.Controls.Add(this.CrudConteiner);
            this.Controls.Add(this.label1);
            this.Name = "Usuario";
            this.Text = "User";
            this.Load += new System.EventHandler(this.Usuario_Load);
            this.CrudConteiner.ResumeLayout(false);
            this.CrudConteiner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel CrudConteiner;
        private TextBox IDUsuario;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label AddNombre;
        private TextBox TBNombreU;
        private TextBox TBDocumentoU;
        private TextBox TBCorreoU;
        private TextBox TBClaveU;
        private TextBox TBRClaveU;
        private ComboBox CBRolU;
        private ComboBox CBEstadoU;
        private FontAwesome.Sharp.IconButton BtnCancelarUsuario;
        private FontAwesome.Sharp.IconButton BtnAddUsuario;
        private DataGridView DGVUsuarios;
        private FontAwesome.Sharp.IconButton BuscarB;
        private FontAwesome.Sharp.IconButton LimpiarU;
    }
}