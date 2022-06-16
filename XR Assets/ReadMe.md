  
  
##  XR Assets
  
  
###  Sprint 1
  
  
####  Learning Goals
  
  * By the end of this sprint...
I have created a model using blender get a basis footing in modelling skills.
  
  * By the end of this sprint... 
I have rigged a model using Blender to make it easier to animate.
  
####  Process
  
  
For this sprint I took it upon myself to create the model for the instructor robot, As I want to improve my Blender skills. 
  
To begin, our team had created a moodboard for the robot. I used that to create a prototype in blender.
![](../XR%20Assets/DocAssets/RobotMoodboard.jpeg?0.927625789340818 )  
  
First off I made some concepts of the robot's head, I modeled  3 different shapes I envisioned as a possible head.
  
![](../XR%20Assets/DocAssets/robohoofden.PNG?0.795669143473017 )  
  
After showing it to the rest of my team we settle on going with the head on the right, as it looks like a monitor.
  
For the body I tried out a different style of shaping the model. First I made a rough shape by extruding and resizing the edges of a cube.
  
![](../XR%20Assets/DocAssets/robo%20lichaam%20base.PNG?0.0360272153941148 )  
  
Once I had the shape I applied a Subdivision Surface to the mesh, this helped round it out.
  
![](../XR%20Assets/DocAssets/robo%20lichaam%20vervorming.PNG?0.8117734255973663 )  
  
I made the arms by first creating a few basic shapes and then combining them together into a single mesh with the Boolean modifier on the union setting. This causes the object it filters for to be added to the mesh it was applied on.
  
I then wanted to add an armature to the robot, I followed the steps in https://en.wikibooks.org/wiki/Blender_3D:_Noob_to_Pro/Bones, I added bones starting from the main body and alligned them with the joints of the robot.
  
![](../XR%20Assets/DocAssets/Robotbones.PNG?0.2217013827330374 )  
  
###  Sprint 2
  
  
####  Learning Goals
  
* By the end of this sprint...
  I have UV mapped and textured a model to get a more complete set of basic modelling skills.
  
####  Process 
  
  
In this sprint our team has finalized the design of the robot assistent, and I have been itterating over how to make it. For the new design we went with a less humanized look.
  
<img src="../XR%20Assets/DocAssets/Sprint2/RobotAssistentSketch.png?0.006478782150036944"  width="300" >
<img src="../XR%20Assets/DocAssets/Sprint2/RobotAssistentSketchSide.png?0.10927201926938945"  width="300" >
<img src="../XR%20Assets/DocAssets/Sprint2/RobotAssistentSketchFront.jpg?0.13990536029641687"  width="300" >
  
I mocked together the head using basic object shapes and morphing their size a bit, I then combined them with boolean modifiers to get a nice looking shape. However, once I wanted to smooth the model I ran into issues, as it did not want to properly smooth the full head. Things looked worse when I wanted to UV unwrap the head, the vertices were all over the place. I inspected the model closer and found that there were stray vertices inside the head causing bad geometry. The boolean modifiers had left behind artifacts that were annoying to deal with. The best option for me was to start over with a new head and try to create the lense in a different way.
  
![](../XR%20Assets/DocAssets/Sprint2/RobotOops.png?0.010535625093299528 )  
  
I started over with a cube once again and beveled it to make the edges smoother. For the lense I tried out a plug-in built into blender: "Edge Loops", it allowed me to transform the edges I selected into a circular shape. Once I changed the edges I could extrude the faces for the lense and went on from there. Once I was done I noticed that when I applied the smooth shading it would cause the lense to be smoothed against the robot head, but I wanted the lense to clearly be a separate part. In order to achieve this I had to mark the edges around the lense as sharp, I  then had to add the edge split modifier in order to make the normals behave like the faces were not connected on the edges.
  
![](../XR%20Assets/DocAssets/Sprint2/RobotSharp.png?0.6905309640061685 )  
![](../XR%20Assets/DocAssets/Sprint2/RobotSharpWire.png?0.2679543452908011 )  
  
Once I was done with making the lense I showed the robot head to the rest of my team for feedback. I continued to make changes based on the feedback until we were satisfied with the profile of the robot assistant.
  
![](../XR%20Assets/DocAssets/Sprint2/Lens1.png?0.9973133853956204 )  
![](../XR%20Assets/DocAssets/Sprint2/Lens2.png?0.11148222133679564 )  
  
![](../XR%20Assets/DocAssets/Sprint2/RobotNewLens.png?0.2708658755635862 )  
  
