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
        private int _id;
        private string _nombre;
        private double _precio_minimo;

        public int Id { get { return _id; } set { _id = value; } }
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public double Precio_minimo { get { return _precio_minimo; } set { _precio_minimo = value; } }
    }
}
