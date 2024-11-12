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
            List<Producto> lstProductos = ProductosDAO.ObtenerTodos();

            foreach (var producto in lstProductos)
            {
                _frmVerProductos.dataGridViewProductos.Rows.Add(producto.Id, producto.Nombre, producto.Precio, producto.CodigoBarras, producto.Categoria);
            }
        }
    }
}
