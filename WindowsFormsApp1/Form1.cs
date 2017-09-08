using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Generar_ColFotos (DataTable datos)
        {
            DataGridViewImageColumn colimg = new DataGridViewImageColumn();
            colimg.HeaderText = "FOTOS";
            lista.Columns.Add(colimg);
            colimg.ImageLayout = DataGridViewImageCellLayout.Zoom;
            int i = 0;
            if (Directory.Exists(Application.StartupPath + "\\fotos"))
            {
                foreach (DataGridViewRow row in lista.Rows)
                {
                    string path = Application.StartupPath + "\\fotos\\" + datos.Rows[i][4].ToString();
                    if (File.Exists(path))
                    {
                        Bitmap img = new Bitmap(path);
                        row.Cells[5].Value = img;
                        i++;
                    }
                    else
                    {
                        row.Cells[5].Value = Properties.Resources.error;
                    }
                }
            }
            else
            {
                Directory.CreateDirectory(Application.StartupPath + "\\fotos");
            }
        }

        private void llenarltabla()
        {
            db usuarios = new db();
            DataTable datos;
            datos = usuarios.cargar();
            lista.DataSource = datos;     
            lista.Columns[0].Visible = false;
            lista.Columns[4].Visible = false;
            Generar_ColFotos(datos);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lista.RowTemplate.Height = 120;
            llenarltabla();           
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frminsertar form_Ins = new frminsertar();
            form_Ins.Show();            
        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
