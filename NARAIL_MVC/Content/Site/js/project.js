$(document).ready(function () {

    $('#software').click(function () {
        $('#softwareDiv').show();
        $('#itDiv').hide();
        $('#financeDiv').hide();
        $('#saleDiv').hide();
    });

    $('#it').click(function () {
        $('#itDiv').show();
        $('#softwareDiv').hide();
        $('#financeDiv').hide();
        $('#saleDiv').hide();

    });
    $('#finance').click(function () {
        $('#financeDiv').show();
        $('#itDiv').hide();
        $('#softwareDiv').hide();
        $('#saleDiv').hide();
    });

    $('#sale').click(function () {
        $('#saleDiv').show();
        $('#financeDiv').hide();
        $('#softwareDiv').hide();
        $('#itDiv').hide();
    });
    
})

$('.service-catergory li').on('click', function () {

    $('li').removeClass('active');
    $(this).addClass('active');


});