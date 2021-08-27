var leafletmap
var marker

var initializeLeaflet = () => {
    leafletmap = L.map('leaflet-map').setView({ lat: 51.380001, lon: -2.36 }, 13)

    // add the OpenStreetMap tiles
    L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
        maxZoom: 19,
        attribution: '&copy; <a href="https://openstreetmap.org/copyright">OpenStreetMap contributors</a>'
    }).addTo(leafletmap)

    // show the scale bar on the lower left corner
    L.control.scale().addTo(leafletmap)

}

var addMarker = (dotNetHelper) => {
    if (!marker) {
        marker = L.marker({ lat: 51.380001, lon: -2.36 }).bindPopup('Bath, UK').addTo(leafletmap)
        setMarkerIsVisible(dotNetHelper, true)
    }
}

var removeMarker = (dotNetHelper) => {
    if (marker) {
        marker.removeFrom(leafletmap)
        marker = null
        setMarkerIsVisible(dotNetHelper, false)
    }
}

// This method is totally redundant, but is used in combination with (the also redundant) ToggleMarkerIsVisible C# method to show JS interop calling a C# method from JS
var setMarkerIsVisible = (dotNetHelper, newState) => {
    return dotNetHelper.invokeMethodAsync('ToggleMarkerIsVisible', newState)
        .then((confirmedState) => {
            console.log(`CONFIRMING NEW STATE: ${confirmedState}`)
        })
}