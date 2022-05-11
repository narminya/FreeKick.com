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


        toastr.options = {
            "closeButton": false,
            "debug": false,
            "newestOnTop": false,
            "progressBar": false,
            "positionClass": "toast-bottom-right",
            "preventDuplicates": false,
            "onclick": null,
            "showDuration": "300",
            "hideDuration": "1000",
            "timeOut": "5000",
            "extendedTimeOut": "1000",
            "showEasing": "swing",
            "hideEasing": "linear",
            "showMethod": "fadeIn",
            "hideMethod": "fadeOut"
        }

   
        $(document).on("click", "#button-addon2", function () {
     let email = $("#email").val();
            $.ajax({
                type: "Get",
                url: "/Home/Subscribe?email=" + email,
                success: function (res) {
                    Command: toastr[res.result]("", res.message)
                    $("#email").val = "";
                },
                error: function (err) {
                    Command: toastr[err.result]("", err.message)
                },
            })
        })

        $("a.dropmenu").click(function (e) {
            e.stopPropagation();
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
      //  timer('#timer1');

        players()




    });

    function players() {

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
    }

    function timer(id) {


        let hourEl = $(id).children('li')[0]
        let minuteEl = $(id).children('li')[2]
        let secondEl = $(id).children('li')[4]


        // let time = $(id).attr('data-time');
        // let timeParts = time.split(':');
        let hours = format($(hourEl).text());
        console.log(hours)
        let minutes = (format($(minuteEl).text()) / 60) - hours
        let seconds = (format($(secondEl).text()) / 60) - minutes
        // let seconds = timeParts[2];
        $(id).addClass('running');

        $(secondEl).text(Math.floor(seconds));
        $(minuteEl).text(minutes);
        $(hourEl).text(hours);

        let pid = setInterval(function () {

            if (seconds > 0) {
                seconds--;
            } else if (minutes > 0) {
                seconds = 59;
                minutes--;
            } else if (hours > 0) {
                minutes = 59;
                seconds = 59;
                hours--;
            } else {
                // sound.play();

                $(id).removeClass('running');
                clearInterval(pid);
            }


            $(secondEl).text(seconds);
            $(minuteEl).text(minutes);
            $(hourEl).text(minutes);
        }, 1000);

    }

    function format(val) {


        if (val < 10)
            return `0${parseInt(val)}`;

        return val;
    }

    function format(val) {

        if (val < 10)
            return `0${parseInt(val)}`;

        return val;
    }

})(jQuery);