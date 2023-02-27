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
    internal class ProveedorController
    {
        SqlConnection _connection = new(Conexion.Cadena);
        
        public void CreateProvedor(string Documento, string RazonSocial, string Correo, string Telefono, bool Estado)
        {
            string query = "insert into PROVEEDOR (Documento,RazonSocial,Correo,Telefono,Estado) values (@Documento,@RazonSocial,@Correo,@Telefono,@Estado)";
            try
            {
                SqlCommand _command = new(query, _connection)
                {
                    CommandType = CommandType.Text
                };
                _connection.Open();
                _command.Parameters.Add("@Documento", SqlDbType.VarChar);
                _command.Parameters.Add("@RazonSocial", SqlDbType.VarChar);
                _command.Parameters.Add("@Correo", SqlDbType.VarChar);
                _command.Parameters.Add("@Telefono", SqlDbType.VarChar);
                _command.Parameters.Add("@Estado", SqlDbType.Bit);

                _command.Parameters["@Documento"].Value = Documento;
                _command.Parameters["@RazonSocial"].Value = RazonSocial;
                _command.Parameters["@Correo"].Value = Correo;
                _command.Parameters["@Telefono"].Value = Telefono;
                _command.Parameters["@Estado"].Value = Estado;
                _command.ExecuteNonQuery();
                _connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        public List<Proveedor> GetProvedores()
        {
            List<Proveedor> proveedors= new();
            string query = "select * from PROVEEDOR";
            try
            {
                SqlCommand _command = new(query, _connection)
                {
                    CommandType = System.Data.CommandType.Text
                };
                _connection.Open();
                SqlDataReader reader = _command.ExecuteReader();
                while (reader.Read()) 
                {
                    proveedors.Add(new Proveedor()
                    {
                        Id = Convert.ToInt32(reader[0]),
                        Documento = reader[1].ToString(),
                        RazonSocial= reader[2].ToString(),
                        Correo= reader[3].ToString(),   
                        Telefono = reader[4].ToString(),
                        Estado =Convert.ToBoolean(reader[5]),
                        FechaCreacion = Convert.ToDateTime(reader[6])

                    });
                }
                _connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            return proveedors;
        }
        public void ActualizarProveedor(int id, string Documento, string RazonSocial, string Correo, string Telefono, bool Estado) 
        {
            string query = "update PROVEEDOR set Documento=@Documento, RazonSocial=@RazonSocial, Correo=@Correo, Telefono =@Telefono, Estado=@Estado where IdProveedor =@Id";
            try
            {
                SqlCommand _command = new(query, _connection)
                {
                    CommandType = CommandType.Text
                };
                _connection.Open();
                _command.Parameters.Add("@Id", SqlDbType.Int);
                _command.Parameters.Add("@Documento", SqlDbType.VarChar);
                _command.Parameters.Add("@RazonSocial", SqlDbType.VarChar);
                _command.Parameters.Add("@Correo", SqlDbType.VarChar);
                _command.Parameters.Add("@Telefono", SqlDbType.VarChar);
                _command.Parameters.Add("@Estado", SqlDbType.Bit);

                _command.Parameters["@Id"].Value = id;
                _command.Parameters["@Documento"].Value = Documento;
                _command.Parameters["@RazonSocial"].Value = RazonSocial;
                _command.Parameters["@Correo"].Value = Correo;
                _command.Parameters["@Telefono"].Value = Telefono;
                _command.Parameters["@Estado"].Value = Estado;
                _command.ExecuteNonQuery();
                _connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            MessageBox.Show("El provedor "+id+" se a actualizado correctamente");
            
            
        }
        public void DeleteProveedor(int id) 
        {
            string query = "delete PROVEEDOR where IdProveedor = @Id";
            try 
            {
                SqlCommand _command = new(query, _connection)
                {
                    CommandType = CommandType.Text
                };
                _connection.Open();
                _command.Parameters.Add("@Id",SqlDbType.Int);

                _command.Parameters["@Id"].Value=id;    
                _command.ExecuteNonQuery();
                _connection.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString()); 
            }
        }
    }
}
