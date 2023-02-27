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
    public partial class VCompra : Form
    {
        public VCompra()
        {
            InitializeComponent();
            CreateDGVCompra();
            DGVCompra.AutoResizeColumns();
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
    }
}
