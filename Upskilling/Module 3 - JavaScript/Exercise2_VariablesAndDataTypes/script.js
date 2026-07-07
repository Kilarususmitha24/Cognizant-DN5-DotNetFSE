

function displayData(){

    let eventName = "Community Sports Meet";

    let eventDate = "25 July 2026";

    let participants = 250;

    let registrationOpen = true;

    document.getElementById("result").innerHTML =
    "<br>Event Name : " + eventName +
    "<br>Event Date : " + eventDate +
    "<br>Participants : " + participants +
    "<br>Registration Open : " + registrationOpen;

    console.log(eventName);
    console.log(eventDate);
    console.log(participants);
    console.log(registrationOpen);

}
