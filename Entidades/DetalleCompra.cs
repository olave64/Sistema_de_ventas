using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistasSV.Entidades
{
    internal class DetalleCompra
    {
        public int Id { get; set; }
        public int IdProducto { get; set; }
        public string? Codigo { get; set; }
        public string? Nombre { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal Cantidad { get; set; }
        public string? Descripcion { get; set; }
        public decimal Total { get; set; }
    }
}
