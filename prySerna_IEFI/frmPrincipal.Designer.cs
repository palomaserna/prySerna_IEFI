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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.tareasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msAdministracion = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msAuditoria = new System.Windows.Forms.ToolStripMenuItem();
            this.ssUsuarioT = new System.Windows.Forms.StatusStrip();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblContador = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmTiempo = new System.Windows.Forms.Timer(this.components);
            this.tmFecha = new System.Windows.Forms.Timer(this.components);
            this.registrarTareaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msPrincipal.SuspendLayout();
            this.ssUsuarioT.SuspendLayout();
            this.SuspendLayout();
            // 
            // msPrincipal
            // 
            this.msPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(133)))), ((int)(((byte)(141)))));
            this.msPrincipal.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tareasToolStripMenuItem,
            this.msAdministracion});
            this.msPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.msPrincipal.Size = new System.Drawing.Size(800, 24);
            this.msPrincipal.TabIndex = 0;
            this.msPrincipal.Text = "menuStrip1";
            // 
            // tareasToolStripMenuItem
            // 
            this.tareasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarTareaToolStripMenuItem});
            this.tareasToolStripMenuItem.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tareasToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.tareasToolStripMenuItem.Name = "tareasToolStripMenuItem";
            this.tareasToolStripMenuItem.Size = new System.Drawing.Size(58, 22);
            this.tareasToolStripMenuItem.Text = "Tareas";
            // 
            // msAdministracion
            // 
            this.msAdministracion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.msAuditoria});
            this.msAdministracion.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msAdministracion.ForeColor = System.Drawing.Color.White;
            this.msAdministracion.Name = "msAdministracion";
            this.msAdministracion.Size = new System.Drawing.Size(107, 22);
            this.msAdministracion.Text = "Administración";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(133)))), ((int)(((byte)(141)))));
            this.usuarioToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // msAuditoria
            // 
            this.msAuditoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(133)))), ((int)(((byte)(141)))));
            this.msAuditoria.ForeColor = System.Drawing.Color.White;
            this.msAuditoria.Name = "msAuditoria";
            this.msAuditoria.Size = new System.Drawing.Size(128, 22);
            this.msAuditoria.Text = "Auditoria";
            this.msAuditoria.Click += new System.EventHandler(this.msAuditoria_Click);
            // 
            // ssUsuarioT
            // 
            this.ssUsuarioT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(133)))), ((int)(((byte)(141)))));
            this.ssUsuarioT.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ssUsuarioT.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuario,
            this.toolStripStatusLabel2,
            this.lblFecha,
            this.lblContador});
            this.ssUsuarioT.Location = new System.Drawing.Point(0, 428);
            this.ssUsuarioT.Name = "ssUsuarioT";
            this.ssUsuarioT.Size = new System.Drawing.Size(800, 22);
            this.ssUsuarioT.TabIndex = 1;
            this.ssUsuarioT.Text = "statusStrip1";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(15, 17);
            this.lblUsuario.Text = "....";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(36, 17);
            this.toolStripStatusLabel2.Text = "Fecha";
            // 
            // lblFecha
            // 
            this.lblFecha.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(13, 17);
            this.lblFecha.Text = "...";
            // 
            // lblContador
            // 
            this.lblContador.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(13, 17);
            this.lblContador.Text = "...";
            // 
            // tmTiempo
            // 
            this.tmTiempo.Interval = 1000;
            this.tmTiempo.Tick += new System.EventHandler(this.tmTiempo_Tick);
            // 
            // tmFecha
            // 
            this.tmFecha.Tick += new System.EventHandler(this.tmFecha_Tick);
            // 
            // registrarTareaToolStripMenuItem
            // 
            this.registrarTareaToolStripMenuItem.Name = "registrarTareaToolStripMenuItem";
            this.registrarTareaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registrarTareaToolStripMenuItem.Text = "Registrar Tarea";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ssUsuarioT);
            this.Controls.Add(this.msPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msPrincipal;
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Timer tmTiempo;
        private System.Windows.Forms.ToolStripStatusLabel lblFecha;
        private System.Windows.Forms.ToolStripStatusLabel lblContador;
        private System.Windows.Forms.Timer tmFecha;
        private System.Windows.Forms.ToolStripMenuItem registrarTareaToolStripMenuItem;
    }
}