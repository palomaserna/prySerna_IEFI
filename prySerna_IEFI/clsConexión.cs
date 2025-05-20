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

        public int Iniciar(clsInicioSesión Iniciar)
        {
            int idUsuario = 0;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    //string query = " SELECT COUNT (*) FROM Usuarios WHERE Usuario = @Usuario AND Contraseña = @Contraseña";
                    string query = "SELECT IdUsuario FROM Usuarios WHERE Usuario = @Usuario AND Contraseña = @Contraseña";

                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@Usuario", Iniciar.Usuario);
                    comando.Parameters.AddWithValue("@Contraseña", Iniciar.Contraseña);

                    object resultado = comando.ExecuteScalar();
                    if(resultado != null)
                    {
                        idUsuario = Convert.ToInt32(resultado);

                        // Actualizar UltimaConexion a ahora
                        string queryU = "UPDATE Usuarios SET UltimaConexion = @UltimaConexion WHERE IdUsuario = @IdUsuario";
                        SqlCommand comandoU = new SqlCommand(queryU, conexion);
                        comandoU.Parameters.AddWithValue("@UltimaConexion", DateTime.Now);
                        comandoU.Parameters.AddWithValue("@IdUsuario", idUsuario);
                        comandoU.ExecuteNonQuery();

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en inicio de sesión: " + ex.Message);
            }
            return idUsuario;

        }
       


        public int AgregarUsuario(clsInicioSesión Usuario)
        {
            int nuevoIdUsuario = 0;
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string query = "INSERT INTO Usuarios (Usuario, Contraseña) VALUES (@Usuario, @Contraseña); SELECT SCOPE_IDENTITY();";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.Parameters.AddWithValue("@Usuario", Usuario.Usuario);
                    comando.Parameters.AddWithValue("@Contraseña", Usuario.Contraseña);

                    object resultado = comando.ExecuteScalar();
                    nuevoIdUsuario = Convert.ToInt32(resultado);

                    // Actualizar UltimaConexion a ahora
                    string queryU = "UPDATE Usuarios SET UltimaConexion = @UltimaConexion WHERE IdUsuario = @IdUsuario";
                    SqlCommand comandoU = new SqlCommand(queryU, conexion);
                    comandoU.Parameters.AddWithValue("@UltimaConexion", DateTime.Now);
                    comandoU.Parameters.AddWithValue("@IdUsuario", nuevoIdUsuario);
                    comandoU.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el usuario: " + ex.Message);
            }

            return nuevoIdUsuario;
        }


























        public void CargarUsuarios(DataGridView dgv)
        {
            try
            {
                string query = "SELECT IdUsuario, Usuario, Contraseña, FechaCreacion, UltimaConexion, TiempoUltimaConexion,TiempoTotal, Estado FROM Usuarios";

                using (SqlConnection conn = new SqlConnection(cadenaConexion))
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataTable tabla = new DataTable();
                    adapter.Fill(tabla);
                    dgv.DataSource = tabla;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }

        }
    }
}
