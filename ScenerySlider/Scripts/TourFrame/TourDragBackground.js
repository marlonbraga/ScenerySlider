/* Adapts background image to screen size
 * It didn't work to use only the CSS command 'BackgroundSize: cover'
 * because it is not possible to get the 'width' and 'height' values
 * of the background image regardless of the dimensions of the 'div'.
 */
$(document).ready(function () {
	var $bg = $('.bg-img');
	var viewportHeight = Math.max(document.documentElement.clientHeight, window.innerHeight || 0);
	$('.navbar').css('margin-bottom', 0);
	var navMargin = parseInt($('.navbar').css('margin-bottom'));
	var navHeight = $('.navbar').height();
	const screenProportion = (16 / 9); //1.777777...

	function AdjustTourScreen() {
		$('.bg-img').css('height', GetBackgroundImage().height + 'px');
		$('.bg-img').css('max-width', GetBackgroundImage().height * screenProportion + 'px');
	}
	function ResizeBackgroundImage(e) {
		size = BackgroundSize();
		$('.bg-img').css('backgroundSize', size.width + 'px ' + size.height + 'px');
	}
	function BackgroundSize() {
		var size = { width: 0, height: 0 };
		if ($bg.width() / GetBackgroundImage().height >= screenProportion)
			size = {
				width: $bg.width(),
				height: $bg.width() / screenProportion
			};
		else
			size = {
				width: GetBackgroundImage().width,
				height: GetBackgroundImage().height
			};
		return size;
	}
	function GetBackgroundImage() {
		var size = {
			height: (viewportHeight - navHeight - navMargin),
			width: (viewportHeight - navHeight - navMargin) * screenProportion
		}
		return size;
	}
	AdjustTourScreen();
	$bg.resize(ResizeBackgroundImage());

	//// TOUR DRAG BACKGROUND

	var $bg = $('.bg-img'),
		data = $('#data')[0],
		elbounds = {
			w: parseInt($bg.width()),
			h: parseInt($bg.height())
		},
		origin = { x: 0, y: 0 },
		start = { x: 0, y: 0 },
		movecontinue = false;
	function Bounds() {
		bounds = {
			width: GetBackgroundImage().width - elbounds.w,
			height: GetBackgroundImage().height - elbounds.h
		};
		return bounds;
	}
	function move(e) {
		var inbounds = { x: false, y: false },
			offset = {
				x: start.x - (origin.x - e.clientX),
				y: start.y - (origin.y - e.clientY)
			};

		data.value = 'X: ' + offset.x + ', Y: ' + offset.y;

		inbounds.x = offset.x < 0 && (offset.x * -1) < Bounds().width;
		inbounds.y = offset.y < 0 && (offset.y * -1) < Bounds().height;

		if (movecontinue && inbounds.x && inbounds.y) {
			start.x = offset.x;
			start.y = offset.y;
			moveSpots(offset);
			$(this).css('background-position', start.x + 'px ' + start.y + 'px');
		}

		origin.x = e.clientX;
		origin.y = e.clientY;

		e.stopPropagation();
		return false;
	}

	//// MOVE SPOTS
	var top = parseInt($('.spot').css('top'));
	var left = parseInt($('.spot').css('left'));

	var spotList = document.querySelectorAll('.spot');
	var spotStartPositions = [];
	for (var i = 0; i < spotList.length; i++) {
		spotStartPositions[i] = {
			top: BackgroundSize().height * parseInt(spotList[i].style.top) / 100,
			left: BackgroundSize().width * parseInt(spotList[i].style.left) / 100
		};
	}
	moveSpots({ x:0,y:0});
	function moveSpots(offset) {
		$('.spot').each(function (index) {
			var margin = parseInt($('.bg-img').css('margin-left'));
			$(this).css('top', spotStartPositions[index].top + offset.y + 'px');
			$(this).css('left', spotStartPositions[index].left + offset.x + margin + 'px');
		});
	}
	//// -
function handle(e) {
	movecontinue = false;
	$bg.unbind('mousemove', move);

	if (e.type == 'mousedown') {
		$(this).css('cursor', 'grabbing');
		origin.x = e.clientX;
		origin.y = e.clientY;
		movecontinue = true;
		$bg.bind('mousemove', move);
	} else {
		$(document.body).focus();
		$(this).css('cursor', 'grab');
	}

	e.stopPropagation();
	return false;
}

function reset() {
	start = { x: 0, y: 0 };
	$(this).css('backgroundPosition', '0 0');
}

$bg.bind('mousedown mouseup mouseleave mouseover', handle);
$bg.bind('dblclick', reset);
});