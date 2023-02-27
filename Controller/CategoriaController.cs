using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using VistasSV.Entidades;

namespace VistasSV.Controller
{
    internal class CategoriaController
    {
        public List<Categoria> GetDescripcionCategoria()
        {
            List<Categoria> categorias = new List<Categoria>();
            try 
            {
                using (SqlConnection sqlConnection = new SqlConnection(Conexion.Cadena)) 
                {
                    string query = "select Descripcion from CATEGORIA";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection)
                    {
                        CommandType = CommandType.Text,
                    };
                    sqlConnection.Open();
                    using(SqlDataReader reader = sqlCommand.ExecuteReader()) 
                    {
                       while (reader.Read())
                       {
                            categorias.Add(new Categoria()
                            {
                                Descripcion = reader["Descripcion"].ToString()
                            });
                              
                       }
                    }
                    sqlConnection.Close();  

                }

            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }

            return categorias;  
        }

        public List<Categoria> GetCategoria() 
        {
            List<Categoria> All= new List<Categoria>();

            try 
            {
                using SqlConnection sqlConnection = new(Conexion.Cadena);
                string query = "select IdCategoria,Descripcion,Estado,FechaRegistro from CATEGORIA";
                SqlCommand sqlCommand = new(query, sqlConnection)
                {
                    CommandType = CommandType.Text,
                };
                sqlConnection.Open();
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        All.Add(new Categoria()
                        {
                            Id = Convert.ToInt32(reader["IdCategoria"]),
                            Descripcion = reader["Descripcion"].ToString(),
                            Estado = Convert.ToBoolean(reader["Estado"]),
                            FechaCreacion = Convert.ToDateTime(reader["FechaRegistro"])
                        });
                    }
                }
                sqlConnection.Close();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.ToString()); 
            }
            

            return All; 
        }
        public void SetCategoria(string Descripcion, bool Estado) 
        {
            try 
            {
                using SqlConnection sqlConnection = new(Conexion.Cadena);
                string query = "insert into CATEGORIA (Descripcion,Estado) values (@Descripcion,@Estado)";
                SqlCommand cmd = new(query, sqlConnection);
                cmd.CommandType = CommandType.Text; 
                sqlConnection.Open();
                cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar);
                cmd.Parameters.Add("@Estado", SqlDbType.Bit);

                cmd.Parameters["@Descripcion"].Value = Descripcion;
                cmd.Parameters["@Estado"].Value = Estado;

                cmd.ExecuteNonQuery();  
                
                sqlConnection.Close();
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.ToString());
            }
        }
        public void SetCategoria(int Id, string Descripcion, bool Estado)
        {
            try
            {
                using SqlConnection sqlConnection = new(Conexion.Cadena);
                string query = "update CATEGORIA set Descripcion = @Descripcion, Estado = @Estado where IdCategoria = @Id";
                SqlCommand cmd = new(query, sqlConnection);
                cmd.CommandType = CommandType.Text;
                sqlConnection.Open();
                cmd.Parameters.Add("@Id", SqlDbType.VarChar);    
                cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar);
                cmd.Parameters.Add("@Estado", SqlDbType.Bit);

                cmd.Parameters["@Id"].Value = Id;
                cmd.Parameters["@Descripcion"].Value = Descripcion;
                cmd.Parameters["@Estado"].Value = Estado;

                cmd.ExecuteNonQuery();

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void DeleteCategoria(int id)
        {
            using (SqlConnection sqlConnection = new(Conexion.Cadena)) 
            {
                try
                {
                    string query = "delete from CATEGORIA where IdCategoria = @id";
                    SqlCommand command = new(query, sqlConnection);
                    command.CommandType = CommandType.Text;
                    sqlConnection.Open();  
                    command.Parameters.Add("@id", SqlDbType.VarChar);

                    command.Parameters["@id"].Value = id;    
                    command.ExecuteNonQuery();  
                    sqlConnection.Close();  
                }
                catch(Exception ex) 
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
