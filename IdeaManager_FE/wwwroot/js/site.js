// Write your JavaScript code.
var ideaList = [];

document.addEventListener("DOMContentLoaded", function(event) {
    ajaxCallIdeasApi('/api/ideas');
  });

function ajaxCallIdeasApi(url, method, data) {

    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function() {
        if( this.readyState === 4 ) {
            if( this.status === 200 || this.status === 201 ) {
                var responseArr = JSON.parse(this.responseText);
                console.log(this.responseText);
                console.log(responseArr);
                while(responseArr.length > 0 ) {
                    var aIdea = responseArr.pop();
                    ideaList.push((aIdea));
                    renderIdea(aIdea);
                }
            } else if( this.status === 404 ){
                alert ("URL " + url + " not found. Check that server instalation is correctly done.");
            } else {
                alert ("Unknown error occcured: " + this.status + " " + this.statusText)
            }  
        }
    };
    if( ! method ) {
        method = "GET";
        xhttp.open(method, url, true);
        xhttp.send();
    } else { 
        xhttp.open(method, url, true);
        xhttp.setRequestHeader("Content-type", "application/json");
        xhttp.send(data);
    }
    console.log("Request: {url: "+url+", method:"+method+", data: "+data+"} sent");

}

function renderIdea(idea) {
    if (idea === '') {
      alert("You must write something!");
      return;
    }

    $('#ideaList').append("<div class='col-sm-4'><h2>"+ idea.title + "</h2>" + 
                  "<div class='card'>" +
                      "<img src='../images/idea-light-bulb.svg' alt='nice Avatar' style='width:20%'>" + 
                          "<div class='container'>" +
                            "<h4><b>"+ idea.author + "</b></h4>" +
                            "<p>Interior Designer</p>" +
                          "</div>" + 
                  "</div>" +
              "</div>");
}

function newIdea() {
    if ($("input[name=ideaTitle]").val() === '' || $("input[name=ideaAuthor]").val() === '') {
      alert("You must write something!");
      return;
    }

    var ideaData = { author: $("input[name=ideaAuthor]").val(), title: $("input[name=ideaTitle]").val()};
    console.log("Creating a new idea");
    ajaxCallIdeasApi("/api/ideas", "POST", JSON.stringify(ideaData));

    renderIdea(ideaData);
}
