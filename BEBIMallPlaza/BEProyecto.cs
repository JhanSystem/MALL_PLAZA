using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEBIMallPlaza
{
    public class BEProyecto
    {
        public string IDProyecto { get; set; }
        public string ProyectoNombre { get; set; }
        public string ProyectoCodMall { get; set; }
        public string ProyectoMall { get; set; }
        public string ProyectoCodTipo { get; set; }
        public string ProyectoTipo { get; set; }
        public string ProyectoCodEstado { get; set; }
        public string ProyectoEstado { get; set; }
        public string ProyectoCodCartera { get; set; }
        public string ProyectoCartera { get; set; }
        public decimal ProyectoAreaTerreno { get; set; }
        public decimal ProyectoM2Construidos { get; set; }
        public decimal ProyectoM2Arrendables { get; set; }
        public int ProyectoEjecucionObras { get; set; }
    }
}
