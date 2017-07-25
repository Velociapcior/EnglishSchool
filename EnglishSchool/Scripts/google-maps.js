function initMap() {
    var uluru = { lat: 51.1390959, lng: 16.96890099999996 };
    var map = new google.maps.Map(document.getElementById('map'), {
        zoom: 16,
        center: uluru
    });

    var infowindow = new google.maps.InfoWindow();
    var contentString = '<div id="content">' +
        '<div id="siteNotice">' +
        '</div>' +
        '<h4 id="firstHeading" class="firstHeading">English School</h4>' +
        '<address>' +
        'Kozanowska 89/15<br/>'+
        '54-152 Wrocław<br/>'+
        '<abbr title="Phone">P:</abbr>'+
        '+48 695366430'+
        '</address>' +
        '</div>' +
        '</div>';

    var infowindow = new google.maps.InfoWindow({
        content: contentString
    });

    var marker = new google.maps.Marker({
        position: uluru,
        map: map
    });
    infowindow.open(map, marker);

}