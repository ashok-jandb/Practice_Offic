const URL = "https://localhost:44393/api/products";

/*Begin: Get Products - Retrieve data using jQuery and promises*/
function get() {
    $.ajax(URL)
    .done(function (data) {
        displayMessage("Products Retrieved")
    })
    .fail(function (error) {
        handleAjaxError(error);
    })
    .always(function () {
        console.log('In the always() method');
    });
}
/*End: Get Products - Retrieve data using jQuery and promises*/

/*Begin: Get a Product Details Using jQuery and Promises */
    
/*End: Get a Product Details Using jQuery and Promises */