namespace WindowsFormsApp1
{
    partial class frmmodificar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btninsertar = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.Button();
            this.btncargarimg = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.txtapellidos = new System.Windows.Forms.TextBox();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.pboximg = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboximg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btninsertar);
            this.panel1.Controls.Add(this.btncerrar);
            this.panel1.Location = new System.Drawing.Point(34, 477);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 122);
            this.panel1.TabIndex = 21;
            // 
            // btninsertar
            // 
            this.btninsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsertar.Location = new System.Drawing.Point(28, 22);
            this.btninsertar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(249, 72);
            this.btninsertar.TabIndex = 8;
            this.btninsertar.Text = "Insertar";
            this.btninsertar.UseVisualStyleBackColor = true;
            // 
            // btncerrar
            // 
            this.btncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.Location = new System.Drawing.Point(486, 22);
            this.btncerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(237, 72);
            this.btncerrar.TabIndex = 9;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.UseVisualStyleBackColor = true;
            // 
            // btncargarimg
            // 
            this.btncargarimg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncargarimg.Location = new System.Drawing.Point(521, 342);
            this.btncargarimg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btncargarimg.Name = "btncargarimg";
            this.btncargarimg.Size = new System.Drawing.Size(268, 66);
            this.btncargarimg.TabIndex = 20;
            this.btncargarimg.Text = "Cargar Imagen";
            this.btncargarimg.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(521, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 56);
            this.label3.TabIndex = 19;
            this.label3.Text = "Fotografia";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 33);
            this.label2.TabIndex = 17;
            this.label2.Text = "Apellidos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 273);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 33);
            this.label1.TabIndex = 16;
            this.label1.Text = "DNI";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(26, 36);
            this.lblnombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(119, 33);
            this.lblnombre.TabIndex = 15;
            this.lblnombre.Text = "Nombre";
            // 
            // txtapellidos
            // 
            this.txtapellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapellidos.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtapellidos.Location = new System.Drawing.Point(34, 199);
            this.txtapellidos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtapellidos.Name = "txtapellidos";
            this.txtapellidos.Size = new System.Drawing.Size(438, 40);
            this.txtapellidos.TabIndex = 14;
            // 
            // txtdni
            // 
            this.txtdni.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdni.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtdni.Location = new System.Drawing.Point(34, 316);
            this.txtdni.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(210, 40);
            this.txtdni.TabIndex = 13;
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtnombre.Location = new System.Drawing.Point(34, 79);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(290, 40);
            this.txtnombre.TabIndex = 12;
            // 
            // pboximg
            // 
            this.pboximg.Location = new System.Drawing.Point(521, 97);
            this.pboximg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pboximg.Name = "pboximg";
            this.pboximg.Size = new System.Drawing.Size(268, 234);
            this.pboximg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboximg.TabIndex = 18;
            this.pboximg.TabStop = false;
            // 
            // frmmodificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 634);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btncargarimg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pboximg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.txtapellidos);
            this.Controls.Add(this.txtdni);
            this.Controls.Add(this.txtnombre);
            this.Name = "frmmodificar";
            this.Text = "frmmodificar";
            this.Load += new System.EventHandler(this.frmmodificar_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboximg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btninsertar;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Button btncargarimg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pboximg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox txtapellidos;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.TextBox txtnombre;
    }
}