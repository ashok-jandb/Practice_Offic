function CorrectTryCatch() {
    const URL = "https://localhost:44393/api/products";
    $.ajax({
        url: URL,
        type: 'GET',
        contentType: 'application/json'
    })
        .done(function (data) {
            // try...catch can be in each promise method
            try {
                console.log(data);
            } catch (error) {
                console.error(error);
            }
        })
        .fail(function (error) {
            // try...catch can be in each promise method
            handleAjaxError(error);
        })
        .always(function () {
            // try...catch can be in each promise method
            console.log('In the always() block');
        });
}