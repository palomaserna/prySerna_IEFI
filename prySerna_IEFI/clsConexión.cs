using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySerna_IEFI
{
    public class clsConexión
    {
      
        public string cadenaConexion;
        public clsConexión()
        {
            cadenaConexion = "Server=localhost;Database=TrabajoIEFI;Trusted_Connection=True;";
        }

        public bool Iniciar(clsInicioSesión Iniciar)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string query = " SELECT COUNT (*) FROM Usuarios WHERE Usuario = @Usuario AND Contraseña = @Contraseña";

                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@Usuario", Iniciar.Usuario);
                    comando.Parameters.AddWithValue("@Contraseña", Iniciar.Contraseña);

                    int resultado = (int)comando.ExecuteScalar();
                    return resultado > 0;
                }

            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public void AgregarUsuario(clsInicioSesión Usuario)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    string query = "INSERT INTO Usuarios (Usuario, Contraseña)" + "VALUES(@Usuario, @Contraseña)";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@Usuario", Usuario.Usuario);
                    comando.Parameters.AddWithValue("@Contraseña", Usuario.Contraseña);
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el usuario: " + ex.Message);
            }
        }
    }
}
