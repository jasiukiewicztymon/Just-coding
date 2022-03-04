$(document).ready(function(){
    const date = new Date();
    const hour = date.getHours();

    if (hour >= 20 || hour <= 5) {
        document.querySelector('#dark-theme').classList.add('none');
        document.querySelector('#light-theme').classList.remove('none');

        document.querySelector('body').classList.add('dark');
        document.querySelectorAll('.github img').forEach(e => {
            e.style.filter = 'invert(100%)';
        })

        document.getElementById('copyrights').classList.add('dark');
    }

    $('#dark-theme').click(() => {
        document.querySelector('#dark-theme').classList.add('none');
        document.querySelector('#light-theme').classList.remove('none');

        document.querySelector('body').classList.add('dark');
        document.querySelectorAll('.github img').forEach(e => {
            e.style.filter = 'invert(100%)';
        })

        document.getElementById('copyrights').classList.add('dark');
    });
    $('#light-theme').click(() => {
        document.querySelector('#light-theme').classList.add('none');
        document.querySelector('#dark-theme').classList.remove('none');

        document.querySelector('body').classList.remove('dark');
        document.querySelectorAll('.github img').forEach(e => {
            e.style.filter = 'invert(0%)';
        })

        document.getElementById('copyrights').classList.remove('dark');
    });
});