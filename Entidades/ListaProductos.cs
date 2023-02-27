using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistasSV.Entidades
{
    internal class ListaProductos
    {
        public int Id { get; set; }
        public Factura? IdFactura { get; set; }
        public Producto? IdProducto { get; set; } 

    }
}
