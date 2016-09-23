$(function () {
    $(".onlynumber").keyup(function () {
        var val = $(this).val();
        val = val.replace(/[^\d]/g, '')
        $(this).val(val);
    });
  //  alert(1);
});