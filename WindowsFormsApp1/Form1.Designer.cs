namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lista = new System.Windows.Forms.DataGridView();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.estado = new System.Windows.Forms.StatusStrip();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lista
            // 
            this.lista.AllowUserToAddRows = false;
            this.lista.AllowUserToDeleteRows = false;
            this.lista.AllowUserToResizeColumns = false;
            this.lista.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lista.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lista.Location = new System.Drawing.Point(40, 97);
            this.lista.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lista.Name = "lista";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lista.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.lista.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lista.Size = new System.Drawing.Size(1711, 725);
            this.lista.TabIndex = 0;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.Menu;
            this.menu.Font = new System.Drawing.Font("Segoe UI", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarToolStripMenuItem,
            this.modificarToolStripMenuItem1,
            this.eliminarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menu.Size = new System.Drawing.Size(1791, 50);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            this.menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menu_ItemClicked);
            // 
            // estado
            // 
            this.estado.Font = new System.Drawing.Font("Segoe UI", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estado.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.estado.Location = new System.Drawing.Point(0, 901);
            this.estado.Name = "estado";
            this.estado.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.estado.Size = new System.Drawing.Size(1791, 22);
            this.estado.TabIndex = 2;
            this.estado.Text = "statusStrip1";
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.add_user_icon__icon_search_engine_28;
            this.modificarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(162, 44);
            this.modificarToolStripMenuItem.Text = "Insertar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem1
            // 
            this.modificarToolStripMenuItem1.Image = global::WindowsFormsApp1.Properties.Resources.modificar;
            this.modificarToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.modificarToolStripMenuItem1.Name = "modificarToolStripMenuItem1";
            this.modificarToolStripMenuItem1.Size = new System.Drawing.Size(187, 44);
            this.modificarToolStripMenuItem1.Text = "Modificar";
            this.modificarToolStripMenuItem1.Click += new System.EventHandler(this.modificarToolStripMenuItem1_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.remove_user_512;
            this.eliminarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(164, 44);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.close_red;
            this.salirToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(115, 44);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1791, 923);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado personas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lista)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView lista;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.StatusStrip estado;
    }
}

