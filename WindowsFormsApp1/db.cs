using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    class db
    {
        private string server = "mysql-netsergi.alwaysdata.net";
        private string usuario = "netsergi_user01";
        private string password = "admin01";
        private string nombredb = "netsergi_usuarios";
        public MySqlConnection conex;

        public db()
        {              
            string txtconexion = String.Format("SERVER={0};DATABASE={1};UID={2};PASSWORD={3};", server, nombredb, usuario, password);
            conex = new MySqlConnection(txtconexion);          
        }

        public DataTable cargar()
        {

            DataTable datos = new DataTable();
            try
            {
                conex.Open();
                string sql = "SELECT * FROM usuarios;";
                MySqlCommand cmd = new MySqlCommand(sql, conex);
                MySqlDataReader rmysql = cmd.ExecuteReader();
                datos.Load(rmysql);
                conex.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido el siguiente error: \n\n" + ex.GetType().ToString() + ":\n\n" + ex.Message.ToString(),"error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }            
            return datos;
        }

        public void insertar (List<string> valores)
        {
            conex.Open();
            string sql = "INSERT INTO usuarios (NOMBRE,APELLIDOS,DNI,FOTO) VALUES ('" + valores[0] + "','" + valores[1] + "','" + valores[2] + "','" + valores[3] + "');";
            MySqlCommand sql_ins = new MySqlCommand(sql, conex);
            MySqlDataReader LeerDatos = sql_ins.ExecuteReader();
            conex.Close();
        }


    }
}
