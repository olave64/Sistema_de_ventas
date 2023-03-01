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
using VistasSV.Entidades;

namespace VistasSV
{
    public partial class VCompra : Form
    {
        ProductoController productoController = new();
        ProveedorController proveedorController = new();
        CompraController compraController = new();
        ListaProductosController lista = new();
        private readonly List<Producto> listProducto = new();
        private readonly Usuario usuarioActivo;
        private Proveedor proveedor = new();


        private double totalPagar;

        public VCompra(Usuario usuario)
        {
            usuarioActivo = usuario;
            InitializeComponent();
            

        }
        private void VCompra_Load(object sender, EventArgs e)
        {
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

        private void AddPCompra_Click_1(object sender, EventArgs e)
        {
            Producto producto = productoController.FindProducto(CbPC.Text);
            listProducto.Add(producto);

            try
            {
                if (NCantidad.Value > 0)
                {
                    double total = producto.PrecioCompra * Convert.ToDouble(NCantidad.Value);
                    totalPagar += total;
                    TbTotalC.Text = totalPagar.ToString();
                    DGVCompra.Rows.Add(producto.Id, producto.Nombre, Convert.ToInt32(NCantidad.Value), producto.PrecioCompra, total);
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

        private void BtnCompra_Click(object sender, EventArgs e)
        {
            try
            {
                int IdCompra;
                IdCompra = compraController.CrearCompra(usuarioActivo.Id, proveedor.Id, Convert.ToDouble(TbTotalC.Text));
                //int idProducto = 0;
                int contadora = 1;

                foreach (DataGridViewRow item in DGVCompra.Rows)
                {

                    if (contadora < DGVCompra.Rows.Count)
                    {
                        int idProducto = Convert.ToInt32(item.Cells[0].FormattedValue.ToString());
                        double cantidad = Convert.ToDouble(item.Cells[2].FormattedValue.ToString());
                        lista.CreateListProductsCompra(IdCompra, idProducto, cantidad);
                    }
                    contadora = contadora + 1;

                }
                MessageBox.Show("COMPRA REALIZADA CORRECTAMENTE");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnBuscarP_Click(object sender, EventArgs e)
        {
            proveedor = proveedorController.GetProveedor(TbDocumentoC.Text);
            if (proveedor.Documento != null)
            {
                TbRazonC.Text = proveedor.RazonSocial;
                TbCorreoC.Text = proveedor.Correo;
            }
            else
            {
                MessageBox.Show("provedor no encontrado");
                MessageBox.Show("jjjjjjj");
            }
        }
    }
}
