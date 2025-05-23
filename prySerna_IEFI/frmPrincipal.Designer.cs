namespace prySerna_IEFI
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.tareasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msAdministracion = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msAuditoria = new System.Windows.Forms.ToolStripMenuItem();
            this.ssUsuarioT = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmTiempo = new System.Windows.Forms.Timer(this.components);
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblContandor = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmFecha = new System.Windows.Forms.Timer(this.components);
            this.msPrincipal.SuspendLayout();
            this.ssUsuarioT.SuspendLayout();
            this.SuspendLayout();
            // 
            // msPrincipal
            // 
            this.msPrincipal.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.msPrincipal.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tareasToolStripMenuItem,
            this.msAdministracion});
            this.msPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.Size = new System.Drawing.Size(1200, 33);
            this.msPrincipal.TabIndex = 0;
            this.msPrincipal.Text = "menuStrip1";
            // 
            // tareasToolStripMenuItem
            // 
            this.tareasToolStripMenuItem.Name = "tareasToolStripMenuItem";
            this.tareasToolStripMenuItem.Size = new System.Drawing.Size(76, 29);
            this.tareasToolStripMenuItem.Text = "Tareas";
            // 
            // msAdministracion
            // 
            this.msAdministracion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.msAuditoria});
            this.msAdministracion.Name = "msAdministracion";
            this.msAdministracion.Size = new System.Drawing.Size(147, 29);
            this.msAdministracion.Text = "Administración";
            this.msAdministracion.Click += new System.EventHandler(this.msAuditoria_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // msAuditoria
            // 
            this.msAuditoria.Name = "msAuditoria";
            this.msAuditoria.Size = new System.Drawing.Size(270, 34);
            this.msAuditoria.Text = "Auditoria";
            // 
            // ssUsuarioT
            // 
            this.ssUsuarioT.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ssUsuarioT.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblUsuario,
            this.toolStripStatusLabel2,
            this.lblFecha,
            this.toolStripStatusLabel3,
            this.lblContandor});
            this.ssUsuarioT.Location = new System.Drawing.Point(0, 660);
            this.ssUsuarioT.Name = "ssUsuarioT";
            this.ssUsuarioT.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.ssUsuarioT.Size = new System.Drawing.Size(1200, 32);
            this.ssUsuarioT.TabIndex = 1;
            this.ssUsuarioT.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(72, 25);
            this.toolStripStatusLabel1.Text = "Usuario";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(28, 25);
            this.lblUsuario.Text = "....";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(57, 25);
            this.toolStripStatusLabel2.Text = "Fecha";
            // 
            // lblFecha
            // 
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(24, 25);
            this.lblFecha.Text = "...";
            // 
            // tmTiempo
            // 
            this.tmTiempo.Tick += new System.EventHandler(this.tmTiempo_Tick);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(72, 25);
            this.toolStripStatusLabel3.Text = "Tiempo";
            // 
            // lblContandor
            // 
            this.lblContandor.Name = "lblContandor";
            this.lblContandor.Size = new System.Drawing.Size(24, 25);
            this.lblContandor.Text = "...";
            // 
            // tmFecha
            // 
            this.tmFecha.Tick += new System.EventHandler(this.tmFecha_Tick);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.ssUsuarioT);
            this.Controls.Add(this.msPrincipal);
            this.MainMenuStrip = this.msPrincipal;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.ssUsuarioT.ResumeLayout(false);
            this.ssUsuarioT.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tareasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msAdministracion;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msAuditoria;
        private System.Windows.Forms.StatusStrip ssUsuarioT;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Timer tmTiempo;
        private System.Windows.Forms.ToolStripStatusLabel lblFecha;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lblContandor;
        private System.Windows.Forms.Timer tmFecha;
    }
}