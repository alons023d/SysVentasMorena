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
using SistemaVentas.models;

namespace SistemaVentas.views
{
    public partial class frmFactura : Form
    {
        CrudCliente crudClient = new CrudCliente();
        CrudProducto crudProduct = new CrudProducto();
        public frmFactura()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmFactura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bdmorenaDataSet2.Producto' Puede moverla o quitarla según sea necesario.
            

            DataTable table = new DataTable();
            table = crudProduct.verTabla("Producto");
            if (table.Rows.Count > 0)
            {
                dataGridBusqueda.Rows.Clear();
                dataGridBusqueda.RowCount = table.Rows.Count;
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    dataGridBusqueda[0, i].Value = Convert.ToString(table.Rows[i].ItemArray[0]);
                    dataGridBusqueda[1, i].Value = Convert.ToString(table.Rows[i].ItemArray[1]);
                    dataGridBusqueda[2, i].Value = Convert.ToString(table.Rows[i].ItemArray[2]);
                    dataGridBusqueda[3, i].Value = Convert.ToString(table.Rows[i].ItemArray[3]);
                    dataGridBusqueda[4, i].Value = Convert.ToString(table.Rows[i].ItemArray[4]);
                    dataGridBusqueda[5, i].Value = Convert.ToString(table.Rows[i].ItemArray[5]);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table = crudProduct.BuscarPro(txtBuscarProduc02.Text);
            if (table.Rows.Count > 0)
            {
                dataGridBusqueda.Rows.Clear();
                dataGridBusqueda.RowCount = table.Rows.Count;
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    dataGridBusqueda[0, i].Value = Convert.ToString(table.Rows[i].ItemArray[0]);
                    dataGridBusqueda[1, i].Value = Convert.ToString(table.Rows[i].ItemArray[1]);
                    dataGridBusqueda[2, i].Value = Convert.ToString(table.Rows[i].ItemArray[2]);
                    dataGridBusqueda[3, i].Value = Convert.ToString(table.Rows[i].ItemArray[3]);
                    dataGridBusqueda[4, i].Value = Convert.ToString(table.Rows[i].ItemArray[4]);
                    dataGridBusqueda[5, i].Value = Convert.ToString(table.Rows[i].ItemArray[5]);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelBuscarCliente.Visible = false;
        }

        private void btnRegisCliente_Click(object sender, EventArgs e)
        {
            if (textDNICli.Text != "" && textNomCli.Text != "" && textApeCli.Text != "" && textDirecCli.Text != "" && textFonoCli.Text != "")
            {
                Cliente cliente = new Cliente();
                cliente.Dni = textDNICli.Text;
                cliente.Nombre = textNomCli.Text;
                cliente.Apellido = textApeCli.Text;
                cliente.Direccion = textDirecCli.Text;
                cliente.Telefono = textFonoCli.Text;
                crudClient.NuevoCli(cliente);
            }
            else
            {
                MessageBox.Show("Complete los campos", "Producto Nuevo");
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table = crudClient.BuscarCli(txtCliente.Text);
            if (table.Rows.Count > 0)
            {
                dataGridCliente.Rows.Clear();
                dataGridCliente.RowCount = table.Rows.Count;
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    dataGridCliente[0, i].Value = Convert.ToString(table.Rows[i].ItemArray[0]);
                    dataGridCliente[1, i].Value = Convert.ToString(table.Rows[i].ItemArray[1]);
                    dataGridCliente[2, i].Value = Convert.ToString(table.Rows[i].ItemArray[2]);
                    dataGridCliente[3, i].Value = Convert.ToString(table.Rows[i].ItemArray[3]);
                    dataGridCliente[4, i].Value = Convert.ToString(table.Rows[i].ItemArray[4]);
                    dataGridCliente[5, i].Value = Convert.ToString(table.Rows[i].ItemArray[5]);
                }
            }
        }

      
    }
}
