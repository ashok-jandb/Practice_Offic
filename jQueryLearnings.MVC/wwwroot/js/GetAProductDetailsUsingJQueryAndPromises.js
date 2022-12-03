function getProduct() {
    const URL = "https://localhost:44393/api/products";
    productId = getValue("productID");

    $.ajax(URL + "/" + productId)
        .done(function (data) {
            displayMessage("Product Retrieved");
            console.log(data);
            setInput(data);
        })
        .fail(function (error) {
            handleAjaxError(error);
        })
        .always(function () {
            console.log('In the always() method');
        });
}