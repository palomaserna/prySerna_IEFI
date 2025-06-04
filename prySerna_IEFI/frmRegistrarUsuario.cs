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
    public partial class frmRegistrarUsuario : Form
    {
        public frmRegistrarUsuario()
        {
            InitializeComponent();
        }

        private void frmRegistrarUsuario_Load(object sender, EventArgs e)
        {
            clsConexión conexion = new clsConexión();
            txtContraseña.PasswordChar = '*';
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexión conexión = new clsConexión();
                clsUsuario Inicio = new clsUsuario();
                Inicio.Usuario = txtUsuario.Text;
                Inicio.Contraseña = txtContraseña.Text;
                Inicio.Direccion = txtDireccion.Text;
                Inicio.Dni = long.Parse(txtDni.Text);
                Inicio.Telefono=long.Parse(txtTelefono.Text);
                Inicio.Gmail = txtGmail.Text;
                Inicio.Rol = "Usuario";

                conexión.AgregarUsuario(Inicio);
                MessageBox.Show("Usuario agregado correctamente");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se creo el usuario" + ex.Message);
            }
            txtUsuario.Clear();
            txtContraseña.Clear();
        }

       
    }
}
