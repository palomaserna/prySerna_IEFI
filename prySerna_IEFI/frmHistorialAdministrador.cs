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
    public partial class frmHistorialAdministrador : Form
    {
        public frmHistorialAdministrador()
        {
            InitializeComponent();
        }

        private void frmHistorialAdministrador_Load(object sender, EventArgs e)
        {
            clsConexión BD = new clsConexión();
            BD.CargarTarea(dgvTareas);
            
            using (SqlConnection conexion = new SqlConnection(BD.cadenaConexion))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("SELECT Id, Nombre FROM TareasTipo", conexion);
                
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                DataRow filaTodos = dt.NewRow();
                filaTodos["Id"] = 0;
                filaTodos["Nombre"] = "Todos";
                dt.Rows.InsertAt(filaTodos, 0);

                cmbTarea.DataSource = dt;
                cmbTarea.DisplayMember = "Nombre";
                cmbTarea.ValueMember = "Id";
            }
            using (SqlConnection conexion = new SqlConnection(BD.cadenaConexion))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("SELECT Id, Nombre FROM Lugar", conexion);

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                DataRow filaTodos = dt.NewRow();
                filaTodos["Id"] = 0;
                filaTodos["Nombre"] = "Todos";
                dt.Rows.InsertAt(filaTodos, 0);
               
                cmbLugar.DataSource = dt;
                cmbLugar.DisplayMember = "Nombre";
                cmbLugar.ValueMember = "Id";
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexión BD = new clsConexión();

                string query = @"
                 SELECT 
                 T.Fecha,
                 L.Nombre AS Lugar,
                 TA.Nombre AS Tarea,
                 T.Comentario,
                 T.Insumo,
                 T.Estudio,
                 T.Vacaciones,
                 T.Enfermedad,
                 T.Salario,
                 T.Recibo,
                 U.Usuario AS Usuario
                 FROM Tareas T
                 JOIN Lugar L ON T.LugarId = L.Id
                 JOIN TareasTipo TA ON T.TareaId = TA.Id
                 JOIN Usuarios U ON T.IdUsuario = U.IdUsuario
                    WHERE 1 = 1";


                using (SqlConnection conexion = new SqlConnection(BD.cadenaConexion))
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = conexion;

                    if (nmCodigo.Value > 0)
                    {
                        query += " AND T.IdUsuario = @IdUsuario";
                        comando.Parameters.AddWithValue("@IdUsuario", Convert.ToInt32(nmCodigo.Value));
                    }

                    if (!string.IsNullOrWhiteSpace(txtUsuario.Text))
                    {
                        query += " AND U.Usuario LIKE @NombreUsuario";
                        comando.Parameters.AddWithValue("@NombreUsuario", "%" + txtUsuario.Text + "%");
                    }

                    if (cmbTarea.SelectedIndex > 0 && cmbTarea.SelectedValue != null)
                    {
                        query += " AND T.TareaId = @TareaId";
                        comando.Parameters.AddWithValue("@TareaId", cmbTarea.SelectedValue);
                    }

                    if (cmbLugar.SelectedIndex > 0 && cmbLugar.SelectedValue != null)
                    {
                        query += " AND T.LugarId = @LugarId";
                        comando.Parameters.AddWithValue("@LugarId", cmbLugar.SelectedValue);
                    }

                    if (dtFecha.ShowCheckBox && dtFecha.Checked)
                    {
                        DateTime fechaInicio = dtFecha.Value.Date;
                        DateTime fechaFin = fechaInicio.AddDays(1);

                        query += " AND T.Fecha >= @FechaInicio AND T.Fecha < @FechaFin";
                        comando.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                        comando.Parameters.AddWithValue("@FechaFin", fechaFin);
                    }

                    comando.CommandText = query;

                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvTareas.DataSource = dt;
                }

            }
            catch (Exception ex) 
            {
                MessageBox.Show($"No se pudo buscar la tarea" + ex.Message);
            }


        }
    }
    
}
