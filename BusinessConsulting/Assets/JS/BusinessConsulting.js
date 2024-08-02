
// ///////////////////////////////////////////////////ABOUT/////////////////////////////////////////////////// //
document.addEventListener('DOMContentLoaded', (event) => {
    let dropdowns = document.querySelectorAll('.dropdown');

    dropdowns.forEach(dropdown => {
        let button = dropdown.querySelector('.dropbtn');
        let content = dropdown.querySelector('.dropdown-content');
        
        button.addEventListener('click', function() {
            let isOpen = content.classList.contains('show');

            // Fermer tous les dropdowns
            document.querySelectorAll('.dropdown-content').forEach(content => {
                content.classList.remove('show');
                content.parentElement.style.marginBottom = '0px';
            });

            // Fermer toutes les flèches
            document.querySelectorAll('.dropdown').forEach(dd => {
                dd.classList.remove('active');
            });

            // Ouvrir le dropdown cliqué
            if (!isOpen) {
                content.classList.add('show');
                content.parentElement.style.marginBottom = content.scrollHeight + 'px';
                dropdown.classList.add('active');
            }
        });
    });

    window.onclick = function(event) {
        if (!event.target.matches('.dropbtn')) {
            document.querySelectorAll('.dropdown-content').forEach(content => {
                content.classList.remove('show');
                content.parentElement.style.marginBottom = '0px';
            });
            document.querySelectorAll('.dropdown').forEach(dropdown => {
                dropdown.classList.remove('active');
            });
        }
    }
});




'use strict';

const overlay = document.querySelector("[data-overlay]");
const navOpenBtn = document.querySelector("[data-nav-open-btn]");
const navbar = document.querySelector("[data-navbar]");
const navCloseBtn = document.querySelector("[data-nav-close-btn]");
const navLinks = document.querySelectorAll("[data-nav-link]");

const navElemArr = [navOpenBtn, navCloseBtn, overlay];

const navToggleEvent = function (elem) {
  for (let i = 0; i < elem.length; i++) {
    elem[i].addEventListener("click", function () {
      navbar.classList.toggle("active");
      overlay.classList.toggle("active");
    });
  }
}

navToggleEvent(navElemArr);
navToggleEvent(navLinks);