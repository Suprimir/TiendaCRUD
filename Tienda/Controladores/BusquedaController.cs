﻿using System.Collections.Generic;
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
            _frmBusqueda._frmMenu.Hide();

            categorias = CategoriasDAO.ObtenerTodas();
            productos = ProductosDAO.ObtenerTodos();

            _frmBusqueda.comboBoxSeleccion.TextChanged += comboBoxSeleccion_TextChanged;
            _frmBusqueda.textBoxBuscar.TextChanged += textBoxBuscar_TextChanged;

            _frmBusqueda.FormClosing += FrmBusqueda_OnClosing;
            _frmBusqueda.btnReturn.Click += FrmBusqueda_OnClosing;
        }

        private void comboBoxSeleccion_TextChanged(object sender, EventArgs e)
        {
            _frmBusqueda.dataGridViewBusqueda.Columns.Clear();

            switch (_frmBusqueda.comboBoxSeleccion.Text)
            {
                case "Categorías":
                    var buscarCategorias = categorias.Where(c => c.Nombre.Contains(_frmBusqueda.textBoxBuscar.Text, StringComparison.OrdinalIgnoreCase)).ToList();
                    
                    _frmBusqueda.dataGridViewBusqueda.DataSource = buscarCategorias;
                    _frmBusqueda.dataGridViewBusqueda.Columns[0].Width = 40;
                    _frmBusqueda.dataGridViewBusqueda.Columns[2].Width = 120;

                    break;
                case "Productos":
                    var buscarProductos = productos.Where(p => p.Nombre.Contains(_frmBusqueda.textBoxBuscar.Text, StringComparison.OrdinalIgnoreCase)).ToList();

                    _frmBusqueda.dataGridViewBusqueda.DataSource = buscarProductos;
                    _frmBusqueda.dataGridViewBusqueda.Columns[4].HeaderText = "Cat_id";
                    _frmBusqueda.dataGridViewBusqueda.Columns[5].HeaderText = "Cat_nombre";
                    _frmBusqueda.dataGridViewBusqueda.Columns[0].Width = 40;

                    break;
            }
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            comboBoxSeleccion_TextChanged(sender, e);
        }

        private void FrmBusqueda_OnClosing(object sender, EventArgs e)
        {
            _frmBusqueda._frmMenu.Show();
            _frmBusqueda.Dispose();
        }
    }
}
