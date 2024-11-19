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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBusqueda));
            dataGridViewBusqueda = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnReturn = new Button();
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
            dataGridViewCellStyle1.BackColor = Color.LightGray;
            dataGridViewBusqueda.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewBusqueda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Lavender;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewBusqueda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewBusqueda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBusqueda.Location = new Point(9, 39);
            dataGridViewBusqueda.Margin = new Padding(0);
            dataGridViewBusqueda.MultiSelect = false;
            dataGridViewBusqueda.Name = "dataGridViewBusqueda";
            dataGridViewBusqueda.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.LightSteelBlue;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewBusqueda.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewBusqueda.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewBusqueda.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewBusqueda.Size = new Size(584, 307);
            dataGridViewBusqueda.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.GradientActiveCaption;
            flowLayoutPanel1.Controls.Add(btnReturn);
            flowLayoutPanel1.Controls.Add(comboBoxSeleccion);
            flowLayoutPanel1.Controls.Add(textBoxBuscar);
            flowLayoutPanel1.Location = new Point(9, -1);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(584, 40);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // btnReturn
            // 
            btnReturn.Image = Properties.Resources.returnIcon;
            btnReturn.Location = new Point(5, 5);
            btnReturn.Margin = new Padding(5);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(38, 29);
            btnReturn.TabIndex = 2;
            btnReturn.UseVisualStyleBackColor = true;
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
            comboBoxSeleccion.Location = new Point(53, 5);
            comboBoxSeleccion.Margin = new Padding(5);
            comboBoxSeleccion.Name = "comboBoxSeleccion";
            comboBoxSeleccion.Size = new Size(116, 29);
            comboBoxSeleccion.TabIndex = 0;
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxBuscar.Location = new Point(179, 5);
            textBoxBuscar.Margin = new Padding(5);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.Size = new Size(400, 27);
            textBoxBuscar.TabIndex = 1;
            // 
            // FrmBusqueda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(602, 355);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(dataGridViewBusqueda);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        public Button btnReturn;
    }
}