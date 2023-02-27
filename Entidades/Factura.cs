using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistasSV.Entidades
{
    internal class Factura
    {
        public int IdFactura { get; set; } 
        public int Cliente { get; set; }    
        public int Usuario { get; set; }  
        public double TotalPagar { get; set; }
        public DateTime? FechaRegistro { get; set;}
    }
}
