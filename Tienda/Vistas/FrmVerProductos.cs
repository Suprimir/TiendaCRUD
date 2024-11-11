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
    public partial class FrmVerProductos : Form
    {
        private VerProductosController _verProductosController;
        public FrmVerProductos()
        {
            InitializeComponent();

            _verProductosController = new VerProductosController(this);
        }
    }
}
