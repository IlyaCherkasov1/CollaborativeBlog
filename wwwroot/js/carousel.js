$(document).ready(function () {
    $(".owl-carousel").owlCarousel({
        autoplay: false,
        autoplayhoverpause: true,
        autoplaytimeout: 50,
        items: 7,
        nav: true,
        loop: true,
        margin: 5,
        padding: 5,
        stagePadding: 5,
        responsive: {
            0: {
                items: 2,
                dots: false
            },
            485: {
                items: 3,
                dots: false
            },
            728: {
                items: 5,
                dots: false
            },
            960: {
                items: 7,
                dots: false
            },
            1200: {
                items: 7,
                dots: false
            },
        }
    });
        
  });
