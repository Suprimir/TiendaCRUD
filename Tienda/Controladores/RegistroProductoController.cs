using Tienda.DAO;
using Tienda.Modelos;

namespace Tienda.Controladores
{
    internal class RegistroProductoController
    {
        private List<Categoria> _lstCategorias = CategoriasDAO.ObtenerTodas(); // Esta lista la usaremos para poder agregar las categorias al comboBox de categorias y poder seleccionarla en el form

        private Categoria _categoriaSeleccionada; // Se declara null por ahora ya despues se le asignara valor

        private FrmRegistroProducto _frmRegistroProducto;

        public RegistroProductoController(FrmRegistroProducto frmRegistroProducto)
        {
            _frmRegistroProducto = frmRegistroProducto;
            _frmRegistroProducto._frmMenu.Hide();

            // Este evento es cuando presionamos una tecla dentro del numericUpDown del id y asignamos funcion la cual basicamente ejecuta el obtenerPorID
            _frmRegistroProducto.numIDProducto.KeyDown += numIDProducto_KeyDown; 

            // Este evento de click en el boton de guardar ejecuta una funcion para guardar el producto
            _frmRegistroProducto.btnGuardar.Click += btnGuardar_Click;

            // Este ejecuta una funcion de mostrar el Menu cuando se cierra el registro de un producto
            _frmRegistroProducto.FormClosing += frmRegistroProducto_OnClosing;
            _frmRegistroProducto.btnReturn.Click += frmRegistroProducto_OnClosing;

            // Este evento se ejecuta en cuanto se abre el formulario y carga las categorias en el comboBox de categorias
            _frmRegistroProducto.Load += frmRegistroProducto_Load;
        }

        // validacion de un producto
        private bool ValidarCapturaProducto()
        {
            // Esto simplemente obtiene los datos de la categoria que se selecciono
            _categoriaSeleccionada = _lstCategorias.FirstOrDefault(c => c.Nombre == _frmRegistroProducto.comboBoxCategoria.Text);

            if (_frmRegistroProducto.txtNombreProducto.Text == "") // Si no escribio nada en el nombre del producto retorna false
                return false;
            else if (Convert.ToDouble(_frmRegistroProducto.numPrecioProdcuto.Value) < _categoriaSeleccionada.Precio_minimo) // Si el precio es menor al minimo segun la categoria retorna false
                return false;
            else if (_frmRegistroProducto.txtCodigoBarrasProducto.Text.Length == 0) // Si no escribio nada en el codBarra retorna false
                return false;
            else if (string.IsNullOrEmpty(_frmRegistroProducto.comboBoxCategoria.Text)) // Si no selecciono ninguna categoria retorna false
                return false;

            return true;
        }

        // funcion que se ejecuta cuando se da clic al boton de guardar y realiza todas las instrucciones para guardar un producto
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // si los datos introducidos no son validos muestra un mensaje de captura incompleta
            if (!ValidarCapturaProducto())
            {
                MessageBox.Show("Captura incompleta.");
                return;
            }
            else
            {
                // crea un producto y le asigna los valores obtenidos del form
                Producto producto = new Producto();
                producto.Nombre = _frmRegistroProducto.txtNombreProducto.Text;
                producto.CategoriaId = _categoriaSeleccionada.Id;
                producto.Precio = Convert.ToDouble(_frmRegistroProducto.numPrecioProdcuto.Value);
                producto.CodigoBarras = _frmRegistroProducto.txtCodigoBarrasProducto.Text;

                // en un if ejecuta la funcion de guardar, si se guarda retorna true y muestra un mensaje de exito.
                if(ProductosDAO.GuardarEnDB(producto, _categoriaSeleccionada))
                {
                    MessageBox.Show($"Producto agregado :)");
                } else
                {
                    MessageBox.Show("Hubo un error en el guardado.");
                }
            }
        }

        // Funcion que se ejecuta cuando se detecta el evento de presion de tecla dentro del numeriUpDown del id
        private void numIDProducto_KeyDown(object sender, KeyEventArgs e)
        {
            // Si la tecla que se presiono es enter ejecuta la funcion de obtener producto por id
            if(e.KeyCode == Keys.Enter)
            {
                int id = Convert.ToInt32(_frmRegistroProducto.numIDProducto.Value);

                Producto producto = ProductosDAO.ObtenerPorID(id);

                if(producto != null)
                {
                    MessageBox.Show($"Producto: {producto.Nombre} | Precio: {producto.Precio} | CodBarra: {producto.CodigoBarras} | Categoria: {producto.CategoriaId}.");
                } else
                {
                    MessageBox.Show("No se encontro un producto con tal ID.");
                }
            }
        }

        // Funcion que se ejecuta cuando se abre el formulario de registro de productos
        private void frmRegistroProducto_Load(object sender, EventArgs e)
        {
            // Itera entre todas las categorias de la lista de categorias y agrega el nombre de cada categoria al comboBox de categorias
            foreach (var categoria in _lstCategorias)
            {
                _frmRegistroProducto.comboBoxCategoria.Items.Add(categoria.Nombre);
            }
        }

        // Funcion que se ejecuta cuando se cierra el formulario la cual simplemente vuelve a mostrar el menu principal.
        private void frmRegistroProducto_OnClosing(object sender, EventArgs e)
        {
            _frmRegistroProducto._frmMenu.Show();
            _frmRegistroProducto.Dispose();
        }
    }
}
