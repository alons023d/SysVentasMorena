using SistemaVentas.datos;
using SistemaVentas.models;
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
    public partial class cliente : Form
    {
        CrudCliente crudClient = new CrudCliente();
        CrudProducto crudProduct = new CrudProducto();
        public cliente()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table = crudClient.BuscarCli(txtBuscarProduc02.Text);
            if (table.Rows.Count > 0)
            {
                dataGridListaClientes.Rows.Clear();
                dataGridListaClientes.RowCount = table.Rows.Count;
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    dataGridListaClientes[0, i].Value = Convert.ToString(table.Rows[i].ItemArray[0]);
                    dataGridListaClientes[1, i].Value = Convert.ToString(table.Rows[i].ItemArray[1]);
                    dataGridListaClientes[2, i].Value = Convert.ToString(table.Rows[i].ItemArray[2]);
                    dataGridListaClientes[3, i].Value = Convert.ToString(table.Rows[i].ItemArray[3]);
                    dataGridListaClientes[4, i].Value = Convert.ToString(table.Rows[i].ItemArray[4]);
                    dataGridListaClientes[5, i].Value = Convert.ToString(table.Rows[i].ItemArray[5]);
                }
            }
        }

        private void cliente_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table = crudProduct.verTabla("Cliente");
            if (table.Rows.Count > 0)
            {
                dataGridListaClientes.Rows.Clear();
                dataGridListaClientes.RowCount = table.Rows.Count;
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    dataGridListaClientes[0, i].Value = Convert.ToString(table.Rows[i].ItemArray[0]);
                    dataGridListaClientes[1, i].Value = Convert.ToString(table.Rows[i].ItemArray[1]);
                    dataGridListaClientes[2, i].Value = Convert.ToString(table.Rows[i].ItemArray[2]);
                    dataGridListaClientes[3, i].Value = Convert.ToString(table.Rows[i].ItemArray[3]);
                    dataGridListaClientes[4, i].Value = Convert.ToString(table.Rows[i].ItemArray[4]);
                    dataGridListaClientes[5, i].Value = Convert.ToString(table.Rows[i].ItemArray[5]);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtDNICli.Text != "" && txtNomCli.Text != "" && txtApeCli.Text != "" && txtDirecCli.Text != "" && txtTeleCli.Text != "")
            {
                Cliente cliente = new Cliente();
                cliente.Dni = txtDNICli.Text;
                cliente.Nombre = txtNomCli.Text;
                cliente.Apellido = txtApeCli.Text;
                cliente.Direccion = txtDirecCli.Text;
                cliente.Telefono = txtTeleCli.Text;
                crudClient.NuevoCli(cliente);
            }
            else
            {
                MessageBox.Show("Complete los campos", "Producto Nuevo");
            }
        }
    }
}
