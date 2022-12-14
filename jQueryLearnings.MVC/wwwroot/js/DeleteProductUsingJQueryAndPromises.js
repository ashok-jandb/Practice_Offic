function deleteProduct() {
    const URL = "https://localhost:44393/api/products";
    let productId = getProductIDFromInput();
    $.ajax({
        url: URL,
        type: "DELETE",
        contentType: "application/json",
        data: JSON.stringify(productId),
        cache: false
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
    return {
        "productID": parseInt(getValue("productID"))
    };
}