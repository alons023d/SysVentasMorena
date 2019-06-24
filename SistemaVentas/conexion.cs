using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
public class conexion
{
    public static MySqlConnection ObtenerConexion()
    {

        MySqlConnection conectar = new MySqlConnection("server = db4free.net; port = 3306; user = admin23; database = bdmorena; password = passadmin");
        conectar.Open();
        MessageBox.Show("SE HA CONECTADO");
        //MySqlCommand query = new MySqlCommand("SELECT * FROM dbM_Empleado WHERE nomEmpleado='" + textBox1.Text + "'AND passEmpleado='" + textBox2.Text + "' ", conectar);
        //MySqlDataReader leer = query.ExecuteReader();
        //if (leer.Read())
        //{
            
       // }
        //else
        //{
         //   MessageBox.Show("Error - Ingrese sus datos correctamente");
        //}
        conectar.Close();




        return null;
        //return conectar;
    }
    


}
