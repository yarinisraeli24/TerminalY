// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$("form#AddProductToCart").submit(function (event) {
    event.preventDefault()
    var product = $('#productId').val();
    var quantity = $('#quantity').val();
    $.ajax({
        url: "/Carts/AddToCart", 
        type: "POST",
        data: {
            productId: product,
            quantity: quantity,
        }, 
        success: function (callback) { 
            if (callback == false) {
                location.href = '/Accounts/Login/';
            }
            else
                alert("The product added to cart successfully");
        },
        error: function (callback) {
            alert("Can't add this product to cart");
        },
    });

});

$(document).ready(function () {
    $("a.dec").on("click", function () {
        var getItemId = parseInt($(this).closest('tr').prop('id'));
        var quantity = parseInt($(this).closest('div').find('input').prop('value'));
        var element = this;
        if (quantity == 0) {
            return;
        }
        $.ajax({
            type: 'POST',
            url: '/Carts/Minus',
            data: {
                id: getItemId,
            },
            success: function (data) {
                $(element).closest('tr').find("td.total-col").find('h4').text("$" + data[0] + ",00");

                $(element).closest('tr').find('input').val("" + (quantity - 1));

                $(document.getElementById('total_cost')).text("$" + data[1] + ",00");
            },
            error: function (data) {
                alert("Can't Change this cart item");
                console.log(data);
            },
            complete: function (data) {
            },
        });
    });
});

$(document).ready(function () {
    $("a.inc").on("click", function () {
        var getItemId = parseInt($(this).closest('tr').prop('id'));
        var quantity = parseInt($(this).closest('div').find('input').prop('value'));
        var element = this;

        $.ajax({
            type: 'POST',
            url: '/Carts/Plus',
            data: {
                id: getItemId,
            },
            success: function (data) {
                $(element).closest('tr').find("td.total-col").find('h4').text("$" + data[0] + ",00");

                $(element).closest('tr').find('input').val("" + (quantity + 1));

                $(document.getElementById('total_cost')).text("$" + data[1] + ",00");
            },
            error: function (data) {
                alert("Can't Change this cart item");
                console.log(data);
            },
            complete: function (data) {
            },
        });
    });
});


$('.trash').on('click', function () {
    var getItemId = parseInt($(this).closest('tr').prop('id'));
    $.ajax({
        type: 'POST',
        url: '/CartItems/Delete',
        data: {
            id: getItemId,
        },
        success: function (data) {
            document.getElementById(getItemId).remove();
            $(document.getElementById('total_cost')).text("$" + data + ",00");
        },
        error: function (data) {
            alert("Can't delete this cart item");
            console.log(data);
        },
        complete: function (data) {
        },
    });
});


