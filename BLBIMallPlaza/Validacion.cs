using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DABIMallPlaza;

namespace BLBIMallPlaza
{
    public class Validacion
    {

        public static Validacion ControlInstancia = null;
        public static Validacion GetInstance()
        {
            return ControlInstancia == null ? ControlInstancia = new Validacion() : ControlInstancia;
        }
        public int validarAccesoUsuario(string usuario, string password)
        {            
            int rpt = 0;
            Acceso obj = new Acceso();
            Acceso objDA = obj;
            rpt = objDA.validarAcceso(usuario, password);
            return rpt;
        }
    }
}
