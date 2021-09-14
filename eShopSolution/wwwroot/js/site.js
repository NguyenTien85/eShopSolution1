var SiteControler = function () {
    this.Initialize = function () {
        registerEvents();
    };

    function registerEvents() {
        $('body').on('click', '.btn-add-cart', function (e) {
            e.preventDefault();
            const id = $(this).data('id');
            const culture = $('#curCulture').val();
            $.ajax({
                type: "POST",
                url: "/" + culture + '/Cart/AddToCart',
                data: {
                    productId: id,
                    languageId: culture
                },
                success: function (res) {
                    var NoItems = res.length;
                    $('.lbl_num_item_in_cart').text(NoItems);
                    console.log(res)
                },
                error: function (err) {
                    console.log(err);
                }
            });
        });
    };
}
// Write your JavaScript code.