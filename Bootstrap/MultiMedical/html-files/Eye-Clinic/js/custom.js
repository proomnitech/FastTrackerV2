$(function() {

    "use strict";
	
	// REMOVE # FROM URL
	$( 'a[href="#"]' ).click( function(e) {
		e.preventDefault();
	});	
	
	// STICKY NAV
	var stickyHeaderTop = $("#slider").height();
	//var stickyHeaderTop = $(window).height();
    $(window).scroll(function() {
        if ($(window).scrollTop() > stickyHeaderTop) {
            $(".sticky-nav").css({position: "fixed", top: "0px"});
            $(".sticky-nav").css("display", "block");
			$(".sticky-nav").addClass("fixednav");
        } else {
            $(".sticky-nav").css({position: "static", top: "0px"});
			$(".sticky-nav").removeClass("fixednav");
        }
    });
	
	// ONE PAGE NAV
	$("#nav").onePageNav({
		currentClass: 'current',
		changeHash: false,
		scrollSpeed: 750,
		scrollThreshold: 0.5,
		filter: '',
		easing: 'swing',
		begin: function() {
			//I get fired when the animation is starting
		},
		end: function() {
			//I get fired when the animation is ending
		},
		scrollChange: function($currentListItem) {
			//I get fired when you enter a section and I pass the list item of the section
		}
	});
	
	// News Post Carousel
	$("#testimonail-carousel").owlCarousel({
		autoPlay: false, //Set AutoPlay to 3 seconds
		items : 3,
		stopOnHover : true,
		navigation : false, // Show next and prev buttons
		pagination : true
	});
	
	// GOOGLE MAP
	function initialize($) {
		var mapOptions = {	
			zoom: 8,
			center: new google.maps.LatLng(17.421306, 78.457553),
			disableDefaultUI: true
		};
		var map = new google.maps.Map(document.querySelector('.map'), mapOptions);
	}
	google.maps.event.addDomListener(window, 'load', initialize);
	
});