
var number = localStorage.getItem("number");




function getProductList() {
    const ImagePath = 'images/'
    const product1 = new Product("Mens shirt", "$ 80",ImagePath + '1.jpg');
    const product2 = new Product("Mens trouse", "$ 50", ImagePath + '2.jpg');
    const product3 = new Product("Women frock", "$ 60", ImagePath + '3.jpg');
    const product4 = new Product("Mens t-shirt", "$ 40", ImagePath + '4.jpg');
    const product5 = new Product("Nike T-shirt","$ 70", ImagePath + '5.jpg');
    const product6 = new Product("Nike T-shirt", "$ 50", ImagePath+ '6.jpg');
	const product7 = new Product("Mens trouse", "$ 20", ImagePath+ '7.jpg');
	const product8 = new Product("Mens shirt", "$ 40", ImagePath+ '8.jpg');
    return [product1, product2, product3, product4, product5, product6, product7, product8];

    
}
class Product {
    constructor(productName, productPrice, productImage,productDetails) {
        this.productName = productName;
        this.productPrice = productPrice;
        this.productImage = productImage;
    }
}










function show(productCode) {
    localStorage.setItem("number",parseInt(productCode))



    window.location = "Product details.html"
    
  
}

    
    
window.addEventListener('load',() => {
    
    localStorage.getItem("number");
    const productList = getProductList();
    document.getElementById("productName").innerHTML = productList[number].productName;

    const header = document.getElementById("header");

    const cloth = document.createElement("img");
    cloth.src = productList[number].productImage;
    header.appendChild(cloth)
    document.getElementById("price").innerHTML = productList[number].productPrice;
   

})
















