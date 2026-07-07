

function divideNumbers(){

try{

    let totalParticipants = 100;

    let groups = 5;

    if(groups==0){

        throw "Groups cannot be zero.";

    }

    let result = totalParticipants/groups;

    document.getElementById("result").innerHTML =
    "Participants per Group : " + result;

    console.log(result);

}

catch(error){

    document.getElementById("result").innerHTML =
    error;

}

finally{

    console.log("Execution Completed.");

}

}
