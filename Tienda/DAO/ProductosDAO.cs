using MySql.Data.MySqlClient;
using System.Configuration;
using Tienda.Modelos;

namespace Tienda.DAO
{
    internal class ProductosDAO
    {
        public static bool GuardarEnDB(Producto producto, Categoria categoria)
        {
            using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
            {
                string query = $"INSERT INTO productos (nombre, precio, codigoBarras, categoria_id) VALUES (@nombre, @precio, @codigoBarras, @categoria_id)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", producto.nombre);
                    cmd.Parameters.AddWithValue("@precio", producto.precio);
                    cmd.Parameters.AddWithValue("@codigoBarras", producto.codigoBarras);
                    cmd.Parameters.AddWithValue("@categoria_id", categoria.Id);

                    conn.Open();

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        return true; 
                    }
                }
            }

            return false;
        }

        public static Producto ObtenerPorID(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
            {
                string query = $"SELECT p.producto_id, p.nombre, p.precio, p.codigoBarras, c.nombre FROM productos p JOIN categorias c ON p.categoria_id = c.categoria_id WHERE p.producto_id = @id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    conn.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
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
                }
            }

            return null;
        }
    }
}
