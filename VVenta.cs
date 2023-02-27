using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Forms;
using VistasSV.Controller;
using VistasSV.Entidades;

namespace VistasSV
{
    public partial class VVenta : Form
    {
        
        private readonly FacturaController controller = new();
        private readonly ProductoController productos = new();
        private readonly CrudUsuarioController crud = new();
        private readonly List<Producto> listProducto = new();
        private readonly ClienteController clienteController = new();
        private readonly Usuario usuarioActivo;
        private readonly FacturaController facturaController = new(); 
        
        private ListaProductosController listaProductosController = new();  
        private Cliente cliente = new();

        private double totalPagar;
        public VVenta(Usuario usuario)
        {
            usuarioActivo = usuario;
            InitializeComponent();
        }

        private void VVenta_Load(object sender, EventArgs e)
        {
            TbCantidad.PlaceholderText = "Cantidad";
            ListNameProduct(); 
            CrearDataGridView();
            
        }
        private void ListNameProduct()
        {
            List<Producto> listProducto = productos.VerProductos();
            List<string?> list = new();
            listProducto.ForEach(p => list.Add(p.Nombre));
            CbProducto.DataSource = list;
           

        }
        private void ActualizarListaProducto()
        {
            Producto producto = productos.FindProducto(CbProducto.Text);
            listProducto.Add(producto);
            
            try 
            {
                if (TbCantidad.Text != string.Empty)
                {
                    double total = producto.PrecioVenta * Convert.ToDouble(TbCantidad.Text);
                    totalPagar += total;
                    TbTotal.Text = totalPagar.ToString();
                    DGVVenta.Rows.Add(producto.Id, producto.Nombre, Convert.ToInt32(TbCantidad.Text), producto.PrecioVenta, total);
                }
                else 
                {
                    MessageBox.Show("EL CAMPO CANTIDAD DEBE CONTENER UNA CANTIDAD");
                }
                
            }
            catch(Exception ex) 
            {
                MessageBox.Show("EL FORMATO DE CANTIDAD DEVE SER NUMERICO"+ ex.ToString());
            }
           
        }
        private void CrearDataGridView()
        {
            DGVVenta.ColumnCount = 5;
            DGVVenta.Columns[0].Name = "ID";
            DGVVenta.Columns[1].Name = "NOMBRE";
            DGVVenta.Columns[2].Name = "CANTIDAD";
            DGVVenta.Columns[3].Name = "PRECIO";
            DGVVenta.Columns[4].Name = "SUBTOTAL";
            
        }
        // AGREGAR NUEVO PRODUCTO A LA DataGridview  //
        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            
            ActualizarListaProducto();  
        }

        private void DGVVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(DGVVenta.CurrentRow.Index.ToString());
            MessageBox.Show(DGVVenta.RowCount.ToString());
        }
        // VERIFICAR SI EL USUARIO EXISTE  //
        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            cliente = clienteController.Getcliente(TbNumeroDocumento.Text);
            TbNombre.Text = cliente.Nombre; 
            TbCorreo.Text = cliente.Correo;
            TbTelefono.Text = cliente.Telefono; 
        }

        private void BtnCompra_Click(object sender, EventArgs e)
        {
            //el tipo de documento del usuario es con que pago
            try
            {
                int IdFactura;
                IdFactura = facturaController.CreateFactura(cliente.Id, usuarioActivo.Id,Convert.ToDouble (TbTotal.Text));
                int idProducto = 0;
                int contadora = 1;
                
                foreach (DataGridViewRow item in DGVVenta.Rows)
                {
                    
                    if (contadora < DGVVenta.Rows.Count)
                    {
                        idProducto = Convert.ToInt32(item.Cells[0].FormattedValue.ToString());
                        listaProductosController.CreateListProducts(IdFactura, idProducto);
                    }
                    contadora = contadora + 1;
                    
                }
                
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void TbPago_TextChanged(object sender, EventArgs e)
        {
            int cambio,total,pago;
            total = Convert.ToInt32(TbTotal.Text);
            pago = Convert.ToInt32(TbPago.Text);
            cambio = pago-total;
            TbCambio.Text = cambio.ToString();
        }
    }
}
