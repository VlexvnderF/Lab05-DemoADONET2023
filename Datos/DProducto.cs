using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
namespace Datos
{
    public class DProducto
    {
        private string connectionString= "Data Source=LAB707-11\\SQLEXPRESS;Initial Catalog=Producto;Integrated Security=True;";

       
        public   List<Producto> Listar()
        {

            //Obtengo la conexión
            SqlConnection connection = null;
            SqlParameter param = null;
            SqlCommand command = null;
            List<Producto> productos = null;
            try
            {
                connection = new SqlConnection(connectionString);

                connection.Open();

                //Hago mi consulta
                command = new SqlCommand("list_productos", connection);
                command.CommandType = CommandType.StoredProcedure;

                //param = new SqlParameter();
                //param.ParameterName = "@Description";
                //param.SqlDbType = SqlDbType.VarChar;
                //param.Value = description;

                //command.Parameters.Add(param);

                SqlDataReader reader = command.ExecuteReader();
                productos = new List<Producto>();


                while (reader.Read())
                {

                    Producto producto = new Producto();
                    producto.IdProducto = (int)reader["id"];
                    producto.Nombre = reader["nombre"].ToString();
                    producto.Precio = Convert.ToDouble( reader["precio"]);
                    producto.Fecha_creacion = (DateTime)reader["fecha_creacion"];

                    productos.Add(producto);

                }

                connection.Close();

                //Muestro la información
                return productos;


            }
            catch (Exception)
            {
                connection.Close();
                throw;
            }
            finally
            {
                connection = null;
                command = null;
                param = null;
                productos = null;

            }


        }

        public void Insertar(Producto producto)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("insert_producto", connection); // Nombre del procedimiento almacenado
                    command.CommandType = CommandType.StoredProcedure;

                    // Parámetros del procedimiento almacenado                
                    command.Parameters.AddWithValue("@nombre", producto.Nombre);
                    command.Parameters.AddWithValue("@precio", producto.Precio);
                    command.Parameters.AddWithValue("@fecha_creacion", producto.Fecha_creacion);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

    }
}
