using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace Login_WinForm.CapaLogica
{
    public class Conexion
    {
        private string cadenaConexion = @"Server=MAGALI;Database=LoginDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            return conexion;
        }
    }
}