For the wheel I started with a cylinder and applied loop cuts. I then rotated a loop and selected faces to extrude the profile of wheel. I then applied a subdivion service to the mesh to make it more smooth and round.
  
![](../XR%20Assets/DocAssets/Sprint2/RobotAssistentWheel1.png?0.5896482240321843 )  
  
After the first wheel prototype was made it was clear that it's geometry would be both too heavy and problematic for shading. Instead of starting with a cylinder I tried out a different approach, I started with a cube and made it round. I was able to do this by selecting the edges I want to make round and applying a transform to sphere, this modified the edges to form a circle. I then gave it a curve to make it feel more like a tire. This seemed to work at first but when inspecting the wheel up close I noticed that the face had problems with rendering properly.
  
![](../XR%20Assets/DocAssets/Sprint2/RobotAssistentWheel2Oof.png?0.41683968578979824 )  
  
When I inspected the edges I saw that the problem happened with faces where the vertices are not on the same plane, causing a folding effect.
  
![](../XR%20Assets/DocAssets/Sprint2/RobotAssistentWheel2OofWire.png?0.5803981315432907 )  
  
I decided to throw away the wheel again and start fresh by using a sphere, the reasoning behind it was that it was already curved in two axes and thus felt more intuitive for me to deform into a wheel. This had the desired effect of having a nice looking wheel.
  
UV mapping the robot was quite the time sink, as there is not one solution for laying it all out. Every now and then I had to unwrap a mesh again, which would reset the all the selected vertices. After looking it up on the internet I found out that by pinning the vertices of an island I can prevent it being unwrapped and moved again, making it easier to plan the layout.
  
Once I was finished with UV mapping I had to texture the robot, I had two options, using a 3rd party tool to create a texture or use the 3d texture tool in Blender. I had to use a little trial and error to get it working, but I was able to figure out how to apply color to my model. I first had to create a new image in the UV editor, then I had to apply that material to the objects I wanted to paint. I was then able to paint directly onto the model, which felt quite intuitive to me. After more trial and error I discorvered that I was able to mask off parts of the mesh by pressing the "paint mask" button and then I was able to manipulate the mask in the "Select menu", this gave me a lot of control over which faces I want to paint.
  
![](../XR%20Assets/DocAssets/Sprint2/PaintMask.png?0.927538165505458 )  
  
After everything was done I ended up with a robot that both my team and I were satisfied with.
  
![](../XR%20Assets/DocAssets/Sprint2/RobotDone.png?0.5451317962326943 )  
  
###  Sprint 3
  
  
####  Learning Goals
  
* By the end of this sprint...
  I have created an animated shader using shader graph.
  
####  Process
  
  
We wanted to expand the decor of the training area, one of which ways was to add posters to the area. To stay within the futuristic theme, I decided to make a hologram shader. To start I watched Brackey's tutorial on how to create a holographic in Unity using shader graphs ([HOLOGRAM using Unity Shader Graph](https://www.youtube.com/watch?v=KGGB5LFEejg )).
  
![](../XR%20Assets/DocAssets/ShaderGraphCompleet.png?0.4910627730580235 )  
After I had lines and emmission working after the tutorial i decided i wanted to add some grain to add to the holographic look. For this I experimented around with noise generation nodes and settled on using gradient noise as it's pattern works well for simulating the dithering pattern. I made the noise pattern change by changing the UV offset with the time passed.
  
![](../XR%20Development/DocAssets/ShaderGraphExtra.png?0.6177053936298762 )  
  
To better illustrate how the dithering works I will explain how each part works
  
![](../XR%20Development/DocAssets/dithering.png?0.3991343405693897 )  
  
It can be broken up into three main parts:
1. The nodes in the purple part represent the offset input, it uses the play time to to create an offset to be passed noise pattern.
2. The nodes in the red part represent the scale input to be passed to the noise node. It uses a sawtooth wave to generate a rising number between 0 and 1. I then amplify it and then offset it to get a changing scale within a certain range.
3. The nodes in the yellow part generate the noise based on the offset and scale input. It generates a gradient noise picture and by changing the offset it will focus on a different part of the noise map, by scaling the noise map it changes the zoom on the noise map, making the noise image look very animated at higher scale levels. After a noise image has been generated it then clamps the noise map so that it can be used as a scalar for the alpha's final input.
  
Inside our enviroment we used it to display the safety measures.
  
![](../XR%20Development/DocAssets/hologramPoster.gif?0.19314596498978398 )  
  
