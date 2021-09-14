var CartController = function () {
    this.initialize = function () {
        loadData();
        registerEvents();
    };

    function loadData() {
        const culture = $('#curCulture').val();
        $.ajax({
            type: "GET",
            url: "/" + culture + '/Cart/GetListItems',
            success: function (res) {
                var html = '';
                var total = 0;

                $.each(res, function (i, item) {
                    var amount = item.price * item.quantity;
                    total += amount;
                    console.log(item.productId);
                    html += "<tr>" +
                        "<td> <img width=\"60\" src=\"" + item.thumbnailImage + "\" alt=\"\" /> </td>" +
                        "<td>" + item.description + "<br />Color : black, Material : metal</td>" +
                        "<td>" +
                        "<div class=\"input-append\">" +
                        "<input id=\"txt_quantity_" + item.productId + "\" class=\"span1 txt_quantity_in_cart\" style=\"max-width:34px\" value=\"" + item.quantity + "\" size=\"16\" type=\"text\">" +
                        "<button data-id=\"" + item.productId + "\" class=\"btn btn-minus-quantity\" type=\"button\"><i class=\"icon-minus\"></i></button>" +
                        "<button data-id=\"" + item.productId + "\" class=\"btn btn-plus-quantity\" type=\"button\"><i class=\"icon-plus\"></i></button>" +
                        "<button data-id=\"" + item.productId + "\" class=\"btn btn-danger btn-remove-product\" type=\"button\"><i class=\"icon-remove icon-white\"></i></button>" +
                        "</div>" +
                        "</td>" +
                        "<td>" + item.price + "</td>" +
                        "<td> " + amount + "</td>" +
                        "</tr>";
                });
                $('#cart_body').html(html);
                $('.lbl_total').text(total.toString());
            },
            error: function (err) {
                console.log(err);
            }
        });
    };

    function updateCart(id, quantity, isRedirect) {
        const culture = $('#curCulture').val();
        $('#txt_quantity_' + id).val(quantity.toString());
        $.ajax({
            type: "POST",
            url: "/" + culture + '/Cart/UpdateCart',
            data: {
                productId: id,
                quantity: quantity,
                isRedirect: isRedirect
            },
            success: function (res) {               
                $('.lbl_num_item_in_cart').text(res.length);
                loadData();
            },
            error: function (err) {
                console.log(err);
            }
        });
    }

    function registerEvents() {
        $('body').on('click', '.btn-minus-quantity', function (e) {
            e.preventDefault();
            const id = $(this).data('id');
            const quantity = parseInt($('#txt_quantity_' + id).val()) - 1;            
            updateCart(id, quantity, false);
        });

        $('body').on('click', '.btn-plus-quantity', function (e) {
            e.preventDefault();
            const id = $(this).data('id');
            const quantity = parseInt($('#txt_quantity_' + id).val()) + 1;            
            updateCart(id, quantity, false);
        });

        $('body').on('click', '.btn-remove-product', function (e) {
            e.preventDefault();
            const id = $(this).data('id');
            updateCart(id, 0, true);            
        });

        $('body').on('change', '.txt_quantiy_in_cart', function (e) {
            e.preventDefault();
            const id = $(this).data('id');
            const quantity = parseInt($('#txt_quantity_' + id).val());
            updateCart(id, quantity, false);
        });
    };
}