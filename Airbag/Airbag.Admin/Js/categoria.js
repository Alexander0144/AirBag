$('#sampleTable').DataTable();

$('#desactivarCategoria').click(function () {
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
            swal("¡Desactivado!", "La categoría se ha desactivado.", "success");
        } else {
            swal("Cancelado", " :)", "error");
        }
    });
});

$('#activarCategoria').click(function () {

    swal({
        position: 'center',
        type: 'success',
        title: '¡Activado!',
        showConfirmButton: false,
        timer: 1500
    })

});

