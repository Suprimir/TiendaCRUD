namespace Tienda.Vistas
{
    partial class FrmRegistroCategoria
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
            numericID = new NumericUpDown();
            lblID = new Label();
            lblNombre = new Label();
            textBoxNombre = new TextBox();
            lblPrecioMinimo = new Label();
            numericPrecioMinimo = new NumericUpDown();
            btnGuardarCategoria = new Button();
            ((System.ComponentModel.ISupportInitialize)numericID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericPrecioMinimo).BeginInit();
            SuspendLayout();
            // 
            // numericID
            // 
            numericID.Location = new Point(120, 12);
            numericID.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            numericID.Name = "numericID";
            numericID.Size = new Size(75, 23);
            numericID.TabIndex = 0;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(21, 14);
            lblID.Name = "lblID";
            lblID.Size = new Size(18, 15);
            lblID.TabIndex = 1;
            lblID.Text = "ID";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(21, 49);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(120, 46);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(179, 23);
            textBoxNombre.TabIndex = 3;
            // 
            // lblPrecioMinimo
            // 
            lblPrecioMinimo.AutoSize = true;
            lblPrecioMinimo.Location = new Point(21, 86);
            lblPrecioMinimo.Name = "lblPrecioMinimo";
            lblPrecioMinimo.Size = new Size(85, 15);
            lblPrecioMinimo.TabIndex = 4;
            lblPrecioMinimo.Text = "Precio Minimo";
            // 
            // numericPrecioMinimo
            // 
            numericPrecioMinimo.Location = new Point(120, 84);
            numericPrecioMinimo.Name = "numericPrecioMinimo";
            numericPrecioMinimo.Size = new Size(75, 23);
            numericPrecioMinimo.TabIndex = 5;
            // 
            // btnGuardarCategoria
            // 
            btnGuardarCategoria.Location = new Point(21, 120);
            btnGuardarCategoria.Name = "btnGuardarCategoria";
            btnGuardarCategoria.Size = new Size(278, 43);
            btnGuardarCategoria.TabIndex = 6;
            btnGuardarCategoria.Text = "Guardar";
            btnGuardarCategoria.UseVisualStyleBackColor = true;
            // 
            // FrmRegistroCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(311, 175);
            Controls.Add(btnGuardarCategoria);
            Controls.Add(numericPrecioMinimo);
            Controls.Add(lblPrecioMinimo);
            Controls.Add(textBoxNombre);
            Controls.Add(lblNombre);
            Controls.Add(lblID);
            Controls.Add(numericID);
            Name = "FrmRegistroCategoria";
            Text = "Registrar Categoria";
            ((System.ComponentModel.ISupportInitialize)numericID).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericPrecioMinimo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblID;
        private Label lblNombre;
        private Label lblPrecioMinimo;
        public NumericUpDown numericID;
        public TextBox textBoxNombre;
        public NumericUpDown numericPrecioMinimo;
        public Button btnGuardarCategoria;
        private NumericUpDown numericUpDown2;
    }
}