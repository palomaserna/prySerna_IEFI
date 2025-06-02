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
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.mkFecha = new System.Windows.Forms.MaskedTextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.nmCodigo = new System.Windows.Forms.NumericUpDown();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtGmail = new System.Windows.Forms.TextBox();
            this.lblGmail = new System.Windows.Forms.Label();
            this.txtTeléfono = new System.Windows.Forms.TextBox();
            this.lblTeléfono = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtDirección = new System.Windows.Forms.TextBox();
            this.lblDirección = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.grpUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(133)))), ((int)(((byte)(141)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Impact", 10F);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(531, 22);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(68, 32);
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
            this.btnModificar.Location = new System.Drawing.Point(531, 82);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(68, 32);
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
            this.btnEliminar.Location = new System.Drawing.Point(531, 143);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(68, 32);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Location = new System.Drawing.Point(4, 69);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(45, 16);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(63, 69);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(81, 22);
            this.txtUsuario.TabIndex = 4;
            // 
            // grpUsuario
            // 
            this.grpUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpUsuario.BackgroundImage")));
            this.grpUsuario.Controls.Add(this.cmbEstado);
            this.grpUsuario.Controls.Add(this.lblEstado);
            this.grpUsuario.Controls.Add(this.mkFecha);
            this.grpUsuario.Controls.Add(this.lblFecha);
            this.grpUsuario.Controls.Add(this.cmbRol);
            this.grpUsuario.Controls.Add(this.nmCodigo);
            this.grpUsuario.Controls.Add(this.lblCodigo);
            this.grpUsuario.Controls.Add(this.txtGmail);
            this.grpUsuario.Controls.Add(this.lblGmail);
            this.grpUsuario.Controls.Add(this.btnEliminar);
            this.grpUsuario.Controls.Add(this.txtTeléfono);
            this.grpUsuario.Controls.Add(this.btnModificar);
            this.grpUsuario.Controls.Add(this.lblTeléfono);
            this.grpUsuario.Controls.Add(this.btnAgregar);
            this.grpUsuario.Controls.Add(this.txtDni);
            this.grpUsuario.Controls.Add(this.lblDni);
            this.grpUsuario.Controls.Add(this.txtDirección);
            this.grpUsuario.Controls.Add(this.lblDirección);
            this.grpUsuario.Controls.Add(this.lblRol);
            this.grpUsuario.Controls.Add(this.txtContraseña);
            this.grpUsuario.Controls.Add(this.lblContraseña);
            this.grpUsuario.Controls.Add(this.lblUsuario);
            this.grpUsuario.Controls.Add(this.txtUsuario);
            this.grpUsuario.Font = new System.Drawing.Font("Impact", 9F);
            this.grpUsuario.ForeColor = System.Drawing.Color.White;
            this.grpUsuario.Location = new System.Drawing.Point(25, 30);
            this.grpUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.grpUsuario.Name = "grpUsuario";
            this.grpUsuario.Padding = new System.Windows.Forms.Padding(2);
            this.grpUsuario.Size = new System.Drawing.Size(610, 194);
            this.grpUsuario.TabIndex = 5;
            this.grpUsuario.TabStop = false;
            this.grpUsuario.Text = "Usuario";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbEstado.Location = new System.Drawing.Point(423, 67);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(81, 24);
            this.cmbEstado.TabIndex = 31;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Location = new System.Drawing.Point(368, 72);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 16);
            this.lblEstado.TabIndex = 30;
            this.lblEstado.Text = "Estado";
            // 
            // mkFecha
            // 
            this.mkFecha.Location = new System.Drawing.Point(425, 22);
            this.mkFecha.Mask = "00/00/0000";
            this.mkFecha.Name = "mkFecha";
            this.mkFecha.Size = new System.Drawing.Size(79, 22);
            this.mkFecha.TabIndex = 29;
            this.mkFecha.ValidatingType = typeof(System.DateTime);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Location = new System.Drawing.Point(324, 25);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(96, 16);
            this.lblFecha.TabIndex = 28;
            this.lblFecha.Text = "Fecha de Creación";
            // 
            // cmbRol
            // 
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.cmbRol.Location = new System.Drawing.Point(64, 155);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(81, 24);
            this.cmbRol.TabIndex = 27;
            // 
            // nmCodigo
            // 
            this.nmCodigo.Location = new System.Drawing.Point(64, 26);
            this.nmCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.nmCodigo.Name = "nmCodigo";
            this.nmCodigo.Size = new System.Drawing.Size(80, 22);
            this.nmCodigo.TabIndex = 26;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigo.Location = new System.Drawing.Point(4, 28);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(41, 16);
            this.lblCodigo.TabIndex = 25;
            this.lblCodigo.Text = "Código";
            // 
            // txtGmail
            // 
            this.txtGmail.Location = new System.Drawing.Point(225, 153);
            this.txtGmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtGmail.Name = "txtGmail";
            this.txtGmail.Size = new System.Drawing.Size(81, 22);
            this.txtGmail.TabIndex = 24;
            // 
            // lblGmail
            // 
            this.lblGmail.AutoSize = true;
            this.lblGmail.BackColor = System.Drawing.Color.Transparent;
            this.lblGmail.Location = new System.Drawing.Point(167, 156);
            this.lblGmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGmail.Name = "lblGmail";
            this.lblGmail.Size = new System.Drawing.Size(35, 16);
            this.lblGmail.TabIndex = 23;
            this.lblGmail.Text = "Gmail";
            // 
            // txtTeléfono
            // 
            this.txtTeléfono.Location = new System.Drawing.Point(225, 111);
            this.txtTeléfono.Margin = new System.Windows.Forms.Padding(2);
            this.txtTeléfono.Name = "txtTeléfono";
            this.txtTeléfono.Size = new System.Drawing.Size(81, 22);
            this.txtTeléfono.TabIndex = 22;
            // 
            // lblTeléfono
            // 
            this.lblTeléfono.AutoSize = true;
            this.lblTeléfono.BackColor = System.Drawing.Color.Transparent;
            this.lblTeléfono.Location = new System.Drawing.Point(167, 117);
            this.lblTeléfono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTeléfono.Name = "lblTeléfono";
            this.lblTeléfono.Size = new System.Drawing.Size(48, 16);
            this.lblTeléfono.TabIndex = 21;
            this.lblTeléfono.Text = "Teléfono";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(225, 66);
            this.txtDni.Margin = new System.Windows.Forms.Padding(2);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(81, 22);
            this.txtDni.TabIndex = 20;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.BackColor = System.Drawing.Color.Transparent;
            this.lblDni.Location = new System.Drawing.Point(167, 69);
            this.lblDni.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(24, 16);
            this.lblDni.TabIndex = 19;
            this.lblDni.Text = "DNI";
            // 
            // txtDirección
            // 
            this.txtDirección.Location = new System.Drawing.Point(225, 22);
            this.txtDirección.Margin = new System.Windows.Forms.Padding(2);
            this.txtDirección.Name = "txtDirección";
            this.txtDirección.Size = new System.Drawing.Size(81, 22);
            this.txtDirección.TabIndex = 18;
            // 
            // lblDirección
            // 
            this.lblDirección.AutoSize = true;
            this.lblDirección.BackColor = System.Drawing.Color.Transparent;
            this.lblDirección.Location = new System.Drawing.Point(167, 28);
            this.lblDirección.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDirección.Name = "lblDirección";
            this.lblDirección.Size = new System.Drawing.Size(54, 16);
            this.lblDirección.TabIndex = 12;
            this.lblDirección.Text = "Dirección";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.BackColor = System.Drawing.Color.Transparent;
            this.lblRol.Location = new System.Drawing.Point(4, 163);
            this.lblRol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(22, 16);
            this.lblRol.TabIndex = 7;
            this.lblRol.Text = "Rol";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(64, 117);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(2);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(81, 22);
            this.txtContraseña.TabIndex = 6;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.BackColor = System.Drawing.Color.Transparent;
            this.lblContraseña.Location = new System.Drawing.Point(4, 120);
            this.lblContraseña.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(64, 16);
            this.lblContraseña.TabIndex = 5;
            this.lblContraseña.Text = "Contraseña";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(25, 260);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersWidth = 62;
            this.dgvUsuarios.Size = new System.Drawing.Size(610, 216);
            this.dgvUsuarios.TabIndex = 6;
            this.dgvUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellDoubleClick);
            // 
            // frmGestiónUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(736, 487);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.grpUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmGestiónUsuarios";
            this.Text = "GestiónUsuarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGestiónUsuarios_FormClosing);
            this.Load += new System.EventHandler(this.frmGestiónUsuarios_Load);
            this.grpUsuario.ResumeLayout(false);
            this.grpUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
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
        private System.Windows.Forms.Label lblDirección;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtDirección;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblTeléfono;
        private System.Windows.Forms.TextBox txtGmail;
        private System.Windows.Forms.Label lblGmail;
        private System.Windows.Forms.NumericUpDown nmCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtTeléfono;
        private System.Windows.Forms.MaskedTextBox mkFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
    }
}