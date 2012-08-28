$(function () {

    //hover states on the static widgets
    $('#dialog_link, #modal_link, ul#icons li').hover(

    function () {
        $(this).addClass('ui-state-hover');
    }, function () {
        $(this).removeClass('ui-state-hover');
    });

    // Autocomplete
    var availableTags = ["ActionScript", "AppleScript", "Asp", "BASIC", "C", "C++", "Clojure", "COBOL", "ColdFusion", "Erlang", "Fortran", "Groovy", "Haskell", "Java", "JavaScript", "Lisp", "Perl", "PHP", "Python", "Ruby", "Scala", "Scheme"];

    $("#tags").autocomplete({
        source: availableTags
    });


    // addTab button: just opens the dialog
    $("#add_tab").button().click(function () {
        $dialog.dialog("open");
    });



    // modal dialog init: custom buttons and a "close" callback reseting the form inside
    var $dialog = $("#dialog2").dialog({
        autoOpen: false,
        modal: true,
        buttons: {
            Add: function () {
                addTab();
                $(this).dialog("close");
            },
            Cancel: function () {
                $(this).dialog("close");
            }
        },
        open: function () {
            $tab_title_input.focus();
        },
        close: function () {
            $form[0].reset();
        }
    });

    // addTab form: calls addTab function on submit and closes the dialog
    var $form = $("form", $dialog).submit(function () {
        $dialog.dialog("close");
        return false;
    });


    // addTab button: just opens the dialog
    $("#add_tab").button().click(function () {
        $dialog.dialog("open");
    });

    // close icon: removing the tab on click
    // note: closable tabs gonna be an option in the future - see http://dev.jqueryui.com/ticket/3924
    $("#tabs span.ui-icon-close").live("click", function () {
        var index = $("li", $tabs).index($(this).parent());
        $tabs.tabs("remove", index);
    });

    //Toolbar
    $("#play, #shuffle").button();
    $("#repeat").buttonset();

   

});