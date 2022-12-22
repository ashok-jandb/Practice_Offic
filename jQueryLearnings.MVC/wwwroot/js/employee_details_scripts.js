function ShowEmployeeDetails() {
    $.ajax({
        url: '@Url.Action("Home", "EmployeeResultsInTable")',
        type: 'GET',
        dataType: 'json'
    })
        .done(function (data) {
            $.each(data, function (key, value) {
                $('#emp_details').append('<tr><td>' + value + '</td><td>' + value + '</td><td>' + value + '</td><td>' + value +'</td></tr>');
            });
        })
        .fail()
        .always();
}