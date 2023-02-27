using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistasSV.Controller
{
    internal class CrudUsuarioController
    {
        public string AddUsuario(string Doc, string Nom, string Correo, string Clave, int IdRol, bool Estado)
        {
            using (SqlConnection sqlCadena = new(Conexion.Cadena))
            {
                try 
                {
                    string query = "insert into USUARIO (Documento,NombreCompleto,Correo,Clave,IdRol,Estado) values (@Doc,@Nom,@Correo,@Clave,@IdRol,@Estado)";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlCadena)
                    {
                        CommandType= CommandType.Text,  
                    };
                    sqlCadena.Open();   
                    sqlCommand.Parameters.Add("@Doc", SqlDbType.VarChar);
                    sqlCommand.Parameters.Add("@Nom", SqlDbType.VarChar);
                    sqlCommand.Parameters.Add("@Correo", SqlDbType.VarChar);
                    sqlCommand.Parameters.Add("@Clave", SqlDbType.VarChar);
                    sqlCommand.Parameters.Add("@IdRol", SqlDbType.Int);
                    sqlCommand.Parameters.Add("@Estado", SqlDbType.Bit);

                    sqlCommand.Parameters["@Doc"].Value = Doc;
                    sqlCommand.Parameters["@Nom"].Value = Nom;
                    sqlCommand.Parameters["@Correo"].Value = Correo;
                    sqlCommand.Parameters["@Clave"].Value = Clave;
                    sqlCommand.Parameters["@IdRol"].Value = IdRol;
                    sqlCommand.Parameters["@Estado"].Value = Estado; 
                    sqlCommand.ExecuteNonQuery();
                    sqlCadena.Close();
                }
                catch(Exception ex) 
                {
                    MessageBox.Show(ex.ToString());
                    return "Error en la creacion del usuario";
                    
                }
            }
            return "Usuario creado satisfactoriamente";
            
        }
        public  string UpdateUsuario(int Id, string Doc, string Nom, string Correo, string Clave, int IdRol, bool Estado) 
        {
            try
            {
                using (SqlConnection updateConneccion = new SqlConnection(Conexion.Cadena)) 
                {
                    string queryUpdate = "update USUARIO set Documento = @Doc, NombreCompleto=@Nom, Correo=@Correo,Clave=@Clave,IdRol=@IdRol,Estado=@Estado where IdUsuario = @Id";
                    SqlCommand sqlCommand = new SqlCommand(queryUpdate, updateConneccion)
                    {
                        CommandType = CommandType.Text,
                    };
                    updateConneccion.Open();
                    sqlCommand.Parameters.Add("@Id", SqlDbType.Int);
                    sqlCommand.Parameters.Add("@Doc", SqlDbType.VarChar);
                    sqlCommand.Parameters.Add("@Nom", SqlDbType.VarChar);
                    sqlCommand.Parameters.Add("@Correo", SqlDbType.VarChar);
                    sqlCommand.Parameters.Add("@Clave", SqlDbType.VarChar);
                    sqlCommand.Parameters.Add("@IdRol", SqlDbType.Int);
                    sqlCommand.Parameters.Add("@Estado", SqlDbType.Bit); 

                    sqlCommand.Parameters["@Id"].Value = Id;
                    sqlCommand.Parameters["@Doc"].Value = Doc;
                    sqlCommand.Parameters["@Nom"].Value = Nom;
                    sqlCommand.Parameters["@Correo"].Value = Correo;
                    sqlCommand.Parameters["@Clave"].Value = Clave;
                    sqlCommand.Parameters["@IdRol"].Value = IdRol;
                    sqlCommand.Parameters["@Estado"].Value = Estado;
                    sqlCommand.ExecuteNonQuery();
                    updateConneccion.Close();   
                };
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
            return "Usuario actualizado correctamente";
        }
        
    }

}
