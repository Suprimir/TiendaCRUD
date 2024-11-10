using Tienda.Controladores;

namespace Tienda
{
    public partial class FrmRegistroProducto : Form
    {
        public FrmMenu _frmMenu;
        private RegistroProductoController _registroProductoController;
        public FrmRegistroProducto(FrmMenu frmMenu)
        {
            _frmMenu = frmMenu;

            InitializeComponent();

            // se declara el controlador de registro de producto
            _registroProductoController = new RegistroProductoController(this);
        }
    }
}
