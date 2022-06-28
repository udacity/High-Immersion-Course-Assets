# High Immersion Course Assets
This project is a collection of projects that are part of [Udacity](https://www.udacity.com "Udacity - Be in demand")'s [VR Developer Nanodegree](https://www.udacity.com/course/vr-developer-nanodegree--nd017).

## Versions
- Unity 2017.4.15
- Steam

## Changes
Across all projects:
- Removed the extra camera from scenes.

In BlockThrowerV3.1ENDOFnode3: 
- Commented out SteamVR lines in the OculusHandInteraction script to avoid generating NullReferenceExceptions.
- Set Oculus camera tracking to "Floor Level" to ensure that our camera rig isn't stuck in the floor in play mode.

In BlockThrowerV4CROSSplatform: 
- Commented out SteamVR lines in the OculusHandInteraction script to avoid generating NullReferenceExceptions.
- Set Oculus camera tracking to "Floor Level" to ensure that our camera rig isn't stuck in the floor in play mode.
- Added an extra conditional in the start method of HeadsetManager to ensure the conditional works as expected. 

## SteamVR
- The projects use SteamVR v1.2.2. 
Note: Additional versions of projects will be created in the future to show the same functionality with the upgraded version of SteamVR. 

## Project Descriptions: 
1. BlockThowerV1 - SteamVR is set up and players have the ability to pick up and throw blocks. 
2. BlockThrowerV2.1 - Everything the previous project has + some initial work on the menu system.
3. BlockThrowerV2.5 - Everything the previous project has + menu works by touching the touchpad. Pressing down spawns the objects. 
4. BlockThrowerV2.9SCENELOAD - Everything the previous project has + Changes scenes when touching the touchpad. 
5. BlockThrowerV3.1ENDOFnode3 - Everything the previous project has + Ads an Oculus specific camera rig with the OculusHandInteraction script. Oculus Rift users can pick up and grab blocks with the headset. (Vive users will need to enable the SteamVR camera rig.)
6. BlockThrowerV4CROSSplatform - Everything the previous project has +  Has a HeadsetManager script to switch between headsets. 
7. LocomotionV1 - SteamVR is set up and players can use the right controller's trigger to teleport around the scene. Press the trigger to show the aimer, release to teleport to the location of the aimer object. 


 # Archival Note 
 This repository is deprecated; therefore, we are going to archive it. However, learners will be able to fork it to their personal Github account but cannot submit PRs to this repository. If you have any issues or suggestions to make, feel free to: 
- Utilize the https://knowledge.udacity.com/ forum to seek help on content-specific issues. 
- Submit a support ticket along with the link to your forked repository if (learners are) blocked for other reasons. Here are the links for the [retail consumers](https://udacity.zendesk.com/hc/en-us/requests/new) and [enterprise learners](https://udacityenterprise.zendesk.com/hc/en-us/requests/new?ticket_form_id=360000279131).