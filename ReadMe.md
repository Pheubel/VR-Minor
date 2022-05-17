  
  
#  VR Minor
  
  
- [Pressure Cooker](#pressure-cooker )
  - [Concept](#concept )
  - [Explanation](#explanation )
  - [Moodboard](#moodboard )
  - [Storyboard](#storyboard )
  - [Goal](#goal )
  - [Assets](#assets )
    - [Goal](#goal-1 )
    - [Research](#research )
    - [Creation](#creation )
    - [Evaluation](#evaluation )
  - [Development](#development )
    - [Goal](#goal-2 )
    - [Research](#research-1 )
    - [Evaluation](#evaluation-1 )
- [XR Assets](#xr-assets )
  - [Sprint 1](#sprint-1 )
    - [Learning Goals](#learning-goals )
    - [Process](#process )
  - [Sprint 2](#sprint-2 )
    - [Learning Goals](#learning-goals-1 )
    - [Process](#process-1 )
- [XR Development](#xr-development )
  - [Sprint 3](#sprint-3 )
    - [Learning Goals](#learning-goals-2 )
    - [Process](#process-2 )
- [Individual Work](#individual-work )
  - [Learning Goals](#learning-goals-3 )
    - [Overarching goals](#overarching-goals )
    - [Short term goals](#short-term-goals )
  
##  Pressure Cooker
  
  
###  Concept
  
###  Explanation
  
The user opperates a time machine boat to save people on the flooding canals of Amsterdam.
###  Moodboard
  
As a theme for the boat i want to have a mix of the past, today and the tomorrow that will never be, steampunk.
![](Pressure%20Cooker/DocAssets/moodboard.png?0.7498852171500221 )  
###  Storyboard
  
![](Pressure%20Cooker/DocAssets/storyboard.png?0.9468167598309087 )  
###  Goal
  
  
###  Assets
  
####  Goal
  
incrementing goals:
* plunger (beginner)
* steering wheel (novice)
* boat (advanced)
  
####  Research
  
I started with researching the basics of how to use Blender 3, for this I watched the first episode of Blender guru's "Blender 3.0 Beginner Donut Tutorial"<sup>[1](#pc-assets-fn-1 )</sup>. 
  
After this i messed around in Blender to get a feel for how to use the tools by adding more objects.
![](Pressure%20Cooker/DocAssets/donut%20modeling.png?0.9592460058846408 )  
  
I want to use a reference image in Blender, but i have not used them before. After finding an article online<sup>[2](#pc-asset-fn-2 )</sup> i followed the steps shown there to import images for reference use.
  
I used a reference for a plunger with a good side view.
![](Pressure%20Cooker/DocAssets/referenceInBlender.png?0.8261589801633442 )  
  
When i was done i noticed that I had issues with the mesh having dark spots, this was because of faulty normals, I had duplicate vertices that i had to delete. Afterwards my model looked fine.
  
Later i modeled a steering wheel for my ship. I made use of mirroring to reduce work, but i ran into trouble when dealing with the spokes, as it had overlapping issues. 
![](Pressure%20Cooker/DocAssets/overlapWheel.png?0.6472994700806864 )  
![](Pressure%20Cooker/DocAssets/overlapWheelWireframe.png?0.1796691842405047 )  
  
After much experimentation i removed the overlaps and was able to export it. By combining the overlaps i was able to make in intermediate shape that i could use to cut out a shape in the spokes and was then able to join them together.
![](Pressure%20Cooker/DocAssets/overlapIntermediateShape.png?0.6358316142836868 )  
  
<a name="pc-assets-fn-1">1</a>: "Blender 3.0 Beginner Tutorial - Part 1" - https://www.youtube.com/watch?v=nIoXOplUvAw
<a name="pc-assets-fn-2">2</a>:  - https://www.makeuseof.com/blender-reference-image-guide/ 
  
####  Creation
  
![](Pressure%20Cooker/DocAssets/modeledPlunger.png?0.19210345006506446 )  
![](Pressure%20Cooker/DocAssets/texturedWheel.png?0.2666942624593167 )  
####  Evaluation
  
I feel that I've made good progress with learning Blender, as i wasn't really skilled with it. I did however spend more time on it than I should have, trying to get things working well, eating away at time that I could've used elsewhere.
  
###  Development
  
VR development in Unity has changed quite a bit since i last used it. I want to be able to be more proficient again. 
  
####  Goal
  
* Be able to set up a VR project from scratch.
* Interact with the game world.
  
####  Research
  
To get started i watched Justin P. Barnett's tutorial to develop VR games in Unity<sup>[1](#pc-dev-fn-1 )</sup>, as it is a recent video with a Unity version close to the latest release.
  
Setting this up was rather easy, however when trying to get it to work with a quest, i ran into issues with it not connecting to Unity. After asking classmates they told me to enable unknown sources in the oculus app. I was nnow able to have headtracking working, but the controller tracking was not working properly. After asking around I searched the oculus forums and discovered i had missed a step, I did not set Oculus to the active XR runtime. Once i had pressed this button i had no more issues with tracking in Unity.
  
<a name="pc-dev-fn-1">1</a>: - "How to Make VR Games in 2022 - Updated Unity VR Tutorial" - https://www.youtube.com/watch?v=yxMzAw2Sg5w
  
####  Evaluation
  
I feel like i can properly set up and work in a VR project now. Figuring out what caused my problems with tracking for the Quest had eaten up more time than it should've. But i think it was worth struggling for, as i can now properly debug using a headset that is relatively easy to jump into for debugging.
  
  
  
  
  
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
![](XR%20Assets/DocAssets/RobotMoodboard.jpeg?0.25390400997323237 )  
  
First off I made some concepts of the robot's head, I modeled  3 different shapes I envisioned as a possible head.
  
![](XR%20Assets/DocAssets/robohoofden.PNG?0.22114375054146773 )  
  
After showing it to the rest of my team we settle on going with the head on the right, as it looks like a monitor.
  
For the body I tried out a different style of shaping the model. First I made a rough shape by extruding and resizing the edges of a cube.
  
![](XR%20Assets/DocAssets/robo%20lichaam%20base.PNG?0.19044068858010177 )  
  
Once I had the shape I applied a Subdivision Surface to the mesh, this helped round it out.
  
![](XR%20Assets/DocAssets/robo%20lichaam%20vervorming.PNG?0.4065654726163077 )  
  
I made the arms by first creating a few basic shapes and then combining them together into a single mesh with the Boolean modifier on the union setting. This causes the object it filters for to be added to the mesh it was applied on.
  
I then wanted to add an armature to the robot, I followed the steps in https://en.wikibooks.org/wiki/Blender_3D:_Noob_to_Pro/Bones, I added bones starting from the main body and alligned them with the joints of the robot.
  
![](XR%20Assets/DocAssets/Robotbones.PNG?0.9016062906513536 )  
  
###  Sprint 2
  
  
####  Learning Goals
  
* By the end of this sprint...
  I have UV mapped and textured a model to get a more complete set of basic modelling skills.
  
####  Process 
  
  
In this sprint our team has finalized the design of the robot assistent, and I have been itterating over how to make it. For the new design we went with a less humanized look.
  
<img src="XR%20Assets/DocAssets/Sprint2/RobotAssistentSketch.png?0.9407451739824357"  width="300" >
<img src="XR%20Assets/DocAssets/Sprint2/RobotAssistentSketchSide.png?0.08910429516349927"  width="300" >
<img src="XR%20Assets/DocAssets/Sprint2/RobotAssistentSketchFront.jpg?0.35699006797385757"  width="300" >
  
I mocked together the head using basic object shapes and morphing their size a bit, I then combined them with boolean modifiers to get a nice looking shape. However, once I wanted to smooth the model I ran into issues, as it did not want to properly smooth the full head. Things looked worse when I wanted to UV unwrap the head, the vertices were all over the place. I inspected the model closer and found that there were stray vertices inside the head causing bad geometry. The boolean modifiers had left behind artifacts that were annoying to deal with. The best option for me was to start over with a new head and try to create the lense in a different way.
  
![](XR%20Assets/DocAssets/Sprint2/RobotOops.png?0.7873024363665926 )  
  
I started over with a cube once again and beveled it to make the edges smoother. For the lense I tried out a plug-in built into blender: "Edge Loops", it allowed me to transform the edges I selected into a circular shape. Once I changed the edges I could extrude the faces for the lense and went on from there. Once I was done I noticed that when I applied the smooth shading it would cause the lense to be smoothed against the robot head, but I wanted the lense to clearly be a separate part. In order to achieve this I had to mark the edges around the lense as sharp, I  then had to add the edge split modifier in order to make the normals behave like the faces were not connected on the edges.
  
![](XR%20Assets/DocAssets/Sprint2/RobotSharp.png?0.5321709042528298 )  
![](XR%20Assets/DocAssets/Sprint2/RobotSharpWire.png?0.16190104594446852 )  
  
Once I was done with making the lense I showed the robot head to the rest of my team for feedback. I continued to make changes based on the feedback until we were satisfied with the profile of the robot assistant.
  
![](XR%20Assets/DocAssets/Sprint2/Lens1.png?0.15734535876546363 )  
![](XR%20Assets/DocAssets/Sprint2/Lens2.png?0.46479624127360153 )  
  
![](XR%20Assets/DocAssets/Sprint2/RobotNewLens.png?0.917093241815762 )  
  
For the wheel I started with a cylinder and applied loop cuts. I then rotated a loop and selected faces to extrude the profile of wheel. I then applied a subdivion service to the mesh to make it more smooth and round.
  
![](XR%20Assets/DocAssets/Sprint2/RobotAssistentWheel1.png?0.5866184281595941 )  
  
After the first wheel prototype was made it was clear that it's geometry would be both too heavy and problematic for shading. Instead of starting with a cylinder I tried out a different approach, I started with a cube and made it round. I was able to do this by selecting the edges I want to make round and applying a transform to sphere, this modified the edges to form a circle. I then gave it a curve to make it feel more like a tire. This seemed to work at first but when inspecting the wheel up close I noticed that the face had problems with rendering properly.
  
![](XR%20Assets/DocAssets/Sprint2/RobotAssistentWheel2Oof.png?0.3160146679953715 )  
  
When I inspected the edges I saw that the problem happened with faces where the vertices are not on the same plane, causing a folding effect.
  
![](XR%20Assets/DocAssets/Sprint2/RobotAssistentWheel2OofWire.png?0.9586918594545846 )  
  
I decided to throw away the wheel again and start fresh by using a sphere, the reasoning behind it was that it was already curved in two axes and thus felt more intuitive for me to deform into a wheel. This had the desired effect of having a nice looking wheel.
  
UV mapping the robot was quite the time sink, as there is not one solution for laying it all out. Every now and then I had to unwrap a mesh again, which would reset the all the selected vertices. After looking it up on the internet I found out that by pinning the vertices of an island I can prevent it being unwrapped and moved again, making it easier to plan the layout.
  
Once I was finished with UV mapping I had to texture the robot, I had two options, using a 3rd party tool to create a texture or use the 3d texture tool in Blender. I had to use a little trial and error to get it working, but I was able to figure out how to apply color to my model. I first had to create a new image in the UV editor, then I had to apply that material to the objects I wanted to paint. I was then able to paint directly onto the model, which felt quite intuitive to me. After more trial and error I discorvered that I was able to mask off parts of the mesh by pressing the "paint mask" button and then I was able to manipulate the mask in the "Select menu", this gave me a lot of control over which faces I want to paint.
  
![](XR%20Assets/DocAssets/Sprint2/PaintMask.png?0.4825047096523851 )  
  
After everything was done I ended up with a robot that both my team and I were satisfied with.
  
![](XR%20Assets/DocAssets/Sprint2/RobotDone.png?0.20520803070665572 )  
  
  
  
  
  
##  XR Development
  
  
###  Sprint 3
  
  
####  Learning Goals
  
  
####  Process
  
  
TODO: shader graph tussen stappen + sauce
  
  
  
([HOLOGRAM using Unity Shader Graph](https://www.youtube.com/watch?v=KGGB5LFEejg ))
  
![](XR%20Development/DocAssets/ShaderGraphCompleet.png?0.8978238901363516 )  
  
![](XR%20Development/DocASsets/ShaderGraphExtra.png?0.015976647511998676 )  
  
TODO: probleem, distortion draait mee met headset
  
  
TODO: Timeline?
  
[How to use Unity3D Timeline in 10 minutes](https://www.youtube.com/watch?v=E5EYO3w-Xco )
  
  
  
[How to make a custom signal receiver with emitter parameter](https://gametorrahod.com/how-to-make-a-custom-signal-receiver-with-emitter-parameter/ )
  
TODO: hoe te gebruiken
  
TODO: eigen audio implementatie met scripts
  
[What you NEED to know about game audio as a beginner in 2021! Unity3d](https://www.youtube.com/watch?v=B9yxkJuHLek )
  
TODO: problemen er mee
  
TODO: FMOD?
  
TODO: conclusie
  
  
  
##  Individual Work
  
  
<table>
<tr>
    <td>
        <b><div>Positive feedback:</div></b>
        <div>
            Fijn dat je niet begint met modellen maar de criteria begint in te plannen. Eerste documentatie was minder maar tweede was een stuk beter.  
        </div>
        <div>
            Goed uitgelegd, stap voor stap. Blij dat je het aantal triangles laat zien. Goed dat je je fouten laat zien, is alleen maar inzichtelijk. Portfolio is heel goed.  
        </div>
    </td>
    <td>
        <b><div>Plans:</div></b>
        <div>
            ik ga mijn dev taken die nog niet in het portfolio zitten erin zetten het het beter bijhouden.
        </div>
    </td>
</tr>
<tr>
    <td>
        <b><div>Things to change / feed forward:</div></b>
        <div>
            Ik heb niet mijn dev taken in mijn portfolio.
        </div>
        <div>
            Let op je time management, aan 1 model werken voor 2 sprints is niet goed gebruik maken van je tijd. Denk aan de proporties van de UV map, iets aan de achterkant van het hoofd is minder belangrijk dus kan kleiner zijn dan iets aan de voorkant. Cirkel in cirkel en andere optimalisatie. Pixel optimalisatie(budget) is belangrijk zelfs al vindt jij het zelf minder overzichtelijk. UV map heeft lege plekken die gevuld moeten worden. 
        </div>
    </td>
    <td>
        <b><div>Goals:</div></b>
        <div>
            Ik moet al mijn werk gaan documenteren ondanks dat het niet onderdeel is van mijn leerdoelen.
        </div>
    </td>
</tr>
</table>
  
  
###  Learning Goals
  
  
####  Overarching goals
  
  
* Asset creation
  * By the end of this semester...
I have built up the knowledge to fully model rig and texture in blender so that I can be part of the asset creation process.
  
  * By the end of this semester...
I have made shaders that can be animated and interactable in Unity so that I can develop good looking environments in the project.
  
####  Short term goals
  
  
Sprint 1
  
* Asset creation
  * By the end of this sprint...
I have created a model using blender get a basis footing in modelling skills.
  
  * By the end of this sprint... 
I have rigged a model using Blender to make it easier to animate.
  
Sprint 2
  
* Asset creation
  * By the end of this sprint...
  I have UV mapped and textured a model to get a more complete set of basic modelling skills.
  
Sprint 3
  
* Development
  * By the end of this sprint...
  I have created an animated shader using shader graph.
  
  * By the end of this sprint...
  I have created implemented a system for playing random sounds and looping sound effects with an intro and outro.
  
  
  