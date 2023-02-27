﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistasSV.Entidades
{
    internal class Proveedor
    {
        public int Id { get; set; } 
        public string? Documento { get; set; }   
        public string? RazonSocial { get; set; } 
        public string? Correo { get; set; } 
        public string? Telefono { get; set; }   
        public bool? Estado { get; set; }
        public DateTime? FechaCreacion { get; set;}
    }
}
