// ligth and dark theme switcher
fetch('./javascript/serverinfo.json')
.then(res => res.json()) 
.then(data => {
    document.querySelector("#totalmembers").textContent = data.total;
    document.querySelector("#activemembers").textContent = data.online;
})