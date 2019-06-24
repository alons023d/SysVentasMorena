using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using SistemaVentas.models;
using System.Threading.Tasks;
using System.Data;

namespace SistemaVentas.datos
{
    class CrudProducto:conexionbd
    {

        public DataTable verTabla(String texto)
        {
            string SQL = "select * from " + texto + "  ;";
            DataTable tabla = this.datosTabla(SQL);
            this.desconectar();
            return tabla;
        }

        public void NuevoPro(Producto producto)
        {
            string SQL = "Insert into Producto(id_producto, Marca, Precio, Stock, Talla, Categoria, id_proveedor) VALUES ('" + producto.IdProducto 
                + "', '" + producto.Marca + "', '" + producto.Precio + "', '" + producto.Stock + "', '" + producto.Talla + "', '" + producto.Categoria 
                + "','" + producto.Proveedor + "');";
            this.execute(SQL);
            this.desconectar();
        }

        public DataTable BuscarPro(String texto)
        {
            string SQL = "select * from Producto where Marca LIKE  '%" + texto + "%' or id_producto LIKE '%" + texto + "%' or Categoria LIKE  '%" + texto + "%' ;";
            DataTable tabla= this.datosTabla(SQL);
            this.desconectar();
            return tabla;
        }

        public void EditarPro(Producto producto)
        {
            string SQL = "update Producto set Marca= '" + producto.Marca + "',Precio = " + producto.Precio 
                + ",Stock = " + producto.Stock + ",Talla = " + producto.Talla + ",Categoria = " + producto.Categoria 
                + " where id_producto = '" + producto.IdProducto+"';";
            this.execute(SQL);
            this.desconectar();
        }
        public void BorrarPro(String idproducto)
        {
            string SQL = "delete from Producto where id_producto = " + idproducto;
            this.execute(SQL);
            this.desconectar();
        }
    }
}
