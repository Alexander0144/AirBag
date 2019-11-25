$(document).ready(function () {

    if ($("#btnCerrarSesion").length > 0) {
        $("#btnCerrarSesion").click(function () {
            console.log("yes");
            $.ajax({
                type: "POST",
                url: "/Session/CerrarSesion",
                dataType: "json",
                success: function (data) {
                    if (data.mensaje === "success") {
                        window.location.replace("../Home/Index");
                        console.log(data.mensaje);
                    }
                },
                error: function (error) {
                    console.log("error " + error);
                }
            });
        });
    }
});