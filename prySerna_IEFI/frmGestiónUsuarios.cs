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
    public partial class frmGestiónUsuarios : Form
    {
        public string RolUsuario {  get; set; }
        public string UsuarioActual { get; set; }
        public frmGestiónUsuarios()
        {
            InitializeComponent();
        }

        private void frmGestiónUsuarios_Load(object sender, EventArgs e)
        {
            

            clsConexión BD = new clsConexión();
            BD.CargarUsuarios(dgvUsuarios);
            if (RolUsuario == "Usuario")
            {
               
                txtRol.Enabled = false;
                txtEstado.Enabled = false;
                dtFechaC.Enabled = false;
                dtUltimaC.Enabled = false;
                mskTiempoTotal.Enabled = false;
                mskTiempoU.Enabled = false;

                btnAgregar.Visible = false;
                btnEliminar.Visible = false;
                grpTiempo.Visible = false;
                var usuario = BD.CargarSoloEsteUsuario(UsuarioActual);
                if (usuario != null)
                {
                    txtUsuario.Text = usuario.Usuario;
                    txtContraseña.Text = usuario.Contraseña;
                }

            }
            else if (RolUsuario == "Administrador")
            {
                BD.CargarUsuarios(dgvUsuarios);
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexión BD = new clsConexión();
                clsUsuario Usuario = new clsUsuario();
                {
                    Usuario.Usuario = txtUsuario.Text;
                    Usuario.Contraseña = txtContraseña.Text;
                    Usuario.Rol = txtRol.Text;
                    Usuario.Estado = txtEstado.Text;
                    Usuario.FechaCreacion = dtFechaC.Value;
                    Usuario.UltimaConexion = dtUltimaC.Value;
                    Usuario.TiempoUltimaConexion = TimeSpan.Parse(mskTiempoU.Text);
                    Usuario.TiempoTotal=TimeSpan.Parse(mskTiempoTotal.Text);
                    BD.Agregar(Usuario);
                    BD.CargarUsuarios(dgvUsuarios);
                };
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
                    Usuario.Usuario = txtUsuario.Text;
                    Usuario.Contraseña = txtContraseña.Text;
                    Usuario.Rol = txtRol.Text;
                    Usuario.Estado = txtEstado.Text;
                    Usuario.FechaCreacion = dtFechaC.Value;
                    Usuario.UltimaConexion = dtUltimaC.Value;
                    Usuario.TiempoUltimaConexion = TimeSpan.Parse(mskTiempoU.Text);
                    Usuario.TiempoTotal = TimeSpan.Parse(mskTiempoTotal.Text);
                    BD.Modificar(Usuario);
                    BD.CargarUsuarios(dgvUsuarios);
                    if (RolUsuario == "Usuario")
                    {
                        Usuario.Rol = null; // o no se asigna
                        Usuario.Estado = null;
                        Usuario.FechaCreacion = DateTime.MinValue;
                        Usuario.UltimaConexion = DateTime.MinValue;
                        Usuario.TiempoUltimaConexion = TimeSpan.Zero;
                        Usuario.TiempoTotal = TimeSpan.Zero;
                    }
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
                    Usuario.Usuario = txtUsuario.Text;
                    Usuario.Contraseña = txtContraseña.Text;
                    Usuario.Rol = txtRol.Text;
                    Usuario.Estado = txtEstado.Text;
                    Usuario.FechaCreacion = dtFechaC.Value;
                    Usuario.UltimaConexion = dtUltimaC.Value;
                    Usuario.TiempoUltimaConexion = TimeSpan.Parse(mskTiempoU.Text);
                    Usuario.TiempoTotal = TimeSpan.Parse(mskTiempoTotal.Text);
                    BD.Eliminar(Usuario);
                    BD.CargarUsuarios(dgvUsuarios);
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmGestiónUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
