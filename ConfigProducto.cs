using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Documents;
using VistasSV.Entidades;
using VistasSV.Controller;
using Entidades;

namespace VistasSV
{
    public partial class ConfigProducto : Form
    {
        public ConfigProducto()
        {
            InitializeComponent();
        }

        private void ConfigProducto_Load(object sender, EventArgs e)
        {
            List<Producto> productos= new ProductoController().VerProductos();
            DGVProductos.DataSource = productos;
            DGVProductos.AutoResizeColumns();

            //Obtener lista de categoria######
            List<Categoria> categorias= new CategoriaController().GetDescripcionCategoria();
            List<string?> lista = new ();
            categorias.ForEach(c => lista.Add(c.Descripcion));
           
            PCategoria.DataSource = lista;  
        }

        private void CancelarP_Click(object sender, EventArgs e)
        {

        }

        private void CrearP_Click(object sender, EventArgs e)
        {
            ProductoController controller = new ProductoController();
            controller.CrearProducto(PCodigo.Text,PNombre.Text,PDescripcion.Text,Convert.ToInt32(PCategoria.Text), Convert.ToInt32(PStock.Text), Convert.ToInt32(PCompra.Text), Convert.ToInt32(PVenta.Text),true);
        }

        private void DGVProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int column = DGVProductos.ColumnCount;
            string?[] datosColumnas = new string[column];
            // _ = new string[column];
            int contadora = 0;
            foreach (DataGridViewCell item in DGVProductos.CurrentRow.Cells)
            {
                datosColumnas[contadora] = item.FormattedValue.ToString();
                contadora++;
            }
            LId.Visible = true;
            TIdProducto.Visible = true; 
            TIdProducto.Text = datosColumnas[0];
            PCodigo.Text = datosColumnas[1];
            PNombre.Text = datosColumnas[2];
            PDescripcion.Text = datosColumnas[3];
            PCategoria.Text = datosColumnas[4];
            PStock.Text = datosColumnas[4];
            PCompra.Text = datosColumnas[5];
            PVenta.Text = datosColumnas[6];
        }
    }
}
