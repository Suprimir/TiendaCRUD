﻿namespace Tienda
{
    partial class FrmMenu
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
            lblTipoUsuario = new Label();
            btnRegistrarProducto = new Button();
            btnCerrarSesion = new Button();
            btnRegistrarCategoria = new Button();
            lblTipoUsuarioStatic = new Label();
            pictureBox1 = new PictureBox();
            btnMostrarProductos = new Button();
            btnMostrarCategorias = new Button();
            lblUsuarioStatic = new Label();
            lblUsuario = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTipoUsuario
            // 
            lblTipoUsuario.AutoSize = true;
            lblTipoUsuario.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipoUsuario.Location = new Point(477, 283);
            lblTipoUsuario.Name = "lblTipoUsuario";
            lblTipoUsuario.Size = new Size(57, 21);
            lblTipoUsuario.TabIndex = 0;
            lblTipoUsuario.Text = "label1";
            // 
            // btnRegistrarProducto
            // 
            btnRegistrarProducto.BackColor = Color.CadetBlue;
            btnRegistrarProducto.FlatStyle = FlatStyle.Flat;
            btnRegistrarProducto.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarProducto.ForeColor = SystemColors.ControlLightLight;
            btnRegistrarProducto.Location = new Point(399, 11);
            btnRegistrarProducto.Margin = new Padding(3, 2, 3, 2);
            btnRegistrarProducto.Name = "btnRegistrarProducto";
            btnRegistrarProducto.Size = new Size(223, 37);
            btnRegistrarProducto.TabIndex = 14;
            btnRegistrarProducto.Text = "Registrar Producto";
            btnRegistrarProducto.UseVisualStyleBackColor = false;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.LightCoral;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrarSesion.ForeColor = SystemColors.ControlLightLight;
            btnCerrarSesion.Location = new Point(399, 332);
            btnCerrarSesion.Margin = new Padding(3, 2, 3, 2);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(223, 37);
            btnCerrarSesion.TabIndex = 15;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            // 
            // btnRegistrarCategoria
            // 
            btnRegistrarCategoria.BackColor = Color.CadetBlue;
            btnRegistrarCategoria.FlatStyle = FlatStyle.Flat;
            btnRegistrarCategoria.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarCategoria.ForeColor = SystemColors.ControlLightLight;
            btnRegistrarCategoria.Location = new Point(401, 62);
            btnRegistrarCategoria.Margin = new Padding(3, 2, 3, 2);
            btnRegistrarCategoria.Name = "btnRegistrarCategoria";
            btnRegistrarCategoria.Size = new Size(223, 37);
            btnRegistrarCategoria.TabIndex = 16;
            btnRegistrarCategoria.Text = "Registrar Categoria";
            btnRegistrarCategoria.UseVisualStyleBackColor = false;
            // 
            // lblTipoUsuarioStatic
            // 
            lblTipoUsuarioStatic.AutoSize = true;
            lblTipoUsuarioStatic.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipoUsuarioStatic.Location = new Point(399, 283);
            lblTipoUsuarioStatic.Name = "lblTipoUsuarioStatic";
            lblTipoUsuarioStatic.Size = new Size(78, 21);
            lblTipoUsuarioStatic.TabIndex = 17;
            lblTipoUsuarioStatic.Text = "Permisos:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.catPfp;
            pictureBox1.Location = new Point(546, 232);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(76, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // btnMostrarProductos
            // 
            btnMostrarProductos.BackColor = Color.MediumSeaGreen;
            btnMostrarProductos.FlatStyle = FlatStyle.Flat;
            btnMostrarProductos.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostrarProductos.ForeColor = SystemColors.ControlLightLight;
            btnMostrarProductos.Location = new Point(10, 11);
            btnMostrarProductos.Margin = new Padding(3, 2, 3, 2);
            btnMostrarProductos.Name = "btnMostrarProductos";
            btnMostrarProductos.Size = new Size(136, 37);
            btnMostrarProductos.TabIndex = 19;
            btnMostrarProductos.Text = "Productos";
            btnMostrarProductos.UseVisualStyleBackColor = false;
            // 
            // btnMostrarCategorias
            // 
            btnMostrarCategorias.BackColor = Color.MediumSeaGreen;
            btnMostrarCategorias.FlatStyle = FlatStyle.Flat;
            btnMostrarCategorias.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostrarCategorias.ForeColor = SystemColors.ControlLightLight;
            btnMostrarCategorias.Location = new Point(10, 62);
            btnMostrarCategorias.Margin = new Padding(3, 2, 3, 2);
            btnMostrarCategorias.Name = "btnMostrarCategorias";
            btnMostrarCategorias.Size = new Size(136, 37);
            btnMostrarCategorias.TabIndex = 20;
            btnMostrarCategorias.Text = "Categorias";
            btnMostrarCategorias.UseVisualStyleBackColor = false;
            // 
            // lblUsuarioStatic
            // 
            lblUsuarioStatic.AutoSize = true;
            lblUsuarioStatic.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuarioStatic.Location = new Point(401, 232);
            lblUsuarioStatic.Name = "lblUsuarioStatic";
            lblUsuarioStatic.Size = new Size(70, 21);
            lblUsuarioStatic.TabIndex = 21;
            lblUsuarioStatic.Text = "Usuario:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(477, 232);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(57, 21);
            lblUsuario.TabIndex = 22;
            lblUsuario.Text = "label1";
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 380);
            Controls.Add(lblUsuario);
            Controls.Add(lblUsuarioStatic);
            Controls.Add(btnMostrarCategorias);
            Controls.Add(btnMostrarProductos);
            Controls.Add(pictureBox1);
            Controls.Add(lblTipoUsuarioStatic);
            Controls.Add(btnRegistrarCategoria);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnRegistrarProducto);
            Controls.Add(lblTipoUsuario);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmMenu";
            Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Button btnCerrarSesion;
        public Label lblTipoUsuario;
        public Button btnRegistrarProducto;
        public Button btnRegistrarCategoria;
        private Label lblTipoUsuarioStatic;
        private PictureBox pictureBox1;
        public Button btnMostrarProductos;
        public Button btnMostrarCategorias;
        private Label lblUsuarioStatic;
        public Label lblUsuario;
    }
}