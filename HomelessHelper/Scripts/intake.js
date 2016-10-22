$(document).ready(function() {
    $("#vetStatus").hide();
});

var showHide = function(divToShow) {
    target = $('#' + divToShow);
    target.toggle();
}