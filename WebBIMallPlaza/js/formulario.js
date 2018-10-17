// Recorrer los elementos y hacer que onchange ejecute una funcion para comprobar el valor de ese input
(function () {

    //var formulario = document.formulario_registro;
    var formulario = document.getElementById('formulario');
    var elementos = formulario.elements;

    // Funcion que se ejecuta cuando el evento click es activado

    var validarInputs = function () {
        for (var i = 0; i < elementos.length; i++) {
            // Identificamos si el elemento es de tipo texto, password
            if (elementos[i].type == "text" || elementos[i].type == "password") {
                // Si es tipo texto o password vamos a comprobar que esten completados los input
                if (elementos[i].value.length == 0) {
                    console.log('El campo ' + elementos[i].name + ' esta incompleto');
                    elementos[i].className = elementos[i].className + " error";
                    return false;
                } else {
                    elementos[i].className = elementos[i].className.replace(" error", "");
                }
            }
        }

        return true;
    };

    var enviar = function (e) {
        if (!validarInputs()) {
            console.log('Falto validar los Input');
            e.preventDefault();
        } else {            
            if (ValidarLogin() == true)
            {
                alert("Bienvenido");
            }
                //{ window.location.href("Principal.aspx"); }
            else { alert("El usuario/contraseña es incorrecta. Por favor vuelva a intentarlo."); }
            //console.log('Envia');
            //e.preventDefault();
        }
    };

    var ValidarLogin = function () {
        var usuario = $('#txtusuario').val();
        var password = $('#txtpass').val();
        var EXISTEPARAMETRO;
        var params = {
            Usuario: usuario,
            Password: password
        };
        alert(usuario+"-"+password);
        $.ajax({
            type: "POST",
            data: JSON.stringify(params),
            dataType: "json",
            url: "Login.aspx/Get_Acceso",
            contentType: "application/json; chartseft:utf-8",
            success: function (response) {
                EXISTEPARAMETRO = response.d;
            },
            error:
                    function (XmlHttpError, error, description) {
                        $("#dvLogin").html(XmlHttpError.responseText);
                    },
            async: false
        });
        if (EXISTEPARAMETRO == 1)
        {
            return true;
        }
        else {
            return false;
        }
    };

    var focusInput = function () {
        this.parentElement.children[1].className = "label active";
        this.parentElement.children[0].className = this.parentElement.children[0].className.replace("error", "");
    };

    var blurInput = function () {
        if (this.value <= 0) {
            this.parentElement.children[1].className = "label";
            this.parentElement.children[0].className = this.parentElement.children[0].className + " error";
        }
    };

    // --- Eventos ---
    formulario.addEventListener("submit", enviar);

    for (var i = 0; i < elementos.length; i++) {
        if (elementos[i].type == "text" || elementos[i].type == "password") {
            elementos[i].addEventListener("focus", focusInput);
            elementos[i].addEventListener("blur", blurInput);
        }
    }
}());

