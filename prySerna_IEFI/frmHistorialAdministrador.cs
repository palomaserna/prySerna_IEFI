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
                cmbLugar.DataSource = dt;
                cmbLugar.DisplayMember = "Nombre";
                cmbLugar.ValueMember = "Id";
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            clsConexión BD = new clsConexión();

            int idUsuario = (int)nmCodigo.Value;
            string usuario = txtUsuario.Text.Trim();
            DateTime fecha = dtFecha.Value.Date;
            int tareaId = cmbTarea.SelectedValue != null ? Convert.ToInt32(cmbTarea.SelectedValue) : 0;
            int lugarId = cmbLugar.SelectedValue != null ? Convert.ToInt32(cmbLugar.SelectedValue) : 0;

            // Muestra los filtros actuales (debug)
           // MessageBox.Show($"IdUsuario: {idUsuario}\nUsuario: {usuario}\nFecha: {fecha.ToShortDateString()}\nTareaId: {tareaId}\nLugarId: {lugarId}");

            DataTable resultado = BD.BuscarTareas(idUsuario, usuario, fecha, tareaId, lugarId);
            dgvTareas.DataSource = resultado;


        }
    }
}
