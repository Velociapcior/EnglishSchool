function initMap() {
    var uluru = { lat: 51.1390959, lng: 16.96890099999996 };
    var map = new google.maps.Map(document.getElementById('map'), {
        zoom: 16,
        center: uluru
    });
    var marker = new google.maps.Marker({
        position: uluru,
        map: map
    });
}