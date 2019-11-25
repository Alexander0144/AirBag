$(document).ready(function () {
    
});

let tblCompras; 

function IniciarTabla() {

    tblCompras = $('#TablaCompras').DataTable({

        language: {
            url: '/Admin/Content/Assets/json/Spanish.json'
        },
        responsive: true,
        select: true,
        columns:
            [
                { "data": "iIdCompra" },
                { "data": "iIdUsuario" },
                { "data": "cNombre" },
                { "data": "cApellidoPaterno" },
                { "data": "cApellido Materno" },
                { "data": "dtFechaCompra" },
            ],
        columnDefs:
            [
                {
                    "targets": [0],
                    "className": "EsconderColumna"
                }
            ],

    });

}

function cargarDatosdeCompras() {

    $.ajax({
        type: "POST",
        url: "/Admin/Compra/ListadeDatosdeCompras",
        dataType: "json",
        success: function (data) {

            tblUsuarios.clear();

            for (let i = 0; i < data.listardatosCompras.length; i++) {

                agregarDatosTabla(data.listardatosCompras[i]);
            }
        },
        error: function () {

            swal("¡Error!", "jjeje", "error");
        }
    });

}

function agregarDatosComprasTabla(oData) {

    let oDatosCompras = {

        iIdCompra: oData.iIdCompra,
        iIdUsuario: oData.iIdUsuario,
        cNombre: oData.cNombre,
        cApellidoPaterno: oData.cApellidoPaterno,
        cApellidoMaterno: oData.cApellidoMaterno,
        dtFechaCompra:oData.dtFechaCompra
    }

    tblCompras.row.add(oDatosCompras).draw(false);
}

/**
 * En esta función se hace una petición ajax para obtener los datos html y mostrar el modal con los datos que se requieran
 * @param {any} cUrl La url que intentara solicitar
 * @param {any} funcionGuardar La funcion que continua el programa
 */
//function cargarModalDetalles(cUrl, funcionGuardar) {
//    $.ajax({
//        type: 'POST',
//        url: cUrl,
//        dataType: 'html',
//        async: false,
//        success: function (response) {
//            $('#modalGeneral').html(response);
//            $('#modalGeneral').modal({
//                show: true,
//                backdrop: "static"
//            });
//            ValidarCampos();
//        },
//        error: function () {
//            swal("Error no logro entrar");
//        }
//    });
//    funcionGuardar();
//}
