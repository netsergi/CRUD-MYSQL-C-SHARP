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
        public frminsertar()
        {
            InitializeComponent();
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

        private void btninsertar_Click(object sender, EventArgs e)
        {
            db datos = new db();
            List<string> valores = new List<string>();
            valores.Add(txtnombre.Text);
            valores.Add(txtapellidos.Text);
            valores.Add(txtdni.Text);
            valores.Add(Dialimg.SafeFileName);
            datos.insertar(valores);
        }
    }
}
