namespace AcaBiblioteca
{
    partial class FrmInicio
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
            panel1 = new Panel();
            lblSubtitulo = new Label();
            lblTitulo = new Label();
            pnlBajo = new Panel();
            lblBajo2 = new Label();
            lblBajo = new Label();
            pbInicio = new PictureBox();
            panel1.SuspendLayout();
            pnlBajo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbInicio).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(lblSubtitulo);
            panel1.Controls.Add(lblTitulo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(851, 103);
            panel1.TabIndex = 0;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = SystemColors.ActiveCaption;
            lblSubtitulo.Location = new Point(263, 66);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(305, 21);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "GESTIONA   -   CONSULTA   -    EXPLORA";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Stencil", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(217, 19);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(393, 38);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GESTOR DE BIBLIOTECA";
            // 
            // pnlBajo
            // 
            pnlBajo.BackColor = Color.RoyalBlue;
            pnlBajo.Controls.Add(lblBajo2);
            pnlBajo.Controls.Add(lblBajo);
            pnlBajo.Dock = DockStyle.Bottom;
            pnlBajo.Location = new Point(0, 452);
            pnlBajo.Name = "pnlBajo";
            pnlBajo.Size = new Size(851, 129);
            pnlBajo.TabIndex = 1;
            // 
            // lblBajo2
            // 
            lblBajo2.AutoSize = true;
            lblBajo2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBajo2.ForeColor = SystemColors.ActiveCaption;
            lblBajo2.Location = new Point(293, 72);
            lblBajo2.Name = "lblBajo2";
            lblBajo2.Size = new Size(275, 21);
            lblBajo2.TabIndex = 2;
            lblBajo2.Text = "TUS LIBROS Y REPORTES A UN CLIC";
            // 
            // lblBajo
            // 
            lblBajo.AutoSize = true;
            lblBajo.Font = new Font("Stencil", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBajo.ForeColor = Color.White;
            lblBajo.Location = new Point(320, 17);
            lblBajo.Name = "lblBajo";
            lblBajo.Size = new Size(214, 38);
            lblBajo.TabIndex = 2;
            lblBajo.Text = "BIENVENIDO";
            // 
            // pbInicio
            // 
            pbInicio.Dock = DockStyle.Fill;
            pbInicio.Image = Properties.Resources.Biblioteca_holográfica_en_movimiento;
            pbInicio.Location = new Point(0, 103);
            pbInicio.Name = "pbInicio";
            pbInicio.Size = new Size(851, 349);
            pbInicio.SizeMode = PictureBoxSizeMode.StretchImage;
            pbInicio.TabIndex = 2;
            pbInicio.TabStop = false;
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 581);
            Controls.Add(pbInicio);
            Controls.Add(pnlBajo);
            Controls.Add(panel1);
            Name = "FrmInicio";
            Text = "FrmInicio";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlBajo.ResumeLayout(false);
            pnlBajo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbInicio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTitulo;
        private Panel pnlBajo;
        private Label lblSubtitulo;
        private Label lblBajo2;
        private Label lblBajo;
        private PictureBox pbInicio;
    }
}