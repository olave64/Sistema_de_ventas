using Controladores;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace VistasSV
{
    public partial class Login : Form
    {
        private Usuario? usuario = new(); 
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnEntrarLogin_Click_1(object sender, EventArgs e)
        {
            List<Usuario> listUsuario = new UsuarioController().BuscarUsuarios();
            usuario = new UsuarioController().BuscarUsuarios()
                .Where(us => us.Documento == UsuarioLogin.Text && us.Clave == PasswordLogin.Text)
                .FirstOrDefault();
            if (usuario != null)
            {
                Inicio inicio = new (usuario);
                inicio.Show();
                this.Hide();
                //inicio.FormClosing += Frm_closing;
                Frm_closing();
            }
            else
            {
                MessageBox.Show("######## NO  ENCONTRADO########");
            }
        }

        private void Frm_closing() 
        {
            PasswordLogin.Text = "";  
            UsuarioLogin.Text= "";
            this.Hide();

        }

        private void BtnCancelarLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
