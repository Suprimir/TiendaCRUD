using Tienda.Vistas;

namespace Tienda.Controladores
{
    internal class MenuController
    {
        private FrmMenu _frmMenu;

        public MenuController(FrmMenu frmMenu)
        {
            _frmMenu = frmMenu;
            _frmMenu._frmLogin.Hide();

            // esto es un una simple asignacion al label de permisos en el menu con una condicional ternaria para saber si el usuario es administrador o no
            _frmMenu.lblTipoUsuario.Text = $"{_frmMenu.usuarioLoggedIn.nombreUsuario} {(_frmMenu.usuarioLoggedIn.administrador ? " Admin" : " Usuario")}";

            // aqui se asigna cada funcion a cada accion de un componente especifico en nuestro view. saluditos a sanchito su amigo peso plumita
            _frmMenu.btnRegistrarProducto.Click += btnRegistrarProducto_Click;
            _frmMenu.btnRegistrarCategoria.Click += btnRegistrarCateogoria_Click;
            _frmMenu.btnCerrarSesion.Click += btnCerrarSesion_Click;
            _frmMenu.FormClosing += frmMenu_OnClosing;
        }

        // Funcion para acceder al menu de registrar producto
        private void btnRegistrarProducto_Click(object sender, EventArgs e)
        {
            FrmRegistroProducto frmRegistroPrducto = new FrmRegistroProducto(_frmMenu);
            frmRegistroPrducto.ShowDialog();
        }

        // Funcion para acceder al menu de registrar categoria
        private void btnRegistrarCateogoria_Click(object sender, EventArgs e)
        {
            FrmRegistroCategoria frmRegistroCategoria = new FrmRegistroCategoria(_frmMenu);
            frmRegistroCategoria.ShowDialog();
        }

        // Funcion para cerrar sesion y volver al view de login
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            _frmMenu._frmLogin.Show();
            _frmMenu.Dispose();
        }

        // Funcion para si se cierra el view de menu se cierre el programa completamente
        private void frmMenu_OnClosing(object sender, FormClosingEventArgs e)
        {
            _frmMenu._frmLogin.Dispose();
        }
    }
}
