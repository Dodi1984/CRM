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
    
    for (i = 0; i < this.tableRows.length;i++) {
      if (this.tableRows[i].innerText.toUpperCase().indexOf(filterText.toUpperCase()) === -1) {
        this.tableRows[i].style.display = 'none'
      }
      else{
        this.tableRows[i].style.display = ""      
      }
    }
  }
}
