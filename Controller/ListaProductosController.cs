using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistasSV.Controller
{
    internal class ListaProductosController
    {
        SqlConnection _connection = new(Conexion.Cadena);
          
        public void CreateListProducts(int IdFactura, int IdProducto)
        {
            SqlConnection _connection = new(Conexion.Cadena);
            string query = "insert into LISTA_PRODUCTO (IdFactura,IdProducto) values (@IdFactura,@IdProducto)";
            SqlCommand command = new(query,_connection );
            command.CommandType =  CommandType.Text;
            _connection.Open();
            command.Parameters.Add("@IdFactura", SqlDbType.Int);
            command.Parameters.Add("@IdProducto", SqlDbType.Int);

            command.Parameters["@IdFactura"].Value = IdFactura;
            command.Parameters["@IdProducto"].Value = IdProducto;   
            command.ExecuteNonQuery();  
            _connection.Close(); 
        }
    }
}
