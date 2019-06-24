using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SistemaVentas.views
{
    public partial class inicio : Form
    {

        public inicio()
        {
            InitializeComponent();

        }
        //mover
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd,int wmsg, int wparam,int lparam);

        private void AbrirFormPanel(object frmHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
            
                this.panelContenedor.Controls.RemoveAt(0);
                Form frm = frmHijo as Form;
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                this.panelContenedor.Controls.Add(frm);
                this.panelContenedor.Tag = frm;
                frm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
        }

        private void inicio_Load(object sender, EventArgs e)
        {
            btnMax.Visible = false;
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new producto());
        }

        //private void btnMax_Click(object sender, EventArgs e)
        //{
        //    this.WindowState = FormWindowState.Maximized;
        //    btnRestaurar.Visible = true;
        //    btnMax.Visible = false;
        //}

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //private void btnRestaurar_Click(object sender, EventArgs e)
        //{
        //    this.WindowState = FormWindowState.Normal;
        //    btnRestaurar.Visible = false;
        //    btnMax.Visible = true;
        //}
        
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new frmFactura());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new cliente());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new Proveedor());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new Empleado());
        }
    }
}
