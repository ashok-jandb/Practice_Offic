/*function Button_Click() {
    $.ajax({
        url: '/Home/GetStudent',
        type: 'GET',
        success: function (data) {
            $('#studentId').text(data.id);
            $('#studentEmail').text(data.email);
            $('#studentName').text(data.name);
        },
        error: function (err) {
            console.error(err);
        }
    });
}*/

/* The above commented method is also working fine.
 * Just two ways work working with jQuery */
function Button_Click() {
    $.ajax({
        url: '/Home/GetStudent',
        type: 'GET',
        contentType: 'application/json'
    })
        .done(function (data) {
            $('#studentId').text(data.id);
            $('#studentEmail').text(data.email);
            $('#studentName').text(data.name);
        })
        .fail(function (err) {
            console.log(err)
        })
        .always(function () {
            console.log('always - executes always');
        });
}