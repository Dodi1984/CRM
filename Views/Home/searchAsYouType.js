$(document).ready(function () {
/* initially hide list items */
$("#companies td").hide();
console.log("PLM")
/* filter dinosaurs as you type */
$("#name").on("keyup click input", function () {
if (this.value.length > 0) {
  $("#companies td").hide().filter(function () {
    return $(this).text().toLowerCase().indexOf($("#name").val().toLowerCase()) != -1;
  }).show();
}
else {
  $("#companies td").hide();
}
});

});