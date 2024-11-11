namespace Tienda
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTipoUsuario
            // 
            lblTipoUsuario.AutoSize = true;
            lblTipoUsuario.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipoUsuario.Location = new Point(552, 405);
            lblTipoUsuario.Name = "lblTipoUsuario";
            lblTipoUsuario.Size = new Size(72, 23);
            lblTipoUsuario.TabIndex = 0;
            lblTipoUsuario.Text = "label1";
            // 
            // btnRegistrarProducto
            // 
            btnRegistrarProducto.BackColor = Color.CadetBlue;
            btnRegistrarProducto.FlatStyle = FlatStyle.Flat;
            btnRegistrarProducto.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarProducto.ForeColor = SystemColors.ControlLightLight;
            btnRegistrarProducto.Location = new Point(456, 15);
            btnRegistrarProducto.Name = "btnRegistrarProducto";
            btnRegistrarProducto.Size = new Size(255, 49);
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
            btnCerrarSesion.Location = new Point(456, 443);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(255, 49);
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
            btnRegistrarCategoria.Location = new Point(458, 83);
            btnRegistrarCategoria.Name = "btnRegistrarCategoria";
            btnRegistrarCategoria.Size = new Size(255, 49);
            btnRegistrarCategoria.TabIndex = 16;
            btnRegistrarCategoria.Text = "Registrar Categoria";
            btnRegistrarCategoria.UseVisualStyleBackColor = false;
            // 
            // lblTipoUsuarioStatic
            // 
            lblTipoUsuarioStatic.AutoSize = true;
            lblTipoUsuarioStatic.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipoUsuarioStatic.Location = new Point(456, 405);
            lblTipoUsuarioStatic.Name = "lblTipoUsuarioStatic";
            lblTipoUsuarioStatic.Size = new Size(97, 23);
            lblTipoUsuarioStatic.TabIndex = 17;
            lblTipoUsuarioStatic.Text = "Permisos:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.catPfp;
            pictureBox1.Location = new Point(624, 309);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 124);
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
            btnMostrarProductos.Location = new Point(12, 15);
            btnMostrarProductos.Name = "btnMostrarProductos";
            btnMostrarProductos.Size = new Size(156, 49);
            btnMostrarProductos.TabIndex = 19;
            btnMostrarProductos.Text = "Productos";
            btnMostrarProductos.UseVisualStyleBackColor = false;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 507);
            Controls.Add(btnMostrarProductos);
            Controls.Add(pictureBox1);
            Controls.Add(lblTipoUsuarioStatic);
            Controls.Add(btnRegistrarCategoria);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnRegistrarProducto);
            Controls.Add(lblTipoUsuario);
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
    }
}