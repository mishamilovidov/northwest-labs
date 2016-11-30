//Script for glyphicon chevron toggle on Rental View
function toggleChevron(e) {
    $(e.target)
        .prev('.panel-heading')
        .find('i.indicator')
        .toggleClass('glyphicon-chevron-right glyphicon-chevron-down');
}
$('#accordion').on('hidden.bs.collapse', toggleChevron);
$('#accordion').on('shown.bs.collapse', toggleChevron);

// For v2 [data-toggle="dropdown"] is required for [data-submenu].
// For v2 .dropdown-submenu > [data-toggle="dropdown"] is forbidden.
// $('[data-submenu]').submenupicker();

$(function() {
  /**
  * NAME: Bootstrap 3 Multi-Level by Johne
  * This script will active Triple level multi drop-down menus in Bootstrap 3.*
  */
  $('li.dropdown-submenu').on('click', function(event) {
      event.stopPropagation(); 
      if ($(this).hasClass('open')){
          $(this).removeClass('open');
      }else{
          $('li.dropdown-submenu').removeClass('open');
          $(this).addClass('open');
     }
  });
});
