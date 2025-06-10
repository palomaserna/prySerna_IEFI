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
    public partial class frmRegistrarTareas : Form
    {
        public string RolUsuario { get; set; }
        public string UsuarioN { get; set; }
        public frmRegistrarTareas(string rol, string usuario)
        {
            InitializeComponent();
            RolUsuario = rol;
            UsuarioN = usuario;
        }
       


        private void frmRegistrarTareas_Load(object sender, EventArgs e)
        {
            clsConexión BD = new clsConexión();
            
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
        
         clsUsuario Iniciar = new clsUsuario();
           if (RolUsuario == "Administrador")
            {
                lblAgregarTarea.Visible = true;
                lblAgregarLugar.Visible = true;
            }
            else
            {
                lblAgregarTarea.Visible = false;
                lblAgregarLugar.Visible = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
               
                dgvTareas.Rows.Add(
                    Convert.ToInt32(nmCodigo.Value),
                    txtUsuario.Text,
                    dtFecha.Value.ToShortDateString(),
                    cmbTarea.Text, 
                    cmbLugar.Text   
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se agregó la tarea: {ex.Message}");
            }


        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTareas.Rows.Count == 0)
                {
                    MessageBox.Show("Primero debes agregar los datos al formulario.");
                    return;
                }

                DataGridViewRow fila = dgvTareas.Rows[0];

                clsTarea tarea = new clsTarea();
                clsConexión conexion = new clsConexión();

                tarea.IdUsuario = Convert.ToInt32(fila.Cells[0].Value);
                tarea.Usuario = fila.Cells[1].Value.ToString();
                tarea.Fecha = DateTime.Parse(fila.Cells[2].Value.ToString());

             
                tarea.TareaId = Convert.ToInt32(cmbTarea.SelectedValue);
                tarea.LugarId = Convert.ToInt32(cmbLugar.SelectedValue);

               
                tarea.Insumo = cbInsumo.Checked;
                tarea.Estudio = cbEstudio.Checked;
                tarea.Vacaciones = cbVacaciones.Checked;
                tarea.Enfermedad = cbEnfermedad.Checked;
                tarea.Salario = cbSalario.Checked;
                tarea.Recibo = cbRecibo.Checked;

                
                tarea.Comentario = txtComentario.Text;

                conexion.GrabarTarea(tarea);
                MessageBox.Show("Tarea grabada correctamente.");

                
                dgvTareas.Rows.Clear();
                nmCodigo.Value = 0;
                txtUsuario.Clear();
                cmbLugar.SelectedIndex = -1;
                cmbTarea.SelectedIndex = -1;
                cbInsumo.Checked = false;
                cbEstudio.Checked = false;
                cbVacaciones.Checked = false;
                cbEnfermedad.Checked = false;
                cbSalario.Checked = false;
                cbRecibo.Checked = false;
                txtComentario.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al grabar la tarea: {ex.Message}");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dgvTareas.DataSource = null;
            dgvTareas.Rows.Clear();
            nmCodigo.Value = 0;
            txtUsuario.Clear();
            cmbLugar.SelectedIndex = -1;
            cmbTarea.SelectedIndex = -1;
            cbInsumo.Checked = false;
            cbEstudio.Checked = false;
            cbVacaciones.Checked = false;
            cbEnfermedad.Checked = false;
            cbSalario.Checked = false;
            cbRecibo.Checked = false;
            txtComentario.Clear();





        }

        private void lblAgregarTarea_Click(object sender, EventArgs e)
        {
            frmAgregarTarea v = new frmAgregarTarea();
            v.ShowDialog();
        }

        private void lblAgregarLugar_Click(object sender, EventArgs e)
        {
            frmAgregarLugar v = new frmAgregarLugar();
            v.ShowDialog();
        }
    }
}
