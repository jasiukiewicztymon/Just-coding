function change() {
    for (let i = 0; i < document.getElementsByClassName("label").length; i++)
        document.getElementsByClassName("label")[i].style.color = document.getElementById('color_font').value
    switch(document.getElementById('font_choice').value) {
        case 'Roboto':
            for (let i = 0; i < document.getElementsByClassName("label").length; i++)
                document.getElementsByClassName("label")[i].style.fontFamily = "Roboto,sans-serif"
            break;
        case 'Open Sans':
            for (let i = 0; i < document.getElementsByClassName("label").length; i++)
                document.getElementsByClassName("label")[i].style.fontFamily = "Open Sans,sans-serif"
            break;
        case 'Lato':
            for (let i = 0; i < document.getElementsByClassName("label").length; i++)
                document.getElementsByClassName("label")[i].style.fontFamily = "Lato,sans-serif"
            break;
        case 'Ubuntu':
            for (let i = 0; i < document.getElementsByClassName("label").length; i++)
                document.getElementsByClassName("label")[i].style.fontFamily = "Ubuntu,sans-serif"
            break;
    }
    document.body.style.backgroundColor = document.getElementById('color_background').value
}