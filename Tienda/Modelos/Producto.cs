using Tienda.DAO;

namespace Tienda.Modelos
{
    public class Producto
    {
        private int _id;
        private string _nombre;
        private double _precio;
        private string _codigoBarras;
        private string _categoria;

        public int Id
        { get { return _id; } set { _id = value; } }
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public double Precio { get { return _precio; } set { _precio = value; } }
        public string CodigoBarras { get { return _codigoBarras; } set { _codigoBarras = value; } }
        public string Categoria { get { return _categoria; } set { _categoria = value; } }
    }

}
