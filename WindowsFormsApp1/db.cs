using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
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
            catch (MySqlException ex)
            {
                int error = ex.Number;
                if (error == 1042)
                {
                    string stringerr = "No se puede conectar con el Servidor de la base de datos. Puede ser debido a: \n\n > Un fallo en la conexión a internet \n > Debido a una incidencia con el Servidor. ";
                    MessageBox.Show(stringerr, "ERROR AL CONECTAR CON LA BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(1);
                }
                else
                {
                    MessageBox.Show("Se ha producido el siguiente error: \n\n" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);                   
                }

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

        public void modifcar(List<string> valores)
        {
            conex.Open();
            string sql = "UPDATE usuarios SET NOMBRE='" + valores[0] + "', APELLIDOS='" + valores[1] + "', DNI='" + valores[2] + "', FOTO='" + valores[3] + "' WHERE ID = " + valores[4] +";";
            MySqlCommand sql_mod = new MySqlCommand(sql, conex);
            MySqlDataReader LeerDatos = sql_mod.ExecuteReader();
            while (LeerDatos.Read())
            { }
            conex.Close();
        
        }

        public bool Controlar_errores(List<string> valores)
        {
            bool resultado = false;
            for (int i = 0; i <= valores.Count -1; i++)
            {
                if (String.IsNullOrEmpty(valores[i]) && (i!= 3))
                {
                    MessageBox.Show("No pueden quedar campos en blanco", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultado = true;
                    break;
                }
            }
            if (!Regex.IsMatch(valores[2], @"^[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][A-Z]$"))
            {
                MessageBox.Show("El DNI no es correcto, el formato correcto es de 8 numeros y una letra.", "Error en el DNI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                resultado = true;
            }
            return resultado;
        }

        public void borrar(int id)
        {
            conex.Open();
            string sql = "DELETE FROM usuarios WHERE    ID= " + id + ";";
            MySqlCommand sql_ins = new MySqlCommand(sql, conex);
            MySqlDataReader LeerDatos = sql_ins.ExecuteReader();
            conex.Close();
        }


    }
}
