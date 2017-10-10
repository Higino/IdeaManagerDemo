// Write your JavaScript code.

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
