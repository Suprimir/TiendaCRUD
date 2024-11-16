using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tienda.Controladores;

namespace Tienda.Vistas
{
    public partial class FrmBusqueda : Form
    {
        public FrmMenu _frmMenu;
        private BusquedaController busquedaController;
        public FrmBusqueda(FrmMenu frmMenu)
        {
            this._frmMenu = frmMenu;

            InitializeComponent();

            busquedaController = new BusquedaController(this);
        }
    }
}
