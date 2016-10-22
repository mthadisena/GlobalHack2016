$(document).ready(function() {
    $("#vetStatus").hide();
    $("#SSN").mask('999-99-9999');
    $("#PhoneNumber").mask('(999) 999-9999');
});

var showHide = function(divToShow) {
    var target = $('#' + divToShow);
    target.toggle();
}