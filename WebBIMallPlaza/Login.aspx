
<%@ Page Language="C#" MasterPageFile="~/MasterLogin.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebBIMallPlaza.Login" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="Content/Login.css" type="text/css" rel="stylesheet"/>
    <script src="js/JSPrincipal.js" type="text/javascript"></script>
    <script src="Scripts/jquery.js" type="text/javascript"></script>
    <script src="Scripts/jquery-1.10.2.js"></script>
    <script src="Scripts/jquery-1.10.2.min.js"></script>
    <script src="Scripts/WebForms/MSAjax/MicrosoftAjax.js"></script>
     <meta name="viewport" content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0" />
    <div class="login" >
        <p></p>
        <h1>Iniciar Sesión</h1>
        <p><input  type="text" id="txtUser" name="login" runat="server" placeholder="Usuario" maxlength="20"/></p>
        <p><input  type="password" id="txtPass" name="password" runat="server" placeholder="Contraseña" maxlength="15"/></p>
        <p><label id="pError" class="miLabelError"></label></p>
        <p style="text-align:center;margin: 25px 0 0;" >
          <asp:Button CssClass="submit" id="btnIngresar" Text="Ingresar" runat="server" OnClick="btnIngresar_Click"/>
        </p>       
    </div>
    <script type="text/javascript">
        $(document).ready(function () {
            $('#<%= btnIngresar.ClientID%>').click(function (event) {

                var user = $('#<%=txtUser.ClientID%>').val();
                var pass = $('#<%=txtPass.ClientID%>').val();

                if (user == "" || user == null) {
                    pError('Por favor ingrese su usuario.');
                    $('#<%=txtUser.ClientID%>').focus();
                    return false;
                } else if (pass == "" || pass == null) {
                    pError('Por favor ingrese la contraseña.');
                    $('#<%=txtPass.ClientID%>').focus();
                    return false;
                }
                var existeSesion = Get_Login_ExisteSesion(user, pass); //Async para que devuelva una respuesta si no no avance
                if (existeSesion == 1) {
                    document.body.style.cursor = 'wait';  //Estilo del cursor
                    return true;
                } else {
                    pError('El Usuario o contraseña es incorrecto');
                    return false;
                }
            });

            function pError(msg) {
                $('#pError').html(msg);
            }
        });
    </script>

</asp:Content>

