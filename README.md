# MG3
## Devlog

Q: Write about how the concept of inheritance and the finite state machine design pattern are working together in this project, citing examples from the code.

The concept of inheritence works in tandem with FSM's because FSM's inherently managed state. State is an abstract concept that is not tied to specific concrete implementation
Therefore when acting polymorphicly, the state can be independant of the actual implementation of the state and its usage of attributes and actions. In this case,
the state of `Panic` was polymorphically altered in the child class of `Pigeon` due to the override of the Update method. This override extended the functionality
of the base class of `Bird` to include a movement away from the direction of the player





## Open-Source Assets
If you added any other assets, list them here!
- [2D pixel art pidgeon sprites](https://elthen.itch.io/2d-pixel-art-pidgeon-sprites) - pidgeon sprites
- [2D pixel art seagull sprites](https://elthen.itch.io/2d-pixel-art-seagull-sprites) - seagull sprites
- [32 rogues](https://sethbb.itch.io/32rogues) - seagull and other animal sprites
- [Sunnyside world](https://danieldiggle.itch.io/sunnyside) - people sprites
- [Free pixel foods](https://ghostpixxells.itch.io/pixelfood) - food sprites
