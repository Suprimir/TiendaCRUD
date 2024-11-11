using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda.Modelos;

namespace Tienda.DAO
{
    internal class UsuariosDAO
    {
        public static Usuario ValidarUsuarioDB(string nombre, string pass)
        {
            using (MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlDB"].ConnectionString))
            {
                string query = "SELECT nombre, pass FROM usuarios WHERE nombre = @nombre AND pass = @pass;";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@pass", pass);


                    conn.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if(reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Usuario usuario = new Usuario();

                                usuario.nombreUsuario = reader.GetString(0);
                                usuario.administrador = reader.GetBoolean(1);

                                return usuario;
                            }
                        }

                        return null;
                    }
                }
            }
        }
    }
}
