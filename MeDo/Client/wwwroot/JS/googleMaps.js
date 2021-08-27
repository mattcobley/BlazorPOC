var initializeGoogle = () => {
    const latlng = new google.maps.LatLng(40.716948, -74.003563)
    const options = {
        zoom: 14, center: latlng,
        mapTypeId: google.maps.MapTypeId.ROADMAP
    }
    const map = new google.maps.Map(document.getElementById("google-map"), options)
}
