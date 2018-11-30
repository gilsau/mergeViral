$(document).ready(function () {
    var url = $(location).attr('href').toLowerCase();
    var arrUrl = $(location).attr('href').split('/');
    var page = $.trim(arrUrl[arrUrl.length - 1]);

    console.log('url: ' + url);
    console.log('page: ' + page);

    //sidebar link selection
    if(page.indexOf('dashboard') > -1 || page === '') {
        $('#mnu1')
            .removeClass()
            .addClass('sidebarMenuItemSel');
    }
    else if (url.indexOf('campaign/list') > -1) {
        $('#mnu2')
            .removeClass()
            .addClass('sidebarMenuItemSel');
    }
    else if (url.indexOf('campaign/create') > -1) {
        $('#mnu3')
            .removeClass()
            .addClass('sidebarMenuItemSel');
    }

    //sidebar link navigation
    $('.sidebarMenuItem').click(function () {
        if ($(this).data('href')) {
            window.location = $(this).data('href');
        }
    });

    //select campaign location
    $('.selCampLoc').click(function () {
        $('#modCampLoc').modal('hide');
        $('#modCampType').modal('show');
    });

    //select campaign location
    $('.selCampLoc').click(function () {
        $('#modCampLoc').modal('hide');
        $('#modCampType').modal('show');
    });

    //create campaign
    $('.btnCreateCamp').click(function () {
        $('#modCampType').modal('hide');
        window.location = '/campaign/rewardsetup/';
    });

});