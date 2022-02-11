const btnAddForm = document.querySelector('#btn-add-form');
const formContainer = document.querySelector("#form-container");
const btnCloseForm = document.querySelector('#form-back-btn');

console.log(btnAddForm)

btnAddForm.addEventListener('click', () => {

    formContainer.classList.add('form-open');
})
btnCloseForm.addEventListener('click', () => {
    closeForm();
})

function closeForm() {
    formContainer.classList.remove('form-open');
}

