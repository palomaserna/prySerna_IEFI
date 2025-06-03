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
    public partial class frmAgregarTarea : Form
    {
        public frmAgregarTarea()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            try
            {
                clsConexión BD = new clsConexión();
                string nombreTarea = txtTarea.Text.Trim();

                if (string.IsNullOrEmpty(nombreTarea))
                {
                    MessageBox.Show("Ingrese un nombre para la tarea.");
                    return;
                }

                BD.AgregarTareaTipo(nombreTarea);
                MessageBox.Show("Tarea agregada correctamente.");
                txtTarea.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la tarea: " + ex.Message);
            }

        }
    }
}
