$(document).ready(function () {
    function AdjustTourScreen() {
        const viewportHeight = Math.max(document.documentElement.clientHeight, window.innerHeight || 0);
        const navMargin = parseInt($('.navbar').css('margin-bottom'));
        const navHeight = $('.nav').height();
        $('.bg-img').css('height', (viewportHeight - navHeight - navMargin) + 'px');
    }

    AdjustTourScreen();
});