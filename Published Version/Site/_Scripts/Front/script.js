$(document).ready(function () {
    
	$(function() {
    	$(".slider").jCarouselLite({
       		btnNext: ".next",
       		btnPrev: ".prev",
       		visible: 6,
            auto: true,
            speed: 2000
    	});
	});			
	$('img.captify').captify({
		speedOver: 'fast',
		speedOut: 'normal',
		hideDelay: 500,	
		animation: 'slide',		
		prefix: '',		
		opacity: '0.7',					
		className: 'caption-bottom',	
		position: 'bottom',
		spanWidth: '100%'
	});
	
	$('#slider1').bxSlider({
		mode: 'fade',		
		auto: true,
		controls: true
	});

	$(function() {
		$('.top-nav ul').droppy ({speed: 100});
	});	
});
