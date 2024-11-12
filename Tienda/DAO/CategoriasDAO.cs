using MySql.Data.MySqlClient;
using System.Configuration;
using Tienda.Modelos;

namespace Tienda.DAO
{
    internal class CategoriasDAO
    {
        // Funcion para guardar una categoria en la base de datos
        public static bool GuardarEnBD(Categoria categoria)
        {
            // Creamos la variable de conexion obteniendo el string de conexion de nuestro App.config
            using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
            {
                // Query para insertar los valores en la tabla categorias (Los parametros que cambiariamos seria @nombre y @precio_minimo)
                string query = $"INSERT INTO categorias (nombre, precio_minimo) VALUES (@nombre, @precio_minimo)";

                // Creamos el comando usando el query y la conexion a la base de datos
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    // Aqui les asignamos los valores a los parametros 
                    cmd.Parameters.AddWithValue("@nombre", categoria.Nombre);
                    cmd.Parameters.AddWithValue("@precio_minimo", categoria.Precio_minimo);

                    // Abrimos la conexion
                    conn.Open();

                    // Ejecutamos la consulta solo si las filas afectadas son mayor a 0 (lo cual podemos suponer que los datos fueron agregados correctamente).
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

        // Funcion para obtener todas las categorias 
        public static List<Categoria> ObtenerTodas()
        {
            // Definimos una lista de categorias la cual retornaremos en esta funcion
            List<Categoria > list = new List<Categoria>();

            using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
            {
                string query = "SELECT * FROM categorias";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();

                    // Creamos un reader el cual iterara por todos los registros que devuelva la consulta
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Mientras itera el reader creamos una categoria y la agregamos a nuestra lista.
                        if(reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Categoria categoria = new Categoria();

                                categoria.Id = reader.GetInt32(0);
                                categoria.Nombre = reader.GetString(1);
                                categoria.Precio_minimo = reader.GetDouble(2);

                                list.Add(categoria);
                            }

                            // regresamos la lista
                            return list;
                        }

                        return null;
                    }
                }
            }
        }

        // Funcion para obtener una categoria por su id
        public static Categoria ObtenerPorID(decimal id)
        {
            using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
            {
                string query = $"SELECT * FROM categorias WHERE categoria_id=@id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    conn.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Categoria categoria = new Categoria();

                                categoria.Nombre = reader.GetString(1);
                                categoria.Precio_minimo = reader.GetDouble(2);

                                return categoria;
                            }
                        }

                        return null;
                    }
                }
            }
        }
    }
}
