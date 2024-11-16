using Tienda.Properties;
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

            //_frmMenu.flowLayoutPanelUsuario.BackColor = ColorTranslator.FromHtml("#4B49AC");

            // esto es un una simple asignacion al label de permisos en el menu con una condicional ternaria para saber si el usuario es administrador o no
            _frmMenu.lblUsuario.Text = $"{_frmMenu.usuarioLoggedIn.NombreUsuario}";
            _frmMenu.lblTipoUsuario.Text = $"{(_frmMenu.usuarioLoggedIn.Administrador ? " Admin" : " Usuario")}";

            // Se le asigna las funciones a los botones de mostrar los productos y categorias
            _frmMenu.btnBusqueda.Click += btnBusqueda_Click;

            _frmMenu.btnRegistrar.Click += btnRegistrar_Click;
            _frmMenu.toolStripRegistrarCategoria.Click += btnRegistrarCateogoria_Click;
            _frmMenu.toolStripRegistrarProductos.Click += btnRegistrarProducto_Click;

            // aqui se asigna cada funcion a cada accion de un componente especifico en nuestro view. saluditos a sanchito su amigo peso plumita
            _frmMenu.btnCerrarSesion.Click += btnCerrarSesion_Click;
            _frmMenu.FormClosing += frmMenu_OnClosing;
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            FrmBusqueda frmBusqueda = new FrmBusqueda();
            frmBusqueda.ShowDialog();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(_frmMenu.btnRegistrar.ContextMenuStrip != null)
            {
                _frmMenu.btnRegistrar.ContextMenuStrip.Show(_frmMenu.btnRegistrar, new Point(_frmMenu.btnRegistrar.Width, 0));
            }
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
