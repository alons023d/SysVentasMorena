using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaVentas.models;



namespace SistemaVentas.datos
{
    class Validator:conexionbd
    {
        
        
        public bool login(String user, String password)
        {
            //conexionbd con = new SqlConnection();
            SqlDataReader r = this.read("select * from empleados where nombre= '" + user + "' and pass= '" + password+"';");
            
            if (r.Read() )
            {
                desconectar();
                return true;
                
            }
            else
            {
                desconectar();
                return false;
            }       
        }

    }
}
