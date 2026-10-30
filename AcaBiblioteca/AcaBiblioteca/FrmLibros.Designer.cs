namespace AcaBiblioteca
{
    partial class FrmLibros
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
            pnlTitulo = new Panel();
            lblTitulo = new Label();
            pnlBusqueda = new Panel();
            btnBuscarISBN = new Button();
            txtBuscarISBN = new TextBox();
            lblBuscar = new Label();
            pnlDatos = new Panel();
            cmbEditorial = new ComboBox();
            cmbAutor = new ComboBox();
            txtExistencias = new TextBox();
            txtAnio = new TextBox();
            txtCategoria = new TextBox();
            txtTitulo = new TextBox();
            txtISBN = new TextBox();
            lblExistencias = new Label();
            lblAno = new Label();
            lblCategoria = new Label();
            lblEditorial = new Label();
            lblAutor = new Label();
            lblTituloLib = new Label();
            lblISBN = new Label();
            pnlBotones = new Panel();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnNuevo = new FontAwesome.Sharp.IconButton();
            iconSplitButton1 = new FontAwesome.Sharp.IconSplitButton();
            dgvLibros = new DataGridView();
            pnlTitulo.SuspendLayout();
            pnlBusqueda.SuspendLayout();
            pnlDatos.SuspendLayout();
            pnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = SystemColors.MenuHighlight;
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(1350, 60);
            pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(279, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(252, 32);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "GESTION DE LIBROS";
            // 
            // pnlBusqueda
            // 
            pnlBusqueda.BackColor = Color.WhiteSmoke;
            pnlBusqueda.Controls.Add(btnBuscarISBN);
            pnlBusqueda.Controls.Add(txtBuscarISBN);
            pnlBusqueda.Controls.Add(lblBuscar);
            pnlBusqueda.Dock = DockStyle.Top;
            pnlBusqueda.Location = new Point(0, 60);
            pnlBusqueda.Name = "pnlBusqueda";
            pnlBusqueda.Size = new Size(1350, 55);
            pnlBusqueda.TabIndex = 1;
            // 
            // btnBuscarISBN
            // 
            btnBuscarISBN.Location = new Point(611, 13);
            btnBuscarISBN.Name = "btnBuscarISBN";
            btnBuscarISBN.Size = new Size(131, 23);
            btnBuscarISBN.TabIndex = 3;
            btnBuscarISBN.Text = "Buscar";
            btnBuscarISBN.UseVisualStyleBackColor = true;
            // 
            // txtBuscarISBN
            // 
            txtBuscarISBN.Location = new Point(328, 13);
            txtBuscarISBN.Name = "txtBuscarISBN";
            txtBuscarISBN.Size = new Size(219, 23);
            txtBuscarISBN.TabIndex = 2;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuscar.Location = new Point(230, 15);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(46, 21);
            lblBuscar.TabIndex = 2;
            lblBuscar.Text = "ISBN";
            // 
            // pnlDatos
            // 
            pnlDatos.Controls.Add(cmbEditorial);
            pnlDatos.Controls.Add(cmbAutor);
            pnlDatos.Controls.Add(txtExistencias);
            pnlDatos.Controls.Add(txtAnio);
            pnlDatos.Controls.Add(txtCategoria);
            pnlDatos.Controls.Add(txtTitulo);
            pnlDatos.Controls.Add(txtISBN);
            pnlDatos.Controls.Add(lblExistencias);
            pnlDatos.Controls.Add(lblAno);
            pnlDatos.Controls.Add(lblCategoria);
            pnlDatos.Controls.Add(lblEditorial);
            pnlDatos.Controls.Add(lblAutor);
            pnlDatos.Controls.Add(lblTituloLib);
            pnlDatos.Controls.Add(lblISBN);
            pnlDatos.Location = new Point(0, 115);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new Size(1350, 295);
            pnlDatos.TabIndex = 2;
            // 
            // cmbEditorial
            // 
            cmbEditorial.FormattingEnabled = true;
            cmbEditorial.Location = new Point(523, 139);
            cmbEditorial.Name = "cmbEditorial";
            cmbEditorial.Size = new Size(219, 23);
            cmbEditorial.TabIndex = 18;
            // 
            // cmbAutor
            // 
            cmbAutor.FormattingEnabled = true;
            cmbAutor.Location = new Point(523, 109);
            cmbAutor.Name = "cmbAutor";
            cmbAutor.Size = new Size(219, 23);
            cmbAutor.TabIndex = 17;
            // 
            // txtExistencias
            // 
            txtExistencias.Location = new Point(523, 242);
            txtExistencias.Name = "txtExistencias";
            txtExistencias.Size = new Size(219, 23);
            txtExistencias.TabIndex = 16;
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(523, 205);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(219, 23);
            txtAnio.TabIndex = 15;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(523, 176);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(219, 23);
            txtCategoria.TabIndex = 14;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(523, 67);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(219, 23);
            txtTitulo.TabIndex = 11;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(523, 29);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(219, 23);
            txtISBN.TabIndex = 4;
            // 
            // lblExistencias
            // 
            lblExistencias.AutoSize = true;
            lblExistencias.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExistencias.Location = new Point(370, 244);
            lblExistencias.Name = "lblExistencias";
            lblExistencias.Size = new Size(110, 21);
            lblExistencias.TabIndex = 10;
            lblExistencias.Text = "EXISTENCIAS:";
            // 
            // lblAno
            // 
            lblAno.AutoSize = true;
            lblAno.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAno.Location = new Point(368, 207);
            lblAno.Name = "lblAno";
            lblAno.Size = new Size(49, 21);
            lblAno.TabIndex = 9;
            lblAno.Text = "AÑO:";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoria.Location = new Point(368, 172);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(100, 21);
            lblCategoria.TabIndex = 8;
            lblCategoria.Text = "CATEGORIA:";
            // 
            // lblEditorial
            // 
            lblEditorial.AutoSize = true;
            lblEditorial.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditorial.Location = new Point(370, 137);
            lblEditorial.Name = "lblEditorial";
            lblEditorial.Size = new Size(92, 21);
            lblEditorial.TabIndex = 7;
            lblEditorial.Text = "EDITORIAL:";
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAutor.Location = new Point(370, 100);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(66, 21);
            lblAutor.TabIndex = 6;
            lblAutor.Text = "AUTOR:";
            // 
            // lblTituloLib
            // 
            lblTituloLib.AutoSize = true;
            lblTituloLib.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloLib.Location = new Point(368, 69);
            lblTituloLib.Name = "lblTituloLib";
            lblTituloLib.Size = new Size(68, 21);
            lblTituloLib.TabIndex = 5;
            lblTituloLib.Text = "TITULO:";
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblISBN.Location = new Point(370, 31);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(50, 21);
            lblISBN.TabIndex = 4;
            lblISBN.Text = "ISBN:";
            // 
            // pnlBotones
            // 
            pnlBotones.Controls.Add(btnCancelar);
            pnlBotones.Controls.Add(btnEliminar);
            pnlBotones.Controls.Add(btnEditar);
            pnlBotones.Controls.Add(btnGuardar);
            pnlBotones.Controls.Add(btnNuevo);
            pnlBotones.Location = new Point(136, 416);
            pnlBotones.Name = "pnlBotones";
            pnlBotones.Size = new Size(742, 64);
            pnlBotones.TabIndex = 3;
            // 
            // btnCancelar
            // 
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.X;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.Location = new Point(584, 17);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(140, 40);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.Location = new Point(438, 17);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(140, 40);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            btnEditar.IconColor = Color.Black;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.Location = new Point(292, 17);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(140, 40);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "EDITAR";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.Location = new Point(146, 18);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(140, 40);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.IconChar = FontAwesome.Sharp.IconChar.Ad;
            btnNuevo.IconColor = Color.Black;
            btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevo.Location = new Point(0, 17);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(140, 41);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "NUEVO";
            btnNuevo.TextAlign = ContentAlignment.MiddleRight;
            btnNuevo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // iconSplitButton1
            // 
            iconSplitButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            iconSplitButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconSplitButton1.IconColor = Color.Black;
            iconSplitButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconSplitButton1.IconSize = 48;
            iconSplitButton1.Name = "iconSplitButton1";
            iconSplitButton1.Rotation = 0D;
            iconSplitButton1.Size = new Size(23, 23);
            iconSplitButton1.Text = "iconSplitButton1";
            // 
            // dgvLibros
            // 
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Location = new Point(136, 479);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.Size = new Size(1100, 260);
            dgvLibros.TabIndex = 4;
            // 
            // FrmLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1350, 729);
            Controls.Add(dgvLibros);
            Controls.Add(pnlBotones);
            Controls.Add(pnlDatos);
            Controls.Add(pnlBusqueda);
            Controls.Add(pnlTitulo);
            Name = "FrmLibros";
            Text = "FrmLibros";
            WindowState = FormWindowState.Maximized;
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            pnlBusqueda.ResumeLayout(false);
            pnlBusqueda.PerformLayout();
            pnlDatos.ResumeLayout(false);
            pnlDatos.PerformLayout();
            pnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitulo;
        private Label lblTitulo;
        private Panel pnlBusqueda;
        private Button btnBuscarISBN;
        private TextBox txtBuscarISBN;
        private Label lblBuscar;
        private Panel pnlDatos;
        private Label lblISBN;
        private Label lblAutor;
        private Label lblTituloLib;
        private Label lblEditorial;
        private Label lblExistencias;
        private Label lblAno;
        private Label lblCategoria;
        private TextBox txtAnio;
        private TextBox txtCategoria;
        private TextBox txtTitulo;
        private TextBox txtISBN;
        private TextBox txtExistencias;
        private ComboBox cmbEditorial;
        private ComboBox cmbAutor;
        private Panel pnlBotones;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private FontAwesome.Sharp.IconSplitButton iconSplitButton1;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private DataGridView dgvLibros;
    }
}