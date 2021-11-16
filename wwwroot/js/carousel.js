$(document).ready(function () {
    $(".owl-one").owlCarousel({
        autoplay: false,
        autoplayhoverpause: true,
        autoplaytimeout: 50,
        items: 10,
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
                items: 6,
                dots: false
            },
            960: {
                items: 8,
                dots: false
            },
            1200: {
                items: 10,
                dots: false
            },
        }
    });

    $(".owl-two").owlCarousel({
        autoplay: true,
        autoplayhoverpause: true,
        autoplaytimeout: 50,
        items: 4,
        nav: true,
        loop: true,
        margin: 5,
        padding: 5,
        stagePadding: 5,
        responsive: {
            0: {
                items: 1,
                dots: false
            },
            485: {
                items: 2,
                dots: false
            },
            728: {
                items: 3,
                dots: false
            },
            960: {
                items: 4,
                dots: false
            },
            1200: {
                items: 4,
                dots: false
            },
        }
    });

    $(".owl-three").owlCarousel({
        autoplay: true,
        autoplayhoverpause: true,
        autoplaytimeout: 50,
        items: 4,
        nav: true,
        loop: true,
        margin: 5,
        padding: 5,
        stagePadding: 5,
        responsive: {
            0: {
                items: 1,
                dots: false
            },
            485: {
                items: 2,
                dots: false
            },
            728: {
                items: 3,
                dots: false
            },
            960: {
                items: 4,
                dots: false
            },
            1200: {
                items: 4,
                dots: false
            },
        }
    });
})