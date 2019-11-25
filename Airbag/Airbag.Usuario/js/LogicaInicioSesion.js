
function ajaxInicioSesion(correo, contraseña) {
    $.ajax({
        type: "POST",
        url: "InicarSesion",
        data: {
            correo: correo,
            contraseña: contraseña
        },
        success: function (data) {
            if (data.mensaje === "exito") {
                window.location.replace("../Home/Index");
            } else {
                window.alert(data.mensaje);
            }
        }
    });
}

$(document).ready(function () {
    console.log("yee");    

    $("#btnInicioSesionUsr").click(function () {
        let correoUsuario = $("#inputLoginCorreo").val().toString().trim();
        let contraseñaUsuario = $("#inputLoginContraseña").val().toString().trim();
        ajaxInicioSesion(correoUsuario, contraseñaUsuario);
    });
});