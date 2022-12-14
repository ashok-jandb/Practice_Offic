function updateProduct() {
    const URL = "https://localhost:44393/api/products";
    // Gather data from user input
    let product = getFromInput();

    //type: "POST",
    //    url: "api/RunAnalysis/LoadFramesData",                   ///// URL must be specified
    //        contentType: "application/json; charset=utf-8",
    //            dataType: "json",
    //                data: JSON.stringify(new RootData()), //this class returns a json object
    //                    cache: false,

    $.ajax({
        url: URL,
        type: "PUT",
        contentType: "application/json",
        data: JSON.stringify(product),
        cache: false
    })
        .done(function (data) {
            displayMessage("Product updated");
            console.log(data);
            setInput(data);
        })
        .fail(function (error) {
            handleAjaxError(error);
        })
        .always(function () {
            // Called everytime
        });
}
