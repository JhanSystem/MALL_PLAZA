using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BEBIMallPlaza;

namespace DABIMallPlaza.Proyecto
{
    public class DAProyecto
    {
        private SqlConnection con;
        private SqlCommand com;
        private SqlDataReader dr;

        public List<BEProyecto> Proyectos_Listar()
        {
            string Cadena = Conexion.CadenaConexion();
            List<BEProyecto> objLista = new List<BEProyecto>();
            try
            {
                con = new SqlConnection(Cadena);
                con.Open();
                com = new SqlCommand("proc_ListarProyectos", con);
                com.CommandType = CommandType.StoredProcedure;
                com.CommandTimeout = 0;
                using (dr = com.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        BEProyecto objBE = new BEProyecto();
                        objBE.IDProyecto = dr[0].ToString();
                        objBE.ProyectoNombre = dr[1].ToString();
                        objBE.ProyectoMall = dr[2].ToString();
                        objBE.ProyectoTipo = dr[3].ToString();
                        objBE.ProyectoEstado = dr[4].ToString();
                        objBE.ProyectoCartera = dr[5].ToString();
                        objBE.ProyectoAreaTerreno = Convert.ToDecimal(dr[6]);
                        objBE.ProyectoM2Construidos = Convert.ToDecimal(dr[7]);
                        objBE.ProyectoM2Arrendables = Convert.ToDecimal(dr[8]);
                        objBE.ProyectoEjecucionObras = Convert.ToInt32(dr[9]);
                        objLista.Add(objBE);
                    }
                    dr.Close();
                }
            }
            catch
            {
                objLista = null;
            }finally
            {
                con.Close();
                con.Dispose();
            }
            return objLista;
        }
    }
}
