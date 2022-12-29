$(document).ready(function () {
    if ($(document.activeElement).data('name') == 'button1') {
        alert('Button1 clicked');
    }
    if ($(document.activeElement).data('name') == 'button2') {
        alert('Button2 clicked');
    }
});
