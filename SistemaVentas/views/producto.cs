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
    public partial class producto : Form
    {
        //Producto newProd;
        CrudProducto crudProduct = new CrudProducto();
        Producto newProduc = new Producto();
        public producto()
        {
            InitializeComponent();
        }

        private void inventario_Load(object sender, EventArgs e)
        {
            panelNuevoProducto.Visible = false;
            // TODO: esta línea de código carga datos en la tabla 'bdmorenaDataSet1.Producto' Puede moverla o quitarla según sea necesario.
            DataTable table = new DataTable();
            table = crudProduct.verTabla("Producto");
            if (table.Rows.Count > 0)
            {
                dataGridProd.Rows.Clear();
                dataGridProd.RowCount = table.Rows.Count;
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    dataGridProd[0, i].Value = Convert.ToString(table.Rows[i].ItemArray[0]);
                    dataGridProd[1, i].Value = Convert.ToString(table.Rows[i].ItemArray[1]);
                    dataGridProd[2, i].Value = Convert.ToString(table.Rows[i].ItemArray[2]);
                    dataGridProd[3, i].Value = Convert.ToString(table.Rows[i].ItemArray[3]);
                    dataGridProd[4, i].Value = Convert.ToString(table.Rows[i].ItemArray[4]);
                    dataGridProd[5, i].Value = Convert.ToString(table.Rows[i].ItemArray[5]);
                }
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="" && textBox2.Text!="" && textBox3.Text!= "")
            {
                string codigo = textBox1.Text;
                double precio = double.Parse(textBox2.Text);
                int stock = int.Parse(textBox3.Text);
                int talla = int.Parse(comboBox3.Text);
                string marca = comboBox2.Text;
                string categoria = comboBox4.Text;
                string proveedor = comboBox1.Text;
                Producto tempProd = new Producto(codigo, precio, stock, talla, marca, categoria, proveedor);

                crudProduct.NuevoPro(tempProd);
                panelNuevoProducto.Visible = false;
            }
            else
            {
                MessageBox.Show("Complete los campos", "Producto Nuevo");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //BUSCAR
            DataTable table = new DataTable();
            table = crudProduct.BuscarPro(txtBuscarProd.Text);
            if (table.Rows.Count > 0)
            {
                dataGridProd.Rows.Clear();
                dataGridProd.RowCount = table.Rows.Count;
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    dataGridProd[0, i].Value = Convert.ToString(table.Rows[i].ItemArray[0]);
                    dataGridProd[1, i].Value = Convert.ToString(table.Rows[i].ItemArray[1]);
                    dataGridProd[3, i].Value = Convert.ToString(table.Rows[i].ItemArray[3]);
                    dataGridProd[4, i].Value = Convert.ToString(table.Rows[i].ItemArray[4]);
                    dataGridProd[5, i].Value = Convert.ToString(table.Rows[i].ItemArray[5]);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panelNuevoProducto.Visible = true;
        }

        private void panelNuevoProducto_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelNuevoProducto.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            foreach (DataGridViewRow row in dataGridProd.SelectedRows)
            {
                newProduc.IdProducto = row.Cells[0].Value.ToString();

            }
            crudProduct.BorrarPro(newProduc.IdProducto);
        }
            private void button3_Click(object sender, EventArgs e)
        {            
            crudProduct.EditarPro(newProduc);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            panelNuevoProducto.Visible = true;
            foreach (DataGridViewRow row in dataGridProd.SelectedRows)
            {
                newProduc.IdProducto = row.Cells[0].Value.ToString();
                newProduc.Marca = row.Cells[1].Value.ToString();
                newProduc.Precio = double.Parse(row.Cells[2].Value.ToString());
                newProduc.Stock = int.Parse(row.Cells[3].Value.ToString());
                newProduc.Talla = int.Parse(row.Cells[4].Value.ToString());
                newProduc.Categoria = row.Cells[5].Value.ToString();
                //newProduc.Proveedor = row.Cells[6].Value.ToString();
            }

            textBox1.Text = newProduc.IdProducto;
            textBox2.Text = newProduc.Precio.ToString();
            textBox3.Text = newProduc.Stock.ToString();
            comboBox3.Text = newProduc.Talla.ToString();
            comboBox2.Text = newProduc.Marca;
            comboBox4.Text = newProduc.Categoria;
            //comboBox1.Text = newProduc.Proveedor;

        }
    }
}
