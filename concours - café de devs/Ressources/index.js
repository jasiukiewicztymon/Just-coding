window.addEventListener("scroll", () => {
    const vw = Math.max(document.documentElement.clientWidth || 0, window.innerWidth || 0);
    const vh = Math.max(document.documentElement.clientHeight || 0, window.innerHeight || 0);
    const slidebox = document.getElementById("slider-box");
    if (slidebox.getBoundingClientRect().top > vh / 100 * 50) 
        slidebox.style.opacity = 0;
    else 
        slidebox.style.opacity = 1;
})

setInterval(()=> {
    const slidebox1 = document.getElementById("slider-box1");
    const slidebox2 = document.getElementById("slider-box2");
    const slidebox3 = document.getElementById("slider-box3");

    if (slidebox1.className.includes("active-slide")) {
        slidebox2.classList.add("active-slide");
        slidebox1.classList.remove("active-slide");
    }
    else if (slidebox2.className.includes("active-slide")) {
        slidebox3.classList.add("active-slide");
        slidebox2.classList.remove("active-slide");
    }
    else {
        slidebox1.classList.add("active-slide");
        slidebox3.classList.remove("active-slide");
    }
}, 5000)