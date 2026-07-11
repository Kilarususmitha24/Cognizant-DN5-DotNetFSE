

const tooltipTriggerList =
document.querySelectorAll('[data-bs-toggle="tooltip"]');

tooltipTriggerList.forEach(function (element){

new bootstrap.Tooltip(element);

});


const popoverTriggerList =
document.querySelectorAll('[data-bs-toggle="popover"]');

popoverTriggerList.forEach(function(element){

new bootstrap.Popover(element);

});
