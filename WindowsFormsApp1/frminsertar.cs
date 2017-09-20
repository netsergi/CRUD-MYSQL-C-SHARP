using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frminsertar : Form
    {
        public DataGridView lista;
        public ToolStrip estado;
        db datos = new db();
        List<string> valores = new List<string>();

        public frminsertar(DataGridView lista, ToolStrip estado)
        {
            InitializeComponent();
            this.lista = lista;
            this.estado = estado;
        }

        private void btncargarimg_Click(object sender, EventArgs e)
        {
            Dialimg.Filter = "Imagenes (*.jpg, *.jpeg, *.jpe, *.gif, *.png) | *.jpg; *.jpeg; *.jpe; *.gif; *.png";
            Dialimg.ShowDialog();
            pboximg.ImageLocation = Dialimg.FileName;
            string imgpath = Application.StartupPath + "\\fotos\\" + Dialimg.SafeFileName;
            if (!String.IsNullOrEmpty(Dialimg.FileName))
            {
                if (!System.IO.File.Exists(imgpath)) System.IO.File.Copy(Dialimg.FileName, imgpath);
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void asignar_valores()
        {
            valores.Add(txtnombre.Text);
            valores.Add(txtapellidos.Text);
            valores.Add(txtdni.Text);
            valores.Add(Dialimg.SafeFileName);
        }

        private void actualizar_lista(DataTable dt)
        {
            lista.DataSource = null;
            lista.Columns.Clear();
            lista.DataSource = dt;
            lista.Columns[0].Visible = false;
            lista.Columns[4].Visible = false;
            Form1 frm_ini = new Form1();
            frm_ini.Generar_ColFotos(dt, lista);
            estado.Items["barraRegistros"].Text = "Total Registros: " + lista.Rows.Count;
            this.Close();
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            asignar_valores();
            bool resultado = datos.Controlar_errores(valores);
            if (!resultado)
            {
                datos.insertar(valores);
                DataTable dt = datos.cargar();
                actualizar_lista(dt);
            }
        }

        private void frminsertar_Load(object sender, EventArgs e)
        {

        }
    }
}
