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
    public partial class frmmodificar : Form
    {
        private List<string> valores;
        public DataGridView lista;
        db datos = new db();
        public frmmodificar(List<string> valores, DataGridView lista)
        {
            InitializeComponent();
            this.valores = valores;
            this.lista = lista;
            txtnombre.Text = valores[0];
            txtapellidos.Text = valores[1];
            txtdni.Text = valores[2];
            pboximg.ImageLocation = Application.StartupPath + "\\fotos\\" + valores[3];
            pboximg.Tag = valores[3];
        }

        private void asignar_valores()
        {
            valores[0] = txtnombre.Text;
            valores[1] = txtapellidos.Text;
            valores[2] = txtdni.Text;
            valores[3] = pboximg.Tag.ToString();
        }


        private void frmmodificar_Load(object sender, EventArgs e)
        {
         
        }

        private void actualizarLista()
        {
            int index = int.Parse(valores[5]);
            lista.Rows[index].Cells[1].Value = valores[0];
            lista.Rows[index].Cells[2].Value = valores[1];
            lista.Rows[index].Cells[3].Value = valores[2];
            lista.Rows[index].Cells[4].Value = valores[3];
            lista.Rows[index].Cells[5].Value = pboximg.Image;
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            asignar_valores();
            bool resultado = datos.Controlar_errores(valores);
            if (!resultado)
            {
                datos.modifcar(valores);
                actualizarLista();
            }          
        }

        private void btncargarimg_Click(object sender, EventArgs e)
        {
            Dialimg.Filter = "Imagenes (*.jpg, *.jpeg, *.jpe, *.gif, *.png) | *.jpg; *.jpeg; *.jpe; *.gif; *.png";
            Dialimg.ShowDialog();
            pboximg.ImageLocation = Dialimg.FileName;
            pboximg.Tag = Dialimg.SafeFileName;
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
    }
}
