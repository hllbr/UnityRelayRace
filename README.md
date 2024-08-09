# RelayRaceRunner

**RelayRaceRunner** is a Unity-based game that simulates a relay race between three objects: a Cube, a Sphere, and a Cylinder. The game showcases basic object movement, color changes, and sequential event triggering using C# scripts within the Unity engine.

## Project Overview

In **RelayRaceRunner**, three objects participate in a relay race. The Cube starts the race, passes the baton to the Sphere, which then passes it to the Cylinder. The Cylinder, after reaching its endpoint, reverses direction, and the process continues in reverse order, with each object passing the baton back until the race is complete.

## Features

- **Sequential Movement**: Each object moves in sequence from a start position to an end position, simulating a relay race.
- **Color Indication**: 
  - At the start, all objects turn yellow.
  - The object currently moving turns green.
  - When an object finishes its part and passes the baton, it turns red.
  - When the reverse sequence completes, all objects turn yellow again and stop.
- **Reverse Relay**: After the Cylinder reaches its endpoint, it reverses direction and passes the baton back to the Sphere, which then passes it to the Cube.

## How It Works

- **GameManager.cs**: Controls the overall flow of the game, managing the relay sequence and coordinating the color changes.
- **RunnerController.cs**: Manages the movement and color change of each individual object (Cube, Sphere, Cylinder).

### Game Flow

1. **Cube** starts at position (0, 0, 0) and moves to position (0, 0, 100).
2. Upon reaching its endpoint, **Cube** turns red and passes the baton to **Sphere**.
3. **Sphere** starts at position (0, 0, 100) and moves to position (0, 0, 200).
4. **Sphere** then turns red and passes the baton to **Cylinder**.
5. **Cylinder** starts at position (0, 0, 200) and moves to position (200, 0, 200).
6. Upon reaching its endpoint, **Cylinder** reverses direction and moves back to its start position.
7. The process continues in reverse until **Cube** returns to its start position, completing the race.

## Technologies Used

- **Unity Engine**: The primary game engine used to develop and run the game.
- **C#**: The programming language used to script the game’s mechanics and logic.
  
## Version

- **Unity Version**: This project was developed using Unity version **2022.3.32f1**.
  
## Installation and Setup

1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/RelayRaceRunner.git

[screencast-nimbusweb_me-2024_08_10-01_21_25.webm](https://github.com/user-attachments/assets/53b96a07-ebfb-410b-81ec-ac03b7135b08)

