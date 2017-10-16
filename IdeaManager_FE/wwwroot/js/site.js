  // Write your JavaScript code.
  var ideaList = [{}];

  function ajaxCall(url) {
    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function() {
      if( this.readyState === 4 ) { // Request is finished and response ready
        if( this.status === 200 ) {
          ideaList.push({ name: this.response});
          console.log(JSON.parse(this.responseText));
        } else if( this.status === 404 ){
          alert ("URL " + url + " not found. Check server instalation is correctly done.");
        } else {
          alert ("Unknown error occcured: " + this.status + " " + this.statusText)
        }  
      }
    };
    xhttp.open("GET", url, true);
    xhttp.send();
  }

  function newIdea() {
    ajaxCall( "/api/ideas");
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
      console.log(ideaList);
  }