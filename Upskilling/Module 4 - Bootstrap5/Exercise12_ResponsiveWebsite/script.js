
window.addEventListener("load", function () {
    console.log("Welcome to TechSite!");
});

const navLinks = document.querySelectorAll(".nav-link");

navLinks.forEach(link => {
    link.addEventListener("click", function () {

        navLinks.forEach(item => {
            item.classList.remove("active");
        });

        this.classList.add("active");
    });
});

const form = document.querySelector("form");

if (form) {

    form.addEventListener("submit", function (event) {

        event.preventDefault();

        const name = document.querySelector('input[type="text"]');
        const email = document.querySelector('input[type="email"]');

        if (name.value.trim() === "") {
            alert("Please enter your name.");
            name.focus();
            return;
        }

        if (email.value.trim() === "") {
            alert("Please enter your email.");
            email.focus();
            return;
        }

        alert("Form submitted successfully!");

        form.reset();

    });

}

document.querySelectorAll('a[href^="#"]').forEach(anchor => {

    anchor.addEventListener("click", function (e) {

        e.preventDefault();

        const target = document.querySelector(this.getAttribute("href"));

        if (target) {

            target.scrollIntoView({

                behavior: "smooth"

            });

        }

    });

});

const buttons = document.querySelectorAll(".btn");

buttons.forEach(button => {

    button.addEventListener("click", function () {

        this.classList.add("shadow");

        setTimeout(() => {

            this.classList.remove("shadow");

        }, 300);

    });

});

const cards = document.querySelectorAll(".card");

cards.forEach(card => {

    card.addEventListener("mouseenter", function () {

        this.style.transform = "translateY(-10px)";

    });

    card.addEventListener("mouseleave", function () {

        this.style.transform = "translateY(0px)";

    });

});

const footer = document.querySelector("footer p");

if (footer) {

    const year = new Date().getFullYear();

    footer.innerHTML = "© " + year + " TechSite | All Rights Reserved";

}
