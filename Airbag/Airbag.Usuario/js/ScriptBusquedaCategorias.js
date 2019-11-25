function ajaxCargarDatosEnVistaCategorias(nombreCategoria) {
    $.ajax({
        type: "POST",
        url: "/Producto/VistaProductosEnCategoria",
        dataType: "json",
        data: { "Categoria": nombreCategoria },
        success: function (data) {

        }
    });
}

$(document).ready(function () {
    $(".licat").click(function () {
        console.log(this.textContent);

    });
});