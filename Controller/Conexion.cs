using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace VistasSV.Controller
{
    internal class Conexion
    {
        public static string Cadena = ConfigurationManager.ConnectionStrings["Conection"].ToString();
    }
}