###  Sprint 5
  
  
####  Learning Goals
  
  
* By the end of this sprint...
  I have created a god ray effect in our scene to have more appealing visuals.
  
####  Process
  
  
For our experience we wanted to see if we can add "god rays" to get a more spacious feeling as part of the extra touch ups we wanted to do with our left over time in the final sprint.
  
![](../XR%20Development/DocAssets/god%20rays.png?0.9442725684108755 )  
(example of god rays)
  
In order to get this effect I tried two approaches:
1. Use a particle system to simulate the effect.
2. Set up a system for volumetric lighting.
  
For the particle system route I watched ["Simple GODRAY PARTICLE Tutorial (Unity URP)"](https://www.youtube.com/watch?v=kbsd6askiCY&ab_channel=SpeedTutor ). It showed me how to set up the particle system to simulate god rays by stretching the particle's sprite, lowering it's opacity, adding a fade in and out and a bit of randomization to give the effect that it is not a static piece.
  
From a distance the effect is looks nice, it looks good and has the god rays we would like to see.
  
![](../XR%20Development/DocAssets/particleGodRays.png?0.4382748294594476 )  
  
The effect does fall apart when the player comes close to the particle system and looks staight into the beams, it makes them feel out of place and removes a lot of the effect.
  
![](../XR%20Development/DocAssets/particleGodFails.png?0.33343634979481496 )  
  
In the end we decided to not make use of this approach due to the player being able to break the illusion of god rays too easily.
  
A different option is to make use of volumetric lighting, a post processing effect that smears the light to create the effect shown in the example for god rays.
  
In order to to introduce volumetric lighting I read through "[Raymarched Volumetric Lighting in Unity URP](https://valeriomarty.medium.com/raymarched-volumetric-lighting-in-unity-urp-e7bc84d31604 )" and followed the steps described in it. It made use of concepts I was not familiar with. I decided to have the documentation for the classes used on the side so that I can figure out what role they play in the code.
  
I referenced :
* [ScriptableRendererFeature API](https://docs.unity3d.com/Packages/com.unity.render-pipelines.universal@13.1/api/UnityEngine.Rendering.Universal.ScriptableRendererFeature.html ) - The base class of a render feature, it tells the renderer which passes it should make and can be made to contain settings that are passed to the render passes
  
* [ScriptableRenderPass API](https://docs.unity3d.com/Packages/com.unity.render-pipelines.universal@13.1/api/UnityEngine.Rendering.Universal.ScriptableRenderPass.html ) - The base class for a render pass, it tells the renderer what steps to take in order to render the final picture
  
Inside of the render pass there was a lot of usage of the `CommandBuffer.Blit` function and I was unsure what it does. After looking at the "[CommandBuffer.Blit API](CommandBuffer.Blit )" it became clear that it does more than one thing: it copies the textures from one handle to another, it applies a shader pass and it also sets the active render target. By giving it a different set of arguments the behavior changes as well. 
  
In the process of getting the effect to work I did encounter some trouble.
  
![](../XR%20Development/DocAssets/volumetricFailOne.png?0.050640960034898264 )  
  
![](../XR%20Development/DocAssets/volumetricFailTwo.png?0.8060742132076228 )  
  
(some failed attempts at getting the shader to work properly)
  
After getting help from Chris Lokhorst, who has made a volumetric lighting effect in his project using the same blog, I was able to get the effect working. There are beams that are being cast when looking at objects that stand between you and the directional light's beam.
  
![](../XR%20Development/DocAssets/succes.png?0.8769920031459317 )  
  
The effect looked great on the computer, however when I decided to try it out in VR I was surprised to see that the left eye was black and the other eye was gray.
  
![](../XR%20Development/DocAssets/whut.png?0.18089962033089235 )  
(a visual representation of what I saw in the quest)
  
After looking through the Unity forums the reason I get this behavior is because the `CommandBuffer.Blit()` function messes up preprocessors in the shader when rendering with single pass instanced. To get rid of this issue I needed to make sure that I was rendering with `multi pass`. After trying it out in VR it seemed to work like it did on PC.
  
When I tried it out in our main scene I encountered another issue: There was only the volumetric lighting, but with no god rays to be seen.
  
![](../XR%20Development/DocAssets/howDidThisHappen.png?0.43230767566669503 )  
  
I tried to see what could have caused this difference to happen between my test scene and our main scene. However due to the large difference I could not come up with a solution and after talking to my team we decided that this task would be left undone for now so that I can focus on the other tasks left to be done.
  