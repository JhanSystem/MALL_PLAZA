using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEBIMallPlaza;
using DABIMallPlaza.Proyecto;

namespace BLBIMallPlaza.Proyecto
{
    public class BLProyecto
    {
        public List<BEProyecto> Proyectos_Listar()
        {
            List<BEProyecto> objLista = new List<BEProyecto>();
            DAProyecto objDA = new DAProyecto();
            objLista = objDA.Proyectos_Listar();
            return objLista;
        }
    }
}
