

function calculate() {

    let adults = 120;
    let children = 80;

    let total = adults + children;
    let difference = adults - children;
    let multiplication = adults * children;
    let division = adults / children;
    let remainder = adults % children;

    let comparison = adults > children;

    let registration = true;
    let payment = true;
    let confirmed = registration && payment;

    let seats = 100;
    seats += 20;

    document.getElementById("result").innerHTML =
    "<b>Arithmetic Operators</b><br><br>" +
    "Total Participants : " + total + "<br>" +
    "Difference : " + difference + "<br>" +
    "Multiplication : " + multiplication + "<br>" +
    "Division : " + division + "<br>" +
    "Remainder : " + remainder + "<br><br>" +

    "<b>Comparison Operator</b><br>" +
    "Adults > Children : " + comparison + "<br><br>" +

    "<b>Logical Operator</b><br>" +
    "Registration Confirmed : " + confirmed + "<br><br>" +

    "<b>Assignment Operator</b><br>" +
    "Available Seats : " + seats;

    console.log(total);
    console.log(comparison);
    console.log(confirmed);
}
