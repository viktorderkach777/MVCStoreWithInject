(function () {
    // Your base, I'm in it!
    var originalAddClassMethod = jQuery.fn.toggleClass;

    jQuery.fn.toggleClass = function () {
        // Execute the original method.
        var result = originalAddClassMethod.apply(this, arguments);

        // trigger a custom event
        jQuery(this).trigger('cssClassChanged');

        // return the original result
        return result;
    }
})();




    $(document).ready(function () {
        $('#sidebarCollapse').on('click', function () {
            $('#sidebar').toggleClass('active');
            $(this).toggleClass('active');
           
            //TouristMap.resize();

            $("#sidebar").on('cssClassChanged', function () {
                TouristMap.resize();
            });

            $(this).on('cssClassChanged', function () {
                TouristMap.resize();
            });
        });



    });



