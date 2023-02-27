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
using VistasSV.Entidades;

namespace VistasSV
{
    public partial class VDetalleVenta : Form
    {
        private FacturaController controller = new();
        public VDetalleVenta()
        {
            InitializeComponent();
        }

        private void VDetalleVenta_Load(object sender, EventArgs e)
        {
            TbBuscarVenta.PlaceholderText = "Digite El Numero De Factura";
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            List<DetalleFactura> list = controller.GetDetalleFactura(Convert.ToInt32(TbBuscarVenta.Text));
            if (list.Count != 0)
            {
                LVUsuario.Text = controller.GetNombreUsuarioFactura(Convert.ToInt32(TbBuscarVenta.Text));
                LVCliente.Text = controller.GetNombreClienteFactura(Convert.ToInt32(TbBuscarVenta.Text));
                DGVDetalleVenta.DataSource = list;
                DGVDetalleVenta.AutoResizeColumns();
            }
            else 

            {
                DGVDetalleVenta.DataSource = null;
                MessageBox.Show("!NO EXISTE EL NUMERO DE FACTURA INTENTE DE NUEVO ¡");
            }
            
        }

        
    }
}
