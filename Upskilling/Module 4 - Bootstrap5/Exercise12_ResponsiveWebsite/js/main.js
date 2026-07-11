
document.addEventListener("DOMContentLoaded", () => {

    console.log("Welcome to TechSite!");

});


const currentPage = window.location.pathname.split("/").pop();

const navLinks = document.querySelectorAll(".navbar-nav .nav-link");

navLinks.forEach(link => {

    const href = link.getAttribute("href");

    if (href === currentPage || (currentPage === "" && href === "index.html")) {

        link.classList.add("active");

    } else {

        link.classList.remove("active");

    }

});


const topButton = document.createElement("button");

topButton.innerHTML = "↑";

topButton.className = "btn btn-primary";

topButton.style.position = "fixed";
topButton.style.bottom = "20px";
topButton.style.right = "20px";
topButton.style.display = "none";
topButton.style.borderRadius = "50%";
topButton.style.width = "50px";
topButton.style.height = "50px";
topButton.style.zIndex = "999";

document.body.appendChild(topButton);


window.addEventListener("scroll", () => {

    if (window.scrollY > 250) {

        topButton.style.display = "block";

    } else {

        topButton.style.display = "none";

    }

});


topButton.addEventListener("click", () => {

    window.scrollTo({

        top: 0,

        behavior: "smooth"

    });

});


const cards = document.querySelectorAll(".card");

cards.forEach(card => {

    card.addEventListener("mouseenter", () => {

        card.style.transform = "translateY(-8px)";

        card.style.transition = "0.3s";

    });

    card.addEventListener("mouseleave", () => {

        card.style.transform = "translateY(0px)";

    });

});


const form = document.querySelector("form");

if (form) {

    form.addEventListener("submit", function (e) {

        e.preventDefault();

        const inputs = form.querySelectorAll("input, textarea");

        let valid = true;

        inputs.forEach(input => {

            if (input.value.trim() === "") {

                input.classList.add("is-invalid");

                valid = false;

            } else {

                input.classList.remove("is-invalid");

                input.classList.add("is-valid");

            }

        });

        if (valid) {

            alert("Message sent successfully!");

            form.reset();

            inputs.forEach(input => {

                input.classList.remove("is-valid");

            });

        }

    });

}


const footer = document.querySelector("footer p");

if (footer) {

    footer.innerHTML = `© ${new Date().getFullYear()} TechSite | All Rights Reserved`;

}
