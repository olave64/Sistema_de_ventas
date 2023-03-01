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
    public partial class VDetalleCompra : Form
    {
        CompraController compraController = new();
        public VDetalleCompra()
        {
            InitializeComponent();
        }

        private void BtnBuscarCompra_Click(object sender, EventArgs e)
        {
            List<DetalleCompra> list = compraController.GetDetalleCompras(Convert.ToInt32(TbBuscarCompra.Text));
            if (list.Count >0) 
            { 
                DGVDetalleCompra.DataSource = list;
                DGVDetalleCompra.AutoResizeColumns();
                double total = compraController.GetTotal(Convert.ToInt32(TbBuscarCompra.Text));
                LTotal.Text = Convert.ToString(total);
            }
            else
            {
                MessageBox.Show("NO HAY DATOS QUE MOSTRAR");
            }

        }

        private void VDetalleCompra_Load(object sender, EventArgs e)
        {

        }
    }
}
