using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.models
{
    class Producto
    {
        string idProducto;
        double precio;
        int stock;
        int talla;
        string marca;
        string categoria;
        string proveedor;

        public Producto() { }
        public Producto(string idProducto, double precio, int stock, int talla, string marca, string categoria, string proveedor)
        {
            this.idProducto = idProducto;
            this.precio = precio;
            this.stock = stock;
            this.talla = talla;
            this.marca = marca;
            this.categoria = categoria;
            this.proveedor = proveedor;
        }

        public string IdProducto { get => idProducto; set => idProducto = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }
        public int Talla { get => talla; set => talla = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Categoria { get => categoria; set => categoria = value; }

       

        public string Proveedor { get => proveedor; set => proveedor = value; }

        public static Producto createProducto(string id,int precio,int stock,int talla,string marca,string cateoria, string proveedor)
        {
            Producto newProducto = new Producto(id, precio, stock, talla, marca, cateoria, proveedor);
            //insert
            //DataReader 
            string sql = "'INSERT INTO bdM_Producto(idProducto, preProducto, stockProducto, tallProducto, marProducto, catProducto,proveProducto)" +
            "VALUES('" + id + "', '" + precio + "', '" + stock + "', '" + talla + "', '" + marca + "', '" + cateoria + "','" + proveedor + ");'";
            return newProducto;
        }
    }
}
