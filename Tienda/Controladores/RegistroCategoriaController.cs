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

            _registroCategoria.numericID.KeyDown += numericID_KeyDown; // Cuando detecta que se presiono una tecla en el numericupdown del id y ejecuta su respectiva funcion
            _registroCategoria.btnGuardarCategoria.Click += btnGuardarCategoria_Click; // Cuando detecta el click en el boton de guardar categoria ejecuta su respectiva funcion
        }

        // Funcion que se ejecuta cuando se da click en el boton de guardar categoria
        public void btnGuardarCategoria_Click(object sender, EventArgs e)
        {
            // obtiene los datos y guarda la categoria
            string nombre = _registroCategoria.textBoxNombre.Text;
            double precio_minimo = Convert.ToDouble(_registroCategoria.numericPrecioMinimo.Value);

            Categoria.Guardar(nombre, precio_minimo);
        }

        // Funcion que se ejcuta cuando detecta una tecla pulsada en el numeriupdown del id
        public void numericID_KeyDown(object sender, KeyEventArgs e)
        {
            // si la tecla presionada es la tecla enter ejecuta la funcion de obtener la categoria por su id
            if(e.KeyCode == Keys.Enter)
            {
                Categoria categoria = Categoria.ObtenerPorID(_registroCategoria.numericID.Value);

                // si la funcion devuelve una categoria valida muestra toda la informacion de la categoria
                if (categoria != null)
                {
                    MessageBox.Show("Categoria: " + categoria.Name + " Precio Minimo: " + categoria.Price);
                }
            }
        }
    }
}
