# SkytrainSurfer

SkytrainSurfer
This is a class project that I took apart in where I did the Gameplay programming, VFX, and post processing

<img width="414" alt="374371940-639c6d84-18ad-4009-839a-fb26dcbb8b90" src="https://github.com/user-attachments/assets/77fda073-2d46-48d8-867f-3054d614a6ca">

When writing the movement code the decision to keep the player stationary was made to allow the world generation and the curve of the world code simpler.
I wrote code to change how the rigidbody behaves in different states though the difficulty I had with this is allowing the states to transition from any other state.
The states wanted to overlap one another so I took the players current lane and vertical position into account to avoid this bug.
