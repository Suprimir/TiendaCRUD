namespace Tienda
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUsuario = new Label();
            lblContraseña = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            btnIniciar = new Button();
            pictureBoxLogin = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogin).BeginInit();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(16, 244);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(95, 27);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContraseña.Location = new Point(16, 349);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(145, 27);
            lblContraseña.TabIndex = 1;
            lblContraseña.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(16, 276);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(362, 36);
            txtUsuario.TabIndex = 2;
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContraseña.Location = new Point(16, 381);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '•';
            txtContraseña.Size = new Size(362, 36);
            txtContraseña.TabIndex = 3;
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.CadetBlue;
            btnIniciar.BackgroundImageLayout = ImageLayout.None;
            btnIniciar.FlatStyle = FlatStyle.Popup;
            btnIniciar.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciar.ForeColor = SystemColors.ControlLightLight;
            btnIniciar.Location = new Point(101, 455);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(205, 43);
            btnIniciar.TabIndex = 4;
            btnIniciar.Text = "Iniciar sesión";
            btnIniciar.UseVisualStyleBackColor = false;
            // 
            // pictureBoxLogin
            // 
            pictureBoxLogin.Image = Properties.Resources.catLogin;
            pictureBoxLogin.Location = new Point(16, 16);
            pictureBoxLogin.Margin = new Padding(3, 4, 3, 4);
            pictureBoxLogin.Name = "pictureBoxLogin";
            pictureBoxLogin.Size = new Size(365, 200);
            pictureBoxLogin.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogin.TabIndex = 5;
            pictureBoxLogin.TabStop = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 512);
            Controls.Add(pictureBoxLogin);
            Controls.Add(btnIniciar);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Name = "FrmLogin";
            Text = "Log In";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Label lblContraseña;
        public TextBox txtUsuario;
        public TextBox txtContraseña;
        public Button btnIniciar;
        private PictureBox pictureBoxLogin;
    }
}
