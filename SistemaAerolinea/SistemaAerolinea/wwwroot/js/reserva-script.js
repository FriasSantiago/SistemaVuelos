$(document).ready(function () {

    $(".cancelarForm").on("submit", e => {
        if (!confirm("¿Está seguro de que desea borrar la reserva?\nEsta acción no se puede deshacer.")) {
            e.preventDefault();
        }
    });

});