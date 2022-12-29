function ShowEmployeeDetails() {
    $.ajax({
        url: '/Home/EmployeeResults',
        type: 'POST',
        dataType: 'json'
    })
        .done(function (data) {
            alert(data);
            $(data).each(function () {
                $('#emp_details').append('<tr><td>'+ this.empId +'</td><td>'+ this.empName +'</td><td>' + this.salary + '</td><td>'+ this.isPermanent +'</td></tr>');
            });
        })
        .fail(function (error) {
            handleAjaxError(error);
        })
        .always(function () {
            console.log('In the always method');
        });
}
