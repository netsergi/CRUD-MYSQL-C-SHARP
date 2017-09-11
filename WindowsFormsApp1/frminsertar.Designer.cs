namespace WindowsFormsApp1
{
    partial class frminsertar
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
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.txtapellidos = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btninsertar = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.Button();
            this.btncargarimg = new System.Windows.Forms.Button();
            this.Dialimg = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pboximg = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboximg)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtnombre.Location = new System.Drawing.Point(32, 74);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(290, 40);
            this.txtnombre.TabIndex = 0;
            // 
            // txtdni
            // 
            this.txtdni.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdni.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtdni.Location = new System.Drawing.Point(32, 311);
            this.txtdni.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(210, 40);
            this.txtdni.TabIndex = 1;
            // 
            // txtapellidos
            // 
            this.txtapellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapellidos.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtapellidos.Location = new System.Drawing.Point(32, 194);
            this.txtapellidos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtapellidos.Name = "txtapellidos";
            this.txtapellidos.Size = new System.Drawing.Size(438, 40);
            this.txtapellidos.TabIndex = 2;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(24, 31);
            this.lblnombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(119, 33);
            this.lblnombre.TabIndex = 3;
            this.lblnombre.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 268);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(519, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 56);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fotografia";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
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
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btncargarimg
            // 
            this.btncargarimg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncargarimg.Location = new System.Drawing.Point(519, 337);
            this.btncargarimg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btncargarimg.Name = "btncargarimg";
            this.btncargarimg.Size = new System.Drawing.Size(268, 66);
            this.btncargarimg.TabIndex = 10;
            this.btncargarimg.Text = "Cargar Imagen";
            this.btncargarimg.UseVisualStyleBackColor = true;
            this.btncargarimg.Click += new System.EventHandler(this.btncargarimg_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btninsertar);
            this.panel1.Controls.Add(this.btncerrar);
            this.panel1.Location = new System.Drawing.Point(32, 472);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 122);
            this.panel1.TabIndex = 11;
            // 
            // pboximg
            // 
            this.pboximg.Location = new System.Drawing.Point(519, 92);
            this.pboximg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pboximg.Name = "pboximg";
            this.pboximg.Size = new System.Drawing.Size(268, 234);
            this.pboximg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboximg.TabIndex = 6;
            this.pboximg.TabStop = false;
            // 
            // frminsertar
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frminsertar";
            this.Text = "Insertar usuario";
            this.Load += new System.EventHandler(this.frminsertar_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboximg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.TextBox txtapellidos;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pboximg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btninsertar;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Button btncargarimg;
        private System.Windows.Forms.OpenFileDialog Dialimg;
        private System.Windows.Forms.Panel panel1;
    }
}