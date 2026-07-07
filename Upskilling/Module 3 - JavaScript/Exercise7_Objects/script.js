

function displayEvent(){

  
    const event = {

        eventId:101,

        eventName:"Community Sports Meet",

        eventDate:"25 July 2026",

        venue:"City Stadium",

        participants:250,

        organizer:"Community Club",

     
        eventInfo:function(){

            return "Welcome to " + this.eventName;

        }

    };

    let output="";

    output += "<b>" + event.eventInfo() + "</b><br><br>";

    output += "<b>Event ID :</b> " + event.eventId + "<br>";

    output += "<b>Event Name :</b> " + event.eventName + "<br>";

    output += "<b>Event Date :</b> " + event.eventDate + "<br>";

    output += "<b>Venue :</b> " + event.venue + "<br>";

    output += "<b>Participants :</b> " + event.participants + "<br>";

    output += "<b>Organizer :</b> " + event.organizer;

    document.getElementById("result").innerHTML = output;

    console.log(event);

}
