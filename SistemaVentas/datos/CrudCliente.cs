using SistemaVentas.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.datos
{
    class CrudCliente:conexionbd
    {
       public void NuevoCli(Cliente cliente)
        {
            string SQL = "Insert into Cliente(dni, Nombre, Apellido, Direccion, Telefono) VALUES ('" + cliente.Dni
                + "', '" + cliente.Nombre + "', '" + cliente.Apellido + "', '" + cliente.Direccion + "', '" + cliente.Telefono  + "');";
            this.execute(SQL);
            this.desconectar();
        }

        public DataTable BuscarCli(String texto)
        {
            string SQL = "select * from Cliente where dni LIKE  '" + texto + "%' or Nombre LIKE '%" + texto + "%' or Apellido LIKE  '%" + texto + "%' ;";
            DataTable tabla = this.datosTabla(SQL);
            this.desconectar();
            return tabla;
        }

        public void EditarPro(Cliente cliente)
        {
            string SQL = "update Producto set dni= '" + cliente.Dni + "',Nombre = '" + cliente.Nombre
                + "',Apellido = '" + cliente.Apellido + "',Direccion = '" + cliente.Direccion + "',Telefono = '" + cliente.Telefono+"';" ;
            this.execute(SQL);
            this.desconectar();
        }
        public void BorrarPro(Cliente cliente)
        {
            string SQL = "delete from Producto where id_producto = '" + cliente.IdCliente+"';";
            this.execute(SQL);
            this.desconectar();
        }
    }
}
