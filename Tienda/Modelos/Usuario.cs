namespace Tienda.Modelos
{
    public class Usuario
    {
        public string nombreUsuario;
        public string contraseña;
        public bool administrador;

        private static List<Usuario> usuarios = new List<Usuario>()
        {
            new Usuario(){ nombreUsuario = "admin", contraseña = "123", administrador = true},
            new Usuario(){ nombreUsuario = "cliente", contraseña = "321", administrador = false}
        };

        // funcion para validar las credenciales si existen en la lista de usuarios
        public bool ValidarCredenciales()
        {
            var usuario = usuarios.Where(u => u.nombreUsuario == nombreUsuario
                                              && u.contraseña == contraseña).ToList();

            if (usuario != null)
            {
                administrador = usuario[0].administrador;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
