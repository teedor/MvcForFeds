$(function () {
    $(".datePicker").datepicker({
        showOn: "button",
        buttonImage: "/images/calendar-icon.png",
        buttonImageOnly: true,
        buttonText: "Select date",
        dateFormat: "dd-MM-yy"
    });

    $('.tagEditor').tagEditor();
});