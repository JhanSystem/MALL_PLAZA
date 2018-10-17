

function Get_Login_ExisteSesion(Usuario, Password) {
        var EXISTEPARAMETRO;
        var params = {
            Usuario: Usuario,
            Password: Password
        };

        $.ajax({
            type: "POST",
            data: JSON.stringify(params),
            dataType: "json",
            url: "Login.aspx/Get_Login_InicioSesionJ",
            contentType: "application/json; chartseft:utf-8",
            success: function (response) {
                EXISTEPARAMETRO = response.d;
            },
            error:
                    function (XmlHttpError, error, description) {
                        alert("error en el sistema");
                        $("#dvLogin").html(XmlHttpError.responseText);
                    },
            async: false
        });

        return EXISTEPARAMETRO;
    }
