
// When the user scrolls down 20px from the top of the document, show the button
window.onscroll = function () { showFunction() };

function showFunction() {
  if (document.body.scrollTop > 20 || document.documentElement.scrollTop > 20) {
    document.getElementById("myBtn").style.display = "block";
  } else {
    document.getElementById("myBtn").style.display = "none";
  }
}

// When the user clicks on the button, scroll to the top of the document
function scrollFunction() {
  document.body.scrollTop = 0;
  document.documentElement.scrollTop = 0;
}

//drop down list for mobile view
function dropDown() {
 
  if ( document.getElementById("mynav").className === "nav") {
    document.getElementById("mynav").className += " responsive";
  } else {
    document.getElementById("mynav").className = "nav";
  }
}
