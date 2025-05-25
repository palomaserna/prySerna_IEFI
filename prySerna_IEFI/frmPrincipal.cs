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
    public partial class frmPrincipal : Form
    {
        public string RolUsuario { get; set; }
        public string UsuarioN {  get; set; }

        public frmPrincipal()
        {
            InitializeComponent();
            this.FormClosing += frmPrincipal_FormClosing;
        }
        
        int tiempo = 0;
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            clsConexión BD=new clsConexión();
            clsUsuario Iniciar=new clsUsuario();
            if (RolUsuario == "Administrador")
            {
                msAuditoria.Visible = true;
            }
            else
            {
                msAuditoria.Visible=false;
            }
            lblUsuario.Text = $"Usuario conectado: {UsuarioN}";
            tmTiempo.Start();
            tmFecha.Start();
        }

       

        private void tmTiempo_Tick(object sender, EventArgs e)
        {
            tiempo++;
            int minutos = tiempo / 60;
            int segundos=tiempo % 60;
            lblContador.Text = $"Tiempo conectado: {minutos:D2}:{segundos:D2}";
        }

        

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmTiempo.Stop();
            TimeSpan tiempoSesion = TimeSpan.FromSeconds(tiempo);
            clsConexión conexion = new clsConexión();
            conexion.GuardarUltimaConexion(UsuarioN, tiempoSesion);
            conexion.ActualizarEstado(UsuarioN, "Inactivo");
        }

        private void tmFecha_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void msAuditoria_Click(object sender, EventArgs e)
        {
            frmAuditoria v = new frmAuditoria();
            v.ShowDialog();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestiónUsuarios v = new frmGestiónUsuarios();
            v.ShowDialog();
        }
    }
}
