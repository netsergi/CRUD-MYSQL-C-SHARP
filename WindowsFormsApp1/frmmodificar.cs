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
        public frmmodificar(List<string> valores)
        {
            InitializeComponent();
            this.valores = valores;
        }

        private void frmmodificar_Load(object sender, EventArgs e)
        {
            txtnombre.Text  = valores[0];
            txtapellidos.Text = valores[1];
            txtdni.Text = valores[2];
            pboximg.ImageLocation = Application.StartupPath + "\\fotos\\" + valores[3];

        }
    }
}
