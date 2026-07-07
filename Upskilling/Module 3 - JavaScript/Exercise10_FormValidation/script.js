function validateForm(){

    let name =
    document.getElementById("name").value.trim();

    let email =
    document.getElementById("email").value.trim();

    let phone =
    document.getElementById("phone").value.trim();

    let age =
    document.getElementById("age").value.trim();

    let message =
    document.getElementById("message");

   

    if(name==""){

        message.innerHTML="Please enter your name.";

        return false;

    }

  

    let emailPattern =
    /^[^\s@]+@[^\s@]+\.[^\s@]+$/;

    if(!emailPattern.test(email)){

        message.innerHTML="Enter a valid email.";

        return false;

    }


    if(phone.length!=10 || isNaN(phone)){

        message.innerHTML="Phone number must contain 10 digits.";

        return false;

    }


    if(age<18){

        message.innerHTML="Age must be 18 or above.";

        return false;

    }

    message.style.color="green";

    message.innerHTML="Registration Successful!";

    return false;

}
