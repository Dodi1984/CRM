$(document).ready(function () {
  App.init()
})

var App = {
  tableRows: null,
  init: function () {
    this.tableRows = document.getElementsByClassName('info')
  },
  onFilterChange: function () {
    var filterText = document.getElementById('filter').value    
    // console.log(filterText)
    // this.tableRows[0].style.display = 'none' // for hiding elements
    for (i = 0; i < this.tableRows.length;i++) {
      if (this.tableRows[i].innerText.toUpperCase().indexOf(filterText.toUpperCase()) === -1) {
        this.tableRows[i].style.display = 'none'
      }
      else{
          console.log("a intart in else")
        this.tableRows[i].style.display = ""      
      }
    }
  }
}
