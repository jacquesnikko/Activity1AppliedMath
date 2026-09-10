# Activity 1 — Movement and Proximity

A simple introductory Unity activity using manual vector math instead of physics.

## Demo video

Google Drive link: **PASTE YOUR SHAREABLE VIDEO LINK HERE**

## How to play

- Use **W, A, S, and D** to move the blue Sphere.
- Stay away from the yellow Cube no-go zones.
- A nearby no-go cube shakes and turns red.
- Moving too close, or staying nearby for two seconds, restarts the scene.
- Reach the green Finish cube to display **YOU WIN!**

## Project details

- Scene: `Assets/Scenes/Activity1.unity`
- Gameplay script: `Assets/Scripts/SimpleActivity.cs`
- The complete gameplay script is only **28 lines**.
- Movement uses `Transform.position`.
- Distance checks use vector subtraction and `.magnitude` inside `Update()`.
- No Rigidbody, physics forces, colliders, triggers, or collision callbacks are used.

Open the scene in Unity 6 and press **Play**. Before submission, record a short demonstration, upload it to Google Drive, and replace the video placeholder above.
