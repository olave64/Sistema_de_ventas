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
using System.Windows.Forms;
using VistasSV.Controller;


namespace VistasSV
{
    public partial class VUsuario : Form
    {
        public VUsuario()
        {
            InitializeComponent();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            List<Usuario> listUsuario = new UsuarioController().BuscarUsuarios();
            DGVUsuarios.DataSource = listUsuario;
            DGVUsuarios.AutoResizeColumns();
             
        }
        

        private void DGVUsuarios_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int column = DGVUsuarios.ColumnCount;
            string?[] datosColumnas = new string[column];
            int contadora = 0;
            foreach (DataGridViewCell item in DGVUsuarios.CurrentRow.Cells)
            {
                datosColumnas[contadora] = item.FormattedValue.ToString();
                contadora++;
            }
            IDUsuario.Text = datosColumnas[0];
            TBDocumentoU.Text = datosColumnas[1];
            TBNombreU.Text = datosColumnas[2];
            TBCorreoU.Text = datosColumnas[3];
            TBClaveU.Text = datosColumnas[4];
            TBRClaveU.Text = datosColumnas[4];
            CBRolU.Text = datosColumnas[5];
            CBEstadoU.Text = datosColumnas[6];
        }

        private void BtnAddUsuario_Click(object sender, EventArgs e)
        {
            CrudUsuarioController crud = new();
            int idRol = 2;
            bool estado = false;
            if (CBRolU.Text == "Admin")
            {
                idRol = 1;
            }
            if (CBEstadoU.Text == "Activo")
            {
                estado = true;
            }
            if (IDUsuario.Text == null)
            {
                
                crud.AddUsuario(TBDocumentoU.Text, TBNombreU.Text, TBCorreoU.Text, TBClaveU.Text, idRol, estado);
            }
            else 
            {
                int id = Convert.ToInt32(IDUsuario.Text);
                crud.UpdateUsuario(id, TBDocumentoU.Text, TBNombreU.Text, TBCorreoU.Text, TBClaveU.Text, idRol, estado);
            }

        }

        private void LimpiarU_Click(object sender, EventArgs e)
        {
            IDUsuario.Text = null;
            TBDocumentoU.Text = null;
            TBNombreU.Text= null;
            TBCorreoU.Text= null;   
            TBClaveU.Text= null;    
            TBRClaveU.Text = null; 
            CBRolU.Text = null; 
            CBEstadoU.Text= null;   
        }
    }
}
