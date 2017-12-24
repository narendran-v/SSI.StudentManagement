"use strict";

//Page empty sample and template.
(function () {
    var sourceData;

    $(document).on('on_page_load', onLoad);
    $(document).on('on_page_unload', onUnload);

    function onLoad(e) {
        $(document).off('on_page_load', onLoad);
        sourceData = e.message;


        $('#login_btn').on('click', onLogin);

        main();
    }

    function main() {
        $.event.trigger({
            type:'unload_header'
        });

        $.event.trigger({
            type:'unload_footer'
        });
    }

    function onLogin(){
        
        if($('#username_txt').val() == ''){
            $('#username_txt').shake();
            return;
        }

        if($('#password_txt').val() == ''){
            $('#password_txt').shake();
            return;
        }

        $('#loader').removeClass('hide');
        setTimeout(function(){
            $.event.trigger({
                type:'change_page',
                url:'dashboard'
            })
        }, 2000);

        
    }

    function onPopupClose(data){
        console.log(data);
        $.event.trigger({
            type:'unload_header',
            url:'header'
        })
    }

    function onUnload(e) {
        //Remove listeners of buttons, events and auto calling scripts
    }
}());