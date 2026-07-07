

function loadData(){

fetch("https://jsonplaceholder.typicode.com/posts?_limit=5")

.then(function(response){

    return response.json();

})

.then(function(data){

    let output="<h2>Upcoming Events</h2>";

    data.forEach(function(event){

        output +=
        "<h3>" + event.title + "</h3>" +
        "<p>" + event.body + "</p><hr>";

    });

    document.getElementById("result").innerHTML=output;

})

.catch(function(error){

    document.getElementById("result").innerHTML=
    "Error Loading Data";

    console.log(error);

});

}
