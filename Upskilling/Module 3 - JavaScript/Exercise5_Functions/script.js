
function welcomeMessage(){

    return "Welcome to Community Event Portal";

}

function eventDetails(name,date){

    return "Event : " + name + "<br>Date : " + date;

}

function calculateFee(price,participants){

    return price * participants;

}

function displayDetails(){

    let message = welcomeMessage();

    let details = eventDetails(
        "Music Festival",
        "25 July 2026"
    );

    let totalFee = calculateFee(200,50);

    document.getElementById("result").innerHTML =
    "<b>" + message + "</b><br><br>" +
    details +
    "<br><br>" +
    "Total Registration Fee : ₹" + totalFee;

    console.log(message);
    console.log(details);
    console.log(totalFee);

}
