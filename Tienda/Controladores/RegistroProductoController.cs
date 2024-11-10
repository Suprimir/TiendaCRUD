using Tienda.Modelos;

namespace Tienda.Controladores
{
    internal class RegistroProductoController
    {
        private List<Categoria> _lstCategorias; // Esta lista la usaremos para poder agregar las categorias al comboBox de categorias y poder seleccionarla en el form

        private Categoria _categoriaSeleccionada; 

        private FrmRegistroProducto _frmRegistroProducto;

        public RegistroProductoController(FrmRegistroProducto frmRegistroProducto)
        {
            _frmRegistroProducto = frmRegistroProducto;
            _frmRegistroProducto._frmMenu.Hide();

            _lstCategorias = Categoria.ObtenerTodas(); // Obtenemos todas las categorias y las guardamos en la lista que definimos anteriormente

            // Este evento es cuando presionamos una tecla dentro del numericUpDown del id y asignamos funcion la cual basicamente ejecuta el obtenerPorID
            _frmRegistroProducto.numIDProducto.KeyDown += numIDProducto_KeyDown; 

            // Este evento de click en el boton de guardar ejecuta una funcion para guardar el producto
            _frmRegistroProducto.btnGuardar.Click += btnGuardar_Click;

            // Este ejecuta una funcion de mostrar el Menu cuando se cierra el registro de un producto
            _frmRegistroProducto.FormClosing += frmRegistroProducto_OnClosing;

            // Este evento se ejecuta en cuanto se abre el formulario y carga las categorias en el comboBox de categorias
            _frmRegistroProducto.Load += frmRegistroProducto_Load;
        }

        // validacion de un producto
        private bool ValidarCapturaProducto()
        {
            if (_frmRegistroProducto.txtNombreProducto.Text == "") // Si no escribio nada en el nombre del producto retorna false
                return false;
            else if (Convert.ToDouble(_frmRegistroProducto.numPrecioProdcuto.Value) < _categoriaSeleccionada.Price) // Si el precio es menor al minimo segun la categoria retorna false
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
                // Esto simplemente obtiene los datos de la categoria que se selecciono
                _categoriaSeleccionada = _lstCategorias.FirstOrDefault(c => c.Name == _frmRegistroProducto.comboBoxCategoria.Text);

                // crea un producto y le asigna los valores obtenidos del form
                Producto producto = new Producto();
                producto.nombre = _frmRegistroProducto.txtNombreProducto.Text;
                producto.categoria = _categoriaSeleccionada.Name;
                producto.precio = Convert.ToDouble(_frmRegistroProducto.numPrecioProdcuto.Value);
                producto.codigoBarras = _frmRegistroProducto.txtCodigoBarrasProducto.Text;

                // en un if ejecuta la funcion de guardar, si se guarda retorna true y muestra un mensaje de exito.
                if(Producto.Guardar(producto, _categoriaSeleccionada))
                {
                    MessageBox.Show($"Producto agregado :)");
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

                Producto producto = Producto.ObtenerPorID(id);

                MessageBox.Show($"Producto: {producto.nombre} | Precio: {producto.precio} | CodBarra: {producto.codigoBarras} | Categoria: {producto.categoria}");
            }
        }

        // Funcion que se ejecuta cuando se abre el formulario de registro de productos
        private void frmRegistroProducto_Load(object sender, EventArgs e)
        {
            // Itera entre todas las categorias de la lista de categorias y agrega el nombre de cada categoria al comboBox de categorias
            foreach(var item in _lstCategorias)
            {
                _frmRegistroProducto.comboBoxCategoria.Items.Add(item.Name);
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
