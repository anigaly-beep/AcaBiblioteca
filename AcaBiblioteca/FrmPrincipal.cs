using AcaBiblioteca.Datos;

namespace AcaBiblioteca
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            Conexion conexion = new Conexion();
            try
            {
                using (var conn = conexion.ObtenerConexion())
                {
                    conn.Open();
                    MessageBox.Show("Conexión exitosa a la base de datos.",
                        "AcaBiblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message,
                     "AcaBiblioteca",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
            }

            AbrirFormulario(new FrmInicio());
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void AbrirFormulario(Form formulario)
        {
            pnlContenido.Controls.Clear();
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            pnlContenido.Controls.Add(formulario);
            formulario.Show();

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmInicio());
        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmLibros());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmUsuarios());
        }

        private void btnAutores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmAutores());
        }

        private void btnEditoriales_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmEditoriales());
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmPrestamos());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmReportes());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAcercade_Click(object sender, EventArgs e)
        {
            string mensaje =
                   "BIBLIOTECA INTERACTIVA\n\n" +
                   "Sistema de gestion bibliotecaria disenado " +
                   "para facilitar la administracion y " +
                   "organizacion de los recursos de una biblioteca.\n\n" +

                   "FUNCIONALIDADES:\n" +
                   "- Gestion de libros.\n" +
                   "- Registro de usuarios.\n" +
                   "- Administracion de autores y editoriales.\n" +
                   "- Control de prestamos.\n" +
                   "- Generacion de reportes.\n\n" +

                   "DESARROLLO:\n" +
                   "Aplicacion desarrollada en C# mediante " +
                   "Windows Forms y SQL Server.\n\n" +

                   "VERSION 1.0\n\n" +
                   "Gracias por utilizar Biblioteca Interactiva.";

            MessageBox.Show(
                mensaje,
                "Acerca de...",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
