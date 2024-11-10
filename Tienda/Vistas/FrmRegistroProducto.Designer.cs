﻿namespace Tienda
{
    partial class FrmRegistroProducto
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
            txtNombreProducto = new TextBox();
            lblUsuario = new Label();
            numPrecioProdcuto = new NumericUpDown();
            lblPrecioProducto = new Label();
            txtCodigoBarrasProducto = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            numIDProducto = new NumericUpDown();
            btnGuardar = new Button();
            comboBoxCategoria = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numPrecioProdcuto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numIDProducto).BeginInit();
            SuspendLayout();
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreProducto.Location = new Point(167, 98);
            txtNombreProducto.Margin = new Padding(3, 2, 3, 2);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(546, 30);
            txtNombreProducto.TabIndex = 4;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(32, 104);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(89, 22);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Nombre:";
            // 
            // numPrecioProdcuto
            // 
            numPrecioProdcuto.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numPrecioProdcuto.Location = new Point(167, 143);
            numPrecioProdcuto.Margin = new Padding(3, 2, 3, 2);
            numPrecioProdcuto.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numPrecioProdcuto.Name = "numPrecioProdcuto";
            numPrecioProdcuto.Size = new Size(213, 24);
            numPrecioProdcuto.TabIndex = 5;
            numPrecioProdcuto.TextAlign = HorizontalAlignment.Center;
            // 
            // lblPrecioProducto
            // 
            lblPrecioProducto.AutoSize = true;
            lblPrecioProducto.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecioProducto.Location = new Point(50, 144);
            lblPrecioProducto.Name = "lblPrecioProducto";
            lblPrecioProducto.Size = new Size(71, 22);
            lblPrecioProducto.TabIndex = 6;
            lblPrecioProducto.Text = "Precio:";
            // 
            // txtCodigoBarrasProducto
            // 
            txtCodigoBarrasProducto.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCodigoBarrasProducto.Location = new Point(167, 188);
            txtCodigoBarrasProducto.Margin = new Padding(3, 2, 3, 2);
            txtCodigoBarrasProducto.Name = "txtCodigoBarrasProducto";
            txtCodigoBarrasProducto.Size = new Size(546, 30);
            txtCodigoBarrasProducto.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 190);
            label1.Name = "label1";
            label1.Size = new Size(121, 22);
            label1.TabIndex = 7;
            label1.Text = "Cod. Barras:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 241);
            label2.Name = "label2";
            label2.Size = new Size(109, 22);
            label2.TabIndex = 9;
            label2.Text = "Categoría:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(50, 53);
            label3.Name = "label3";
            label3.Size = new Size(34, 22);
            label3.TabIndex = 12;
            label3.Text = "ID:";
            // 
            // numIDProducto
            // 
            numIDProducto.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numIDProducto.Location = new Point(167, 52);
            numIDProducto.Margin = new Padding(3, 2, 3, 2);
            numIDProducto.Name = "numIDProducto";
            numIDProducto.Size = new Size(213, 24);
            numIDProducto.TabIndex = 11;
            numIDProducto.TextAlign = HorizontalAlignment.Center;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(269, 315);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(179, 32);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // comboBoxCategoria
            // 
            comboBoxCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategoria.FormattingEnabled = true;
            comboBoxCategoria.Location = new Point(167, 243);
            comboBoxCategoria.Name = "comboBoxCategoria";
            comboBoxCategoria.Size = new Size(161, 23);
            comboBoxCategoria.TabIndex = 14;
            // 
            // FrmRegistroProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 394);
            Controls.Add(comboBoxCategoria);
            Controls.Add(btnGuardar);
            Controls.Add(label3);
            Controls.Add(numIDProducto);
            Controls.Add(label2);
            Controls.Add(txtCodigoBarrasProducto);
            Controls.Add(label1);
            Controls.Add(lblPrecioProducto);
            Controls.Add(numPrecioProdcuto);
            Controls.Add(txtNombreProducto);
            Controls.Add(lblUsuario);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmRegistroProducto";
            Text = "Registro de Producto";
            ((System.ComponentModel.ISupportInitialize)numPrecioProdcuto).EndInit();
            ((System.ComponentModel.ISupportInitialize)numIDProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblUsuario;
        private Label lblPrecioProducto;
        private Label label1;
        private Label label2;
        private Label label3;
        public TextBox txtNombreProducto;
        public NumericUpDown numPrecioProdcuto;
        public TextBox txtCodigoBarrasProducto;
        public NumericUpDown numIDProducto;
        public Button btnGuardar;
        public ComboBox comboBoxCategoria;
    }
}