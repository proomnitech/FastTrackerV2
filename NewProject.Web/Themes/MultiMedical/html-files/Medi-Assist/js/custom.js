$(function() {

    "use strict";
	
	// News Post Carousel
	$("#news-post-carousel").owlCarousel({
		autoPlay: false, //Set AutoPlay to 3 seconds
		items : 4,
		stopOnHover : true,
		navigation : true, // Show next and prev buttons
		pagination : false,
		navigationText : ["<span class='fa fa-chevron-left'></span>","<span class='fa fa-chevron-right'></span>"]
	});
	
});