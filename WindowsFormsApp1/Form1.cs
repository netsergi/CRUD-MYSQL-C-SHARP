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

        public void Generar_ColFotos (DataTable datos, DataGridView lista)
        {
            if (!lista.Columns.Contains("colfotos"))
            {
                DataGridViewImageColumn colimg = new DataGridViewImageColumn();
                colimg.HeaderText = "FOTOS";
                colimg.Name = "colfotos";
                lista.Columns.Add(colimg);
                colimg.ImageLayout = DataGridViewImageCellLayout.Zoom;
            }
                
            int i = 0;
            if (Directory.Exists(Application.StartupPath + "\\fotos"))
            {
                foreach (DataGridViewRow fila in lista.Rows)
                {
                   string path = Application.StartupPath + "\\fotos\\" + fila.Cells[4].Value.ToString();
                   if (File.Exists(path))
                   {
                       Bitmap img = new Bitmap(path);
                       fila.Cells[5].Value = img;                       
                   }
                   else
                   {
                       fila.Cells[5].Value = Properties.Resources.error;
                   }
                   if (i < datos.Rows.Count) i++;
                }
             }
             else
             {
                Directory.CreateDirectory(Application.StartupPath + "\\fotos");
             }
        }

        public void llenarltabla()
        {
            db usuarios = new db();
            DataTable personas = new DataTable();
            personas = usuarios.cargar();
            lista.DataSource = personas;
            Generar_ColFotos(personas, lista);
            lista.Columns[0].Visible = false;
            lista.Columns[4].Visible = false;
                    
         }

        private void Form1_Load(object sender, EventArgs e)
        {
            lista.RowTemplate.Height = 120;
            llenarltabla();
            barraRegistros.Text += lista.Rows.Count.ToString();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frminsertar form_Ins = new frminsertar(lista, estado);
            form_Ins.Show();            
        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
                List<string> valores = new List<string>();
                valores.Add(lista.SelectedRows[0].Cells[1].Value.ToString());
                valores.Add(lista.SelectedRows[0].Cells[2].Value.ToString());
                valores.Add(lista.SelectedRows[0].Cells[3].Value.ToString());
                valores.Add(lista.SelectedRows[0].Cells[4].Value.ToString());
                valores.Add(lista.SelectedRows[0].Cells[0].Value.ToString());
                int i = 0;
                bool salir = false;
                while (!salir)
                {
                    if (valores[0] == lista.Rows[i].Cells[1].Value.ToString())
                    {
                    salir = true;
                    }
                    if (!salir) i++;
                }
                valores.Add(i.ToString());
                frmmodificar form_mod = new frmmodificar(valores, lista);
                form_mod.Show();   
                
        }
    }
}
