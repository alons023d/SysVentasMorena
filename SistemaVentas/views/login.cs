using MySql.Data.MySqlClient;
using SistemaVentas.datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas.views
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Validator val=new Validator();
            if(val.login(textBox1.Text, textBox2.Text)){
                this.Hide();
                inicio ss = new inicio();
                ss.Show();
            }
            else
            {
                MessageBox.Show( "Ingresede nuevo el usuario y contraseña ","Usuario invalido");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //conexionbd cerrar = this.desconectar();
            this.Close();
        }
        public void cerrar()
        {
            this.Close();
        }
    }
}
