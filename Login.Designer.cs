namespace VistasSV
{
    partial class Login
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
            this.PanelLogin = new System.Windows.Forms.Panel();
            this.IconoLogin = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UsuarioLogin = new System.Windows.Forms.TextBox();
            this.PasswordLogin = new System.Windows.Forms.TextBox();
            this.BtnEntrarLogin = new FontAwesome.Sharp.IconButton();
            this.BtnCancelarLogin = new FontAwesome.Sharp.IconButton();
            this.PanelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconoLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelLogin
            // 
            this.PanelLogin.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.PanelLogin.Controls.Add(this.IconoLogin);
            this.PanelLogin.Controls.Add(this.label1);
            this.PanelLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLogin.Location = new System.Drawing.Point(0, 0);
            this.PanelLogin.Name = "PanelLogin";
            this.PanelLogin.Size = new System.Drawing.Size(200, 198);
            this.PanelLogin.TabIndex = 0;
            // 
            // IconoLogin
            // 
            this.IconoLogin.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.IconoLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IconoLogin.IconChar = FontAwesome.Sharp.IconChar.UserSecret;
            this.IconoLogin.IconColor = System.Drawing.SystemColors.ControlText;
            this.IconoLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconoLogin.IconSize = 124;
            this.IconoLogin.Location = new System.Drawing.Point(28, 16);
            this.IconoLogin.Name = "IconoLogin";
            this.IconoLogin.Size = new System.Drawing.Size(125, 124);
            this.IconoLogin.TabIndex = 2;
            this.IconoLogin.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(10, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Servicio De Venta";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(226, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "USUARIO";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(226, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "CONTRASEÑA";
            // 
            // UsuarioLogin
            // 
            this.UsuarioLogin.Location = new System.Drawing.Point(226, 42);
            this.UsuarioLogin.Name = "UsuarioLogin";
            this.UsuarioLogin.Size = new System.Drawing.Size(170, 23);
            this.UsuarioLogin.TabIndex = 3;
            // 
            // PasswordLogin
            // 
            this.PasswordLogin.Location = new System.Drawing.Point(226, 117);
            this.PasswordLogin.Name = "PasswordLogin";
            this.PasswordLogin.PasswordChar = '#';
            this.PasswordLogin.Size = new System.Drawing.Size(170, 23);
            this.PasswordLogin.TabIndex = 4;
            // 
            // BtnEntrarLogin
            // 
            this.BtnEntrarLogin.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnEntrarLogin.IconColor = System.Drawing.Color.Black;
            this.BtnEntrarLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEntrarLogin.Location = new System.Drawing.Point(227, 163);
            this.BtnEntrarLogin.Name = "BtnEntrarLogin";
            this.BtnEntrarLogin.Size = new System.Drawing.Size(75, 23);
            this.BtnEntrarLogin.TabIndex = 5;
            this.BtnEntrarLogin.Text = "ENTRAR";
            this.BtnEntrarLogin.UseVisualStyleBackColor = true;
            this.BtnEntrarLogin.Click += new System.EventHandler(this.BtnEntrarLogin_Click_1);
            // 
            // BtnCancelarLogin
            // 
            this.BtnCancelarLogin.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BtnCancelarLogin.IconColor = System.Drawing.Color.Black;
            this.BtnCancelarLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCancelarLogin.Location = new System.Drawing.Point(321, 163);
            this.BtnCancelarLogin.Name = "BtnCancelarLogin";
            this.BtnCancelarLogin.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelarLogin.TabIndex = 6;
            this.BtnCancelarLogin.Text = "CANCELAR";
            this.BtnCancelarLogin.UseVisualStyleBackColor = true;
            this.BtnCancelarLogin.Click += new System.EventHandler(this.BtnCancelarLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 198);
            this.Controls.Add(this.BtnCancelarLogin);
            this.Controls.Add(this.BtnEntrarLogin);
            this.Controls.Add(this.PasswordLogin);
            this.Controls.Add(this.UsuarioLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PanelLogin);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.PanelLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IconoLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel PanelLogin;
        
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox UsuarioLogin;
        private TextBox PasswordLogin;
        private FontAwesome.Sharp.IconPictureBox IconoLogin;
        private FontAwesome.Sharp.IconButton BtnEntrarLogin;
        private FontAwesome.Sharp.IconButton BtnCancelarLogin;
    }
}