function searchCars() {
    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            var data = JSON.parse(this.responseText);
            data.car.forEach(element => {
                var node = document.createElement("li");
                node.innerText = element;
                document.getElementById("car").appendChild(node)
            });
        }
    };
    xhttp.open("GET", "http://localhost:55700/api/cars", true);
    xhttp.sent();
}
