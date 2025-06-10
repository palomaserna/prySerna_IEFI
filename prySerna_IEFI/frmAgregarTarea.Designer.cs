namespace prySerna_IEFI
{
    partial class frmAgregarTarea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarTarea));
            this.lblTarea = new System.Windows.Forms.Label();
            this.txtTarea = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblIndicaccion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTarea
            // 
            this.lblTarea.AutoSize = true;
            this.lblTarea.BackColor = System.Drawing.Color.Transparent;
            this.lblTarea.Location = new System.Drawing.Point(42, 182);
            this.lblTarea.Name = "lblTarea";
            this.lblTarea.Size = new System.Drawing.Size(57, 25);
            this.lblTarea.TabIndex = 13;
            this.lblTarea.Text = "Tarea";
            // 
            // txtTarea
            // 
            this.txtTarea.Font = new System.Drawing.Font("Impact", 9F);
            this.txtTarea.Location = new System.Drawing.Point(105, 182);
            this.txtTarea.Name = "txtTarea";
            this.txtTarea.Size = new System.Drawing.Size(242, 29);
            this.txtTarea.TabIndex = 15;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(133)))), ((int)(((byte)(141)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Location = new System.Drawing.Point(121, 267);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(184, 67);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblIndicaccion
            // 
            this.lblIndicaccion.AutoSize = true;
            this.lblIndicaccion.BackColor = System.Drawing.Color.Transparent;
            this.lblIndicaccion.Location = new System.Drawing.Point(26, 75);
            this.lblIndicaccion.Name = "lblIndicaccion";
            this.lblIndicaccion.Size = new System.Drawing.Size(279, 25);
            this.lblIndicaccion.TabIndex = 17;
            this.lblIndicaccion.Text = "Complete para agregar una tarea";
            // 
            // frmAgregarTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(470, 476);
            this.Controls.Add(this.lblIndicaccion);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtTarea);
            this.Controls.Add(this.lblTarea);
            this.Font = new System.Drawing.Font("Impact", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAgregarTarea";
            this.Text = "Agregar una Tarea";
            this.Load += new System.EventHandler(this.frmAgregarTarea_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTarea;
        private System.Windows.Forms.TextBox txtTarea;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblIndicaccion;
    }
}