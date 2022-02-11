const formAddItem = document.getElementById('form-additem');

const contentSection = document.querySelector('#content-section');

const itemCount = document.querySelector('#item-count');

const Item = function (name, quantity, unitPrice) {
    this.name = name;
    this.quantity = quantity;
    this.unitPrice = unitPrice;
    this.totalPrice = function () {
        return this.quantity * this.unitPrice
    }
}

let item1 = new Item("Agbado", 4, 200)
let items = [item1];


let template = fetch('template.txt').then(r => r.text())
    .then(res => res)

function grossTotalPrice() {
    let sum = 0;

    for (let item of items) sum += item.totalPrice();

    return sum;
}

function addToItems(item) {
    var oldItem = items.find(i => i.name.toLowerCase() === item.name.toLowerCase());

    if (oldItem == undefined) {
        items.push(item);
        return;
    }

    oldItem.quantity = parseInt(oldItem.quantity) + parseInt(item.quantity);
}

function removeItemFromItem(name) {
    var oldItem = items.find(i => i.name.toLowerCase() === name.toLowerCase());

    if (oldItem == undefined) return;

    items = items.filter(i => i.name.toLowerCase() !== name.toLowerCase());

}

function renderItems() {
    contentSection.innerHTML = "";

    for (let i = 0; i < items.length; i++) addItemToList(items[i])

    updateTotalPrice();
}

function addItemToList(item) {
    createItem(item).then(it => {
        contentSection.innerHTML += it;
    })
}


async function createItem(item) {
    let temp = await template;
    let it = temp
        .replace('$$INITIALS', item.name.substring(0, 1).toUpperCase())
        .replace('$$ITEM', item.name)
        .replace('$$TOTALPRICE', formatAsCurrency(item.totalPrice()))
        .replace('$$QUANTITY', item.quantity)
        .replace('$$UNITPRICE', formatAsCurrency(item.unitPrice));

    return it;

}

function updateTotalPrice() {
    let totalPriceitem = document.querySelector('#total-price');
    totalPriceitem.innerText = items.length == 0 ? 0 : formatAsCurrency(grossTotalPrice());

    itemCount.innerText = items.length + " items"
}

function formatAsCurrency(x) {
    return '$' + x.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",");
}

function deleteRowOnClick(name) {

    removeItemFromItem(name);
    renderItems();


}

formAddItem.addEventListener('submit', function (e) {

    e.preventDefault();
    const inputName = document.getElementById('input-item-name');
    const inputQuantity = document.getElementById('input-item-quantity');
    const inputUnitPrice = document.getElementById('input-item-unit-price');

    let newItem = new Item(inputName.value, inputQuantity.value, inputUnitPrice.value);

    addToItems(newItem);

    renderItems();

    inputName.value = "";
    inputQuantity.value = "";
    inputUnitPrice.value = "";

    closeForm();

});

renderItems();

