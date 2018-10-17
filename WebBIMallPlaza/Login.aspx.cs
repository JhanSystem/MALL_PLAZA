using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLBIMallPlaza;
using System.Web.Services;

namespace WebBIMallPlaza
{
    public partial class Login : System.Web.UI.Page
    {
        Validacion obj = new Validacion();
        protected void Page_Load(object sender, EventArgs e)
        {
            string Registro;
            int pos = 0;
            Session["Registro"] = null;
            Session["Registro"] = "";

            if (!Page.IsPostBack)
            {
                //obtener Usuario de Windows
                Registro = Request.ServerVariables["AUTH_USER"].ToString();
                pos = Registro.LastIndexOf("\\");
                Registro = Registro.Substring(pos + 1, Registro.Length - pos - 1);
                txtUser.Value = Registro.ToString();
            }

        }

        [WebMethod]
        public static int Get_Login_InicioSesionJ(string Usuario, string Password)
        {
            return  Validacion.GetInstance().validarAccesoUsuario(Usuario, Password);
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            Session["Registro"] = txtUser.Value;
            Response.Redirect("MenuPrincipal.aspx");            
        }
    }
}