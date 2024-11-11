namespace Tienda.Vistas
{
    partial class FrmVerCategorias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewCategorias = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            PrecioMinimo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategorias).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCategorias
            // 
            dataGridViewCategorias.AllowUserToAddRows = false;
            dataGridViewCategorias.AllowUserToDeleteRows = false;
            dataGridViewCategorias.AllowUserToResizeColumns = false;
            dataGridViewCategorias.AllowUserToResizeRows = false;
            dataGridViewCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCategorias.ColumnHeadersHeight = 29;
            dataGridViewCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCategorias.Columns.AddRange(new DataGridViewColumn[] { ID, Categoria, PrecioMinimo });
            dataGridViewCategorias.ImeMode = ImeMode.NoControl;
            dataGridViewCategorias.Location = new Point(12, 12);
            dataGridViewCategorias.MultiSelect = false;
            dataGridViewCategorias.Name = "dataGridViewCategorias";
            dataGridViewCategorias.RightToLeft = RightToLeft.No;
            dataGridViewCategorias.RowHeadersVisible = false;
            dataGridViewCategorias.RowHeadersWidth = 51;
            dataGridViewCategorias.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCategorias.Size = new Size(637, 426);
            dataGridViewCategorias.TabIndex = 0;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.MinimumWidth = 6;
            Categoria.Name = "Categoria";
            // 
            // PrecioMinimo
            // 
            PrecioMinimo.HeaderText = "Precio Minimo";
            PrecioMinimo.MinimumWidth = 6;
            PrecioMinimo.Name = "PrecioMinimo";
            // 
            // FrmVerCategorias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 450);
            Controls.Add(dataGridViewCategorias);
            Name = "FrmVerCategorias";
            Text = "Ver Categorias";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategorias).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView dataGridViewCategorias;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn PrecioMinimo;
    }
}