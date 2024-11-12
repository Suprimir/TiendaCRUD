namespace Tienda.Modelos
{
    public class Usuario
    {
        private int _id;
        private string _nombreUsuario;
        private string _password;
        private bool _administrador;

        public int Id { get { return _id; } set { _id = value; } }
        public string NombreUsuario { get { return _nombreUsuario; } set { _nombreUsuario = value; } } 
        public string Password { get { return _password; } set { _password = value; } }
        public bool Administrador { get { return _administrador; } set { _administrador = value; } }
    }
}
