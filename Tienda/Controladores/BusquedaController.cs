using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Tienda.DAO;
using Tienda.Modelos;
using Tienda.Vistas;

namespace Tienda.Controladores
{
    internal class BusquedaController
    {
        private FrmBusqueda _frmBusqueda;
        private List<Categoria> categorias;
        private List<Producto> productos;
        public BusquedaController(FrmBusqueda frmBusqueda)
        {
            this._frmBusqueda = frmBusqueda;

            categorias = CategoriasDAO.ObtenerTodas();
            productos = ProductosDAO.ObtenerTodos();

            _frmBusqueda.comboBoxSeleccion.TextChanged += comboBoxSeleccion_TextChanged;
            _frmBusqueda.textBoxBuscar.TextChanged += textBoxBuscar_TextChanged; 
        }

        private void comboBoxSeleccion_TextChanged(object sender, EventArgs e)
        {
            _frmBusqueda.dataGridViewBusqueda.Columns.Clear();

            switch (_frmBusqueda.comboBoxSeleccion.Text)
            {
                case "Categorias":
                    var buscarCategorias = categorias.Where(c => c.Nombre.Contains(_frmBusqueda.textBoxBuscar.Text)).ToList();
                    
                    _frmBusqueda.dataGridViewBusqueda.DataSource = buscarCategorias;

                    break;
                case "Productos":
                    var buscarProductos = productos.Where(p => p.Nombre.Contains(_frmBusqueda.textBoxBuscar.Text)).ToList();

                    _frmBusqueda.dataGridViewBusqueda.DataSource = buscarProductos;

                    break;
            }
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            comboBoxSeleccion_TextChanged(sender, e);
        }
    }
}
