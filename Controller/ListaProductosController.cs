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
          
        public void CreateListProducts(int IdFactura, int IdProducto,double Cantidad)
        {
            SqlConnection _connection = new(Conexion.Cadena);
            string query = "insert into LISTA_PRODUCTO (IdFactura,IdProducto,Cantidad) values (@IdFactura,@IdProducto,@Cantidad)";
            SqlCommand command = new(query,_connection );
            command.CommandType =  CommandType.Text;
            _connection.Open();
            command.Parameters.Add("@IdFactura", SqlDbType.Int);
            command.Parameters.Add("@IdProducto", SqlDbType.Int);
            command.Parameters.Add("@Cantidad", SqlDbType.Decimal);

            command.Parameters["@IdFactura"].Value = IdFactura;
            command.Parameters["@IdProducto"].Value = IdProducto;
            command.Parameters["@Cantidad"].Value = Cantidad;
            command.ExecuteNonQuery();  
            _connection.Close(); 
        }
        public void CreateListProductsCompra(int IdFactura, int IdProducto, double Cantidad)
        {
            try
            {
                string query = "insert into LISTA_PRODUCTO_COMPRA (IdCompra,IdProducto,Cantidad) values (@IdCompra,@IdProducto,@Cantidad)";
                SqlCommand command = new(query, _connection);
                command.CommandType = CommandType.Text;
                _connection.Open();
                command.Parameters.Add("@IdCompra", SqlDbType.Int);
                command.Parameters.Add("@IdProducto", SqlDbType.Int);
                command.Parameters.Add("@Cantidad", SqlDbType.Decimal);

                command.Parameters["@IdCompra"].Value = IdFactura;
                command.Parameters["@IdProducto"].Value = IdProducto;
                command.Parameters["@Cantidad"].Value = Cantidad;
                command.ExecuteNonQuery();
                _connection.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
                _connection.Close();
            }
            
        }
    }

}
