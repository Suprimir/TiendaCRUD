using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda.DAO;
using Tienda.Modelos;
using Tienda.Vistas;

namespace Tienda.Controladores
{
    internal class VerProductosController
    {
        public FrmVerProductos _frmVerProductos;

        public VerProductosController(FrmVerProductos frmVerProductos)
        {
            this._frmVerProductos = frmVerProductos;

            _frmVerProductos.Load += frmVerProductos_Load;
        }

        public void frmVerProductos_Load(object sender, EventArgs e)
        {
            List<Producto> productos = ProductosDAO.ObtenerTodos();

            foreach (var item in productos)
            {
                _frmVerProductos.dataGridViewProductos.Rows.Add(item.id.ToString(), item.nombre, item.precio.ToString(), item.codigoBarras, item.categoria);
            }
        }
    }
}
