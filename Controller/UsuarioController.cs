
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using VistasSV.Controller;

namespace Controladores
{
    public class UsuarioController
    {
        public List<Usuario> BuscarUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                
                using (SqlConnection sqlConnection = new(Conexion.Cadena))
                {
                    
                    string query = "select IdUsuario,Documento,NombreCompleto,Correo,Clave,IdRol,Estado,FechaRegistro from USUARIO";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection)
                    {
                        CommandType = CommandType.Text
                    };
                    sqlConnection.Open();
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                usuarios.Add(new Usuario()
                                {
                                   Id = Convert.ToInt32(reader["IdUsuario"]),
                                   Documento = reader["Documento"].ToString(),
                                   Nombre = reader["NombreCompleto"].ToString(),
                                   Correo= reader["Correo"].ToString(),
                                   Clave = reader["Clave"].ToString(),
                                   Rol = Convert.ToInt32(reader["IdRol"]),
                                   Estado = Convert.ToBoolean(reader["Estado"]),
                                   FechaCreacion = Convert.ToDateTime(reader["FechaRegistro"])
                                   
                                });
                                
                            }
                        }
                }
               
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());

            }
            

            return usuarios;
        }
    }
}
