You can launch the window from Window > Vector Field Lite V2.

You can create a 3D Texture from scratch or Import (in Pro Version) a 3D Texture.

Then you can create arrows from the "+" button or duplicate arrows from
 Edit > Duplicate Arrow or using the Ctrl+Shift+D shortcut.
You can also create arrows based on selected game objects in the
 scene by using the "Selected to Arrows" button.
You can create only up to 15 arrows, Pro version doesn't have this limit.

There are four types of arrows:
-Absolute: affects all pixels by "Force" amount equally.
-Relative: affects pixels within inner radius by full amount of "Force" then fades out in the outer radius.
-Multiply: multiplies the value of pixels within inner radius by full amount of "Force" then fades out in the outer radius.
-Suck (didn't find a better name lol): sets pixels inside inner radius to 0 and the pixels in outer radius to direct towards the arrow (producing a suction effect),
 if you set the "Force" to a negative value then the direction of the pixels will be in the opposite direction (producing a propelling effect).

To delete arrows make sure to use the "-" button next to the "+" button rather than deleting the game object.

You can select the root of an arrow either by clicking at the center piece or by clicking on the "☰" button,
 it is worth noting that the "☰" button acts like a checkbox, meaning that it will toggle selection for the arrow.
The order of arrows is relevant, for example if a multiply arrow is before a relative arrow then there will be no value to multiply,
 you can drag arrows from the "☰" button to reorder them.

When multiple arrows are selected changing any property would change all of them,
 for example if you select all arrows then set the mode of one of them to "Relative" then all arrows will become relative

You can select the tip or the base of any arrow and move it to change the direction.

When you open the window, a render texture will be created (if it is not created already) called "RealtimeTexture" in the "Asset" folder,
 you can use this texture (after checking the "Realtime" checkbox) to see all changes to arrows in realtime without having to apply and save.

When you are happy with the result you can name the texture 
 and click "Apply Arrows and Save" button which will create a texture in the "Asset" folder.


You can customize arrow tip, mid and base if you wish, just remove the label of the original ones and add it to your custom prefab with the appropriate one.


There is a tutorial video on YouTube that goes though an example:
https://www.youtube.com/watch?v=2c34PTmDhxA
and for V1:
https://www.youtube.com/watch?v=Mh-zh_Hj0V4

This is the Lite version of the asset which have limits on
 the number of arrows that you can create and doesn't have the Import feature
 which gives the ability to import other 3D Textures and modify them.

You can checkout the Pro version here:
http://bit.ly/pro-from-lite