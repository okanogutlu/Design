$(document).ready(function () {
    var scroll_start = 0;
    var startchange = $('.content-dummy');
    var offset = startchange.offset();
    if (startchange.length) {
        $(document).scroll(function () {
            scroll_start = $(this).scrolltop();
            if (scroll_start > offset.top) {
                $(".navbar-default").css('background', 'black');
               

            } else {
                $(".navbar-default").css('background', 'black');
            }
        });
    }
}
    );