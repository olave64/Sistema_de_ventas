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
    internal class FacturaController
    {
        readonly SqlConnection _connection = new(Conexion.Cadena);
        public FacturaController() 
        {
        }
        public  List<Factura> GetFacturas()
        { 
            List<Factura> all = new();
            try
            {
                
                string query = "select * from FACTURA";
                SqlCommand cmd = new(query, _connection)
                {
                    CommandType = CommandType.Text
                };
                _connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) 
                {
                    all.Add(new Factura()
                    {
                        IdFactura = Convert.ToInt32(reader[0]),
                        Cliente= Convert.ToInt32(reader[1]),
                        Usuario = Convert.ToInt32(reader[2]),
                        TotalPagar = Convert.ToInt32(reader[3]), 
                        FechaRegistro= Convert.ToDateTime(reader[5]),
                    }) ;
                } 
                _connection.Close();

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());    
            }

        return all;
        }
        public string GetNombreUsuarioFactura(int Id) 
        {
            string nombre = "";
            string query = "select NombreCompleto from USUARIO inner join FACTURA on FACTURA.IdUsuario = USUARIO.IdUsuario where IdFactura = @Id";
            try
            {
                SqlCommand cmd = new(query, _connection) 
                {
                   CommandType = CommandType.Text
                }; 
                _connection.Open();
                cmd.Parameters.Add("@Id",SqlDbType.Int);
                cmd.Parameters["@Id"].Value= Id;
                nombre = (string)cmd.ExecuteScalar();

                _connection.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
            return nombre;
        }
        public string GetNombreClienteFactura(int Id)
        {
            string nombre = "";
            string query = "select NombreCompleto from CLIENTE inner join FACTURA on FACTURA.IdCliente = CLIENTE.IdCliente where IdFactura = @Id";
            try
            {
                SqlCommand cmd = new(query, _connection)
                {
                    CommandType = CommandType.Text
                };
                _connection.Open();
                cmd.Parameters.Add("@Id", SqlDbType.Int);
                cmd.Parameters["@Id"].Value = Id;
                nombre = (string)cmd.ExecuteScalar();

                _connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return nombre;
        }
        public int CreateFactura(int IdCliente,int IdUsuario,double TotalPagar) 
        {
            int Id= 0;
            try
            {
                string query = "insert into FACTURA (IdCliente,IdUsuario,TotalPagar) values (@IdCliente,@IdUsuario,@TotalPagar);" + "SELECT CAST(scope_identity() AS int)";
                SqlCommand sql = new(query, _connection)
                {
                    CommandType = CommandType.Text
                };
                _connection.Open();

                sql.Parameters.Add("@IdCliente", SqlDbType.Int);
                sql.Parameters.Add("@IdUsuario", SqlDbType.Int);
                sql.Parameters.Add("@TotalPagar", SqlDbType.Decimal);

                sql.Parameters["@IdCliente"].Value = IdCliente;
                sql.Parameters["@IdUsuario"].Value = IdUsuario;
                sql.Parameters["@TotalPagar"].Value = TotalPagar;

                
                
                Id = Convert.ToInt32(sql.ExecuteScalar());

                _connection.Close();
            }
            catch (Exception ex) 
            {
                _connection.Close();
                MessageBox.Show(ex.ToString());
            }
            return Id;

        }
        public List<DetalleFactura> GetDetalleFactura(int IdFactura) 
        {
            List<DetalleFactura> detalleFacturas= new List<DetalleFactura>();   
            try
            {
                String query = "select IdProducto,Codigo,Nombre,PrecioVenta,Cantidad,Descripcion from LISTA_PRODUCTO inner join PRODUCTO  on LISTA_PRODUCTO.IdProducto = PRODUCTO.Id where IdFactura = @IdFactura";
                SqlCommand cmd = new(query, _connection)
                {
                    CommandType = CommandType.Text
                };
                _connection.Open();
                cmd.Parameters.Add("@IdFactura", SqlDbType.Int);
                cmd.Parameters["@IdFactura"].Value=IdFactura;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) 
                {
                    detalleFacturas.Add(new DetalleFactura()
                    {
                        Id = IdFactura,
                        IdProducto = reader.GetInt32(0),
                        Codigo= reader.GetString(1),
                        Nombre= reader.GetString(2),
                        PrecioVenta=reader.GetDecimal(3),
                        Cantidad=reader.GetDecimal(4),   
                        Descripcion=reader.GetString(5),
                        Total= reader.GetDecimal(3)* reader.GetDecimal(4)
                    });
                }
                _connection.Close();
                 
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
            return detalleFacturas;
        }
        
    }
}
