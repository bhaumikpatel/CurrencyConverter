$(function () {

    $('#amount').bind('keyup', function (e) {
        comman();
    });

    $('#FromValue, #ToValue').live('change', function () {
        comman();
    });

    $('.topconvert').live('click', function () {
        var from = $(this).attr('from');
        var to = $(this).attr('to');
        $('#FromValue').val(from);
        $('#ToValue').val(to);
        $('#submit').click();
    });

    $('#swap').live('click', function () {
        var from = $('#FromValue').val();
        var to = $('#ToValue').val();
        $('#FromValue').val(to)
        $('#ToValue').val(from);
        comman();
    });

    $('#submit').click(function () {

        if ($('#curForm').valid()) {
            var errormsg = "";
            var amount = $('#amount').val();
            var from = $('#FromValue').val();
            var to = $('#ToValue').val();
            console.log(amount + " + " + from + " + " + to);
            $.ajax({ type: "POST",
                url: "/Home/Converter",
                data: "{amount:'" + amount + "',fromCurrency:'" + from + "',toCurrency:'" + to + "'}",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                beforeSend: function () {
                    $("#error").hide();
                    $('#results').addClass("loader");
                },
                success: function (data) {
                    $('.valgoogle').html($('#amount').val() + " " + $('#FromValue').val() + " = " + data[0] + " " + $('#ToValue').val());
                    $('.valyahoo').html($('#amount').val() + " " + $('#FromValue').val() + " = " + data[1] + " " + $('#ToValue').val());
                    $('#results').removeClass("loader");
                },
                error: function (jqXHR, exception) {
                    if (jqXHR.status === 0) {
                        errormsg = 'Not connect.\n Verify Network.'; ;
                    } else if (jqXHR.status == 404) {
                        errormsg = 'Requested page not found. [404]'; ;
                    } else if (jqXHR.status == 500) {
                        errormsg = 'Internal Server Error [500].'; ;
                    } else if (exception === 'parsererror') {
                        errormsg = 'Requested JSON parse failed.'; ;
                    } else if (exception === 'timeout') {
                        errormsg = 'Time out error.'; ;
                    } else if (exception === 'abort') {
                        errormsg = 'Ajax request aborted.'; ;
                    } else {
                        errormsg = 'Uncaught Error. refresh page.';
                    }

                    $("#error").show();
                    $('#errorResults').html(errormsg);
                }
            });
        }
        return false;
    });

});

function comman() {
    if ($('#amount').val() != "") {
        $('.valgoogle').html($('#amount').val() + " " + $('#FromValue').val() + " = " + $('#ToValue').val());
        $('.valyahoo').html($('#amount').val() + " " + $('#FromValue').val() + " = " + $('#ToValue').val());
    }
    else {
        $('.valgoogle,.valyahoo').html('');
    }
}