﻿namespace prySerna_IEFI
{
    partial class frmHistorialAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistorialAdministrador));
            this.grpTarea = new System.Windows.Forms.GroupBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.nmCodigo = new System.Windows.Forms.NumericUpDown();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigoUser = new System.Windows.Forms.Label();
            this.lblLugar = new System.Windows.Forms.Label();
            this.lblTarea = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbLugar = new System.Windows.Forms.ComboBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbTarea = new System.Windows.Forms.ComboBox();
            this.dgvTareas = new System.Windows.Forms.DataGridView();
            this.grpTarea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
            this.SuspendLayout();
            // 
            // grpTarea
            // 
            this.grpTarea.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpTarea.BackgroundImage")));
            this.grpTarea.Controls.Add(this.txtUsuario);
            this.grpTarea.Controls.Add(this.nmCodigo);
            this.grpTarea.Controls.Add(this.lblNombre);
            this.grpTarea.Controls.Add(this.lblCodigoUser);
            this.grpTarea.Controls.Add(this.lblLugar);
            this.grpTarea.Controls.Add(this.lblTarea);
            this.grpTarea.Controls.Add(this.lblFecha);
            this.grpTarea.Controls.Add(this.btnBuscar);
            this.grpTarea.Controls.Add(this.cmbLugar);
            this.grpTarea.Controls.Add(this.dtFecha);
            this.grpTarea.Controls.Add(this.cmbTarea);
            this.grpTarea.Font = new System.Drawing.Font("Impact", 9F);
            this.grpTarea.ForeColor = System.Drawing.Color.White;
            this.grpTarea.Location = new System.Drawing.Point(12, 34);
            this.grpTarea.Name = "grpTarea";
            this.grpTarea.Size = new System.Drawing.Size(1069, 179);
            this.grpTarea.TabIndex = 9;
            this.grpTarea.TabStop = false;
            this.grpTarea.Text = "Búsqueda de tareas de usuarios";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(172, 104);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(131, 29);
            this.txtUsuario.TabIndex = 14;
            // 
            // nmCodigo
            // 
            this.nmCodigo.Location = new System.Drawing.Point(172, 40);
            this.nmCodigo.Name = "nmCodigo";
            this.nmCodigo.Size = new System.Drawing.Size(120, 29);
            this.nmCodigo.TabIndex = 13;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Location = new System.Drawing.Point(19, 107);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(146, 22);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "Nombre de Usuario";
            // 
            // lblCodigoUser
            // 
            this.lblCodigoUser.AutoSize = true;
            this.lblCodigoUser.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigoUser.Location = new System.Drawing.Point(19, 46);
            this.lblCodigoUser.Name = "lblCodigoUser";
            this.lblCodigoUser.Size = new System.Drawing.Size(141, 22);
            this.lblCodigoUser.TabIndex = 11;
            this.lblCodigoUser.Text = "Código de Usuario";
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.BackColor = System.Drawing.Color.Transparent;
            this.lblLugar.Location = new System.Drawing.Point(328, 112);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(50, 22);
            this.lblLugar.TabIndex = 10;
            this.lblLugar.Text = "Lugar";
            // 
            // lblTarea
            // 
            this.lblTarea.AutoSize = true;
            this.lblTarea.BackColor = System.Drawing.Color.Transparent;
            this.lblTarea.Location = new System.Drawing.Point(664, 53);
            this.lblTarea.Name = "lblTarea";
            this.lblTarea.Size = new System.Drawing.Size(50, 22);
            this.lblTarea.TabIndex = 9;
            this.lblTarea.Text = "Tarea";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Location = new System.Drawing.Point(328, 48);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(53, 22);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(133)))), ((int)(((byte)(141)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Location = new System.Drawing.Point(854, 107);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(114, 36);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbLugar
            // 
            this.cmbLugar.FormattingEnabled = true;
            this.cmbLugar.Location = new System.Drawing.Point(416, 104);
            this.cmbLugar.Name = "cmbLugar";
            this.cmbLugar.Size = new System.Drawing.Size(200, 30);
            this.cmbLugar.TabIndex = 4;
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(416, 43);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.ShowCheckBox = true;
            this.dtFecha.Size = new System.Drawing.Size(200, 29);
            this.dtFecha.TabIndex = 1;
            // 
            // cmbTarea
            // 
            this.cmbTarea.FormattingEnabled = true;
            this.cmbTarea.Location = new System.Drawing.Point(738, 45);
            this.cmbTarea.Name = "cmbTarea";
            this.cmbTarea.Size = new System.Drawing.Size(200, 30);
            this.cmbTarea.TabIndex = 2;
            // 
            // dgvTareas
            // 
            this.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTareas.Location = new System.Drawing.Point(12, 303);
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.ReadOnly = true;
            this.dgvTareas.RowHeadersWidth = 62;
            this.dgvTareas.RowTemplate.Height = 28;
            this.dgvTareas.Size = new System.Drawing.Size(1030, 316);
            this.dgvTareas.TabIndex = 15;
            // 
            // frmHistorialAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1142, 761);
            this.Controls.Add(this.dgvTareas);
            this.Controls.Add(this.grpTarea);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHistorialAdministrador";
            this.Text = "Historial de los Usuarios";
            this.Load += new System.EventHandler(this.frmHistorialAdministrador_Load);
            this.grpTarea.ResumeLayout(false);
            this.grpTarea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTarea;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.NumericUpDown nmCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigoUser;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.Label lblTarea;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cmbLugar;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.ComboBox cmbTarea;
        private System.Windows.Forms.DataGridView dgvTareas;
    }
}