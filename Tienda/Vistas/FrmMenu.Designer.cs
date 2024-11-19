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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            lblTipoUsuario = new Label();
            btnRegistrar = new Button();
            contextMenuRegistrar = new ContextMenuStrip(components);
            toolStripRegistrarCategoria = new ToolStripMenuItem();
            toolStripRegistrarProductos = new ToolStripMenuItem();
            btnCerrarSesion = new Button();
            lblTipoUsuarioStatic = new Label();
            pictureBox1 = new PictureBox();
            lblUsuarioStatic = new Label();
            lblUsuario = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanelUsuario = new FlowLayoutPanel();
            btnBusqueda = new Button();
            pictureBox2 = new PictureBox();
            lblMenuForm = new Label();
            contextMenuRegistrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanelUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblTipoUsuario
            // 
            lblTipoUsuario.AutoSize = true;
            lblTipoUsuario.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipoUsuario.ForeColor = SystemColors.ControlText;
            lblTipoUsuario.Location = new Point(76, 37);
            lblTipoUsuario.Name = "lblTipoUsuario";
            lblTipoUsuario.Size = new Size(47, 17);
            lblTipoUsuario.TabIndex = 0;
            lblTipoUsuario.Text = "label1";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.Azure;
            btnRegistrar.ContextMenuStrip = contextMenuRegistrar;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = SystemColors.ControlText;
            btnRegistrar.Image = Properties.Resources.registrarIcon;
            btnRegistrar.ImageAlign = ContentAlignment.MiddleRight;
            btnRegistrar.Location = new Point(4, 114);
            btnRegistrar.Margin = new Padding(3, 2, 3, 2);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(216, 37);
            btnRegistrar.TabIndex = 14;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // contextMenuRegistrar
            // 
            contextMenuRegistrar.BackColor = SystemColors.GradientInactiveCaption;
            contextMenuRegistrar.BackgroundImageLayout = ImageLayout.None;
            contextMenuRegistrar.DropShadowEnabled = false;
            contextMenuRegistrar.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contextMenuRegistrar.ImeMode = ImeMode.NoControl;
            contextMenuRegistrar.Items.AddRange(new ToolStripItem[] { toolStripRegistrarCategoria, toolStripRegistrarProductos });
            contextMenuRegistrar.Name = "contextMenuBusqueda";
            contextMenuRegistrar.ShowCheckMargin = true;
            contextMenuRegistrar.Size = new Size(206, 60);
            // 
            // toolStripRegistrarCategoria
            // 
            toolStripRegistrarCategoria.BackColor = SystemColors.GradientActiveCaption;
            toolStripRegistrarCategoria.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripRegistrarCategoria.ForeColor = SystemColors.ControlText;
            toolStripRegistrarCategoria.Image = Properties.Resources.categoriasIcon;
            toolStripRegistrarCategoria.Name = "toolStripRegistrarCategoria";
            toolStripRegistrarCategoria.Size = new Size(205, 28);
            toolStripRegistrarCategoria.Text = "Categorias";
            toolStripRegistrarCategoria.ToolTipText = "Registrar categorias";
            // 
            // toolStripRegistrarProductos
            // 
            toolStripRegistrarProductos.BackColor = SystemColors.GradientActiveCaption;
            toolStripRegistrarProductos.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripRegistrarProductos.ForeColor = SystemColors.ControlText;
            toolStripRegistrarProductos.Image = Properties.Resources.productosIcon;
            toolStripRegistrarProductos.MergeAction = MergeAction.Insert;
            toolStripRegistrarProductos.Name = "toolStripRegistrarProductos";
            toolStripRegistrarProductos.Size = new Size(205, 28);
            toolStripRegistrarProductos.Text = "Productos";
            toolStripRegistrarProductos.ToolTipText = "Visualizar productos";
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Anchor = AnchorStyles.Bottom;
            btnCerrarSesion.BackColor = Color.SlateGray;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrarSesion.ForeColor = SystemColors.ControlLightLight;
            btnCerrarSesion.Location = new Point(0, 343);
            btnCerrarSesion.Margin = new Padding(0);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(223, 37);
            btnCerrarSesion.TabIndex = 15;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            // 
            // lblTipoUsuarioStatic
            // 
            lblTipoUsuarioStatic.AutoSize = true;
            lblTipoUsuarioStatic.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipoUsuarioStatic.ForeColor = SystemColors.ControlText;
            lblTipoUsuarioStatic.Location = new Point(3, 37);
            lblTipoUsuarioStatic.Name = "lblTipoUsuarioStatic";
            lblTipoUsuarioStatic.Size = new Size(67, 16);
            lblTipoUsuarioStatic.TabIndex = 17;
            lblTipoUsuarioStatic.Text = "Permisos:";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.catPfp;
            pictureBox1.Location = new Point(161, 0);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // lblUsuarioStatic
            // 
            lblUsuarioStatic.Anchor = AnchorStyles.Left;
            lblUsuarioStatic.AutoSize = true;
            lblUsuarioStatic.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuarioStatic.ForeColor = SystemColors.ControlText;
            lblUsuarioStatic.Location = new Point(3, 5);
            lblUsuarioStatic.Margin = new Padding(3, 5, 3, 10);
            lblUsuarioStatic.Name = "lblUsuarioStatic";
            lblUsuarioStatic.Padding = new Padding(0, 5, 0, 0);
            lblUsuarioStatic.Size = new Size(59, 21);
            lblUsuarioStatic.TabIndex = 21;
            lblUsuarioStatic.Text = "Usuario:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Dock = DockStyle.Top;
            lblUsuario.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = SystemColors.ControlText;
            lblUsuario.ImageAlign = ContentAlignment.MiddleRight;
            lblUsuario.Location = new Point(68, 5);
            lblUsuario.Margin = new Padding(3, 5, 3, 10);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Padding = new Padding(0, 5, 0, 0);
            lblUsuario.RightToLeft = RightToLeft.No;
            lblUsuario.Size = new Size(47, 22);
            lblUsuario.TabIndex = 22;
            lblUsuario.Text = "label1";
            lblUsuario.TextAlign = ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Azure;
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Controls.Add(flowLayoutPanelUsuario);
            flowLayoutPanel1.Controls.Add(btnBusqueda);
            flowLayoutPanel1.Controls.Add(btnRegistrar);
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 1);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(223, 342);
            flowLayoutPanel1.TabIndex = 23;
            // 
            // flowLayoutPanelUsuario
            // 
            flowLayoutPanelUsuario.BackColor = Color.LightCyan;
            flowLayoutPanelUsuario.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanelUsuario.Controls.Add(lblUsuarioStatic);
            flowLayoutPanelUsuario.Controls.Add(lblUsuario);
            flowLayoutPanelUsuario.Controls.Add(lblTipoUsuarioStatic);
            flowLayoutPanelUsuario.Controls.Add(lblTipoUsuario);
            flowLayoutPanelUsuario.Location = new Point(0, 0);
            flowLayoutPanelUsuario.Margin = new Padding(0);
            flowLayoutPanelUsuario.Name = "flowLayoutPanelUsuario";
            flowLayoutPanelUsuario.Size = new Size(161, 71);
            flowLayoutPanelUsuario.TabIndex = 24;
            // 
            // btnBusqueda
            // 
            btnBusqueda.BackColor = Color.Azure;
            btnBusqueda.BackgroundImageLayout = ImageLayout.Zoom;
            btnBusqueda.FlatAppearance.BorderSize = 0;
            btnBusqueda.FlatStyle = FlatStyle.Flat;
            btnBusqueda.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBusqueda.ForeColor = SystemColors.ControlText;
            btnBusqueda.Image = Properties.Resources.searchIcon;
            btnBusqueda.ImageAlign = ContentAlignment.MiddleRight;
            btnBusqueda.Location = new Point(4, 73);
            btnBusqueda.Margin = new Padding(3, 2, 3, 2);
            btnBusqueda.Name = "btnBusqueda";
            btnBusqueda.RightToLeft = RightToLeft.No;
            btnBusqueda.Size = new Size(216, 37);
            btnBusqueda.TabIndex = 25;
            btnBusqueda.Text = "Búsqueda";
            btnBusqueda.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBusqueda.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.menuForm;
            pictureBox2.Location = new Point(288, 51);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(249, 329);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // lblMenuForm
            // 
            lblMenuForm.AutoSize = true;
            lblMenuForm.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMenuForm.Location = new Point(288, 7);
            lblMenuForm.Name = "lblMenuForm";
            lblMenuForm.Size = new Size(249, 30);
            lblMenuForm.TabIndex = 25;
            lblMenuForm.Text = "SISTEMA DE TIENDA";
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(603, 380);
            Controls.Add(lblMenuForm);
            Controls.Add(pictureBox2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnCerrarSesion);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "FrmMenu";
            Text = "Menu";
            contextMenuRegistrar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanelUsuario.ResumeLayout(false);
            flowLayoutPanelUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Button btnCerrarSesion;
        public Label lblTipoUsuario;
        public Button btnRegistrar;
        private Label lblTipoUsuarioStatic;
        private PictureBox pictureBox1;
        private Label lblUsuarioStatic;
        public Label lblUsuario;
        private FlowLayoutPanel flowLayoutPanel1;
        public Button btnBusqueda;
        public ContextMenuStrip contextMenuRegistrar;
        public ToolStripMenuItem toolStripRegistrarCategoria;
        public ToolStripMenuItem toolStripRegistrarProductos;
        public FlowLayoutPanel flowLayoutPanelUsuario;
        private PictureBox pictureBox2;
        private Label lblMenuForm;
    }
}