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
    internal class ClienteController
    {
        SqlConnection _connection = new(Conexion.Cadena);
        
        public Cliente Getcliente(string NDocumento) 
        {
            Cliente cliente = new();
            string query = "select * from CLIENTE where Documento = @NDocumento";
            try 
            {
                SqlCommand cmd = new(query,_connection); 
                cmd.CommandType = CommandType.Text;
                _connection.Open();
                cmd.Parameters.Add("@NDocumento", SqlDbType.Int);

                cmd.Parameters["@NDocumento"].Value = NDocumento;
                SqlDataReader reader= cmd.ExecuteReader();
                while (reader.Read()) 
                {
                    cliente = new () 
                    { 
                        Id = Convert.ToInt32(reader[0]),
                        NumeroDocumento = reader[1].ToString(),
                        Nombre= reader[2].ToString(),
                        Correo= reader[3].ToString(),   
                        Telefono= reader[4].ToString(),
                        Estado= Convert.ToBoolean(reader[5]),
                        FechaCreacion = Convert.ToDateTime(reader[6]),
                    }; 
                        
                }
                _connection.Close();   
            }
            catch(Exception ex)  
            {
                MessageBox.Show(ex.Message);  
                _connection.Close();
            }
            return cliente;
        }
    }
}
