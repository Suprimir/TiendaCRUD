using Tienda.Modelos;

namespace Tienda.Controladores
{
    internal class RegistroProductoController
    {
        private List<Categoria> _lstCategorias;

        private Categoria _categoriaSeleccionada;

        private FrmRegistroProducto _frmRegistroProducto;

        public RegistroProductoController(FrmRegistroProducto frmRegistroProducto)
        {
            _frmRegistroProducto = frmRegistroProducto;
            _frmRegistroProducto._frmMenu.Hide();

            _lstCategorias = Categoria.ObtenerTodas();

            _frmRegistroProducto.numIDProducto.KeyDown += numIDProducto_KeyDown;
            _frmRegistroProducto.btnGuardar.Click += btnGuardar_Click;
            _frmRegistroProducto.FormClosing += frmRegistroProducto_OnClosing;

            _frmRegistroProducto.Load += frmRegistroProducto_Load;
        }

        private bool ValidarCapturaProducto()
        {
            _categoriaSeleccionada = _lstCategorias.FirstOrDefault(c => c.Name == _frmRegistroProducto.comboBoxCategoria.Text);

            if (_frmRegistroProducto.txtNombreProducto.Text == "")
                return false;
            else if (Convert.ToDouble(_frmRegistroProducto.numPrecioProdcuto.Value) < _categoriaSeleccionada.Price)
                return false;
            else if (_frmRegistroProducto.txtCodigoBarrasProducto.Text.Length == 0)
                return false;
            else if (string.IsNullOrEmpty(_frmRegistroProducto.comboBoxCategoria.Text))
                return false;

            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCapturaProducto())
            {
                MessageBox.Show("Captura incompleta.");
                return;
            }
            else
            {
                Producto producto = new Producto();
                producto.nombre = _frmRegistroProducto.txtNombreProducto.Text;
                producto.categoria = _categoriaSeleccionada.Name;
                producto.precio = Convert.ToDouble(_frmRegistroProducto.numPrecioProdcuto.Value);
                producto.codigoBarras = _frmRegistroProducto.txtCodigoBarrasProducto.Text;

                if(Producto.Guardar(producto, _categoriaSeleccionada))
                {
                    MessageBox.Show($"Producto agregado :)");
                }
            }
        }

        private void numIDProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                int id = Convert.ToInt32(_frmRegistroProducto.numIDProducto.Value);

                Producto producto = Producto.ObtenerPorID(id);

                MessageBox.Show($"Producto: {producto.nombre} | Precio: {producto.precio} | CodBarra: {producto.codigoBarras} | Categoria: {producto.categoria}");
            }
        }

        private void frmRegistroProducto_Load(object sender, EventArgs e)
        {
            foreach(var item in _lstCategorias)
            {
                _frmRegistroProducto.comboBoxCategoria.Items.Add(item.Name);
            }
        }

        private void frmRegistroProducto_OnClosing(object sender, EventArgs e)
        {
            _frmRegistroProducto._frmMenu.Show();
            _frmRegistroProducto.Dispose();
        }
    }
}
