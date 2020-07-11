$(document).ready(function () {

    $("#card-form").on("submit", e => {

        let titular = $("[name=titular]").val();
        let nroTarjeta = $("[name=nroTarjeta]").val();
        console.log(validarNombre(titular));
        if (validarNombre(titular) && validarTarjeta(nroTarjeta)) {

        } else {
            e.preventDefault();
        }

    });

    const validarNombre = titular => /^[a-zA-Z]{4,}(?: [a-zA-Z]+){0,2}$/.test(titular);

    $(".inputTarjeta").on("keyup", () => {
        let cardIn = $(".inputTarjeta");
        let currentNum = cardIn.val()

        if (currentNum == "4") {
            $(".logoTarjeta").removeClass("fa-cc-amex");
            $(".logoTarjeta").removeClass("fa-cc-mastercard");
            $(".logoTarjeta").addClass("fa-cc-visa");
        } else if (currentNum >= 51 && currentNum <= 55) {
            $(".logoTarjeta").removeClass("fa-cc-amex");
            $(".logoTarjeta").removeClass("fa-cc-visa");
            $(".logoTarjeta").addClass("fa-cc-mastercard");
        } else if (currentNum == "34" || currentNum == "37") {
            $(".logoTarjeta").removeClass("fa-cc-visa");
            $(".logoTarjeta").removeClass("fa-cc-mastercard");
            $(".logoTarjeta").addClass("fa-cc-amex");
        } else if (cardIn.val().length == 0 || !(/\S/.test(cardIn.val()))) {
            $(".logoTarjeta").removeClass("fa-cc-visa");
            $(".logoTarjeta").removeClass("fa-cc-mastercard");
            $(".logoTarjeta").removeClass("fa-cc-amex");
        }

        if (cardIn.val().length > 0 && /\S/.test(cardIn.val())) {
            cardIn = cardIn.val().split(' ').join('');

            let dash = cardIn.match(/.{1,4}/g).join(' ');
            $(".inputTarjeta").val(dash)
        }

        validarTarjeta(currentNum);
    })

    const validarTarjeta = nro => {
        nro = nro.replace(/\s/g, '');
        if (validarVisa(nro) || validarMasterCard(nro) || validarAmericanExpress(nro)) {
            $(".logoTarjeta").css("color", "#28a745");
            return true;
        } else {
            $(".logoTarjeta").css("color", "red");
            return false;
        }
    }


    const validarVisa = nro => {
        var cardno = /^(?:4[0-9]{12}(?:[0-9]{3})?)$/;
        if (nro.match(cardno)) {
            return true;
        }
        else {
            return false;
        }
    }

    const validarMasterCard = nro => {
        var cardno = /^(?:5[1-5][0-9]{14})$/;
        if (nro.match(cardno)) {
            return true;
        }
        else {
            return false;
        }
    }

    const validarAmericanExpress = nro => {
        var cardno = /^(?:3[47][0-9]{13})$/;
        if (nro.match(cardno)) {
            return true;
        }
        else {
            return false;
        }
    }

});