# MG3
## Devlog

Q: Write about how the concept of inheritance and the finite state machine design pattern are working together in this project, citing examples from the code.

A:
The concept of inheritence works in tandem with FSM's because FSM's can inherently manage state abstractly. Meaning, State is not tied to specific concrete implementation
Therefore when acting polymorphicly, the state can be independant of the actual implementation of itself and its usage of attributes and actions via the implementing script.

In this case, the state of `Panic` was polymorphically altered in the child class of `Pigeon` due to the override of the Update method. And in the Seagul via the virtual method `Panic()`
These overrides extended the functionality of the base class of `Bird` to include a movement away from the direction of the player, and an explosion.

Additionally put, the `Bird` inheritors use the states of `{ Idle, Curious, Panic }` in their own unique ways.
This state is stored in the variable that uses the `enum` definition as its datatype: `public BirdState state`
So because of inheritence, the concrete children of `Bird` can use the member variable `state` to do that explosion, or that fleeing mechanic.

The point of structuring code like an FSM with 2 unique subclasses lets those subclasses operate on a script footprint that is much more readable and understandable abstractly.
All the developer needs to know is that `Pigeon` or `Seagul` act like `Bird`s. via the inheritence signature, and they are free to implement the extended 
functionality without having to worry about even seeing let alone implementing again the `Bird` functionalities.

Speaking generally, inheritence allows FSMs to operate at an abstract level that allows for much clearner implementation.



## Open-Source Assets
If you added any other assets, list them here!
- [2D pixel art pidgeon sprites](https://elthen.itch.io/2d-pixel-art-pidgeon-sprites) - pidgeon sprites
- [2D pixel art seagull sprites](https://elthen.itch.io/2d-pixel-art-seagull-sprites) - seagull sprites
- [32 rogues](https://sethbb.itch.io/32rogues) - seagull and other animal sprites
- [Sunnyside world](https://danieldiggle.itch.io/sunnyside) - people sprites
- [Free pixel foods](https://ghostpixxells.itch.io/pixelfood) - food sprites
