// Write your JavaScript code.

function UserAction() {
    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function() {
      if (this.readyState == 4 && this.status == 200) {
        var jsonResponse = JSON.parse(this.responseText);
        alert(jsonResponse);
      }
    };
    xhttp.open("GET", "/api", true);
    xhttp.send();
}

function newIdea() {
      if ($("input[name=ideaTitle]").val() === '' || $("input[name=ideaAuthor]").val() === '') {
        alert("You must write something!");
        return;
      }

    $('#ideaList').append("<div class='col-sm-4'><h2>"+ $("input[name=ideaTitle]").val()+ "</h2>" + 
                    "<div class='card'>" +
                        "<img src='../images/idea-light-bulb.svg' alt='nice Avatar' style='width:20%'>" + 
                            "<div class='container'>" +
                               "<h4><b>"+ $("input[name=ideaAuthor]").val() + "</b></h4>" +
                               "<p>Interior Designer</p>" +
                            "</div>" + 
                    "</div>" +
                 "</div>");
}
