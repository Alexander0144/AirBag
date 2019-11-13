$('#sampleTable').DataTable();

$("#demoSelect").select2({
    dropdownParent: $("#agregarProducto"),
    placeholder: "Busca una categoría",
});

$('#ActivarProducto').click(function () {
    swal("¡Activado!", "El producto se ha activado", "success")
});

$('#demoSwal').click(function () {
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
            swal("¡Desactivado!", "El producto se ha desactivado.", "success");
        } else {
            swal("Cancelado", " :)", "error");
        }
    });
});

window.CKEDITOR_BASEPATH = '~/Js/ckEditor/'

initSample();
initSample2();