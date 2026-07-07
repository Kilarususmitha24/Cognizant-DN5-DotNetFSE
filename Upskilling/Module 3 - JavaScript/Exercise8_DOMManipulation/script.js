

function changeContent(){

    document.getElementById("heading").innerHTML =
    "Community Event Portal - Updated";

    document.getElementById("message").innerHTML =
    "Registration for the Annual Sports Meet is now OPEN!";

    document.getElementById("heading").style.color = "blue";

    document.body.style.backgroundColor = "#E3F2FD";

    document.getElementById("message").style.fontSize = "22px";

    document.getElementById("message").style.color = "green";

    document.getElementById("eventImage").src =
    "https://picsum.photos/401/250";

    console.log("DOM Updated Successfully");

}
