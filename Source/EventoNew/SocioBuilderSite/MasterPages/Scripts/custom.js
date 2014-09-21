$(document).ready(function() { 
	// Dialog			
	$('#dialog').dialog({
		autoOpen: false,
		width: 600,
		bgiframe: false,
		modal: false,
		buttons: {
			"Ok": function() { 
				$(this).dialog("close"); 
			}, 
			"Cancel": function() { 
				$(this).dialog("close"); 
			} 
		}
	});
	
	
	// Dialog Link
	$('#dialog_link').click(function(){
		$('#dialog').dialog('open');
		return false;
	});
    // Tabs
    $('#tabs').tabs();
    //Sortable
    $(".column").sortable({
        connectWith: '.column'
    });

	//Sidebar only sortable boxes
	$(".side-col").sortable({
		axis: 'y',
		connectWith: '.side-col'
	});

	$(".portlet").addClass("ui-widget ui-widget-content ui-helper-clearfix ui-corner-all")
		.find(".portlet-header")
			.addClass("ui-widget-header")
			.prepend('<span class="ui-icon ui-icon-circle-arrow-s"></span>')
			.end()
		.find(".portlet-content");

	$(".portlet-header .ui-icon").click(function() {
		$(this).toggleClass("ui-icon-circle-arrow-n");
		$(this).parents(".portlet:first").find(".portlet-content").slideToggle();
	});

	$(".column").disableSelection();

	$(".header").append('<span class="ui-icon ui-icon-carat-2-n-s"></span>');

	/* Tooltip */

	$(function () {
	    $('.tooltip').tooltip({
	        track: true,
	        delay: 0,
	        showURL: false,
	        showBody: " - ",
	        fade: 250
	    });
	});    
});

