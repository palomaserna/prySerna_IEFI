using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySerna_IEFI
{
    public partial class frmGestiónUsuarios : Form
    {
      
        public frmGestiónUsuarios()
        {
            InitializeComponent();
        }

        private void frmGestiónUsuarios_Load(object sender, EventArgs e)
        {
            clsConexión BD = new clsConexión();
            BD.CargarGestion(dgvUsuarios);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexión BD = new clsConexión();
                clsUsuario Usuario = new clsUsuario();
                {
                    Usuario.IdUsuario = Convert.ToInt32(nmCodigo.Value);
                    Usuario.Usuario = txtUsuario.Text;
                    Usuario.Contraseña = txtContraseña.Text;
                    Usuario.Rol=txtRol.Text;
                    Usuario.Direccion=txtDirección.Text;
                    Usuario.Dni=long.Parse(txtDni.Text);
                    Usuario.Telefono = long.Parse(txtTeléfono.Text);
                    Usuario.Gmail=txtGmail.Text;
                    Usuario.Estado=txtEstado.Text;
                    Usuario.FechaCreacion = DateTime.Parse(mkFecha.Text);
                    BD.Agregar(Usuario);
                    BD.CargarGestion(dgvUsuarios);
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexión BD = new clsConexión();
                clsUsuario Usuario = new clsUsuario();
                {
                    Usuario.IdUsuario = Convert.ToInt32(nmCodigo.Value);
                    Usuario.Usuario = txtUsuario.Text;
                    Usuario.Contraseña = txtContraseña.Text;
                  
                    Usuario.Rol=txtRol.Text;
                    Usuario.Direccion = txtDirección.Text;
                    Usuario.Dni = long.Parse(txtDni.Text);
                    
                    Usuario.Telefono = long.Parse(txtTeléfono.Text);
                    Usuario.Gmail = txtGmail.Text;
                 
                  Usuario.Estado = txtEstado.Text;
                    Usuario.FechaCreacion = DateTime.Parse(mkFecha.Text);
                    BD.Modificar(Usuario);
                    BD.CargarGestion(dgvUsuarios);
                   
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexión BD = new clsConexión();
                clsUsuario Usuario = new clsUsuario();
                {
                    Usuario.IdUsuario=Convert.ToInt32(nmCodigo.Value);
                    Usuario.Usuario = txtUsuario.Text;
                    Usuario.Contraseña = txtContraseña.Text;
                    Usuario.Rol=txtRol.Text;
                    Usuario.Direccion = txtDirección.Text;
                    Usuario.Dni =   long.Parse(txtDni.Text);
                    Usuario.Telefono = long.Parse(txtTeléfono.Text);
                    Usuario.Gmail = txtGmail.Text;
                    Usuario.Estado = txtEstado.Text;
                    Usuario.FechaCreacion = DateTime.Parse(mkFecha.Text);
                    BD.Eliminar(Usuario);
                    BD.CargarGestion(dgvUsuarios);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];
                nmCodigo.Value = Convert.ToInt32(fila.Cells["IdUsuario"].Value);
                txtUsuario.Text = fila.Cells["Usuario"].Value.ToString();
                txtContraseña.Text = fila.Cells["Contraseña"].Value.ToString();
                txtRol.Text = fila.Cells["Rol"].Value.ToString();
                txtDirección.Text = fila.Cells["Direccion"].Value.ToString();
                txtDni.Text = fila.Cells["Dni"].Value.ToString();
                txtTeléfono.Text = fila.Cells["Telefono"].Value.ToString();
                txtGmail.Text = fila.Cells["Gmail"].Value.ToString();
                txtEstado.Text = fila.Cells["Estado"].Value.ToString();
                if (fila.Cells["FechaCreacion"].Value != DBNull.Value)
                {
                    mkFecha.Text = Convert.ToDateTime(fila.Cells["FechaCreacion"].Value).ToString("dd/MM/yyyy");
                }
            }
        }
    }
}
