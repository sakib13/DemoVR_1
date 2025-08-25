**Throwfinity**
📖 Project Overview

Throwfinity is a VR prototype developed in Unity that explores tangible interaction through bidirectional communication between Unity and Arduino hardware. Inspired by the mechanics of Spider-Man’s web-shooting, the project integrates virtual object manipulation with physical input/output devices.

The system allows a user in VR to:

-Press a physical push button connected to an Arduino Uno, which triggers the spawning and throwing of virtual cubes (mimicking web-slinging).

-Interact with a red button in VR, which activates a physical buzzer connected to the Arduino.

This prototype demonstrates the potential of tangible VR interactions that combine physical hardware feedback with virtual immersion.

**🎨 Design**

Objectives

-Explore bidirectional communication between Arduino hardware and Unity.

-Create a natural, tangible gesture-based interaction (web-shooting metaphor).

**Interaction Flow**

-Physical → Virtual: User presses a push button → Arduino sends signal → Unity spawns and launches a cube from the hand position in VR.

-Virtual → Physical: User presses a red button inside VR → Unity sends signal to Arduino → buzzer emits a sound in real life.

**Hardware Setup**

-Arduino Uno board

-Push Button (used as tangible input)

-Buzzer (used as tangible output)

-Breadboard and jumper wires

**Implementation**

-Unity Version: 2022.3.47f1

Packages:

-XR Interaction Toolkit (for VR hand tracking and interactions)

-TextMesh Pro (for scoring UI)

**Bidirectional Communication Protocol**

Unity → Arduino:

-Sends "B" when VR red button pressed.

Arduino → Unity:

-Sends "T" when push button pressed.

**Installation**

-Unity 2022.3.47f1 or compatible LTS version.

-Arduino IDE (for uploading Arduino sketch).

-Git & GitHub Desktop (for cloning the repository).

-Meta Quest Pro (or equivalent) + Meta XR Setup.

**Steps**
Clone repository: git clone https://github.com/<your-username>/Throwfinity.git
cd Throwfinit

-Launch Unity Hub.

-Open the Throwfinity project folder.

-Upload the provided Arduino sketch from /Arduino/ folder to your Arduino Uno.

-Ensure correct COM port is selected.

-In Unity, assign the correct COM port in SerialController.cs.

-Run the scene with XR simulator or VR headset connected.

**Usage**

-Press the red button → buzzer sounds in real life.

-Throw cubes into the basket → score updates on VR HUD.

-Press the push button → cube spawns and launches forward from your VR hand, simulating web-shooting.

**Future works**

-Improve throwing mechanics by aligning cube trajectory precisely with palm orientation.

-Add haptic feedback or vibration motors for richer tangible feedback.

-Expand scoring system with difficulty levels and multiplayer mode.

