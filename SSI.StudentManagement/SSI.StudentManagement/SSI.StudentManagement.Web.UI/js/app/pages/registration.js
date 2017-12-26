"use strict";

//Page empty sample and template.
(function () {
    var sourceData;

    $(document).on('on_page_load', onLoad);
    $(document).on('on_page_unload', onUnload);

    function onLoad(e) {
        $(document).off('on_page_load', onLoad);
        sourceData = e.message;


        $('#register_btn').on('click', onRegistration);

        $('#back_btn').on('click', onBack);

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

    function onRegistration(){
        if($('#username_txt').val() == ''){
            $('#username_txt').shake();
            return;
        }

        if($('#password_txt').val() == ''){
            $('#password_txt').shake();
            return;
        }


        if($('#password_txt').val() != $('#re_password_txt').val()){
            $('#password_txt').shake();
            $('#re_password_txt').shake();
            return;
        }

        $('#loader').removeClass('hide');

        var jsonData = {};
        jsonData.Email = $('#username_txt').val();
        jsonData.Password = $('#password_txt').val();
        jsonData.ConfirmPassword = $('#re_password_txt').val();

        console.log(jsonData);
        $.ajax({
            url:'api/Account/Register',
            type:'POST',
            contentType: 'application/json',
            data: JSON.stringify(jsonData),
            success: function(data){
                console.log(data);
            }
        })
    }

    function onPopupClose(data){
        console.log(data);
        $.event.trigger({
            type:'unload_header',
            url:'header'
        })
    }

    function onBack(){
        $.event.trigger({
            type:'change_page',
            url:'login'
        })
    }

    function onUnload(e) {
        //Remove listeners of buttons, events and auto calling scripts
    }
}());