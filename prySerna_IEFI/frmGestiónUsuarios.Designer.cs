namespace prySerna_IEFI
{
    partial class frmGestiónUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestiónUsuarios));
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.grpUsuario = new System.Windows.Forms.GroupBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtRol = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.lblUltimaC = new System.Windows.Forms.Label();
            this.lblTiempoUlt = new System.Windows.Forms.Label();
            this.lblFCreacion = new System.Windows.Forms.Label();
            this.lblTiempoTotal = new System.Windows.Forms.Label();
            this.grpTiempo = new System.Windows.Forms.GroupBox();
            this.mskTiempoTotal = new System.Windows.Forms.MaskedTextBox();
            this.mskTiempoU = new System.Windows.Forms.MaskedTextBox();
            this.dtUltimaC = new System.Windows.Forms.DateTimePicker();
            this.dtFechaC = new System.Windows.Forms.DateTimePicker();
            this.grpUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.grpTiempo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(133)))), ((int)(((byte)(141)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Impact", 10F);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(37, 358);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(102, 47);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(133)))), ((int)(((byte)(141)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Font = new System.Drawing.Font("Impact", 10F);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(449, 358);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(109, 47);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(133)))), ((int)(((byte)(141)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Impact", 10F);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(856, 355);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(102, 50);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Location = new System.Drawing.Point(6, 45);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(66, 22);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(104, 39);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(148, 29);
            this.txtUsuario.TabIndex = 4;
            // 
            // grpUsuario
            // 
            this.grpUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpUsuario.BackgroundImage")));
            this.grpUsuario.Controls.Add(this.txtEstado);
            this.grpUsuario.Controls.Add(this.txtRol);
            this.grpUsuario.Controls.Add(this.lblEstado);
            this.grpUsuario.Controls.Add(this.lblRol);
            this.grpUsuario.Controls.Add(this.txtContraseña);
            this.grpUsuario.Controls.Add(this.lblContraseña);
            this.grpUsuario.Controls.Add(this.lblUsuario);
            this.grpUsuario.Controls.Add(this.txtUsuario);
            this.grpUsuario.Font = new System.Drawing.Font("Impact", 9F);
            this.grpUsuario.ForeColor = System.Drawing.Color.White;
            this.grpUsuario.Location = new System.Drawing.Point(46, 25);
            this.grpUsuario.Name = "grpUsuario";
            this.grpUsuario.Size = new System.Drawing.Size(267, 299);
            this.grpUsuario.TabIndex = 5;
            this.grpUsuario.TabStop = false;
            this.grpUsuario.Text = "Usuario";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(104, 233);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(148, 29);
            this.txtEstado.TabIndex = 18;
            // 
            // txtRol
            // 
            this.txtRol.Location = new System.Drawing.Point(104, 178);
            this.txtRol.Name = "txtRol";
            this.txtRol.Size = new System.Drawing.Size(148, 29);
            this.txtRol.TabIndex = 13;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Location = new System.Drawing.Point(10, 233);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(57, 22);
            this.lblEstado.TabIndex = 12;
            this.lblEstado.Text = "Estado";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.BackColor = System.Drawing.Color.Transparent;
            this.lblRol.Location = new System.Drawing.Point(6, 178);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(34, 22);
            this.lblRol.TabIndex = 7;
            this.lblRol.Text = "Rol";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(104, 104);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(148, 29);
            this.txtContraseña.TabIndex = 6;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.BackColor = System.Drawing.Color.Transparent;
            this.lblContraseña.Location = new System.Drawing.Point(6, 110);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(93, 22);
            this.lblContraseña.TabIndex = 5;
            this.lblContraseña.Text = "Contraseña";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(37, 413);
            this.dgvUsuarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersWidth = 62;
            this.dgvUsuarios.Size = new System.Drawing.Size(921, 333);
            this.dgvUsuarios.TabIndex = 6;
            // 
            // lblUltimaC
            // 
            this.lblUltimaC.AutoSize = true;
            this.lblUltimaC.Location = new System.Drawing.Point(6, 127);
            this.lblUltimaC.Name = "lblUltimaC";
            this.lblUltimaC.Size = new System.Drawing.Size(127, 22);
            this.lblUltimaC.TabIndex = 8;
            this.lblUltimaC.Text = "Ultima Conexión";
            // 
            // lblTiempoUlt
            // 
            this.lblTiempoUlt.Location = new System.Drawing.Point(6, 206);
            this.lblTiempoUlt.Name = "lblTiempoUlt";
            this.lblTiempoUlt.Size = new System.Drawing.Size(143, 55);
            this.lblTiempoUlt.TabIndex = 9;
            this.lblTiempoUlt.Text = "Tiempo de Ultima Conexión";
            // 
            // lblFCreacion
            // 
            this.lblFCreacion.AutoSize = true;
            this.lblFCreacion.Location = new System.Drawing.Point(6, 51);
            this.lblFCreacion.Name = "lblFCreacion";
            this.lblFCreacion.Size = new System.Drawing.Size(143, 22);
            this.lblFCreacion.TabIndex = 10;
            this.lblFCreacion.Text = "Fecha de Creación";
            // 
            // lblTiempoTotal
            // 
            this.lblTiempoTotal.AutoSize = true;
            this.lblTiempoTotal.Location = new System.Drawing.Point(374, 51);
            this.lblTiempoTotal.Name = "lblTiempoTotal";
            this.lblTiempoTotal.Size = new System.Drawing.Size(102, 22);
            this.lblTiempoTotal.TabIndex = 11;
            this.lblTiempoTotal.Text = "Tiempo Total";
            // 
            // grpTiempo
            // 
            this.grpTiempo.BackColor = System.Drawing.Color.Transparent;
            this.grpTiempo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpTiempo.BackgroundImage")));
            this.grpTiempo.Controls.Add(this.mskTiempoTotal);
            this.grpTiempo.Controls.Add(this.mskTiempoU);
            this.grpTiempo.Controls.Add(this.dtUltimaC);
            this.grpTiempo.Controls.Add(this.dtFechaC);
            this.grpTiempo.Controls.Add(this.lblFCreacion);
            this.grpTiempo.Controls.Add(this.lblUltimaC);
            this.grpTiempo.Controls.Add(this.lblTiempoTotal);
            this.grpTiempo.Controls.Add(this.lblTiempoUlt);
            this.grpTiempo.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTiempo.ForeColor = System.Drawing.Color.White;
            this.grpTiempo.Location = new System.Drawing.Point(328, 25);
            this.grpTiempo.Name = "grpTiempo";
            this.grpTiempo.Size = new System.Drawing.Size(659, 299);
            this.grpTiempo.TabIndex = 7;
            this.grpTiempo.TabStop = false;
            this.grpTiempo.Text = "Tiempo";
            // 
            // mskTiempoTotal
            // 
            this.mskTiempoTotal.Location = new System.Drawing.Point(480, 51);
            this.mskTiempoTotal.Mask = "90:00:00";
            this.mskTiempoTotal.Name = "mskTiempoTotal";
            this.mskTiempoTotal.Size = new System.Drawing.Size(114, 29);
            this.mskTiempoTotal.TabIndex = 21;
            this.mskTiempoTotal.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // mskTiempoU
            // 
            this.mskTiempoU.Location = new System.Drawing.Point(155, 206);
            this.mskTiempoU.Mask = "90:00:00";
            this.mskTiempoU.Name = "mskTiempoU";
            this.mskTiempoU.Size = new System.Drawing.Size(114, 29);
            this.mskTiempoU.TabIndex = 20;
            this.mskTiempoU.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // dtUltimaC
            // 
            this.dtUltimaC.Location = new System.Drawing.Point(155, 127);
            this.dtUltimaC.Name = "dtUltimaC";
            this.dtUltimaC.Size = new System.Drawing.Size(200, 29);
            this.dtUltimaC.TabIndex = 19;
            // 
            // dtFechaC
            // 
            this.dtFechaC.Location = new System.Drawing.Point(155, 48);
            this.dtFechaC.Name = "dtFechaC";
            this.dtFechaC.Size = new System.Drawing.Size(200, 29);
            this.dtFechaC.TabIndex = 18;
            // 
            // frmGestiónUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1104, 789);
            this.Controls.Add(this.grpTiempo);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.grpUsuario);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGestiónUsuarios";
            this.Text = "GestiónUsuarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGestiónUsuarios_FormClosing);
            this.Load += new System.EventHandler(this.frmGestiónUsuarios_Load);
            this.grpUsuario.ResumeLayout(false);
            this.grpUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.grpTiempo.ResumeLayout(false);
            this.grpTiempo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.GroupBox grpUsuario;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblTiempoTotal;
        private System.Windows.Forms.Label lblFCreacion;
        private System.Windows.Forms.Label lblTiempoUlt;
        private System.Windows.Forms.Label lblUltimaC;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtRol;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.GroupBox grpTiempo;
        private System.Windows.Forms.DateTimePicker dtUltimaC;
        private System.Windows.Forms.DateTimePicker dtFechaC;
        private System.Windows.Forms.MaskedTextBox mskTiempoTotal;
        private System.Windows.Forms.MaskedTextBox mskTiempoU;
    }
}