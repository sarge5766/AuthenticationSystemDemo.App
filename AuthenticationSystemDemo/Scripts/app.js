const btnlogin = document.querySelector('.btn-login')

btnlogin.addEventListener('mouseover', () => {
    btnlogin.classList.remove('changeBack')
    btnlogin.classList.add('changeButtonBackground')
})

btnlogin.addEventListener('mouseout', () => {
    btnlogin.classList.remove('changeButtonBackground')
    btnlogin.classList.add('changeBack')
})