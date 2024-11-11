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
            List<Categoria> list = CategoriasDAO.ObtenerTodas();

            foreach (var item in list)
            {
                _frmVerCategorias.dataGridViewCategorias.Rows.Add(item.Id, item.Name, item.Price);
            }
        }
    }
}
