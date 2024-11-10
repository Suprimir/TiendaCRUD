using Tienda.Controladores;

namespace Tienda.Vistas
{
    public partial class FrmRegistroCategoria : Form
    {
        private FrmMenu _frmMenu;
        public FrmRegistroCategoria(FrmMenu frmMenu)
        {
            _frmMenu = frmMenu;

            InitializeComponent();

            RegistroCategoriaController registroCategoriaController = new RegistroCategoriaController(this);
        }
    }
}
