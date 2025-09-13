<!DOCTYPE html>
<html lang="es">
<head>
  <meta charset="UTF-8">
  <title>Poema de Amor</title>
  <link href="https://fonts.googleapis.com/css2?family=Great+Vibes&family=Open+Sans&display=swap" rel="stylesheet">
  <style>
    body {
      margin: 0;
      padding: 0;
      background: linear-gradient(135deg, #fbd3e9, #bb377d);
      font-family: 'Open Sans', sans-serif;
      color: #fff;
      overflow: hidden;
    }

    .container {
      max-width: 800px;
      margin: 5% auto;
      background-color: rgba(255, 255, 255, 0.1);
      padding: 40px;
      border-radius: 15px;
      box-shadow: 0 8px 32px rgba(0,0,0,0.2);
      backdrop-filter: blur(8px);
      animation: fadeIn 2s ease-in-out;
    }

    h1 {
      font-family: 'Great Vibes', cursive;
      font-size: 3em;
      text-align: center;
      margin-bottom: 20px;
      color: #ffe9f3;
    }

    p {
      font-size: 1.2em;
      line-height: 1.8em;
      text-align: justify;
      opacity: 0;
      animation: reveal 2s forwards;
    }

    p:nth-of-type(1) { animation-delay: 0.5s; }
    p:nth-of-type(2) { animation-delay: 1s; }
    p:nth-of-type(3) { animation-delay: 1.5s; }
    p:nth-of-type(4) { animation-delay: 2s; }
    p:nth-of-type(5) { animation-delay: 2.5s; }
    p:nth-of-type(6) { animation-delay: 3s; }

    @keyframes fadeIn {
      from { opacity: 0; transform: translateY(30px); }
      to { opacity: 1; transform: translateY(0); }
    }

    @keyframes reveal {
      to { opacity: 1; }
    }

    /* Corazones flotando */
    .heart {
      position: absolute;
      width: 20px;
      height: 20px;
      background: pink;
      transform: rotate(45deg);
      animation: floatUp 10s infinite ease-in;
      opacity: 0.6;
    }

    .heart::before,
    .heart::after {
      content: '';
      position: absolute;
      width: 20px;
      height: 20px;
      background: pink;
      border-radius: 50%;
    }

    .heart::before {
      top: -10px;
      left: 0;
    }

    .heart::after {
      left: -10px;
      top: 0;
    }

    @keyframes floatUp {
      0% {
        bottom: -50px;
        left: calc(100% * var(--x));
        opacity: 0;
      }
      50% {
        opacity: 0.8;
      }
      100% {
        bottom: 110%;
        left: calc(100% * var(--x) + 30px);
        opacity: 0;
      }
    }
  </style>
</head>
<body>

  <!-- Corazones -->
  <div class="heart" style="--x: 0.1;"></div>
  <div class="heart" style="--x: 0.3;"></div>
  <div class="heart" style="--x: 0.5;"></div>
  <div class="heart" style="--x: 0.7;"></div>
  <div class="heart" style="--x: 0.9;"></div>

  <div class="container">
    <h1>Amor Verdadero</h1>
    <p>Amor es más que una palabra; es la sinfonía callada que susurra entre miradas.</p>
    <p>Es el temblor en los dedos antes de rozar otra piel, el vértigo dulce de saberse vulnerable ante alguien, y aún así, entregarse por completo.</p>
    <p>Es el olor de una camiseta impregnada de la otra persona, que al abrazarla en soledad, calma el alma más que mil canciones.</p>
    <p>Es saber que nada es perfecto, pero aún así elegir una y otra vez a la misma persona, con sus luces y sombras.</p>
    <p>Amor es mirarse como si el tiempo se deshiciera, como si en ese instante el universo conspirara para que todo tenga sentido.</p>
    <p>Porque el amor verdadero no grita, no presume, no exige. El amor verdadero cuida, respeta, construye, escucha… y sobre todo, permanece.</p>
  </div>

</body>
</html>
