using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using VistasSV.Controller;
using VistasSV.Entidades;

namespace VistasSV
{
    public partial class ConfigCategoria : Form
    {
        private CategoriaController categoriaController = new();
        public ConfigCategoria()
        {
            InitializeComponent();
            
        }

        private void ConfigCategoria_Load(object sender, EventArgs e)
        {

            List<Categoria> categorias = new CategoriaController().GetCategoria();
            DGVCategorias.DataSource = categorias;
        }

        private void CAgregar_Click(object sender, EventArgs e)
        {
            categoriaController.SetCategoria(CTDescrpcion.Text, Convert.ToBoolean( CCEstado.Text));
        }

        private void CModificar_Click(object sender, EventArgs e)
        { 
            categoriaController.SetCategoria(Convert.ToInt32( CTId.Text), CTDescrpcion.Text, Convert.ToBoolean(CCEstado.Text));
        }

        private void CCancelar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(CTId.Text);
            DialogResult confirmar = MessageBox.Show("Desea eliminar la categoria" + id, "Confirmacion", MessageBoxButtons.YesNo);
            if (confirmar == DialogResult.Yes) 
            {
                categoriaController.DeleteCategoria(id);
            }

            
        }
    }
}
