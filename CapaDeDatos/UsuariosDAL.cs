using Login_WinForm.CapaLogica;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Login_WinForm.CapaDeDatos
{
    // Clase encargada de realizar operaciones con la tabla Usuarios
    public class UsuarioDAL
    {
        private Conexion conexionDB = new Conexion();

        // Método para insertar un nuevo usuario
        public bool InsertarUsuario(string usuario, string contrasena)
        {
            bool insertado = false;

            try
            {
                using (SqlConnection conexion = conexionDB.ObtenerConexion())
                {
                    string query = "INSERT INTO Usuarios (Usuario, Contrasena) VALUES (@Usuario, @Contrasena)";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@Usuario", usuario);
                        comando.Parameters.AddWithValue("@Contrasena", contrasena);

                        conexion.Open();

                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            insertado = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el usuario: " + ex.Message);
            }

            return insertado;
        }

        // Método para validar el LOGIN
        public bool ValidarUsuario(string usuario, string contrasena)
        {
            bool existe = false;

            try
            {
                using (SqlConnection conexion = conexionDB.ObtenerConexion())
                {
                    string query = "SELECT COUNT(*) FROM Usuarios WHERE Usuario = @Usuario AND Contrasena = @Contrasena";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@Usuario", usuario);
                        comando.Parameters.AddWithValue("@Contrasena", contrasena);

                        conexion.Open();

                        int cantidad = (int)comando.ExecuteScalar();

                        if (cantidad > 0)
                        {
                            existe = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar el usuario: " + ex.Message);
            }

            return existe;
        }

        // Método para listar usuarios
        public DataTable ListarUsuarios()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conexion = conexionDB.ObtenerConexion())
            {
                string query = "SELECT Id, Usuario, Contrasena FROM Usuarios";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);

                adapter.Fill(tabla);
            }

            return tabla;
        }

        // Método para verificar si un usuario ya existe
        public bool ExisteUsuario(string usuario)
        {
            bool existe = false;

            using (SqlConnection conexion = conexionDB.ObtenerConexion())
            {
                string query = "SELECT COUNT(*) FROM Usuarios WHERE Usuario = @Usuario";

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@Usuario", usuario);
                    conexion.Open();

                    int count = (int)cmd.ExecuteScalar();
                    existe = count > 0;
                }
            }

            return existe;
        }

        // Método para eliminar usuarios
        public bool EliminarUsuario(int Id)
        {
            bool eliminado = false;

            try
            {
                using (SqlConnection conexion = conexionDB.ObtenerConexion())
                {
                    string query = "DELETE FROM Usuarios WHERE Id = @Id";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@Id", Id);
                        conexion.Open();

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            eliminado = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el usuario: " + ex.Message);
            }

            return eliminado;
        }

        // Método para modificar usuarios
        public bool ModificarUsuario(int id, string usuario, string contrasena)
        {
            bool modificado = false;

            try
            {
                using (SqlConnection conexion = conexionDB.ObtenerConexion())
                {
                    string query = "UPDATE Usuarios SET Usuario = @Usuario, Contrasena = @Contrasena WHERE Id = @Id";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@Id", id);
                        comando.Parameters.AddWithValue("@Usuario", usuario);
                        comando.Parameters.AddWithValue("@Contrasena", contrasena);

                        conexion.Open();

                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            modificado = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar usuario: " + ex.Message);
            }

            return modificado;
        }

        // Método para buscar los usuarios en la barra
        public DataTable BuscarUsuarios(string texto)
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conexion = conexionDB.ObtenerConexion())
            {
                string query = "SELECT Id, Usuario, Contrasena " + "FROM Usuarios " + "WHERE Usuario LIKE @Busqueda";

                SqlDataAdapter adapter =
                    new SqlDataAdapter(query, conexion);

                adapter.SelectCommand.Parameters.AddWithValue("@Busqueda","%" + texto + "%");

                adapter.Fill(tabla);
            }

            return tabla;
        }
    }
}