# AlienRun 👽🏃

[English](#english) | [Español](#español)

---

## English

A 2D endless runner built in Unity, in the style of Google's Dino game, made for the **TP05** assignment of *Programación con Motores de Videojuegos I* (Tecnicatura Superior en Desarrollo de Videojuegos, Image Campus).

**🎮 Play it here:** https://kevinlivora.itch.io/alien-run

### Features

- Physics-based jump (`Rigidbody2D` + `AddForce`) with ground detection through layers
- Endless world: the player stays in place while obstacles and collectibles move towards them
- Difficulty increases over time: the world speed accelerates up to a capped maximum
- Score based on distance travelled, plus bonus points from coins
- Four obstacle types spawned at random intervals
- Three collectibles:
  - **Coin**: adds points
  - **Star**: 5 seconds of invincibility, with a visible countdown on the HUD
  - **Blue gem**: adds an extra life (up to a maximum), which is consumed on a hit followed by a brief invincibility
- Parallax background with several layers and an infinitely scrolling ground
- Sprite animations for the player, obstacles and collectibles, and a dust particle effect when jumping and landing
- Player values (jump force, gravity, jump key, invincibility duration) editable through a **ScriptableObject**
- Central **AudioManager** with an **AudioMixer**: independent Master, Music, SFX and UI volume sliders in the Settings menu
- Best score saved between sessions
- Two scenes: **Main Menu** (Play, Settings, Credits, Quit) and **Gameplay**, with a Game Over panel offering **Retry** / **Menu**
- Decoupled architecture: the player notifies actions through events, and audio, effects and animation react on their own

### Controls

| Action | Key |
|---|---|
| Jump | Space |

### Built with

- Unity 6000.3.21f1
- TextMeshPro
- Art and sound effects from [Kenney](https://kenney.nl) (CC0)

### Project structure

```
Assets/
├── Art/
│   ├── Animations/   # Animation clips and Animator Controllers
│   ├── Audio/        # Music, sound effects and GameMixer
│   └── Sprites/
├── Data/             # ScriptableObjects (PlayerData)
├── Prefabs/          # Obstacles, collectibles, AudioManager, UI panels
├── Scenes/           # Main Menu, Gameplay
└── Scripts/
    ├── Audio/        # AudioManager, MusicPlayer, PlayerAudio
    ├── Data/         # PlayerDataSo
    ├── Gameplay/     # GameManager, Spawner, Obstacle, Collectible, parallax...
    ├── Player/       # PlayerController, PlayerPowerUps, PlayerEffects, PlayerAnimator
    └── UI/           # HUD, menus, settings
```

### Run it locally

1. Clone this repository.
2. Open the project with **Unity 6000.3.21f1** (or a compatible 6000.3.x LTS version) via Unity Hub.
3. Open `Assets/Scenes/Main Menu.unity` and press Play.

### Credits

- Developed by **Kevin Livora**
- Course: Programación con Motores de Videojuegos I — Clase 2026
- Teacher: Federico Olivé
- Sprites, UI and sound effects: Kenney (kenney.nl)
- Music from Pixabay: "Happy Fantasy Dream" by emmraan and "Confuze" by DSTechnician

---

## Español

Un endless runner 2D hecho en Unity, al estilo del juego del Dino de Google, para el **TP05** de la materia *Programación con Motores de Videojuegos I* (Tecnicatura Superior en Desarrollo de Videojuegos, Image Campus).

**🎮 Jugalo acá:** https://kevinlivora.itch.io/alien-run

### Características

- Salto con físicas (`Rigidbody2D` + `AddForce`) y detección de suelo mediante capas
- Mundo infinito: el jugador queda en su lugar y son los obstáculos y coleccionables los que se mueven hacia él
- La dificultad aumenta con el tiempo: la velocidad del mundo acelera hasta un tope máximo
- Puntaje según la distancia recorrida, más puntos extra por monedas
- Cuatro tipos de obstáculos que aparecen a intervalos aleatorios
- Tres coleccionables:
  - **Moneda**: suma puntos
  - **Estrella**: 5 segundos de invencibilidad, con cuenta regresiva visible en el HUD
  - **Gema azul**: suma una vida extra (hasta un máximo), que se gasta al recibir un golpe y da una breve invencibilidad
- Fondo con parallax en varias capas y suelo con scroll infinito
- Animaciones de sprites para el jugador, los obstáculos y los coleccionables, y efecto de polvo (partículas) al saltar y aterrizar
- Valores del jugador (fuerza de salto, gravedad, tecla de salto, duración de invencibilidad) editables mediante un **ScriptableObject**
- **AudioManager** central con **AudioMixer**: sliders de volumen independientes para Master, Música, SFX y UI en el menú de Settings
- Mejor puntaje guardado entre sesiones
- Dos escenas: **Main Menu** (Play, Settings, Credits, Quit) y **Gameplay**, con panel de Game Over con opciones **Retry** / **Menu**
- Arquitectura desacoplada: el jugador avisa sus acciones con eventos y el audio, los efectos y la animación reaccionan por su cuenta

### Controles

| Acción | Tecla |
|---|---|
| Saltar | Espacio |

### Hecho con

- Unity 6000.3.21f1
- TextMeshPro
- Arte y efectos de sonido de [Kenney](https://kenney.nl) (CC0)

### Estructura del proyecto

```
Assets/
├── Art/
│   ├── Animations/   # Clips de animación y Animator Controllers
│   ├── Audio/        # Música, efectos de sonido y GameMixer
│   └── Sprites/
├── Data/             # ScriptableObjects (PlayerData)
├── Prefabs/          # Obstáculos, coleccionables, AudioManager, paneles de UI
├── Scenes/           # Main Menu, Gameplay
└── Scripts/
    ├── Audio/        # AudioManager, MusicPlayer, PlayerAudio
    ├── Data/         # PlayerDataSo
    ├── Gameplay/     # GameManager, Spawner, Obstacle, Collectible, parallax...
    ├── Player/       # PlayerController, PlayerPowerUps, PlayerEffects, PlayerAnimator
    └── UI/           # HUD, menús, settings
```

### Correrlo localmente

1. Cloná este repositorio.
2. Abrí el proyecto con **Unity 6000.3.21f1** (o una versión LTS 6000.3.x compatible) desde Unity Hub.
3. Abrí `Assets/Scenes/Main Menu.unity` y dale Play.

### Créditos

- Desarrollado por **Kevin Livora**
- Materia: Programación con Motores de Videojuegos I — Cursada 2026
- Docente: Federico Olivé
- Sprites, UI y efectos de sonido: Kenney (kenney.nl)
- Música de Pixabay: "Happy Fantasy Dream" de emmraan y "Confuze" de DSTechnician
