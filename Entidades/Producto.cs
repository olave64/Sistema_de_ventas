﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistasSV.Entidades
{
    public class Producto
    {
        public int Id { get; set; } 
        public string? Codigo { get; set; }    
        public string? Nombre { get; set;}
        public string? Descripcion { get; set;}   
        public int IdCategoria { get; set; }    
        public int Stock { get; set; }  
        public double PrecioCompra { get; set; }    
        public double PrecioVenta { get; set; } 
        public bool Estado { get; set; }    
        public DateTime FechaCreacion { get; set; }
        
    }
}
