$(document).ajaxStart(function () {
    console.log('The first Ajax call is being fired');
});

$(document).ajaxStop(function () {
    console.log('The last Ajax call has completed');
});

$(document).ajaxSend(function () {
    console.log('Ajax call is being sent');
});

$(document).ajaxSend(function (event, xhr, settings) {
    console.log(settings);
});

$(document).ajaxSuccess(function () {
    console.log('An Ajax call has finished successfully');
});

$(document).ajaxSuccess(function (event, xhr, settings) {
    console.log(settings);
});

$(document).ajaxComplete(function () {
    console.log('Ajax call is complete');
});

$(document).ajaxComplete(function (event, xhr, settings) {
    console.log(settings.url);
    console.log(xhr.responseText);
});

$(document).ajaxError(function () {
    console.log('Ajax call had an ERROR');
});

$(document).ajaxError(function (event, xhr, settings, thrownError) {
    console.log('Ajax call had an ERROR');
    console.log(thrownError);
    console.log(settings);
});

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
