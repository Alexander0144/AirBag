$(document).ready(function () {
    inicializarTabla();
    inicializarBotones();
    obtenerUsuarios();
});

let tblUsuarios; /*Variable asignada al DataTable*/
let oiIdUsuarios; /*Variable que almacena el identificador*/
let oseleccionarUsuario; /*Variable que almacena la fila seleccionada*/
let activo;/*Variable que almacena la etiqueta span */
let inactivo;/*Variable que almacena la etiqueta span*/

/**
 * Función que inicializa la tabla como DataTable con sus respectivas configuraciones.*/
function inicializarTabla() {

   tblUsuarios = $('#TablaUsuarios').DataTable({

        language: {
            url: '/Admin/Content/Assets/json/Spanish.json'
        },
        responsive: true,
        select: true,
        columns:
            [
                { "data": "iIdUsuario" },
                { "data": "cNombre" },
                { "data": "cApellidoPaterno" },
                { "data": "cApellidoMaterno" },
                { "data": "cCorreo" },
                { "data": "iEstatus" }
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

/**funcionalidad del evento on.click para seleccionar fila con estatus activo e inactivo del usuario.*/
$('#TablaUsuarios tbody').on('click', 'tr', function () {

   oseleccionarUsuario = tblUsuarios.row(this).index();

   oiIdUsuario = (tblUsuarios.row(oseleccionarUsuario).data());

    if (oiIdUsuario.iEstatus === activo) {

        tblUsuarios.$('tr.selected').removeClass('selected');
        $(this).addClass('selected');

        $('#btnactivarUsuario').attr("disabled", "true");
        $('#btndesactivarUsuario').removeAttr("disabled");

    } else {
        tblUsuarios.$('tr.selected').removeClass('selected');

        $('#btnactivarUsuario').removeAttr("disabled");
        $('#btndesactivarUsuario').attr("disabled", "true");
    }

});

/**
 * Función que tiene los eventos .click de los botones activar y desactivar usuarios.*/
function inicializarBotones() {

    $('#btnactivarUsuario').attr("disabled", "true");
    $('#btndesactivarUsuario').attr("disabled", "true");

    $('#btndesactivarUsuario').click(function () {

        swal({

            title: "¿Desea dar de baja a este usuario?",
            type: "warning",
            showCancelButton: true,
            confirmButtonText: "Aceptar",
            closeOnConfirm: false
        }, function (respuesta) {

            if (respuesta) {

                cambiarEstatusUsuario(0);
            }

            else {
                swal("Error");
            }
        })
    });

    $('#btnactivarUsuario').click(function () {

        cambiarEstatusUsuario(1);

    });
}

/**
 * Función que obtiene la lista de los datos de usuarios desde el controlador 
 * y realiza una iteración de indices para plasmar los datos en la tabla.*/
function obtenerUsuarios() {

    $.ajax({
        type: "POST",
        url: "/Admin/Usuario/ListarUsuarios",
        dataType: "json",
        success: function (respuesta) {

            tblUsuarios.clear();

            for (let i = 0; i < respuesta._olistaUsuarios.length; i++) {

               agregarDatosTabla(respuesta._olistaUsuarios[i]);
            }
        },
        error: function () {
            swal("¡Error!", respuesta._cMensaje, "error");
        }
    });
}

/**
 * Función que recibe datos de los usuarios para agregarlo en la tabla.
 * @param oData Objeto que se recibe los datos del usuario de la solicitud ajax.
 */
function agregarDatosTabla(oData) {

   activo = '<span class="badge badge-info">activo</span>';
   inactivo = '<span class="badge badge-danger">Inactivo</span>';

    let oDatosUsuario = {

        iIdUsuario: oData.iIdUsuario,
        cNombre: oData.cNombre,
        cApellidoPaterno: oData.cApellidoPaterno,
        cApellidoMaterno: oData.cApellidoMaterno,
        cCorreo: oData.cCorreo,
        iEstatus: oData.iEstatus != 0 ? activo : inactivo
    }

    tblUsuarios.row.add(oDatosUsuario).draw(false);
}

/**
 * Función que envía mediante ajax el identificador y estatus del usuario, recibiendo como respuesta el cambio y agregarlo a la tabla.
 * @param ivalorEstatus Recibe el valor de 0 y 1 para validar si activa o desactiva el usuario.
 */
function cambiarEstatusUsuario(ivalorEstatus) {

    $.ajax({
        type: "POST",
        url: "/Admin/Usuario/CambiarEstatus",
        data: { iId: oiIdUsuario.iIdUsuario, iEstatus: ivalorEstatus },
        success: function (respuesta) {

            let _scambiarEstatus; 

            ivalorEstatus === 0 ? _scambiarEstatus = inactivo : _scambiarEstatus = activo;

            if (_scambiarEstatus === inactivo) {

                swal("¡Desactivado!", respuesta._cMensaje, "success");
            } else {

                swal("¡Activado!", respuesta._cMensaje, "success");
            }

            tblUsuarios.cell({ row: oseleccionarUsuario, column: 5 }).data(_scambiarEstatus);
        },
        error: function () {

            swal("¡Error!", respuesta._cMensaje, "error");
        }
    });
}
