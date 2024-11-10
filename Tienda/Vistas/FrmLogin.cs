using Tienda.Controladores;

namespace Tienda
{
    public partial class FrmLogin : Form
    {
        private LoginController _loginController;
        public FrmLogin()
        {
            InitializeComponent();

            // Se declara el login controller para poder controlar esta view
            _loginController = new LoginController(this);
        }
    }
}
