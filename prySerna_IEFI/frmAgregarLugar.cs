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
    public partial class frmAgregarLugar : Form
    {
        public frmAgregarLugar()
        {
            InitializeComponent();
        }

        private void frmAgregarLugar_Load(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                clsConexión BD = new clsConexión();
                string nombreLugar = txtLugar.Text.Trim();
                BD.AgregarLugar(nombreLugar);
                MessageBox.Show("Lugar agregado correctamente");
                txtLugar.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el lugar: " + ex.Message);
            }
        }
        public void ValidarDatos()
        {
            if (txtLugar.Text == "")
            {
                btnAgregar.Enabled = false;
            }
            else
            {
                btnAgregar.Enabled = true;
            }
        }
    }
}
