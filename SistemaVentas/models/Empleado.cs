using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.models
{
    class Empleado
    {
        private int idEmpleado;
        private string nomEmpleado;
        private string apeEmpleado;
        private string dirEmpleado;
        private string teleEmpleado;
        private string passEmpleado;

        public Empleado() { }

        public Empleado(int idEmpleado, string nomEmpleado, string apeEmpleado, string dirEmpleado, string teleEmpleado, string passEmpleado)
        {
            this.idEmpleado = idEmpleado;
            this.nomEmpleado = nomEmpleado;
            this.apeEmpleado = apeEmpleado;
            this.dirEmpleado = dirEmpleado;
            this.teleEmpleado = teleEmpleado;
            this.passEmpleado = passEmpleado;
        }

        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public string NomEmpleado { get => nomEmpleado; set => nomEmpleado = value; }
        public string ApeEmpleado { get => apeEmpleado; set => apeEmpleado = value; }
        public string DirEmpleado { get => dirEmpleado; set => dirEmpleado = value; }
        public string TeleEmpleado { get => teleEmpleado; set => teleEmpleado = value; }
        public string PassEmpleado { get => passEmpleado; set => passEmpleado = value; }
    }
}
