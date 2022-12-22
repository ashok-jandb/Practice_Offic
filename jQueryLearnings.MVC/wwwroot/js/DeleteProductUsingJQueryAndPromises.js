function deleteProduct() {
    const URL = "/api/products";
    let productId = getValue("productID")
    $.ajax({
        url: URL + "/" + productId,
        type: "DELETE",
        dataType: "json",
    })
        .done(function (data) {
            displayMessage('Product Deleted');
            console.log(data);
        })
        .fail(function (error) {
            handleAjaxError(error);
        })
        .always(function () {
            // Called everytime
        });
}

function getProductIDFromInput() {
    return parseInt(getValue("productID"))
}