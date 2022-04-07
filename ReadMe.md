  
  
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
  - [Sprint 2](#sprint-2 )
- [Learning Goals](#learning-goals )
  - [Overarching goals](#overarching-goals )
  - [Short term goals](#short-term-goals )
  
##  Pressure Cooker
  
  
###  Concept
  
###  Explanation
  
The user opperates a time machine boat to save people on the flooding canals of Amsterdam.
###  Moodboard
  
As a theme for the boat i want to have a mix of the past, today and the tomorrow that will never be, steampunk.
![](Pressure%20Cooker/DocAssets/moodboard.png?0.528545219330588 )  
###  Storyboard
  
![](Pressure%20Cooker/DocAssets/storyboard.png?0.8765444436748437 )  
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
![](Pressure%20Cooker/DocAssets/donut%20modeling.png?0.999942731504281 )  
  
I want to use a reference image in Blender, but i have not used them before. After finding an article online<sup>[2](#pc-asset-fn-2 )</sup> i followed the steps shown there to import images for reference use.
  
I used a reference for a plunger with a good side view.
![](Pressure%20Cooker/DocAssets/referenceInBlender.png?0.23192383571287656 )  
  
When i was done i noticed that I had issues with the mesh having dark spots, this was because of faulty normals, I had duplicate vertices that i had to delete. Afterwards my model looked fine.
  
Later i modeled a steering wheel for my ship. I made use of mirroring to reduce work, but i ran into trouble when dealing with the spokes, as it had overlapping issues. 
![](Pressure%20Cooker/DocAssets/overlapWheel.png?0.8172797065239978 )  
![](Pressure%20Cooker/DocAssets/overlapWheelWireframe.png?0.49041445177472753 )  
  
After much experimentation i removed the overlaps and was able to export it. By combining the overlaps i was able to make in intermediate shape that i could use to cut out a shape in the spokes and was then able to join them together.
![](Pressure%20Cooker/DocAssets/overlapIntermediateShape.png?0.1557756119042062 )  
  
<a name="pc-assets-fn-1">1</a>: "Blender 3.0 Beginner Tutorial - Part 1" - https://www.youtube.com/watch?v=nIoXOplUvAw
<a name="pc-assets-fn-2">2</a>:  - https://www.makeuseof.com/blender-reference-image-guide/ 
  
####  Creation
  
![](Pressure%20Cooker/DocAssets/modeledPlunger.png?0.9018060847734721 )  
![](Pressure%20Cooker/DocAssets/texturedWheel.png?0.553324139027469 )  
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
  
  
For this sprint I took it upon myself to create the model for the instructor robot, As I want to improve my Blender skills. 
  
To begin, our team had created a moodboard for the robot. I used that to create a prototype in blender.
![](XR%20Assets/DocAssets/RobotMoodboard.jpeg?0.906738104018 )  
  
First off I made some concepts of the robot's head, I modeled  3 different shapes I envisioned as a possible head.
  
![](XR%20Assets/DocAssets/robohoofden.png?0.703446009044234 )  
  
After showing it to the rest of my team we settle on going with the head on the right, as it looks like a monitor.
  
For the body I tried out a different style of shaping the model. First I made a rough shape by extruding and resizing the edges of a cube.
  
![](XR%20Assets/DocAssets/robo%20lichaam%20base.PNG?0.9329160092626119 )  
  
Once i had the shape I applied a Subdivision Surface to the mesh, this helped round it out.
  
![](XR%20Assets/DocAssets/robo%20lichaam%20vervorming.PNG?0.6034857932113062 )  
  
I made the arms by first creating a few basic shapes and then combining them together into a single mesh with the Boolean modifier on the union setting. This causes the object it filters for to be added to the mesh it was applied on.
  
I then wanted to add an armature to the robot, I followed the steps in https://en.wikibooks.org/wiki/Blender_3D:_Noob_to_Pro/Bones, I added bones starting from the main body and alligned them with the joints of the robot.
  
![](XR%20Assets/DocAssets/Robot%20Bones.PNG?0.9244225733188047 )  
  
###  Sprint 2
  
  
In this sprint our team ahs finalized the design of the robot assistent, and i have been itterating over how to make it. For the new design we went with a less humanized look.
  
<img src="XR%20Assets/DocAssets/Sprint2/RobotAssistentSketch.png?0.8072973156591599"  width="300" >
<img src="XR%20Assets/DocAssets/Sprint2/RobotAssistentSketchSide.png?0.13800883355976223"  width="300" >
<img src="XR%20Assets/DocAssets/Sprint2/RobotAssistentSketchFront.jpg?0.690264626076649"  width="300" >
  
  
  
  
##  Learning Goals
  
  
###  Overarching goals
  
  
* Asset creation
  * By the end of this semester...
I have built up the knowledge to fully model rig and texture in blender so that I can be part of the asset creation process.
  
  * By the end of this semester...
I have made shaders that can be animated and interactable in Unity so that I can develop good looking environments in the project.
  
###  Short term goals
  
  
Sprint 1
  
* Asset creation
  * By the end of this sprint...
I have created a model using blender get a basis footing in modelling skills.
  
  * By the end of this sprint... 
I have rigged a model using Blender to make it easier to animate.
  
  