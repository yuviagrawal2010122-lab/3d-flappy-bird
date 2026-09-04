# 3D Flappy Bird Game - Unity

A 3D version of the popular Flappy Bird game built with Unity game engine.

## Features

- 3D gameplay with immersive camera angles
- Physics-based bird movement
- Procedurally generated obstacles
- Score tracking and high score system
- Sound effects and visual feedback
- Mobile and PC controls support

## Requirements

- Unity 2021.3 LTS or later
- C# scripting knowledge (for modifications)

## Project Structure

```
Assets/
├── Scripts/
│   ├── Bird.cs
│   ├── Pipe.cs
│   ├── PipeSpawner.cs
│   ├── GameManager.cs
│   ├── UIManager.cs
│   └── InputManager.cs
├── Scenes/
│   └── MainScene.unity
├── Prefabs/
│   ├── Bird.prefab
│   ├── Pipe.prefab
│   └── Environment.prefab
├── Materials/
├── Audio/
└── Models/
```

## Getting Started

1. Clone the repository
2. Open the project in Unity
3. Open the MainScene from `Assets/Scenes/`
4. Press Play to run the game

## Controls

- **Spacebar** - Make bird fly up (PC)
- **Mouse Click** - Make bird fly up (PC)
- **Touch** - Make bird fly up (Mobile)

## Development

### Key Systems

- **Bird Physics**: Gravity and flap impulse system
- **Pipe Generation**: Random pipe gaps and spacing
- **Collision Detection**: 3D collision with pipes and boundaries
- **Score System**: Points for passing through pipes

## License

MIT License
