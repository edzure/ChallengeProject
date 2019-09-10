$(document).ready(function () {    
    function changeSelect() {
           alert("Pasa por aquì!");
        console.log(e);
    }
    $("#User").on('change', function (e) {
        alert("Pasa por cambio!");
        console.log(e);
    })

    $("#UserList").on('change', function (e) {
        $("#userform").submit();
        
    })
});