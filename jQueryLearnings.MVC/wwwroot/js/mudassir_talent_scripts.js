$(document).ready(function () {
    $('#btnGet').click(function () {
        $.ajax({
            type: 'POST',
            url: '/Home/AjaxMethod',
            data: { 'name': $('#txtName').val() },
            success: function (response) {
                alert('Hello ' + response.name + '\nCurrent date and time: ' + response.dateTime)
            },
            failure: function (response) {
                alert(response.responseText);
            },
            error: function (response) {
                alert(response.responseText);
            }
        });
    });
});
