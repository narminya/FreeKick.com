(function($) {

    'use strict';

    // Set environment vars
   function initHorizontalMenu() {
        $('.horizontal-menu .bar-inner > ul > li').on('click', function () {
            $(this).toggleClass('open').siblings().removeClass('open');

        });
         if($('body').hasClass('horizontal-menu')){
            $('.content').on('click', function () {
                $('.horizontal-menu .bar-inner > ul > li').removeClass('open');
            });
         }
    }
    // Tooltip
    initHorizontalMenu() 
})(jQuery);


$(function() {
    'use strict';
});