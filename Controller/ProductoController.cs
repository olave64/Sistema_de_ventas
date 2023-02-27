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
    internal class ProductoController
    {
        public  List<Producto> VerProductos() 
        {
            List<Producto> listProducto = new List<Producto>();
            try 
            {
                string query = "select Id,Codigo,Nombre,Descripcion,IdCategoria,Stock,PrecioVenta,PrecioCompra,Estado,FechaRegistro from PRODUCTO";
                using (SqlConnection sqlConnection = new SqlConnection(Conexion.Cadena)) 
                {
                    SqlCommand cmd = new SqlCommand(query, sqlConnection) 
                    { 
                        CommandType = CommandType.Text,
                    };
                    sqlConnection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader()) 
                    {
                        while (reader.Read()) 
                        {
                            listProducto.Add(new Producto()
                            {   Id = Convert.ToInt32(reader["Id"]),
                                Codigo = reader["Codigo"].ToString(),
                                Nombre= reader["Nombre"].ToString(),
                                Descripcion = reader["Descripcion"].ToString(),
                                IdCategoria = Convert.ToInt32(reader["IdCategoria"]),
                                Stock = Convert.ToInt32(reader["Stock"]),
                                PrecioCompra = Convert.ToDouble(reader["PrecioCompra"]),
                                PrecioVenta = Convert.ToDouble(reader["PrecioCompra"]),
                                Estado = Convert.ToBoolean(reader["Estado"]),
                                FechaCreacion = Convert.ToDateTime(reader["FechaRegistro"])
                            });
                        }
                    };
                    sqlConnection.Close();
                    
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.ToString());
                
            }

            return listProducto;
        }

        public string CrearProducto(string Codigo,string Nombre,string Descripcion,int IdCategoria,int Stock,int PrecioCompra,int PrecioVenta,bool Estado )
        {
            string mensage = "";
            try 
            {
                using (SqlConnection sqlConnection = new(Conexion.Cadena)) 
                {
                    string query = "insert into PRODUCTO (Codigo,Nombre,Descripcion,IdCategoria,Stock,PrecioCompra,PrecioVenta,Estado) values (@Codigo,@Nombre,@Descripcion,@IdCategoria,@Stock,@PrecioCompra,@PrecioVenta,@Estado)";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection)
                    {
                        CommandType = CommandType.Text, 
                    };
                    sqlConnection.Open();
                    sqlCommand.Parameters.Add("@Codigo", SqlDbType.VarChar);
                    sqlCommand.Parameters.Add("@Nombre", SqlDbType.VarChar);
                    sqlCommand.Parameters.Add("@Descripcion", SqlDbType.VarChar);
                    sqlCommand.Parameters.Add("@IdCategoria", SqlDbType.Int);
                    sqlCommand.Parameters.Add("@Stock", SqlDbType.Int);
                    sqlCommand.Parameters.Add("@PrecioCompra", SqlDbType.Decimal);
                    sqlCommand.Parameters.Add("@PrecioVenta", SqlDbType.Decimal);
                    sqlCommand.Parameters.Add("@Estado", SqlDbType.Bit);

                    sqlCommand.Parameters["@Codigo"].Value = Codigo;
                    sqlCommand.Parameters["@Nombre"].Value = Nombre;
                    sqlCommand.Parameters["@descripcion"].Value = Descripcion;
                    sqlCommand.Parameters["@IdCategoria"].Value = IdCategoria;
                    sqlCommand.Parameters["@Stock"].Value = Stock;
                    sqlCommand.Parameters["@PrecioCompra"].Value = PrecioCompra;
                    sqlCommand.Parameters["@PrecioVenta"].Value = PrecioVenta;
                    sqlCommand.Parameters["@Estado"].Value = Estado;
                    sqlCommand.ExecuteNonQuery();
                    
                    sqlConnection.Close();
                    mensage = "Usuario creado satisfactoriamente";
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.ToString());
                mensage = "Error al crear Usuario";
            }
            return mensage;
        }
        public Producto FindProducto(string nombre) 
        {
            Producto producto = new();
            try
            {
                SqlConnection sql = new(Conexion.Cadena);
                string query = "select * from PRODUCTO where Nombre = @nombre";
                SqlCommand cmd = new(query,sql);
                cmd.CommandType = CommandType.Text; 
                sql.Open();
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar);
                cmd.Parameters["@nombre"].Value = nombre;    
                SqlDataReader reader = cmd.ExecuteReader(); 
                while (reader.Read()) 
                {
                    producto = new Producto()
                    {
                        Id = Convert.ToInt32(reader[0]),
                        Codigo = reader[1].ToString(),
                        Nombre= reader[2].ToString(),
                        Descripcion= reader[3].ToString(),  
                        IdCategoria = Convert.ToInt32(reader[4]),
                        Stock = Convert.ToInt32(reader[5]),
                        PrecioVenta= Convert.ToDouble(reader[6]),
                        PrecioCompra= Convert.ToDouble(reader[7]),
                        Estado = Convert.ToBoolean(reader[8]),
                        FechaCreacion = Convert.ToDateTime(reader[9]),  
                    };
                }
                sql.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.ToString());    
            }
            return producto;
        }
    }
}
