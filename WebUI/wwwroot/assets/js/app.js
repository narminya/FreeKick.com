(function ($) {
    'use strict';
    var browserWindow = $(window);
    browserWindow.on('load', function () {
        $('.preloader').fadeOut(2000, function () {
            $(this).remove();
        });

        $('.burger').on("click", function () {
            console.log(1)
            $('.nav-links').toggleClass('show');
            $('body').toggleClass('modal-open');
        });


        $("a.dropmenu").click(function (e) {
            e.stopPropagation();
            e.preventDefault();
            $(this).next(".dropdown").toggleClass('selected')

            if ($(this).next(".dropdown").hasClass('selected')) {
                $(this).next(".dropdown").fadeIn();

            } else {
                $(this).next(".dropdown").fadeOut();
            }

        });

        $(document).click(function () {
            $('.selected').removeClass('selected');

        })

        $(".sub-menu-heading").click(function () {
            $(this).next(".sub-menu").toggleClass('selected')
            if ($(this).next(".sub-menu").hasClass('selected')) {
                $(this).next(".sub-menu").fadeIn();

            } else {
                $(this).next(".sub-menu").fadeOut();
            }
        });

        let players = $('.player');
        let field = $(".field-main");


        var keeperHome = $('<div class="keeper home"></div>');
        var defenceHome = $('<div class="defence home"></div>');
        var midfieldHome = $('<div class="midfield home"></div>');
        var attackHome = $('<div class="attack home"></div>');
        var defenceAway = $('<div class="defence away"></div>');
        var midfieldAway = $('<div class="midfield away"></div>');
        var attackAway = $('<div class="attack away"></div>');
        var keeperAway = $('<div class="keeper away"></div>');

        $(field).append(defenceHome, midfieldHome, attackHome, defenceAway, midfieldAway, attackAway, keeperHome, keeperAway)


        for (let i = 0; i < players.length; i++) {
            if ($(players[i]).hasClass("goalkeeper g-home")) {
                $(keeperHome).append(players[i])
            } else if ($(players[i]).hasClass("defender g-home")) {
                $(defenceHome).append(players[i])
            } else if ($(players[i]).hasClass("midfielder g-home")) {
                $(midfieldHome).append(players[i])
            } else if ($(players[i]).hasClass("forward g-home")) {
                $(attackHome).append(players[i])
            } else if ($(players[i]).hasClass("forward g-away")) {
                $(attackAway).append(players[i])
            } else if ($(players[i]).hasClass("midfielder g-away")) {
                $(midfieldAway).append(players[i])
            } else if ($(players[i]).hasClass("defender g-away")) {
                $(defenceAway).append(players[i])
            } else if ($(players[i]).hasClass("goalkeeper g-away")) {
                $(keeperAway).append(players[i])
            }
        }



    });

})(jQuery);



