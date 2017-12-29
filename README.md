Thayer Merritt
Udacity VR Project 3
2017-12-28
Unity 2017.3.0f3
GoogleVR Version 1.70.0

Resubmission: Reinitialized witout LFS 2017-12-29

Asset Store Items Used:
Skybox: Purple Space Nebula:
https://assetstore.unity.com/packages/2d/textures-materials/sky/purple-space-nebula-skybox-25117 

Torches and Fires: Campfire Pack:
https://assetstore.unity.com/packages/3d/environments/fantasy/campfire-pack-11256

Contains:
Required Collectables: 1 Key (added rotation)
Optional Collectables: 6 Coins (added rotation)
Waypoints to navigate the maze
Door which rises when clicked on after collecting the key, triggered off keycollected bool.
Added fires and torches for interest
lit Udacity flags for visability. 

All collectables, waypoints and door have sounds associated with them.

Found that calling the Unlock() method in the door script had the same effect as calling on a public bool for key collected. 

Tested on Google Pixel (Sailfish)
need to learn daydream controller -> cardboard trigger emulation
