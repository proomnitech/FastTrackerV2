$(function() {

    "use strict";
	
	// REMOVE # FROM URL
	$( 'a[href="#"]' ).click( function(e) {
		e.preventDefault();
	});
	
	// Team Owl Carousel
	$("#services-home-carousel").owlCarousel({
		autoPlay: false, //Set AutoPlay to 3 seconds
		items : 4,
		stopOnHover : true,
		navigation : true, // Show next and prev buttons
		pagination : false,
		navigationText : ["<span class='fa fa-chevron-left'></span>","<span class='fa fa-chevron-right'></span>"]
	});
	
	$("#testimonials-carousel").owlCarousel({
		autoPlay: true,
        singleItem: true,
		stopOnHover : true,
		navigation : true, // Show next and prev buttons
		pagination : false,
		navigationText : ["<span class='fa fa-chevron-left'></span>","<span class='fa fa-chevron-right'></span>"]
	});
	
	// ACCORDION
	var $active = $("#accordion-1 .panel-collapse.in")
					.prev()
					.addClass("active");
					
	$active
		.find("a")
		.append("<span class=\"fa fa-minus-circle pull-left\"></span>");
		
	$("#accordion-1 .panel-heading")
		.not($active)
		.find('a')
		.prepend("<span class=\"fa fa-plus-circle pull-left\"></span>");
	
	$("#accordion-1").on("show.bs.collapse", function (e) {	
		$("#accordion-1 .panel-heading.active")
			.removeClass("active")
			.find(".fa")
			.toggleClass("fa-plus-circle fa-minus-circle");				
		$(e.target)
			.prev()
			.addClass("active")
			.find(".fa")
			.toggleClass("fa-plus-circle fa-minus-circle");		
	});
	
	$("#accordion-1").on("hide.bs.collapse", function (e) {
		$(e.target)
			.prev()
			.removeClass("active")
			.find(".fa")
			.removeClass("fa-minus-circle")
			.addClass("fa-plus-circle");
	});
	
	// Gallery FILTERS
	var $grid = $('#gallery-grid');
	$grid.shuffle({
		itemSelector: '.gallery-grid-item', // the selector for the items in the grid
		speed: 500 // Transition/animation speed (milliseconds)
	});
	/* reshuffle when user clicks a filter item */
	$('#gallery-filter li a').click(function (e) {
		// set active class
		$('#gallery-filter li a').removeClass('active');
		$(this).addClass('active');
		// get group name from clicked item
		var groupName = $(this).attr('data-group');
		// reshuffle grid
		$grid.shuffle('shuffle', groupName );
	});
	
	//MAGNIFIC POPUP
	$('#gallery-grid').magnificPopup({
		delegate: 'a', 
		type: 'image',
		gallery: {
			enabled: true
		}
	});
	
	// GOOGLE MAP
	function initialize($) {
		var mapOptions = {	
			zoom: 8,
			center: new google.maps.LatLng(17.421306, 78.457553),
			disableDefaultUI: true
		};
		var map = new google.maps.Map(document.querySelector('.map, .contact-page-map'), mapOptions);
	}
	google.maps.event.addDomListener(window, 'load', initialize);
	
});