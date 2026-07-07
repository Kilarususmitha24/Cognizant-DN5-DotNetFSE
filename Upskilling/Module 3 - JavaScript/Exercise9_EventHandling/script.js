
function clickEvent(){

    document.getElementById("output").innerHTML =
    "Button Clicked Successfully";

}

function doubleClickEvent(){

    document.getElementById("output").innerHTML =
    "Button Double Clicked";

}

let box = document.getElementById("box");

box.onmouseover = function(){

    box.style.background = "lightgreen";

    box.innerHTML = "Mouse Over";

}

box.onmouseout = function(){

    box.style.background = "lightgray";

    box.innerHTML = "Move Mouse Here";

}

function changeEvent(){

    let value =
    document.getElementById("events").value;

    document.getElementById("output").innerHTML =
    "Selected Event : " + value;

}

document.getElementById("name").onkeydown =
function(){

    document.getElementById("output").innerHTML =
    "Typing...";

}

document.getElementById("heading")
.addEventListener("click",function(){

    alert("Community Event Portal");

});
