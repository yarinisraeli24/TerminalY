
$('.site-btn').on('click', function (Model) {
    var min = "0";
    var max = $('#myRange').val().toString();
    console.log(min,max);

    var cat = location.href.substr(location.href.lastIndexOf('/') + 1);

    $.ajax({

        url: '/Categories/SearchByPriceAndCategory',
        data:
        {
            minamount: min,
            maxamount: max,
            category: cat
        },
        dataType: "JSON",
        success: function (data) {
            $('#tbody').empty();
            $('#results').tmpl(data).appendTo('#tbody');
        },
        error: function (data) {
            alert("Noo");
            console.log(data);
        },

    });
});

$(document).on('input change', '#myRange', function () {
    $('#slider-value').html($(this).val());
});
