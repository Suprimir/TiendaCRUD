using MySql.Data.MySqlClient;
using System.Configuration;
using Tienda.Modelos;

namespace Tienda.DAO
{
    internal class ProductosDAO
    {

        // Funcion para agregar productos en la base de datos
        public static bool GuardarEnDB(Producto producto, Categoria categoria)
        {
            // Creamos la variable de conexion usando el connectionString del App.config
            using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
            {
                // creamos el query que ejecutaremos (los valores con un @ al lado son parametros que reemplazaremos despues)
                string query = $"INSERT INTO productos (nombre, precio, codigoBarras, categoria_id) VALUES (@nombre, @precio, @codigoBarras, @categoria_id)";

                // creamos un cmd que ejecutaremos despues pasandole el query y la conexion
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    // asignamos los valores a los parametros
                    cmd.Parameters.AddWithValue("@nombre", producto.nombre);
                    cmd.Parameters.AddWithValue("@precio", producto.precio);
                    cmd.Parameters.AddWithValue("@codigoBarras", producto.codigoBarras);
                    cmd.Parameters.AddWithValue("@categoria_id", categoria.Id);

                    conn.Open();

                    // ejecutamos el cmd y si hay filas afectadas retorne true
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        return true; 
                    }
                }
            }

            return false;
        }

        // funcion para obtener un producto por su id
        public static Producto ObtenerPorID(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
            {
                string query = $"SELECT p.producto_id, p.nombre, p.precio, p.codigoBarras, c.nombre FROM productos p JOIN categorias c ON p.categoria_id = c.categoria_id WHERE p.producto_id = @id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    conn.Open();

                    // creamos un reader que iterara en los registros que retorne nuestro query (en este caso solo deberia devolver 1)
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        // mientras "itera" que devuelva el producto que coincida con el id
                        if(reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Producto producto = new Producto();

                                producto.id = reader.GetInt32(0);
                                producto.nombre = reader.GetString(1);
                                producto.precio = reader.GetDouble(2);
                                producto.codigoBarras = reader.GetString(3);
                                producto.categoria = reader.GetString(3);

                                return producto;
                            }
                        }

                        return null;
                    }
                }
            }
        }
    }
}
