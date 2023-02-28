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
    public partial class VCompra : Form
    {
        ProductoController productoController = new();
        ProveedorController proveedorController = new();
        private readonly List<Producto> listProducto = new();

        private double totalPagar;

        public VCompra()
        {
            InitializeComponent();
            CreateDGVCompra();
            DGVCompra.AutoResizeColumns();
            DatosCB();

        }
        private void CreateDGVCompra()
        {
            DGVCompra.ColumnCount = 5;
            DGVCompra.Columns[0].Name = "ID";
            DGVCompra.Columns[1].Name = "NOMBRE";
            DGVCompra.Columns[2].Name = "CANTIDAD";
            DGVCompra.Columns[3].Name = "PRECIO COMPRA";
            DGVCompra.Columns[4].Name = "SUBTOTAL";
        }
        private void DatosCB()
        {
            List<Producto> listProducto = productoController.VerProductos();
            List<string?> list = new();
            listProducto.ForEach(x => list.Add(x.Nombre));
            CbPC.DataSource = list;
        }
        private void ActualizarListaProducto()
        {
            Producto producto = productoController.FindProducto(CbPC.Text);
            listProducto.Add(producto);

            try
            {
                if (NCantidad.Value > 0)
                {
                    double total = producto.PrecioVenta * Convert.ToDouble(NCantidad.Value);
                    totalPagar += total;
                    TbTotalC.Text = totalPagar.ToString();
                    DGVCompra.Rows.Add(producto.Id, producto.Nombre, NCantidad.Value, producto.PrecioCompra, total);
                }
                else
                {
                    MessageBox.Show("EL CAMPO CANTIDAD DEBE CONTENER UNA CANTIDAD");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("EL FORMATO DE CANTIDAD DEVE SER NUMERICO" + ex.ToString());
            }

        }

        private void AddPCompra_Click(object sender, EventArgs e)
        {
            ActualizarListaProducto();
        }

        private void BuscarP_Click(object sender, EventArgs e)
        {

            Proveedor miProveedor = proveedorController.GetProveedor(TbDocumentoC.Text);
            if (miProveedor.Documento != null)
            {
                TbRazonC.Text = miProveedor.RazonSocial;
                TbCorreoC.Text = miProveedor.Correo;
            }
            else
            {
                MessageBox.Show("provedor no encontrado");
                MessageBox.Show("jjjjjjj");
            }

        }
    }
}
