using Tienda.Modelos;

namespace Tienda.Controladores
{
    internal class LoginController
    {
        private FrmLogin _frmLogin;

        public LoginController(FrmLogin frmLogin)
        {
            _frmLogin = frmLogin;

            _frmLogin.btnIniciar.Click += btnIniciar_Click;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (_frmLogin.txtUsuario.Text == "")
            {
                MessageBox.Show("Ingrese un usuario válido.");
                return;
            }
            if (_frmLogin.txtContraseña.Text == "")
            {
                MessageBox.Show("Ingrese una contraseña válida.");
                return;
            }

            Usuario usuario = new Usuario();
            usuario.nombreUsuario = _frmLogin.txtUsuario.Text;
            usuario.contraseña = _frmLogin.txtContraseña.Text;

            if (usuario.ValidarCredenciales())
            {
                MessageBox.Show("Sesión inicada correctamente.");
                FrmMenu frmMenu = new FrmMenu(usuario, _frmLogin);
                frmMenu.Show();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas.");
            }
        }
    }
}
