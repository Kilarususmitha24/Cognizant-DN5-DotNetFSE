

function showEvents() {

    let events = [
        "Music Festival",
        "Sports Meet",
        "Food Carnival",
        "Book Exhibition"
    ];

    events.push("Coding Hackathon");

    events.pop();

    let output = "";

    output += "<b>Total Events : </b>" + events.length + "<br><br>";

    output += "<b>First Event : </b>" + events[0] + "<br>";
    output += "<b>Last Event : </b>" + events[events.length - 1] + "<br><br>";

    output += "<b>All Events</b><br><br>";

    for(let i = 0; i < events.length; i++){

        output += (i + 1) + ". " + events[i] + "<br>";

    }

    document.getElementById("result").innerHTML = output;

    console.log(events);

}
