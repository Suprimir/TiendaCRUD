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
    internal class VerCategoriasController
    {
        private FrmVerCategorias _frmVerCategorias;

        public VerCategoriasController(FrmVerCategorias frmVerCategorias)
        {
            this._frmVerCategorias = frmVerCategorias;

            _frmVerCategorias.Load += FrmVerCategorias_Load;
        }

        public void FrmVerCategorias_Load(object sender, EventArgs e)
        {
            List<Categoria> _listCategorias = CategoriasDAO.ObtenerTodas();

            foreach (var categoria in _listCategorias)
            {
                _frmVerCategorias.dataGridViewCategorias.Rows.Add(categoria.Id, categoria.Nombre, categoria.Precio_minimo);
            }
        }
    }
}
