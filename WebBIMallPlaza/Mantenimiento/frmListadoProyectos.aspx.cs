using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BEBIMallPlaza;
using BLBIMallPlaza.Proyecto;

namespace WebBIMallPlaza.Mantenimiento
{
    public partial class frmListadoProyectos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Proyectos_Listar();
        }
        void Proyectos_Listar()
        {
            List<BEProyecto> objLista = new List<BEProyecto>();
            BLProyecto objBL = new BLProyecto();
            objLista = objBL.Proyectos_Listar();

            this.gvProyectos.AutoGenerateColumns = false;
            this.gvProyectos.DataSource = objLista;
            this.gvProyectos.DataBind();
        }
        protected void gvProyectos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}