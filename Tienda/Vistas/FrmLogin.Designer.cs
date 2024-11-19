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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
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
            lblUsuario.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(14, 183);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(89, 22);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario:";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContraseña.Location = new Point(14, 251);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(125, 22);
            lblContraseña.TabIndex = 1;
            lblContraseña.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.Window;
            txtUsuario.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(14, 207);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(317, 26);
            txtUsuario.TabIndex = 2;
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtContraseña.Location = new Point(14, 275);
            txtContraseña.Margin = new Padding(3, 2, 3, 2);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '•';
            txtContraseña.Size = new Size(317, 26);
            txtContraseña.TabIndex = 3;
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.CadetBlue;
            btnIniciar.BackgroundImageLayout = ImageLayout.None;
            btnIniciar.FlatAppearance.BorderColor = Color.White;
            btnIniciar.FlatAppearance.BorderSize = 0;
            btnIniciar.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciar.ForeColor = SystemColors.ControlLightLight;
            btnIniciar.Location = new Point(84, 321);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(168, 42);
            btnIniciar.TabIndex = 4;
            btnIniciar.Text = "Iniciar sesión";
            btnIniciar.UseVisualStyleBackColor = false;
            // 
            // pictureBoxLogin
            // 
            pictureBoxLogin.Image = Properties.Resources.loginForm;
            pictureBoxLogin.Location = new Point(14, 12);
            pictureBoxLogin.Name = "pictureBoxLogin";
            pictureBoxLogin.Size = new Size(319, 150);
            pictureBoxLogin.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogin.TabIndex = 5;
            pictureBoxLogin.TabStop = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 384);
            Controls.Add(pictureBoxLogin);
            Controls.Add(btnIniciar);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
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
