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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistroCategoria));
            numericID = new NumericUpDown();
            lblID = new Label();
            lblNombre = new Label();
            textBoxNombre = new TextBox();
            lblPrecioMinimo = new Label();
            numericPrecioMinimo = new NumericUpDown();
            btnGuardarCategoria = new Button();
            btnReturn = new Button();
            ((System.ComponentModel.ISupportInitialize)numericID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericPrecioMinimo).BeginInit();
            SuspendLayout();
            // 
            // numericID
            // 
            numericID.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericID.Location = new Point(135, 8);
            numericID.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            numericID.Name = "numericID";
            numericID.Size = new Size(75, 27);
            numericID.TabIndex = 0;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblID.Location = new Point(12, 10);
            lblID.Name = "lblID";
            lblID.Size = new Size(27, 21);
            lblID.TabIndex = 1;
            lblID.Text = "ID";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(12, 46);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(73, 21);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNombre.Location = new Point(135, 43);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(155, 27);
            textBoxNombre.TabIndex = 3;
            // 
            // lblPrecioMinimo
            // 
            lblPrecioMinimo.AutoSize = true;
            lblPrecioMinimo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecioMinimo.Location = new Point(12, 84);
            lblPrecioMinimo.Name = "lblPrecioMinimo";
            lblPrecioMinimo.Size = new Size(117, 21);
            lblPrecioMinimo.TabIndex = 4;
            lblPrecioMinimo.Text = "Precio Mínimo";
            // 
            // numericPrecioMinimo
            // 
            numericPrecioMinimo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericPrecioMinimo.Location = new Point(135, 82);
            numericPrecioMinimo.Name = "numericPrecioMinimo";
            numericPrecioMinimo.Size = new Size(75, 27);
            numericPrecioMinimo.TabIndex = 5;
            // 
            // btnGuardarCategoria
            // 
            btnGuardarCategoria.BackColor = Color.CadetBlue;
            btnGuardarCategoria.FlatStyle = FlatStyle.Flat;
            btnGuardarCategoria.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarCategoria.ForeColor = SystemColors.ControlLightLight;
            btnGuardarCategoria.Location = new Point(55, 120);
            btnGuardarCategoria.Name = "btnGuardarCategoria";
            btnGuardarCategoria.Size = new Size(238, 43);
            btnGuardarCategoria.TabIndex = 6;
            btnGuardarCategoria.Text = "Guardar";
            btnGuardarCategoria.UseVisualStyleBackColor = false;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.CadetBlue;
            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReturn.ForeColor = SystemColors.ControlLightLight;
            btnReturn.Image = Properties.Resources.returnIconWhite;
            btnReturn.Location = new Point(12, 120);
            btnReturn.Margin = new Padding(3, 2, 3, 2);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(37, 43);
            btnReturn.TabIndex = 16;
            btnReturn.UseVisualStyleBackColor = false;
            // 
            // FrmRegistroCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(305, 174);
            Controls.Add(btnReturn);
            Controls.Add(btnGuardarCategoria);
            Controls.Add(numericPrecioMinimo);
            Controls.Add(lblPrecioMinimo);
            Controls.Add(textBoxNombre);
            Controls.Add(lblNombre);
            Controls.Add(lblID);
            Controls.Add(numericID);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmRegistroCategoria";
            Text = "Registrar Categoría";
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
        public Button btnReturn;
    }
}