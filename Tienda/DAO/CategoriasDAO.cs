using MySql.Data.MySqlClient;
using System.Configuration;
using Tienda.Modelos;

namespace Tienda.DAO
{
    internal class CategoriasDAO
    {
        public static bool GuardarEnBD(Categoria categoria)
        {
            using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
            {
                string query = $"INSERT INTO categorias (nombre, precio_minimo) VALUES ('{categoria.Name}', {categoria.Price})";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Categoria Agregada");

                        return true;
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar la categoria");

                        return false;
                    }
                }
            }
        }

        public static List<Categoria> ObtenerTodas()
        {
            List<Categoria > list = new List<Categoria>();

            using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
            {
                string query = "SELECT * FROM categorias";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Categoria categoria = new Categoria();

                            categoria.Id = reader.GetInt32(0);
                            categoria.Name = reader.GetString(1);
                            categoria.Price = reader.GetDouble(2);

                            list.Add(categoria);
                        }

                        return list;
                    }
                }
            }
        }

        public static Categoria ObtenerPorID(decimal id)
        {
            using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
            {
                string query = $"SELECT * FROM categorias WHERE categoria_id={id}";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Categoria categoria = new Categoria();

                            categoria.Name = reader.GetString(1);
                            categoria.Price = reader.GetDouble(2);

                            return categoria;
                        }
                    }
                }
            }

            return null;
        }
    }
}
