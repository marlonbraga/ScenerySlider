/* Adapts background image to screen size
 * It didn't work to use only the CSS command 'BackgroundSize: cover'
 * because it is not possible to get the 'width' and 'height' values
 * of the background image regardless of the dimensions of the 'div'.
 */
$(document).ready(function () {
	var $bg = $('.bg-img');
	var viewportHeight = Math.max(document.documentElement.clientHeight, window.innerHeight || 0);
	const navMargin = parseInt($('.navbar').css('margin-bottom'));
	const navHeight = $('.nav').height();

	function AdjustTourScreen() {
		$('.bg-img').css('height', GetBackgroundImage().height + 'px');
		$('.bg-img').css('max-width', GetBackgroundImage().height*1.777 + 'px');
	}
	function ResizeBackgroundImage(e) {
		size = BackgroundSize();
		$('.bg-img').css('backgroundSize', size.width + 'px ' + size.height + 'px');
	}
	function BackgroundSize() {
		var size = { width: 0, height: 0 };
		if ($bg.width() / GetBackgroundImage().height >= 1.777)
			size = {
				width: $bg.width(),
				height: $bg.width() / 1.777
			};
		else
			size = {
				width: GetBackgroundImage().width,
				height: GetBackgroundImage().height
			};
		console.log("BackgroundSize: " + size);
		return size;
	}
	function GetBackgroundImage() {
		var size = {
			height: (viewportHeight - navHeight - navMargin),
			width: (viewportHeight - navHeight - navMargin) * 1.777
		}
		return size;
	}
	AdjustTourScreen();
	$bg.resize(ResizeBackgroundImage());
});