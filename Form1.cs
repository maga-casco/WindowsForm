using Login_WinForm.CapaDeDatos;
using Login_WinForm.CapaLogica;

namespace Login_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Oculta los caracteres de la contraseña de base
            txtContraseña.UseSystemPasswordChar = true;
        }

        // BOTÓN PARA INICIAR SESIÓN
        private void btnIniciarSesion_Click_1(object sender, EventArgs e)
        {
            UsuarioDAL dal = new UsuarioDAL();

            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();

            bool existe = dal.ValidarUsuario(usuario, contraseña);

            if (txtUsuario.Text.Length == 0)
            {
                MessageBox.Show("Por favor, ingrese el usuario: ");
            }
            else if (txtContraseña.Text.Length == 0)
            {
                MessageBox.Show("Por favor, ingrese la contraseña: ");
            }
            else if (existe)
            {
                MessageBox.Show("Inicio de sesión exitoso.");

                MenuPrincipal menu = new MenuPrincipal();
                this.Hide();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos. ");
            }
        }

        // Muestra u oculta la contraseña
        private void chkMostrarCaracteres_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMostrarCaracteres.Checked == true)
            {
                txtContraseña.UseSystemPasswordChar = false;
            }
            else
            {
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

    }
}
