using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.models
{
    class Cliente
    {
        private String idCliente;
        private String dni;
        private String nombre;
        private String apellido;
        private String direccion;
        private String telefono;

        public Cliente() { }
        public Cliente(string idCliente, string dni, string nombre, string apellido, string direccion, string telefono)
        {
            this.IdCliente = idCliente;
            this.Dni = dni;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Direccion = direccion;
            this.Telefono = telefono;
        }

        public string IdCliente { get => idCliente; set => idCliente = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
    }
}
