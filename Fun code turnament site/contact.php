<?php
    if(isset($_POST['submit'])) {
        if(!empty($_POST['subject']) AND !empty($_POST['message'])) {
            $subject = ($_POST['subject']);
            $msg = nl2br($_POST['message']);

            mail('yourmail@email.ch', $subject, $msg);

            echo '<script language="javascript">';
            echo 'alert("Sending...")';
            echo '</script>';
        }
    }
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Fun Code Tournament - Index</title>

    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.googleapis.com/css2?family=Open+Sans:wght@500&display=swap" rel="stylesheet">

    <!-- CSS -->
    <link rel="stylesheet" href="./style/contact.css">
    <!-- Bootstrap CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <!-- Tailwind CSS -->
    <script src="https://cdn.tailwindcss.com"></script>

    <!-- JQuery -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <!-- JavaScript -->    
    <script src="./javascript/darkcontact.js"></script>
</head>
<body class="grid grid-cols-12">
    <nav class="top-0 left-0 flex relative z-[1] col-span-12 h-[100%] w-[97.5vw] mb-[15vw] lg:mb-[12.5vw] lg:mb-[10vw] lg:mb-[2vw]">
        <ul class="grid grid-cols-4 lg:grid-cols-6 w-[100vw] lg:w-[85vw] ml-[5vw] mt-[3vw] text-[3vw] lg:text-[2vw]">
            <li><a href="">🏠 Accueil</a></li>
            <li><a href="#">🗓 Calendrier</a></li>
            <li><a href="#">🏆 Podium</a></li>
            <li><a href="#">📞 Contact</a></li>
        </ul>
        <button id="connection_btn" class="mt-[2vw] lg:mt-0 top-[10vw] left-[50%] -translate-x-[100%] lg:-translate-x-[0%] lg:left-auto lg:top-[2.5vw] hover:bg-blue-700 lg:right-[1vw] absolute text-[2.5vw] lg:text-[1.5vw] p-[0.7vw] hover:scale-[115%] transition ease-in-out rounded-[1vw] bg-blue-600 text-white">Connexion</button>
        <div id="theme-switcher" class="scale-125 lg:scale-100 top-[10.5vw] lg:top-[2.5vw] left-[55%] lg:left-auto lg:-translate-x-[0%] absolute lg:right-[12.5vw] lg:top-[2.5vw] mt-[2.5vw] lg:mt-[0.5vw] mr-[3vw]">
            <span id="dark-theme" class="absolute"></span>
            <span id="light-theme" class="absolute none"></span>
        </div>
    </nav>
    <article class="col-span-12 ml-[5vw] grid grid-cols-3">
        <h1 class="text-[2.5vw] col-span-3 text-center mb-[2vw] mt-[1vw]">Si vous avez quelconque doute contactez nous !</h1>
        <section id="discord-section" class="mt-[3vw] lg:mt-[10vw] w-[90vw] lg:w-auto p-[1.3vw] col-span-3 lg:col-span-1 rounded-[1.5vw]">
            <h2 class="text-[2.5vw] lg:text-[1.5vw]">Rejoinez notre discord...</h2>
            <p class="mb-[3vw] mt-[2vw] lg:mt-[1vw] text-[2vw] lg:text-[1.2vw]">Une communauté super avec des membres actifs et ouvert aux question. Le staff fait de son mieux pour organiser des concours</p>
            <a href="https://discord.gg/McGgzaS63M" target="_blank" rel="noopener noreferrer" class="text-[2vw] lg:text-[1.1vw]"><h2 class="hover:underline hover:decoration-blue-600">Rejoint dès maintenant</h2></a>
        </section>
        <section id="mail-section" class="mt-[5vw] lg:mt-[1vw] relative h-[25vw] col-span-3 lg:col-span-2">
            <div class="absolute left-[50%] -translate-x-[50%]">
                <h2 class="text-[2.5vw] lg:text-[1.5vw]">Ou bien écris nous un message ici</h2>
                <form action="" method="post" >
                    <input id="subject" type="text" placeholder="Sujet" name="subject" class="text-[2.5vw] lg:text-[1.5vw] ml-[50%] lg:ml-0 -translate-x-[50%] lg:-translate-x-[0%] border-[0.2vw] border-[#201f1f] rounded-[1.2vw] p-[1vw] mb-[1vw] mt-[1.5vw] text-black w-[30vw] lg:w-[20vw]"><br>
                    <textarea id="message" name="message" placeholder="Ton message" class="text-[2.5vw] lg:text-[1.5vw] ml-[50%] lg:ml-0 -translate-x-[50%] lg:-translate-x-[0%] border-[0.2vw] border-[#201f1f] mb-[1vw] w-[25vw] h-[30vw] lg:h-[20vw] rounded-[1.2vw] p-[1vw] text-black w-[40vw] lg:w-[30vw]"></textarea><br>
                    <input id="submit" type="submit" name="submit" value="Envoyer" class="left-[50%] relative -translate-x-[50%]">
                </form>
            </div>
        </section>
    </article>
    <footer class="relative bottom-[2.5vw] grid grid-cols-5 w-[70vw] l-[50%] transform translate-x-[25%] mt-[40vw] lg:mt-[15vw]">
        <section class="youtube col-span-1 col-start-1">
            <h2 class="text-[2.2vw] lg:text-[1.1vw] mb-[1.5vw]">Notre Youtube : </h2>
            <a href="https://www.youtube.com/channel/UCHWPs-vJg9uGkyIrixR-yCA" target="_blank"><img src="./img/youtube.png" alt="Youtube" class="icon" width="40vw"></a>
        </section>
        <section class="discord col-span-1 col-start-2">
            <h2 class="mb-[3vw] text-[2.1vw] lg:text-[1.1vw] lg:mb-[1.5vw]">Notre Discord : </h2>
            <a href="https://discord.gg/McGgzaS63M" target="_blank"><img src="./img/discord.svg" alt="Discord" class="icon" width="40vw"></a>
        </section>
        <section class="github col-span-1 col-start-4">
            <h2 class="mb-[3vw] text-[2.1vw] lg:text-[1.1vw] lg:mb-[1.5vw]">Front-end : </h2>
            <a href="https://github.com/jasiukiewicztymon" target="_blank"><img src="./img/github.png" alt="GitHub" class="icon" width="40vw"></a>
        </section>
        <section class="github col-span-1 col-start-5">
            <h2 class="mb-[3vw] text-[2.1vw] lg:text-[1.1vw] lg:mb-[1.5vw]">Back-end : </h2>
            <a href="" target="_blank"><img src="./img/github.png" alt="GitHub" class="icon" width="40vw"></a>
        </section>
    </footer>
    <div id="copyrights" class="z-[100] text-[2vh] lg:text-[2vw]">© - Fun Code Tournament</div>
</body>
</html>
