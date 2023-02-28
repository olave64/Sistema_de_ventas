using Entidades;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistasSV
{
    public partial class Inicio : Form
    {
        private Usuario usuarioActual;
        private static IconMenuItem menuActivo = new();
        private static Form formularioActivo = new();
        public Inicio(Usuario usuario)
        {
            usuarioActual = usuario;
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            LNUsuario.Text = usuarioActual.Nombre;
        }

        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login login = new();
            login.Show();
        }
        private void AddForm(IconMenuItem iconMenuItem, Form form)
        {

            if (menuActivo != null)
            {
                menuActivo.BackColor = Color.White;
            }
            iconMenuItem.BackColor = Color.Silver;
            menuActivo = iconMenuItem;
            formularioActivo.Close();
            formularioActivo = form;

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.BackColor = Color.SteelBlue;
            ContenedorInicio.Controls.Add(form);
            form.Show();

        }

        private void MUser_Click(object sender, EventArgs e)
        {
            AddForm((IconMenuItem)sender, new VUsuario());
        }

        private void ConfigCategoria_Click(object sender, EventArgs e)
        {
            AddForm(MConfig, new ConfigCategoria());
        }

        private void ConfigProducto_Click(object sender, EventArgs e)
        {
            AddForm(MConfig, new ConfigProducto());
        }

        private void MRegistarVenta_Click(object sender, EventArgs e)
        {
            AddForm(MVentas, new VVenta(usuarioActual));
        }

        private void MDetalleVenta_Click(object sender, EventArgs e)
        {
            AddForm(MVentas, new VDetalleVenta());
        }

        private void MProveedores_Click(object sender, EventArgs e)
        {
            AddForm((IconMenuItem)sender, new VProveedor());
        }

        private void registrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddForm(MCompras, new VCompra(usuarioActual));
        }
    }
}
