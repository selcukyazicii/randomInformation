(function () {
	"use strict";

	var slideMenu = $('.side-menu');
	$('.app').addClass('sidenav-toggled');
	$('.app').removeClass('sidenav-open');

	// Toggle Sidebar
	$(document).on('click','[data-bs-toggle="sidebar"]',function(event) {
		event.preventDefault();
		$('.app').toggleClass('sidenav-toggled');
		 $('.app').removeClass('sidenav-toggled-open');
	});

	$(document).on("click", ".sidenav-toggled .app-sidebar", function() {
        $('.app').addClass('sidenav-toggled-open');
    });
	
	$(document).on("click", ".sidenav-toggled.sidenav-toggled-open .app-content", function() {
       $('.app').removeClass('sidenav-toggled-open');
    });
	

	if ( $(window).width() > 739) {     
		$('.app').ready(function(event) {
			$('.app').removeClass('sidenav-toggled-open');
		});
	} 
	
    //Mobile menu
    jQuery(document).ready(function($) {
      var alterClass = function() {
        var ww = document.body.clientWidth;
        if (ww < 768) {
          $('body').removeClass('sidenav-toggled');
        } else if (ww >= 767) {
          $('body').addClass('sidenav-toggled');
        };
      };
      $(window).resize(function(){
        alterClass();
      });
      //Fire it when the page first loads:
      alterClass();
    });

	
    // Activate sidebar slide toggle
    $("[data-bs-toggle='slide']").click(function(event) {
        event.preventDefault();
        if (!$(this).parent().hasClass('is-expanded')) {
            slideMenu.find("[data-bs-toggle='slide']").parent().removeClass('is-expanded');
        }
        $(this).parent().toggleClass('is-expanded');
    });

    $("[data-bs-toggle='sub-slide']").click(function(event) {
        event.preventDefault();
        if (!$(this).parent().hasClass('is-expanded')) {
            slideMenu.find("[data-bs-toggle='sub-slide']").parent().removeClass('is-expanded');
        }
        $(this).parent().toggleClass('is-expanded');
        $('.slide.active').addClass('is-expanded');
    });

    // Set initial active toggle
    $("[data-bs-toggle='slide.'].is-expanded").parent().toggleClass('is-expanded');
    $("[data-bs-toggle='sub-slide.'].is-expanded").parent().toggleClass('is-expanded');


    //Activate bootstrip tooltips
    // $("[data-bs-toggle='tooltip']").tooltip();


    // ______________Active Class
    $(".app-sidebar li a").each(function() {
      var pageUrl = window.location.href.split(/[?#]/)[0];
      if (this.href == pageUrl) { 
        $(this).addClass("active");
        $(this).parent().addClass("is-expanded");
        $(this).parent().parent().prev().addClass("active"); 
        $(this).parent().parent().addClass("open"); 
        $(this).parent().parent().prev().addClass("is-expanded"); 
        $(this).parent().parent().parent().addClass("is-expanded"); 
        $(this).parent().parent().parent().parent().addClass("open"); 
        $(this).parent().parent().parent().parent().prev().addClass("active"); 
        $(this).parent().parent().parent().parent().parent().addClass("is-expanded"); 
      }
    });
	//P-scrolling
	const ps15 = new PerfectScrollbar('.app-sidebar', {
		useBothWheelAxes:true,
		suppressScrollX:true,
		});

})();