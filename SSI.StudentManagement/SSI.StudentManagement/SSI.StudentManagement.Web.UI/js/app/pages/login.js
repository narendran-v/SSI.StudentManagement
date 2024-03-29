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
        $('#signup_btn').on('click', onSignup);

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
        var body = {
            grant_type: 'password',
            username: $('#username_txt').val(),
            password: $('#password_txt').val()
        };
        // var jsonData = {};
        // jsonData.grant_type ='password';
        // jsonData.Username = $('#username_txt').val();
        // jsonData.Password = $('#password_txt').val();
        // console.log(jsonData);
        $('#loader').removeClass('hide');
        $.ajax({
            url:'Token',
            type: 'POST',
            dataType: 'json',
            contentType: 'application/x-www-form-urlencoded; charset=UTF-8',
            data: body,
            success: function(data){
                $.event.trigger({
                    type:'change_page',
                    url:'dashboard',
                    message:data
                })
            }
        })

        
    }

    function onSignup(){
        $.event.trigger({
            type:'change_page',
            url:'registration'
        })
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