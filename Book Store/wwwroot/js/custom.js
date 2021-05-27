//BookStore var
(function ($) {
    "use strict";
    var BookStore = {};


// Predefined Variables
    var $window = $(window),
        $document = $(document),
        $body = $('body')

//Check if function exists
$.fn.exists = function () {
    return this.length > 0;
    };



// Select2 
// var dropdownSelect = $('.basic-select');

// if(dropdownSelect.exists()){
//     if(dropdownSelect.lenght>0){
//         dropdownSelect.select2({dropdownCssClass : 'bigdrop'});
//     }
// }

//************************* select2
BookStore.select2 = function () {
    var dropdownSelect = $('.basic-select');
    if (dropdownSelect.exists()) {
        if (dropdownSelect.length > 0) {
        $('.basic-select').select2();
        }

    }
};


//**************** BookStore Window load and functions
  //Window load functions
    $window.on("load", function () {
    });
    //Document ready functions
    $document.ready(function () {
    BookStore.select2()
    });
    })(jQuery);
