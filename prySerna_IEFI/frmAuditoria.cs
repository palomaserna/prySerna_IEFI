using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySerna_IEFI
{
    public partial class frmAuditoria : Form
    {
        public frmAuditoria()
        {
            InitializeComponent();
        }

        private void frmAuditoria_Load(object sender, EventArgs e)
        {
            clsConexión BD = new clsConexión();
            BD.CargarUsuarios(dgvAuditoria);
        }





        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexión BD = new clsConexión();

                string query = @"
              SELECT 
              U.IdUsuario,
              U.Usuario,
              U.Contraseña,
              U.Rol,
              U.FechaCreacion,
              U.UltimaConexion,
              U.TiempoUltimaConexion,
              U.TiempoTotal,
              U.Estado
              FROM Usuarios U
              WHERE 1 = 1";

                using (SqlConnection conexion = new SqlConnection(BD.cadenaConexion))
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = conexion;

                    if (nmCodigo.Value > 0)
                    {
                        query += " AND U.IdUsuario = @IdUsuario";
                        comando.Parameters.AddWithValue("@IdUsuario", Convert.ToInt32(nmCodigo.Value));
                    }

                    if (!string.IsNullOrWhiteSpace(txtUsuario.Text))
                    {
                        query += " AND U.Usuario LIKE @NombreUsuario";
                        comando.Parameters.AddWithValue("@NombreUsuario", "%" + txtUsuario.Text + "%");
                    }

                    comando.CommandText = query;
                    conexion.Open();
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dgvAuditoria.DataSource = dt;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el usuario: " + ex.Message);
            }

            }
    }
}
