/* Begin: Insert Product using $.ajax method */
const URL = "https://localhost:44393/api/products";
let product = getFromInput();

function loadHeaderHtml() {
    let headerContentUrl = 'https://localhost:44393/StaticContent/header.html';
    $('#header').load(headerContentUrl);
}

function insertProduct() {
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
/* End: Insert Product using $.ajax method */

/* Begin: Insert Product using $.post method */
/*function insertProduct() {
    let settings = {
        url: URL,
        contentType: 'application/json',
        data: JSON.stringify(product)
    }
    $.post(settings)
        .done(function (data) {
            displayMessage('Product Inserted');
            console.log(data);
            setInput(data);
        })
        .fail(function (error) {
            handleAjaxError(error);
        })
        .always(function () {
            console.log('In the always() method');
        });
}*/
/* End: Insert Product using $.post method */