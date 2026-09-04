# Unity Setup Guide for 3D Flappy Bird

## Scene Setup Instructions

### 1. Create the Main Scene
- Create a new scene named `MainScene`
- Set up the basic scene structure

### 2. Create the Bird
1. Create a new 3D Cube (GameObject > 3D Object > Cube)
2. Scale it to look like a bird (scale down on Y axis)
3. Rename it to "Bird"
4. Add a Rigidbody component
5. Set Rigidbody constraints:
   - Freeze Rotation X, Y, Z
   - Freeze Position Z
6. Add a Collider (Box Collider works, or use a Sphere for rounder shape)
7. Tag it as "Player"
8. Add the `Bird.cs` script
9. Add an AudioSource component for flap sounds

### 3. Create Pipes
1. Create a new Cube for pipe visuals
2. Scale it appropriately (tall and thin)
3. Rename to "Pipe"
4. Add Box Collider and set as trigger (Is Trigger = true)
5. Add the `Pipe.cs` script
6. Create a Prefab by dragging it into Assets/Prefabs/ folder
7. Delete the pipe from the scene

### 4. Set up PipeSpawner
1. Create an empty GameObject named "PipeSpawner"
2. Add the `PipeSpawner.cs` script
3. Drag the Pipe prefab into the Pipe Prefab field
4. Adjust spawn settings:
   - Spawn Interval: 2
   - Spawn X: 15
   - Min Height: -3
   - Max Height: 3
   - Gap Size: 3

### 5. Create Canvas for UI
1. Create a Canvas (GameObject > UI > Canvas)
2. Add a TextMeshPro Text for Score
3. Add a TextMeshPro Text for High Score
4. Create a Panel for Game Over screen
5. Add TextMeshPro Text for Final Score
6. Add a Button for Restart
7. Add the `UIManager.cs` script to the Canvas
8. Assign references in the UIManager script

### 6. Create Camera Setup
1. Use the Main Camera
2. Position it to view the game area
3. Consider using an orthographic camera for a better 2D feel in 3D space

### 7. Add Game Manager
1. Create an empty GameObject named "GameManager"
2. Add the `GameManager.cs` script
3. Assign references to PipeSpawner and UIManager

### 8. Lighting
1. Add a Directional Light for basic illumination
2. Adjust intensity and color as needed

### 9. Background/Environment
1. Create a Cube for the background (scaled large)
2. Position it behind the gameplay area
3. Use a material with a sky texture

## Project Settings

### Tags and Layers
- Create a tag "Player" for the bird

### Physics Settings
- Adjust gravity in Physics settings (Edit > Project Settings > Physics)
- Default gravity (-9.81) works well, but can be adjusted for gameplay feel

### Build Settings
- Add MainScene to Build Settings (File > Build Settings)
- Select target platform (PC, Mobile, WebGL, etc.)

## Testing Checklist
- [ ] Bird responds to input (Space/Mouse/Touch)
- [ ] Bird falls with gravity
- [ ] Pipes spawn and move
- [ ] Collision detection works (bird dies on pipe contact)
- [ ] Score increases when passing through pipes
- [ ] High score is saved and persists
- [ ] Game Over screen displays
- [ ] Restart button works

## Performance Tips
- Destroy pipes that go off-screen to save memory
- Use object pooling for frequently spawned objects
- Optimize mesh colliders to use simple shapes
