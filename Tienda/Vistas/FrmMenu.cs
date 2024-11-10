using Tienda.Controladores;
using Tienda.Modelos;

namespace Tienda
{
    public partial class FrmMenu : Form
    {
        public Usuario usuarioLoggedIn;
        public FrmLogin _frmLogin;
        private MenuController _menuController;
        public FrmMenu(Usuario usuario, FrmLogin frmLogin)
        {
            // Guardamos el usuario para poder acceder a su informacion dentro del menu
            usuarioLoggedIn = usuario;

            // Guardamos el login para poder volver a acceder a el si se cierra sesion
            _frmLogin = frmLogin;

            InitializeComponent();

            // se declara el controlador de menu
            _menuController = new MenuController(this);
        }
    }
}
