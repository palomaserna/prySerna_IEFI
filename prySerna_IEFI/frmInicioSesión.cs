using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySerna_IEFI
{
    public partial class frmInicioSesión : Form
    {
        public frmInicioSesión()
        {
            InitializeComponent();
        }
      
      int IntentosFallidos = 0;
        private void frmInicioSesión_Load(object sender, EventArgs e)
        {
            clsConexión conexion = new clsConexión();
            txtContraseña.PasswordChar = '*';

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            clsUsuario Inicio = new clsUsuario();
            clsConexión conexión = new clsConexión();
            Inicio.Usuario = txtUsuario.Text;
            Inicio.Contraseña = txtContraseña.Text;
            int idUsuario = conexión.Iniciar(Inicio);

            if (idUsuario>0)
            {
                frmPrincipal principal = new frmPrincipal(idUsuario, Inicio.Usuario, Inicio.Rol);
                principal.Show();
                this.Hide();
            }
            else
            {
                IntentosFallidos++;

                MessageBox.Show($"Usuario o Contraseña incorrecto . Intento{IntentosFallidos} de 3");
            }
            if (IntentosFallidos >= 3)
            {
                MessageBox.Show("Demasiados intentos fallidos");
                Application.Exit();
            }
            txtUsuario.Clear();
            txtContraseña.Clear();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexión conexión = new clsConexión();
                clsUsuario Inicio = new clsUsuario();
                Inicio.Usuario = txtUsuario.Text;
                Inicio.Contraseña = txtContraseña.Text;
                conexión.AgregarUsuario(Inicio);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se creo el usuario" + ex.Message);
            }
            txtUsuario.Clear();
            txtContraseña.Clear();
        }
        public void ValidarDatos()
        {
            if (txtUsuario.Text != "" && txtContraseña.Text != "")
            {
                btnEntrar.Enabled = true;
               
            }
            else
            {
                
                btnEntrar.Enabled = false;
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void lblRegistro_Click(object sender, EventArgs e)
        {
            frmRegistrarUsuario v= new frmRegistrarUsuario();
            v.ShowDialog();
        }
    }
}
