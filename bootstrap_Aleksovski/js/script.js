var navbarScrollFunction = () => {
    if ($("#codeAcademyNavBar").offset().top > 100) {
        $("#codeAcademyNavBar").addClass("navbar-shrink");
        $(".navbar-brand").addClass("navbar-brand-font-size-1");
    } else {
        $("#codeAcademyNavBar").removeClass("navbar-shrink");
        $(".navbar-brand").removeClass("navbar-brand-font-size-1");
    }
}

$(window).scroll(navbarScrollFunction);
navbarScrollFunction();



