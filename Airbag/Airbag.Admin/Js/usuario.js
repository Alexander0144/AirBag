$('#sampleTable').DataTable()

$('#DesactivarUsuario').click(function () {
    swal({
        title: "¿Está seguro?",
        type: "warning",
        showCancelButton: true,
        confirmButtonText: "Aceptar",
        cancelButtonText: "Cancelar",
        closeOnConfirm: false,
        closeOnCancel: false
    }, function (isConfirm) {
        if (isConfirm) {
            swal("¡Desactivado!", "El usuario se ha desactivado.", "success");
        } else {
            swal("Cancelado", " :)", "error");
        }
    });
});

$('#ActivarUsuario').click(function(){

    swal("¡Activado!", "El usuario se ha activado", "success")

})