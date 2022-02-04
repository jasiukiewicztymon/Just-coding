$(document).ready(function(){
    var e = document.getElementById("menu-button");
    var eclass = e.classList;
    $("#menu-button").click(function() {
        if (eclass.length == 1)
            $("#menu-smallsize").toggle("slow");  
        else {
            $("#menu-fullsize").slideToggle("slow");
        }
    })
})
$(window).resize(function() {
    var windowWidth = $(window).width();
    var element = document.getElementById("menu-button");
    if (windowWidth < 992) {
        element.classList.add("disable");
        $("#menu-fullsize").slideUp("slow");
    }    
    else {
        element.classList.remove("disable");
        $("#menu-smallsize").hide("slow");
    }
});