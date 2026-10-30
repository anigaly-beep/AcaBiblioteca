namespace AcaBiblioteca
{
    partial class FrmPrincipal
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
            pnlMenu = new Panel();
            btnSalir = new FontAwesome.Sharp.IconButton();
            btnReportes = new FontAwesome.Sharp.IconButton();
            btnPrestamos = new FontAwesome.Sharp.IconButton();
            btnEditoriales = new FontAwesome.Sharp.IconButton();
            btnAutores = new FontAwesome.Sharp.IconButton();
            btnUsuarios = new FontAwesome.Sharp.IconButton();
            btnLibros = new FontAwesome.Sharp.IconButton();
            btnInicio = new FontAwesome.Sharp.IconButton();
            pnlLogo = new Panel();
            picLogo = new PictureBox();
            lblSubtitulo = new Label();
            lblTitulo = new Label();
            pnlSuperior = new Panel();
            pnlEstado = new Panel();
            pnlContenido = new Panel();
            pnlMenu.SuspendLayout();
            pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = SystemColors.GradientActiveCaption;
            pnlMenu.Controls.Add(btnSalir);
            pnlMenu.Controls.Add(btnReportes);
            pnlMenu.Controls.Add(btnPrestamos);
            pnlMenu.Controls.Add(btnEditoriales);
            pnlMenu.Controls.Add(btnAutores);
            pnlMenu.Controls.Add(btnUsuarios);
            pnlMenu.Controls.Add(btnLibros);
            pnlMenu.Controls.Add(btnInicio);
            pnlMenu.Controls.Add(pnlLogo);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(220, 509);
            pnlMenu.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.Dock = DockStyle.Top;
            btnSalir.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.IconChar = FontAwesome.Sharp.IconChar.Eject;
            btnSalir.IconColor = Color.Black;
            btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalir.IconSize = 40;
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(0, 367);
            btnSalir.Name = "btnSalir";
            btnSalir.RightToLeft = RightToLeft.No;
            btnSalir.Size = new Size(220, 41);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnReportes
            // 
            btnReportes.Dock = DockStyle.Top;
            btnReportes.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReportes.IconChar = FontAwesome.Sharp.IconChar.CheckToSlot;
            btnReportes.IconColor = Color.Black;
            btnReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReportes.IconSize = 40;
            btnReportes.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportes.Location = new Point(0, 326);
            btnReportes.Name = "btnReportes";
            btnReportes.RightToLeft = RightToLeft.No;
            btnReportes.Size = new Size(220, 41);
            btnReportes.TabIndex = 7;
            btnReportes.Text = "REPORTES";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnPrestamos
            // 
            btnPrestamos.Dock = DockStyle.Top;
            btnPrestamos.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrestamos.IconChar = FontAwesome.Sharp.IconChar.Handshake;
            btnPrestamos.IconColor = Color.Black;
            btnPrestamos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPrestamos.IconSize = 40;
            btnPrestamos.ImageAlign = ContentAlignment.MiddleLeft;
            btnPrestamos.Location = new Point(0, 285);
            btnPrestamos.Name = "btnPrestamos";
            btnPrestamos.RightToLeft = RightToLeft.No;
            btnPrestamos.Size = new Size(220, 41);
            btnPrestamos.TabIndex = 6;
            btnPrestamos.Text = "PRESTAMOS";
            btnPrestamos.UseVisualStyleBackColor = true;
            btnPrestamos.Click += btnPrestamos_Click;
            // 
            // btnEditoriales
            // 
            btnEditoriales.Dock = DockStyle.Top;
            btnEditoriales.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditoriales.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            btnEditoriales.IconColor = Color.Black;
            btnEditoriales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditoriales.IconSize = 40;
            btnEditoriales.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditoriales.Location = new Point(0, 244);
            btnEditoriales.Name = "btnEditoriales";
            btnEditoriales.RightToLeft = RightToLeft.No;
            btnEditoriales.Size = new Size(220, 41);
            btnEditoriales.TabIndex = 5;
            btnEditoriales.Text = "EDITORIALES";
            btnEditoriales.UseVisualStyleBackColor = true;
            btnEditoriales.Click += btnEditoriales_Click;
            // 
            // btnAutores
            // 
            btnAutores.Dock = DockStyle.Top;
            btnAutores.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAutores.IconChar = FontAwesome.Sharp.IconChar.Pen;
            btnAutores.IconColor = Color.Black;
            btnAutores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAutores.IconSize = 40;
            btnAutores.ImageAlign = ContentAlignment.MiddleLeft;
            btnAutores.Location = new Point(0, 203);
            btnAutores.Name = "btnAutores";
            btnAutores.RightToLeft = RightToLeft.No;
            btnAutores.Size = new Size(220, 41);
            btnAutores.TabIndex = 4;
            btnAutores.Text = "AUTORES";
            btnAutores.UseVisualStyleBackColor = true;
            btnAutores.Click += btnAutores_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Dock = DockStyle.Top;
            btnUsuarios.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            btnUsuarios.IconColor = Color.Black;
            btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUsuarios.IconSize = 40;
            btnUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.Location = new Point(0, 162);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.RightToLeft = RightToLeft.No;
            btnUsuarios.Size = new Size(220, 41);
            btnUsuarios.TabIndex = 3;
            btnUsuarios.Text = "USUARIOS";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnLibros
            // 
            btnLibros.Dock = DockStyle.Top;
            btnLibros.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLibros.IconChar = FontAwesome.Sharp.IconChar.Book;
            btnLibros.IconColor = Color.Black;
            btnLibros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLibros.IconSize = 40;
            btnLibros.ImageAlign = ContentAlignment.MiddleLeft;
            btnLibros.Location = new Point(0, 121);
            btnLibros.Name = "btnLibros";
            btnLibros.RightToLeft = RightToLeft.No;
            btnLibros.Size = new Size(220, 41);
            btnLibros.TabIndex = 2;
            btnLibros.Text = "LIBROS";
            btnLibros.UseVisualStyleBackColor = true;
            btnLibros.Click += btnLibros_Click;
            // 
            // btnInicio
            // 
            btnInicio.Dock = DockStyle.Top;
            btnInicio.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInicio.IconChar = FontAwesome.Sharp.IconChar.House;
            btnInicio.IconColor = Color.Black;
            btnInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnInicio.IconSize = 40;
            btnInicio.ImageAlign = ContentAlignment.MiddleLeft;
            btnInicio.Location = new Point(0, 80);
            btnInicio.Name = "btnInicio";
            btnInicio.RightToLeft = RightToLeft.No;
            btnInicio.Size = new Size(220, 41);
            btnInicio.TabIndex = 1;
            btnInicio.Text = "INICIO";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // pnlLogo
            // 
            pnlLogo.BackColor = Color.PaleTurquoise;
            pnlLogo.Controls.Add(picLogo);
            pnlLogo.Controls.Add(lblSubtitulo);
            pnlLogo.Controls.Add(lblTitulo);
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(220, 80);
            pnlLogo.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.BackgroundImageLayout = ImageLayout.Zoom;
            picLogo.Image = Properties.Resources.IconoBiblioteca;
            picLogo.Location = new Point(3, 3);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(74, 74);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 2;
            picLogo.TabStop = false;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Location = new Point(83, 45);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(128, 15);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "GESTIONA TUS LIBROS";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Stencil", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(78, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(139, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "BIBLIOTECA";
            // 
            // pnlSuperior
            // 
            pnlSuperior.BackColor = SystemColors.ControlLight;
            pnlSuperior.Dock = DockStyle.Top;
            pnlSuperior.Location = new Point(220, 0);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(625, 80);
            pnlSuperior.TabIndex = 1;
            // 
            // pnlEstado
            // 
            pnlEstado.BackColor = SystemColors.ControlLight;
            pnlEstado.Dock = DockStyle.Bottom;
            pnlEstado.Location = new Point(220, 459);
            pnlEstado.Name = "pnlEstado";
            pnlEstado.Size = new Size(625, 50);
            pnlEstado.TabIndex = 2;
            // 
            // pnlContenido
            // 
            pnlContenido.Dock = DockStyle.Fill;
            pnlContenido.Location = new Point(220, 80);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(625, 379);
            pnlContenido.TabIndex = 3;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 509);
            Controls.Add(pnlContenido);
            Controls.Add(pnlEstado);
            Controls.Add(pnlSuperior);
            Controls.Add(pnlMenu);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BIBLIOTECA INTERACTIVA";
            WindowState = FormWindowState.Maximized;
            Load += FrmPrincipal_Load;
            pnlMenu.ResumeLayout(false);
            pnlLogo.ResumeLayout(false);
            pnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private Panel pnlSuperior;
        private Panel pnlEstado;
        private Panel pnlContenido;
        private Panel pnlLogo;
        private Label lblTitulo;
        private PictureBox picLogo;
        private Label lblSubtitulo;
        private FontAwesome.Sharp.IconButton btnInicio;
        private FontAwesome.Sharp.IconButton btnLibros;
        private FontAwesome.Sharp.IconButton btnAutores;
        private FontAwesome.Sharp.IconButton btnUsuarios;
        private FontAwesome.Sharp.IconButton btnReportes;
        private FontAwesome.Sharp.IconButton btnPrestamos;
        private FontAwesome.Sharp.IconButton btnEditoriales;
        private FontAwesome.Sharp.IconButton btnSalir;
    }
}
