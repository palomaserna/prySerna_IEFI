namespace prySerna_IEFI
{
    partial class frmRegistrarTareas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarTareas));
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbTarea = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmbLugar = new System.Windows.Forms.ComboBox();
            this.cbInsumo = new System.Windows.Forms.CheckBox();
            this.grpDetalle = new System.Windows.Forms.GroupBox();
            this.cbRecibo = new System.Windows.Forms.CheckBox();
            this.cbSalario = new System.Windows.Forms.CheckBox();
            this.lblReclamo = new System.Windows.Forms.Label();
            this.cbEnfermedad = new System.Windows.Forms.CheckBox();
            this.cbVacaciones = new System.Windows.Forms.CheckBox();
            this.cbEstudio = new System.Windows.Forms.CheckBox();
            this.lblLicencia = new System.Windows.Forms.Label();
            this.lblFaltaUniforme = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.lblTarea = new System.Windows.Forms.Label();
            this.grpTarea = new System.Windows.Forms.GroupBox();
            this.lblAgregarLugar = new System.Windows.Forms.Label();
            this.lblAgregarTarea = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.nmCodigo = new System.Windows.Forms.NumericUpDown();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigoUser = new System.Windows.Forms.Label();
            this.lblLugar = new System.Windows.Forms.Label();
            this.lblComentario = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.dgvTareas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpDetalle.SuspendLayout();
            this.grpTarea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Location = new System.Drawing.Point(328, 53);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(53, 22);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha";
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(416, 47);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(200, 29);
            this.dtFecha.TabIndex = 1;
            // 
            // cmbTarea
            // 
            this.cmbTarea.FormattingEnabled = true;
            this.cmbTarea.Location = new System.Drawing.Point(738, 50);
            this.cmbTarea.Name = "cmbTarea";
            this.cmbTarea.Size = new System.Drawing.Size(200, 30);
            this.cmbTarea.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(133)))), ((int)(((byte)(141)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Location = new System.Drawing.Point(874, 123);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(105, 41);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cmbLugar
            // 
            this.cmbLugar.FormattingEnabled = true;
            this.cmbLugar.Location = new System.Drawing.Point(416, 114);
            this.cmbLugar.Name = "cmbLugar";
            this.cmbLugar.Size = new System.Drawing.Size(200, 30);
            this.cmbLugar.TabIndex = 4;
            // 
            // cbInsumo
            // 
            this.cbInsumo.AutoSize = true;
            this.cbInsumo.Location = new System.Drawing.Point(64, 78);
            this.cbInsumo.Name = "cbInsumo";
            this.cbInsumo.Size = new System.Drawing.Size(89, 26);
            this.cbInsumo.TabIndex = 6;
            this.cbInsumo.Text = "Insumo";
            this.cbInsumo.UseVisualStyleBackColor = true;
            // 
            // grpDetalle
            // 
            this.grpDetalle.Controls.Add(this.cbRecibo);
            this.grpDetalle.Controls.Add(this.cbSalario);
            this.grpDetalle.Controls.Add(this.lblReclamo);
            this.grpDetalle.Controls.Add(this.cbEnfermedad);
            this.grpDetalle.Controls.Add(this.cbVacaciones);
            this.grpDetalle.Controls.Add(this.cbEstudio);
            this.grpDetalle.Controls.Add(this.lblLicencia);
            this.grpDetalle.Controls.Add(this.lblFaltaUniforme);
            this.grpDetalle.Controls.Add(this.cbInsumo);
            this.grpDetalle.Location = new System.Drawing.Point(12, 354);
            this.grpDetalle.Name = "grpDetalle";
            this.grpDetalle.Size = new System.Drawing.Size(738, 221);
            this.grpDetalle.TabIndex = 7;
            this.grpDetalle.TabStop = false;
            this.grpDetalle.Text = "Detalle";
            // 
            // cbRecibo
            // 
            this.cbRecibo.AutoSize = true;
            this.cbRecibo.Location = new System.Drawing.Point(555, 128);
            this.cbRecibo.Name = "cbRecibo";
            this.cbRecibo.Size = new System.Drawing.Size(87, 26);
            this.cbRecibo.TabIndex = 14;
            this.cbRecibo.Text = "Recibo";
            this.cbRecibo.UseVisualStyleBackColor = true;
            // 
            // cbSalario
            // 
            this.cbSalario.AutoSize = true;
            this.cbSalario.Location = new System.Drawing.Point(554, 78);
            this.cbSalario.Name = "cbSalario";
            this.cbSalario.Size = new System.Drawing.Size(88, 26);
            this.cbSalario.TabIndex = 17;
            this.cbSalario.Text = "Salario";
            this.cbSalario.UseVisualStyleBackColor = true;
            // 
            // lblReclamo
            // 
            this.lblReclamo.AutoSize = true;
            this.lblReclamo.Location = new System.Drawing.Point(525, 42);
            this.lblReclamo.Name = "lblReclamo";
            this.lblReclamo.Size = new System.Drawing.Size(74, 22);
            this.lblReclamo.TabIndex = 16;
            this.lblReclamo.Text = "Reclamo";
            // 
            // cbEnfermedad
            // 
            this.cbEnfermedad.AutoSize = true;
            this.cbEnfermedad.Location = new System.Drawing.Point(293, 183);
            this.cbEnfermedad.Name = "cbEnfermedad";
            this.cbEnfermedad.Size = new System.Drawing.Size(121, 26);
            this.cbEnfermedad.TabIndex = 15;
            this.cbEnfermedad.Text = "Enfermedad";
            this.cbEnfermedad.UseVisualStyleBackColor = true;
            // 
            // cbVacaciones
            // 
            this.cbVacaciones.AutoSize = true;
            this.cbVacaciones.Location = new System.Drawing.Point(293, 128);
            this.cbVacaciones.Name = "cbVacaciones";
            this.cbVacaciones.Size = new System.Drawing.Size(121, 26);
            this.cbVacaciones.TabIndex = 14;
            this.cbVacaciones.Text = "Vacaciones";
            this.cbVacaciones.UseVisualStyleBackColor = true;
            // 
            // cbEstudio
            // 
            this.cbEstudio.AutoSize = true;
            this.cbEstudio.Location = new System.Drawing.Point(293, 78);
            this.cbEstudio.Name = "cbEstudio";
            this.cbEstudio.Size = new System.Drawing.Size(88, 26);
            this.cbEstudio.TabIndex = 13;
            this.cbEstudio.Text = "Estudio";
            this.cbEstudio.UseVisualStyleBackColor = true;
            // 
            // lblLicencia
            // 
            this.lblLicencia.AutoSize = true;
            this.lblLicencia.Location = new System.Drawing.Point(253, 42);
            this.lblLicencia.Name = "lblLicencia";
            this.lblLicencia.Size = new System.Drawing.Size(72, 22);
            this.lblLicencia.TabIndex = 12;
            this.lblLicencia.Text = "Licencia";
            // 
            // lblFaltaUniforme
            // 
            this.lblFaltaUniforme.AutoSize = true;
            this.lblFaltaUniforme.Location = new System.Drawing.Point(19, 42);
            this.lblFaltaUniforme.Name = "lblFaltaUniforme";
            this.lblFaltaUniforme.Size = new System.Drawing.Size(134, 22);
            this.lblFaltaUniforme.TabIndex = 11;
            this.lblFaltaUniforme.Text = "Falta de uniforme";
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(16, 646);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtComentario.Size = new System.Drawing.Size(738, 83);
            this.txtComentario.TabIndex = 8;
            // 
            // lblTarea
            // 
            this.lblTarea.AutoSize = true;
            this.lblTarea.BackColor = System.Drawing.Color.Transparent;
            this.lblTarea.Location = new System.Drawing.Point(664, 58);
            this.lblTarea.Name = "lblTarea";
            this.lblTarea.Size = new System.Drawing.Size(50, 22);
            this.lblTarea.TabIndex = 9;
            this.lblTarea.Text = "Tarea";
            // 
            // grpTarea
            // 
            this.grpTarea.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpTarea.BackgroundImage")));
            this.grpTarea.Controls.Add(this.lblAgregarLugar);
            this.grpTarea.Controls.Add(this.lblAgregarTarea);
            this.grpTarea.Controls.Add(this.txtUsuario);
            this.grpTarea.Controls.Add(this.nmCodigo);
            this.grpTarea.Controls.Add(this.lblNombre);
            this.grpTarea.Controls.Add(this.lblCodigoUser);
            this.grpTarea.Controls.Add(this.lblLugar);
            this.grpTarea.Controls.Add(this.lblTarea);
            this.grpTarea.Controls.Add(this.lblFecha);
            this.grpTarea.Controls.Add(this.btnAgregar);
            this.grpTarea.Controls.Add(this.cmbLugar);
            this.grpTarea.Controls.Add(this.dtFecha);
            this.grpTarea.Controls.Add(this.cmbTarea);
            this.grpTarea.Font = new System.Drawing.Font("Impact", 9F);
            this.grpTarea.ForeColor = System.Drawing.Color.White;
            this.grpTarea.Location = new System.Drawing.Point(12, 12);
            this.grpTarea.Name = "grpTarea";
            this.grpTarea.Size = new System.Drawing.Size(994, 180);
            this.grpTarea.TabIndex = 8;
            this.grpTarea.TabStop = false;
            this.grpTarea.Text = "Complete para registrar la tarea";
            // 
            // lblAgregarLugar
            // 
            this.lblAgregarLugar.AutoSize = true;
            this.lblAgregarLugar.BackColor = System.Drawing.Color.Transparent;
            this.lblAgregarLugar.Font = new System.Drawing.Font("Impact", 8F);
            this.lblAgregarLugar.Location = new System.Drawing.Point(412, 157);
            this.lblAgregarLugar.Name = "lblAgregarLugar";
            this.lblAgregarLugar.Size = new System.Drawing.Size(177, 20);
            this.lblAgregarLugar.TabIndex = 16;
            this.lblAgregarLugar.Text = "¿Desea agregar un lugar?";
            this.lblAgregarLugar.Click += new System.EventHandler(this.lblAgregarLugar_Click);
            // 
            // lblAgregarTarea
            // 
            this.lblAgregarTarea.AutoSize = true;
            this.lblAgregarTarea.BackColor = System.Drawing.Color.Transparent;
            this.lblAgregarTarea.Font = new System.Drawing.Font("Impact", 8F);
            this.lblAgregarTarea.Location = new System.Drawing.Point(727, 88);
            this.lblAgregarTarea.Name = "lblAgregarTarea";
            this.lblAgregarTarea.Size = new System.Drawing.Size(186, 20);
            this.lblAgregarTarea.TabIndex = 15;
            this.lblAgregarTarea.Text = "¿Desea agregar una tarea?";
            this.lblAgregarTarea.Click += new System.EventHandler(this.lblAgregarTarea_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(172, 114);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(131, 29);
            this.txtUsuario.TabIndex = 14;
            // 
            // nmCodigo
            // 
            this.nmCodigo.Location = new System.Drawing.Point(172, 44);
            this.nmCodigo.Name = "nmCodigo";
            this.nmCodigo.Size = new System.Drawing.Size(120, 29);
            this.nmCodigo.TabIndex = 13;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Location = new System.Drawing.Point(19, 118);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(146, 22);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "Nombre de Usuario";
            // 
            // lblCodigoUser
            // 
            this.lblCodigoUser.AutoSize = true;
            this.lblCodigoUser.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigoUser.Location = new System.Drawing.Point(19, 51);
            this.lblCodigoUser.Name = "lblCodigoUser";
            this.lblCodigoUser.Size = new System.Drawing.Size(141, 22);
            this.lblCodigoUser.TabIndex = 11;
            this.lblCodigoUser.Text = "Código de Usuario";
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.BackColor = System.Drawing.Color.Transparent;
            this.lblLugar.Location = new System.Drawing.Point(328, 123);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(50, 22);
            this.lblLugar.TabIndex = 10;
            this.lblLugar.Text = "Lugar";
            // 
            // lblComentario
            // 
            this.lblComentario.AutoSize = true;
            this.lblComentario.BackColor = System.Drawing.Color.Transparent;
            this.lblComentario.ForeColor = System.Drawing.Color.White;
            this.lblComentario.Location = new System.Drawing.Point(12, 598);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(94, 22);
            this.lblComentario.TabIndex = 11;
            this.lblComentario.Text = "Comentario";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(133)))), ((int)(((byte)(141)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(38, 761);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 45);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(133)))), ((int)(((byte)(141)))));
            this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGrabar.ForeColor = System.Drawing.Color.White;
            this.btnGrabar.Location = new System.Drawing.Point(776, 761);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(111, 45);
            this.btnGrabar.TabIndex = 12;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // dgvTareas
            // 
            this.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTareas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvTareas.Location = new System.Drawing.Point(12, 212);
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.RowHeadersWidth = 62;
            this.dgvTareas.RowTemplate.Height = 28;
            this.dgvTareas.Size = new System.Drawing.Size(842, 122);
            this.dgvTareas.TabIndex = 13;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código ";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Fecha";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Lugar";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tarea";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // frmRegistrarTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 813);
            this.Controls.Add(this.dgvTareas);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblComentario);
            this.Controls.Add(this.grpTarea);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.grpDetalle);
            this.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistrarTareas";
            this.Text = "Registrar Tareas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRegistrarTareas_Load);
            this.grpDetalle.ResumeLayout(false);
            this.grpDetalle.PerformLayout();
            this.grpTarea.ResumeLayout(false);
            this.grpTarea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.ComboBox cmbTarea;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbLugar;
        private System.Windows.Forms.CheckBox cbInsumo;
        private System.Windows.Forms.GroupBox grpDetalle;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Label lblTarea;
        private System.Windows.Forms.GroupBox grpTarea;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.CheckBox cbEstudio;
        private System.Windows.Forms.Label lblLicencia;
        private System.Windows.Forms.Label lblFaltaUniforme;
        private System.Windows.Forms.Label lblReclamo;
        private System.Windows.Forms.CheckBox cbEnfermedad;
        private System.Windows.Forms.CheckBox cbVacaciones;
        private System.Windows.Forms.CheckBox cbRecibo;
        private System.Windows.Forms.CheckBox cbSalario;
        private System.Windows.Forms.Label lblComentario;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.NumericUpDown nmCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigoUser;
        private System.Windows.Forms.DataGridView dgvTareas;
        private System.Windows.Forms.Label lblAgregarLugar;
        private System.Windows.Forms.Label lblAgregarTarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}