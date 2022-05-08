# GE2-Assignment-Space-Battle

Name: Johann-Dorian Gudenus

Student Number: C19518983

Class Group: Game Design

# Description of the project

The idea for this project is to create a representation of an iconic sci-fi space battle scene from the movie The Last Starfighter.

[Watch the Scene here](https://www.youtube.com/watch?v=0YXobQ9Gi10)

[Watch the Game View here](https://youtu.be/s2zSrLDZk7c)

[Watch the Scene View here](https://youtu.be/yGi91oJxwf0)

# Events Summary
1. Camera sees the line of enemy ships behind the Gunstar
2. Camera pans towards the Gunstar
4. Gunstar flies around and then through the enmy ships´ linfe
5. Enemy ships starts chasing the Gunstar
6. Ships collide, explosions happen
7. The Gunstar stops moving and starts spinning, eliminating all enemy ships within its reach

# How it works
## Sequence
- The cameras are timed according to the waypoints the Gunstar uses to follow its path
- There is different cameras in the scene to show off the same angles shown in the original scene
- Gunstar follows a path, which at a certain point activates the enemy ships, which are autonomous agents, that will avoid obstacles and pursue the Gunstar
- Enemy ships will explode if they collide, as well as when the Gunstar starts spinning

## Behaviours
- ***Obstacle Avoidance***: Avoids game objects with a specific layer mask
- ***Constrain***: Keeps the Gunstar inside a set radius so it doesn't drift off
- ***Noise Wander***: Allows ships to wander within the worldspace
- ***Pursue***: Sets a target for the enemy ships to move towards

## Design
- Particle systems
  - Explosion plays when an enemy ship is destroyed. 

- Skybox uses space textures

Visual Aspects

- AI Flocking and pathfinding
- Switching cameras

# List of classes/assets with sources
| Class | Source |
|-----------|-----------|
| Activator.cs  | Self-written|
| BigBoid.cs  | Modified from the module git|
| Boid.cs  | Modified from the module git|
| Bullet.cs  | Taken from the module git|
| CamFollow.cs  | Modified from [Source](https://github.com/Jammie506/GameEngines2Project/blob/main/Space%20Battle/Assets/Scripts/cameraController.cs)|
| Constrain.cs  | Taken from the module git|
| explode.cs  | Self-written|
| Flee.cs  | Taken from the module git|
| multiCam.cs  | Modified from [Source](https://docs.unity3d.com/Manual/MultipleCameras.html)|
| NoiseWander.cs  | Taken from the module git|
| ObstacleAvoidance.cs  | Taken from the module git|
| Path.cs  | Taken from the module git|
| Pursue.cs  | Taken from the module git|
| spin.cs  | Self-written|
| SteeringBehaviour.cs  | Taken from the module git|


| Asset | Source |
|-----------|-----------|
| Spaceships | Taken from [Source](https://assetstore.unity.com/packages/3d/vehicles/space/star-sparrow-modular-spaceship-73167) |
| Starfighter | Taken from [Source](https://assetstore.unity.com/packages/3d/vehicles/space/free-sf-fighter-11711) |
| SkyBox | Taken from [Source](https://tools.wwwtyro.net/space-3d/index.html) |
| Explosions| Taken from [Source](https://assetstore.unity.com/packages/vfx/particles/fire-explosions/fx-explosion-pack-30102) |
