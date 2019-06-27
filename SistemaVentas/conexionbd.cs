using System;
using System.Windows.Forms;

using System.Data;
using System.Data.SqlClient;
using SistemaVentas.models;

public class conexionbd
{
   private SqlConnection conec = new SqlConnection();
    private SqlCommand cmd=new SqlCommand();
    private SqlDataAdapter adapter = new SqlDataAdapter();

    /// //////////////////////////////////////////////777
    public  SqlConnection conectar()
    {

       conec.ConnectionString =
            "Server= (localdb)\\localhost; Database= bdmorena;  Integrated Security=SSPI;";
        try
        {
            conec.Open();
            MessageBox.Show("Connection Exitosa ! ");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
            
        }
        return conec;
    }
    public void desconectar()
    {
        conec.Close();
    }

    ///////////////////////////////////////////////////// 

    public void execute(String sql)
    {
        cmd = new SqlCommand(sql, conectar());
        cmd.ExecuteNonQuery();
        
    }

    public  SqlDataReader read(String sql)
    {
        cmd = new SqlCommand(sql, conectar());
        
        return cmd.ExecuteReader();
        
    }
    public DataTable datosTabla(String consulta)
    {
        DataTable table = new DataTable();
        //adapter.Fill(table);
        table.Load(read(consulta));

        return table;
    }

}
