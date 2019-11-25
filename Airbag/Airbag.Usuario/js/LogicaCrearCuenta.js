
function ajaxRegistrarUsuario(usuario) {
    $.ajax({
        type: "POST",
        url: "RegistrarUsuario",
        data: usuario,
        success: function (data) {
            if (data.estatus) {
                window.location.replace("InicioSesion");
            } else {
                alert(data.message);
            }
        }
    });
}

$(document).ready(function () {
    console.log("yee");

    $("#btnRegistrarUsr").click(function () {
        //debugger;
        //window.alert("hello world");
        let usuario = {
            iIdUsuario: null,
            iEstatus: true,
            cNombre: $("#txtNombreRegUsuario").val().toString().trim(),
            cApellidoPaterno: $("#txtApellidoPaternoRegUsuario").val().toString().trim(),
            cApellidoMaterno: $("#txtApellidoMaternoRegUsuario").val().toString().trim(),
            cCorreo: $("#txtCorreoRegUsuario").val().toString().trim(),
            cContrasenia: $("#contraseñaRegUsr").val().toString().trim()
        }
        let contraseña = $("#contraseñaRegUsr").val().toString().trim();
        let contraseñaConf = $("#confContrsñRegUsr").val().toString().trim();

        if (contraseña === contraseñaConf) {
            if (contraseña != "") {
                ajaxRegistrarUsuario(usuario);
            } else {
                window.alert("no dejar campos vacios");
            }
        } else {
            window.alert("las contraseñas no coinciden");
        }
    });
});