const btnAddForm = document.querySelector('#btn-add-form');
const formContainer = document.querySelector("#form-container");
const btnCloseForm = document.querySelector('#form-back-btn');

btnAddForm.addEventListener('click', ()=>{
    formContainer.classList.add('form-open');
})
btnCloseForm.addEventListener('click', ()=>{
    formContainer.classList.remove('form-open');
})

