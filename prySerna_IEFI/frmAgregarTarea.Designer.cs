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
            this.lblTarea = new System.Windows.Forms.Label();
            this.txtTarea = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblIndicaccion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTarea
            // 
            this.lblTarea.AutoSize = true;
            this.lblTarea.Location = new System.Drawing.Point(44, 106);
            this.lblTarea.Name = "lblTarea";
            this.lblTarea.Size = new System.Drawing.Size(50, 20);
            this.lblTarea.TabIndex = 13;
            this.lblTarea.Text = "Tarea";
            // 
            // txtTarea
            // 
            this.txtTarea.Location = new System.Drawing.Point(100, 103);
            this.txtTarea.Name = "txtTarea";
            this.txtTarea.Size = new System.Drawing.Size(218, 26);
            this.txtTarea.TabIndex = 15;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(91, 184);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(166, 54);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblIndicaccion
            // 
            this.lblIndicaccion.AutoSize = true;
            this.lblIndicaccion.Location = new System.Drawing.Point(23, 50);
            this.lblIndicaccion.Name = "lblIndicaccion";
            this.lblIndicaccion.Size = new System.Drawing.Size(244, 20);
            this.lblIndicaccion.TabIndex = 17;
            this.lblIndicaccion.Text = "Complete para agregar una tarea";
            // 
            // frmAgregarTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 381);
            this.Controls.Add(this.lblIndicaccion);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtTarea);
            this.Controls.Add(this.lblTarea);
            this.Name = "frmAgregarTarea";
            this.Text = "frmAgregarTarea";
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