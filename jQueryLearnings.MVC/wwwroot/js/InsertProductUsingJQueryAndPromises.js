function insertProduct() {
    const URL = "https://localhost:44393/api/products";
    let product = getFromInput();

    $.ajax({
        url: URL,
        type: "POST",
        contentType: "application/json",
        data: JSON.stringify(product)
    })
        .done(function (data) {
            displayMessage('Product Inserted');
            console.log(data);
            setInput(data);
        })
        .fail(function (error) {
            handleAjaxError(error);
        })
        .always(function () {
            //Gets called everytime
        });
}
