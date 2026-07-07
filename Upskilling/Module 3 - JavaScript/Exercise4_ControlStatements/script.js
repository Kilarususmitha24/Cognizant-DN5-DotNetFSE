
function checkEligibility() {

    let age = 20;
    let eventType = "Sports";

    let output = "";



    if (age >= 18) {
        output += "<b>Eligibility:</b> Eligible to participate.<br><br>";
    } else {
        output += "<b>Eligibility:</b> Not Eligible.<br><br>";
    }

  

    switch(eventType){

        case "Sports":
            output += "<b>Venue:</b> City Stadium<br><br>";
            break;

        case "Music":
            output += "<b>Venue:</b> Town Hall<br><br>";
            break;

        case "Food":
            output += "<b>Venue:</b> Community Park<br><br>";
            break;

        default:
            output += "<b>Venue:</b> Not Available<br><br>";
    }

  

    output += "<b>Upcoming Events</b><br>";

    let events = [
        "Music Festival",
        "Sports Meet",
        "Food Carnival",
        "Book Exhibition"
    ];

    for(let i = 0; i < events.length; i++){

        output += (i + 1) + ". " + events[i] + "<br>";

    }

    output += "<br>";

   

    output += "<b>Countdown</b><br>";

    let count = 3;

    while(count > 0){

        output += count + "<br>";
        count--;

    }

    output += "Event Started!";

    document.getElementById("result").innerHTML = output;

}
