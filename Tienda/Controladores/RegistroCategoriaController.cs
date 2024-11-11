using Tienda.Vistas;
using Tienda.Modelos;

namespace Tienda.Controladores
{
    internal class RegistroCategoriaController
    {
        private FrmRegistroCategoria _frmRegistroCategoria;

        public RegistroCategoriaController(FrmRegistroCategoria frmRregistroCategoria)
        {
            _frmRegistroCategoria = frmRregistroCategoria;
            _frmRegistroCategoria._frmMenu.Hide();

            _frmRegistroCategoria.numericID.KeyDown += numericID_KeyDown; // Cuando detecta que se presiono una tecla en el numericupdown del id y ejecuta su respectiva funcion
            _frmRegistroCategoria.btnGuardarCategoria.Click += btnGuardarCategoria_Click; // Cuando detecta el click en el boton de guardar categoria ejecuta su respectiva funcion
            _frmRegistroCategoria.FormClosing += frmRegistroCategoria_OnClosing; // Cuando se cierra la ventana de registro categoria ejecuta su respectiva funcion
        }

        // Funcion que se ejecuta cuando se da click en el boton de guardar categoria
        public void btnGuardarCategoria_Click(object sender, EventArgs e)
        {
            // obtiene los datos y guarda la categoria
            string nombre = _frmRegistroCategoria.textBoxNombre.Text;
            double precio_minimo = Convert.ToDouble(_frmRegistroCategoria.numericPrecioMinimo.Value);

            Categoria.Guardar(nombre, precio_minimo);
        }

        // Funcion que se ejcuta cuando detecta una tecla pulsada en el numeriupdown del id
        public void numericID_KeyDown(object sender, KeyEventArgs e)
        {
            // si la tecla presionada es la tecla enter ejecuta la funcion de obtener la categoria por su id
            if(e.KeyCode == Keys.Enter)
            {
                Categoria categoria = Categoria.ObtenerPorID(_frmRegistroCategoria.numericID.Value);

                // si la funcion devuelve una categoria valida muestra toda la informacion de la categoria
                if (categoria != null)
                {
                    MessageBox.Show("Categoria: " + categoria.Name + " Precio Minimo: " + categoria.Price);
                } else
                {
                    MessageBox.Show("No se encontro una categoria con tal ID.");
                }
            }
        }

        // funcion que cuando se cierra el form de registro de categoria muestre el menu y cierre este formulario
        public void frmRegistroCategoria_OnClosing(object sender, FormClosingEventArgs e)
        {
            _frmRegistroCategoria._frmMenu.Show();
            _frmRegistroCategoria.Dispose();
        }
    }
}
