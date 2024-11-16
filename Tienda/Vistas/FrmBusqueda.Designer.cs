namespace Tienda.Vistas
{
    partial class FrmBusqueda
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
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            dataGridViewBusqueda = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            comboBoxSeleccion = new ComboBox();
            textBoxBuscar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBusqueda).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewBusqueda
            // 
            dataGridViewBusqueda.AllowUserToAddRows = false;
            dataGridViewBusqueda.AllowUserToDeleteRows = false;
            dataGridViewBusqueda.AllowUserToResizeColumns = false;
            dataGridViewBusqueda.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.BackColor = Color.LightGray;
            dataGridViewBusqueda.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            dataGridViewBusqueda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = Color.Lavender;
            dataGridViewCellStyle18.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle18.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.True;
            dataGridViewBusqueda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            dataGridViewBusqueda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBusqueda.Location = new Point(9, 39);
            dataGridViewBusqueda.Margin = new Padding(0);
            dataGridViewBusqueda.MultiSelect = false;
            dataGridViewBusqueda.Name = "dataGridViewBusqueda";
            dataGridViewBusqueda.ReadOnly = true;
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = Color.LightSteelBlue;
            dataGridViewCellStyle19.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle19.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = DataGridViewTriState.True;
            dataGridViewBusqueda.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewBusqueda.RowHeadersVisible = false;
            dataGridViewCellStyle20.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewBusqueda.RowsDefaultCellStyle = dataGridViewCellStyle20;
            dataGridViewBusqueda.Size = new Size(584, 307);
            dataGridViewBusqueda.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Azure;
            flowLayoutPanel1.Controls.Add(comboBoxSeleccion);
            flowLayoutPanel1.Controls.Add(textBoxBuscar);
            flowLayoutPanel1.Location = new Point(9, -1);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(584, 40);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // comboBoxSeleccion
            // 
            comboBoxSeleccion.BackColor = Color.Azure;
            comboBoxSeleccion.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSeleccion.DropDownWidth = 189;
            comboBoxSeleccion.FlatStyle = FlatStyle.System;
            comboBoxSeleccion.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxSeleccion.FormattingEnabled = true;
            comboBoxSeleccion.Items.AddRange(new object[] { "Categorias", "Productos" });
            comboBoxSeleccion.Location = new Point(5, 5);
            comboBoxSeleccion.Margin = new Padding(5);
            comboBoxSeleccion.Name = "comboBoxSeleccion";
            comboBoxSeleccion.Size = new Size(129, 29);
            comboBoxSeleccion.TabIndex = 0;
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxBuscar.Location = new Point(144, 5);
            textBoxBuscar.Margin = new Padding(5);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.Size = new Size(435, 27);
            textBoxBuscar.TabIndex = 1;
            // 
            // FrmBusqueda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(602, 355);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(dataGridViewBusqueda);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmBusqueda";
            Text = "Busqueda";
            ((System.ComponentModel.ISupportInitialize)dataGridViewBusqueda).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        public ComboBox comboBoxSeleccion;
        public DataGridView dataGridViewBusqueda;
        public TextBox textBoxBuscar;
    }
}