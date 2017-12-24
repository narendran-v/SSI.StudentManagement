"use strict";

//Page empty sample and template.
(function () {
    var sourceData;

    $(document).on('on_page_load', onLoad);
    $(document).on('on_page_unload', onUnload);

    function onLoad(e) {
        $(document).off('on_page_load', onLoad);
        sourceData = e.message;
        main();
    }

    function main() {
        $.event.trigger({
            type:'load_header',
            url:'header'
        });

        $.event.trigger({
            type:'load_footer',
            url:'footer'
        });
        //Page specific code
        console.log('help screen loaded');


        //To unload the header and footer for some reason use this code
        // $.event.trigger({
        //     type: 'unload_header',
        //     message: {}
        // });

    }

    function onUnload(e) {
        //Remove listeners of buttons, events and auto calling scripts
    }
}());