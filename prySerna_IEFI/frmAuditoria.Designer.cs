namespace prySerna_IEFI
{
    partial class frmAuditoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAuditoria));
            this.dgvAuditoria = new System.Windows.Forms.DataGridView();
            this.grpTarea = new System.Windows.Forms.GroupBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.nmCodigo = new System.Windows.Forms.NumericUpDown();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigoUser = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditoria)).BeginInit();
            this.grpTarea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCodigo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAuditoria
            // 
            this.dgvAuditoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuditoria.Location = new System.Drawing.Point(121, 168);
            this.dgvAuditoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvAuditoria.Name = "dgvAuditoria";
            this.dgvAuditoria.ReadOnly = true;
            this.dgvAuditoria.RowHeadersWidth = 62;
            this.dgvAuditoria.Size = new System.Drawing.Size(958, 488);
            this.dgvAuditoria.TabIndex = 0;
            // 
            // grpTarea
            // 
            this.grpTarea.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpTarea.BackgroundImage")));
            this.grpTarea.Controls.Add(this.txtUsuario);
            this.grpTarea.Controls.Add(this.nmCodigo);
            this.grpTarea.Controls.Add(this.lblNombre);
            this.grpTarea.Controls.Add(this.lblCodigoUser);
            this.grpTarea.Controls.Add(this.btnBuscar);
            this.grpTarea.Font = new System.Drawing.Font("Impact", 9F);
            this.grpTarea.ForeColor = System.Drawing.Color.White;
            this.grpTarea.Location = new System.Drawing.Point(121, 30);
            this.grpTarea.Name = "grpTarea";
            this.grpTarea.Size = new System.Drawing.Size(903, 120);
            this.grpTarea.TabIndex = 10;
            this.grpTarea.TabStop = false;
            this.grpTarea.Text = "Búsqueda de usuarios";
          
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(518, 40);
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
            this.lblNombre.Location = new System.Drawing.Point(348, 47);
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
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(133)))), ((int)(((byte)(141)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Location = new System.Drawing.Point(696, 36);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(114, 36);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmAuditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.grpTarea);
            this.Controls.Add(this.dgvAuditoria);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAuditoria";
            this.Text = "Auditoria";
            
            this.Load += new System.EventHandler(this.frmAuditoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditoria)).EndInit();
            this.grpTarea.ResumeLayout(false);
            this.grpTarea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCodigo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAuditoria;
        private System.Windows.Forms.GroupBox grpTarea;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.NumericUpDown nmCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigoUser;
        private System.Windows.Forms.Button btnBuscar;
    }
}