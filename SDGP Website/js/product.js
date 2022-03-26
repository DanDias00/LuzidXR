window.addEventListener("load", function () {
    let url = new URLSearchParams(this.location.search);
    let id = url.get("productId");


    //to retrieve the product details
    for (product of products) {
        if (product.id == id) {

            this.document.getElementById("p_name").innerHTML += product.name;
            this.document.getElementById("p_des").innerHTML += product.description;
            this.document.getElementById("p_price").innerHTML += product.price;
            this.document.getElementById("myImg").src = product.image;
        }
    }
}

);

// create method to pass to unity
function sendToUnity() {
    let url = new URLSearchParams(this.location.search);
    let id = url.get("productId");
    window.location.href = "https://chanithas.github.io/LuzidXR/?val=" + id + "";
}