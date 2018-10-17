using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DABIMallPlaza
{
    public class Acceso
    {
        public int validarAcceso(string usuario, string password)
        {
            int rpta = 0;
            string resp = "";
            SqlConnection conexion = new SqlConnection();
            SqlCommand comand = new SqlCommand();
            SqlConnection con = conexion;
            SqlCommand com = comand;
            con = new SqlConnection(DABIMallPlaza.Conexion.CadenaConexion());
            try
            {

                con.Open();
                com = new SqlCommand("proc_ValidarAcceso", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add("@codPersona", SqlDbType.VarChar, 15).Value = usuario;
                com.Parameters.Add("@password", SqlDbType.VarChar, 15).Value = password;
                com.Parameters.Add("@respuesta", SqlDbType.VarChar, 2).Direction = ParameterDirection.Output;
                com.ExecuteNonQuery();
                //nombre = Convert.ToString(com.Parameters["@Nombre"].Value.ToString());
                //periodo = Convert.ToInt32(com.Parameters["@Periodo"].Value.ToString());
                resp = com.Parameters["@respuesta"].Value.ToString();
                com.CommandTimeout = 0;
                if (resp == "NO") rpta = 0;
                else rpta = 1;
                return rpta;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }
    }
}
