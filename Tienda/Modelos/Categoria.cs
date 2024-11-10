using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda.DAO;

namespace Tienda.Modelos
{
    public class Categoria
    {
        private int id;
        private string nombre;
        private double precio_minimo;

        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return nombre; } set { nombre = value; } }
        public double Price { get { return precio_minimo; } set { precio_minimo = value; } }

        public static bool Guardar(string nombre, double precio_minimo)
        {
            Categoria categoria = new Categoria();

            categoria.Name = nombre;
            categoria.Price = precio_minimo;

            return CategoriasDAO.GuardarEnBD(categoria);
        }

        public static Categoria ObtenerPorID(decimal id)
        {
            return CategoriasDAO.ObtenerPorID(id);
        }

        public static List<Categoria> ObtenerTodas()
        {
            return CategoriasDAO.ObtenerTodas();
        }
    }
}
