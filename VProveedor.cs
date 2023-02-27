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
    public partial class VProveedor : Form
    {
        private ProveedorController controller = new();
        public VProveedor()
        {
            InitializeComponent();
        }

        private void VProveedor_Load(object sender, EventArgs e)
        {
            TbIdP.PlaceholderText = "ID";
            TbdocumentoP.PlaceholderText = "Numero Documento";
            TbRazonSocialP.PlaceholderText = "Razon social";
            TbCorreoP.PlaceholderText = "Correo";
            TbTelefonoP.PlaceholderText = "Numero Telefono";
            DGVProveedores.DataSource = controller.GetProvedores();
            DGVProveedores.AutoResizeColumns();
        }

        private void AddP_Click(object sender, EventArgs e)
        {
            controller.CreateProvedor(TbdocumentoP.Text, TbRazonSocialP.Text, TbCorreoP.Text, TbTelefonoP.Text, CBActivo.Checked);
            LimpiarCampos();
            DGVProveedores.DataSource = controller.GetProvedores();
        }

        private void CBActivo_CheckedChanged(object sender, EventArgs e)
        {
            if (CBActivo.Checked)
            {
                CBActivo.Text = "Activo";
            }
            else
            {
                CBActivo.Text = "Desactivado";
            }

        }
        private void LimpiarCampos()
        {
            TbIdP.PlaceholderText = "";
            TbdocumentoP.PlaceholderText = "";
            TbRazonSocialP.PlaceholderText = "";
            TbCorreoP.PlaceholderText = "";
            TbTelefonoP.PlaceholderText = "";
            CBActivo.Checked = false;
            CBActivo.Text = "Desactivado";
        }

        private void DGVProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string?[] datos = new string[DGVProveedores.ColumnCount];
            foreach (DataGridViewCell item in DGVProveedores.CurrentRow.Cells)
            {
                datos[item.ColumnIndex] = item.FormattedValue.ToString();
            }
            TbIdP.Text = datos[0];
            TbdocumentoP.Text = datos[1];
            TbRazonSocialP.Text = datos[2];
            TbCorreoP.Text = datos[3];
            TbTelefonoP.Text = datos[4];
            CBActivo.Checked = Convert.ToBoolean(datos[5]);

        }

        private void UpdateP_Click(object sender, EventArgs e)
        {

            controller.ActualizarProveedor(Convert.ToInt32(TbIdP.Text), TbdocumentoP.Text, TbRazonSocialP.Text, TbCorreoP.Text, TbTelefonoP.Text, CBActivo.Checked);
            DGVProveedores.DataSource = controller.GetProvedores();
            LimpiarCampos();
        }

        private void DeleteP_Click(object sender, EventArgs e)
        {
            controller.DeleteProveedor(Convert.ToInt32(TbIdP.Text));
            DGVProveedores.DataSource = controller.GetProvedores();
            LimpiarCampos();
        }
    }
}
