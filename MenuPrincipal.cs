using Login_WinForm.CapaDeDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Login_WinForm
{
    public partial class MenuPrincipal : Form
    {
        int idUsuarioSeleccionado = 0; // Guarda el ID del usuario seleccionado
        bool esEdicion = false; // Variable para saber si estamos editando o agregando

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        // Método para cargar los usuarios en el DataGridView
        private void CargarUsuarios()
        {
            UsuarioDAL dal = new UsuarioDAL();

            dataGridView1.DataSource = dal.ListarUsuarios();

            // Limpia y vuelve a cargar para refrescar los datos
            dataGridView1.DataSource = null; 
            dataGridView1.DataSource = dal.ListarUsuarios();

            // Oculta la columna de contraseña
            if (dataGridView1.Columns.Count > 0)
            {
                if (dataGridView1.Columns.Contains("Contrasena"))
                {
                    dataGridView1.Columns["Contrasena"].Visible = false;
                }
            }
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            CargarUsuarios();

            // Oculta la solapa de tabcontrol llamada "Formulario"
            Formulario.Appearance = TabAppearance.FlatButtons;
            Formulario.ItemSize = new Size(0, 1);
            Formulario.SizeMode = TabSizeMode.Fixed;

            // Configura dataGridView
            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.MultiSelect = false;

            dataGridView1.ReadOnly = true;

        }
      
        // BOTÓN DE ELIMINAR UN USUARIO
        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtiene el ID del usuario seleccionado
                int idUsuario = Convert.ToInt32(
                    dataGridView1.SelectedRows[0].Cells["Id"].Value
                );

                // Muestra la ventana de confirmación
                DialogResult resultado = MessageBox.Show(
                    "¿Está seguro que desea eliminar este usuario?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (resultado == DialogResult.Yes)
                {
                    UsuarioDAL dal = new UsuarioDAL();

                    bool eliminado = dal.EliminarUsuario(idUsuario);

                    // Verifica si se eliminó correctamente
                    if (eliminado)
                    {
                        MessageBox.Show("Usuario eliminado correctamente");

                        CargarUsuarios();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el usuario");
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un usuario para eliminar");
            }
        }

        // BOTÓN DE EDITAR UN USUARIO
        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            // Verifica si hay una fila seleccionada
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Activa el modo edición
                esEdicion = true;

                idUsuarioSeleccionado = Convert.ToInt32(
                    dataGridView1.SelectedRows[0].Cells["Id"].Value
                );

                // Carga los datos existentes en el TextBox
                txtUsuarios.Text = dataGridView1.SelectedRows[0].Cells["Usuario"].Value.ToString();
                txtContraseñas.Text = dataGridView1.SelectedRows[0].Cells["Contrasena"].Value.ToString();
                txtConfirmar.Text = dataGridView1.SelectedRows[0].Cells["Contrasena"].Value.ToString();

                lblUsuario.Text = "Usuario";
                lblTitulo.Text = "Editar un usuario";

                Formulario.SelectedTab = tabFormulario;
            }
            else
            {
                MessageBox.Show("Seleccione un usuario");
            }
        }

        // BOTÓN DE AGREGAR UN USUARIO
        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            // Desactiva el modo edición
            esEdicion = false;

            lblUsuario.Text = "Nuevo usuario: ";

            txtUsuarios.Clear();
            txtContraseñas.Clear();
            txtConfirmar.Clear();

            // Va a la pestaña del formulario
            Formulario.SelectedTab = tabFormulario;
        }

        // BOTÓN DE GUARDAR CAMBIOS
        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            UsuarioDAL dal = new UsuarioDAL();

            // Obtiene los datos ingreados
            string usuario = txtUsuarios.Text.Trim();
            string contrasena = txtContraseñas.Text.Trim();
            string confirmar = txtConfirmar.Text.Trim();

            // Validaciones
            if (usuario.Length == 0)
            {
                MessageBox.Show("Ingrese el usuario");
                return;
            }

            if (contrasena.Length == 0)
            {
                MessageBox.Show("Ingrese la contraseña");
                return;
            }

            if (confirmar.Length == 0)
            {
                MessageBox.Show("Confirme la contraseña");
                return;
            }

            if (contrasena != confirmar)
            {
                MessageBox.Show("Las contraseñas no coinciden");
                return;
            }

            bool ok = false;

            // Verifica si se edita o se agrega
            if (esEdicion)
            {
                ok = dal.ModificarUsuario(
                    idUsuarioSeleccionado,
                    usuario,
                    contrasena
                );

                if (ok)
                {
                    MessageBox.Show("Usuario modificado correctamente");
                }
            }
            else
            {
                if (dal.ExisteUsuario(usuario))
                {
                    MessageBox.Show("El usuario ya existe");
                    return;
                }

                ok = dal.InsertarUsuario(usuario, contrasena);

                if (ok)
                {
                    MessageBox.Show("Usuario agregado correctamente");
                }
            }

            // Actualiza la tabla y vuelve al listado
            if (ok)
            {
                CargarUsuarios();
                Formulario.SelectedTab = tabUsuarios;
            }
        }

        // Botón de cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Formulario.SelectedTab = tabUsuarios;
        }

        // Buscador de usuarios
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            UsuarioDAL dal = new UsuarioDAL();

            dataGridView1.DataSource =
                dal.BuscarUsuarios(txtBuscar.Text.Trim());
        }

        private void tabUsuarios_Click(object sender, EventArgs e)
        {

        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
