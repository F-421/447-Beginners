// JavaScript source code
function testJava() {
    alert('You sucessfully clicked on Javascript');
}

/*For testing out Google maps */
function myMap() {
    var mapProp = {
        center: new google.maps.LatLng(51.508742, -0.120850),
        zoom: 5,
    };
    var map = new google.maps.Map(document.getElementById("googleMap"), mapProp);
}