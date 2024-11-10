using Tienda.Vistas;
using Tienda.Modelos;

namespace Tienda.Controladores
{
    internal class RegistroCategoriaController
    {
        private FrmRegistroCategoria _registroCategoria;

        public RegistroCategoriaController(FrmRegistroCategoria registroCategoria)
        {
            _registroCategoria = registroCategoria;

            _registroCategoria.numericID.ValueChanged += mostrar;
            _registroCategoria.btnGuardarCategoria.Click += btnGuardarCategoria_Click;
        }

        public void btnGuardarCategoria_Click(object sender, EventArgs e)
        {
            string nombre = _registroCategoria.textBoxNombre.Text;
            double precio_minimo = Convert.ToDouble(_registroCategoria.numericPrecioMinimo.Value);

            Categoria.Guardar(nombre, precio_minimo);
        }

        public void mostrar(object sender, EventArgs e)
        {
            Categoria categoria = Categoria.ObtenerPorID(_registroCategoria.numericID.Value);

            if (categoria != null )
            {
                MessageBox.Show("Categoria: " + categoria.Name + " Precio Minimo: " + categoria.Price);
            }
        }
    }
}
