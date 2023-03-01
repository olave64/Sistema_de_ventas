using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VistasSV.Entidades;

namespace VistasSV.Controller
{
    internal class CompraController
    {
        SqlConnection _connection = new(Conexion.Cadena);
        public int CrearCompra(int IdUsuario, int IdProveedor, double TotalPagar) 
        {
            int Id = 0;
            string query = "insert into COMPRA (IdUsuario, IdProveedor, TotalPagar) values (@IdUsuario, @IdProveedor, @TotalPagar);" + "SELECT CAST(scope_identity() AS int)";
            try 
            {
                SqlCommand _command = new SqlCommand(query, _connection)
                {
                    CommandType = CommandType.Text
                };
                _connection.Open();
                _command.Parameters.Add("@IdUsuario", SqlDbType.Int);
                _command.Parameters.Add("@IdProveedor", SqlDbType.Int);
                _command.Parameters.Add("@TotalPagar", SqlDbType.Decimal);

                _command.Parameters["@IdUsuario"].Value = IdUsuario;
                _command.Parameters["@IdProveedor"].Value = IdProveedor;
                _command.Parameters["@TotalPagar"].Value = TotalPagar;
                Id = Convert.ToInt32(_command.ExecuteScalar());

                _connection.Close();
            }
            catch(Exception e) 
            {
                MessageBox.Show(e.ToString());
            }
            return Id;
        }
        public List<DetalleCompra> GetDetalleCompras(int IdCompra ) 
        {
            List<DetalleCompra> detalleCompra = new();
            try
            {
                string query = "select IdProducto,Codigo,Nombre,PrecioVenta,Cantidad,Descripcion from LISTA_PRODUCTO_COMPRA inner join PRODUCTO  on LISTA_PRODUCTO_COMPRA.IdProducto = PRODUCTO.Id where IdCompra = @IdCompra";
                SqlCommand cmd = new(query, _connection)
                {
                    CommandType = CommandType.Text
                };
                _connection.Open();
                cmd.Parameters.Add("@IdCompra", SqlDbType.Int);
                cmd.Parameters["@IdCompra"].Value = IdCompra;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    detalleCompra.Add(new DetalleCompra()
                    {
                        Id = IdCompra,
                        IdProducto = reader.GetInt32(0),
                        Codigo = reader.GetString(1),
                        Nombre = reader.GetString(2),
                        PrecioCompra = reader.GetDecimal(3),
                        Cantidad = reader.GetDecimal(4),
                        Descripcion = reader.GetString(5),
                        Total = reader.GetDecimal(3) * reader.GetDecimal(4)
                    });
                }
                _connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                _connection.Close();
            }
            return detalleCompra;
        }
        public double GetTotal(int Id)
        {
            double total = 0;
            string query = "select TotalPagar from COMPRA where IdCompra = @Id";
            try
            {
                SqlCommand _command = new(query, _connection)
                {
                    CommandType = CommandType.Text,
                };
                _connection.Open();
                _command.Parameters.Add("@Id", SqlDbType.Int);
                _command.Parameters["@Id"].Value = Id;
                total = Convert.ToDouble(_command.ExecuteScalar());
                _connection.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
            
            return total;
        }
    }
}
