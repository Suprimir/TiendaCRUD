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

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public double precio { get { return _precio; } set { _precio = value; } }
        public string codigoBarras { get { return _codigoBarras; } set { _codigoBarras = value; } }
        public string categoria { get { return _categoria; } set { _categoria = value; } }

        public static bool Guardar(Producto producto, Categoria categoria)
        {
            return ProductosDAO.GuardarEnDB(producto, categoria);
        }

        public static Producto ObtenerPorID(int id)
        {
            return ProductosDAO.ObtenerPorID(id);
        }
    }

}
