  
  
##  XR Assets
  
  
###  Sprint 1
  
  
For this sprint I took it upon myself to create the model for the instructor robot, As I want to improve my Blender skills. 
  
To begin, our team had created a moodboard for the robot. I used that to create a prototype in blender.
![](../XR%20Assets/DocAssets/RobotMoodboard.jpeg?0.591023525071013 )  
  
First off I made some concepts of the robot's head, I modeled  3 different shapes I envisioned as a possible head.
  
![](../XR%20Assets/DocAssets/robohoofden.png?0.9182831777952987 )  
  
After showing it to the rest of my team we settle on going with the head on the right, as it looks like a monitor.
  
For the body I tried out a different style of shaping the model. First I made a rough shape by extruding and resizing the edges of a cube.
  
![](../XR%20Assets/DocAssets/robo%20lichaam%20base.PNG?0.03259115854973915 )  
  
Once i had the shape I applied a Subdivision Surface to the mesh, this helped round it out.
  
![](../XR%20Assets/DocAssets/robo%20lichaam%20vervorming.PNG?0.2129324477895398 )  
  
I made the arms by first creating a few basic shapes and then combining them together into a single mesh with the Boolean modifier on the union setting. This causes the object it filters for to be added to the mesh it was applied on.
  
I then wanted to add an armature to the robot, I followed the steps in https://en.wikibooks.org/wiki/Blender_3D:_Noob_to_Pro/Bones, I added bones starting from the main body and alligned them with the joints of the robot.
  
![](../XR%20Assets/DocAssets/Robot%20Bones.PNG?0.7540204524161556 )  
  
###  Sprint 2
  
  
In this sprint our team has finalized the design of the robot assistent, and i have been itterating over how to make it. For the new design we went with a less humanized look.
  
<img src="../XR%20Assets/DocAssets/Sprint2/RobotAssistentSketch.png?0.3016351138690596"  width="300" >
<img src="../XR%20Assets/DocAssets/Sprint2/RobotAssistentSketchSide.png?0.1359083275204671"  width="300" >
<img src="../XR%20Assets/DocAssets/Sprint2/RobotAssistentSketchFront.jpg?0.8937059097020834"  width="300" >
  
I mocked together the head using basic object shapes and morphing their size a bit, i then combined them with boolean modifiers to get a nice looking shape. However, once i wanted to smooth the model i ran into issues, as it did not want to properly smooth the full head. Things looked worse when i wanted to UV unwrap the head, the vertices were all over the place. I inspected the model closer and found that there were stray vertices inside the head causing bad geometry. The boolean modifiers had left behind artifacts that were annoying to deal with. The best option for me was to start over with a new head and try to create the lense in a different way.
  
//TODO: zet screenshots van hoofd 1 hier
  
I started over with a cube once again and beveled it to make the edges smoother. For the lense i tried out a plug-in built into blender: "Edge Loops", it allowed me to transform the edges i selected into a circular shape. Once i changed the edges i could extrude the faces for the lense and went on from there. Once i was done i noticed that when i applied the smooth shading it would cause the lense to be smoothed against the robot head, but i wanted the lense to clearly be a separate part. In order to achieve this i had to mark the edges around the lense as sharp, I  then had to add the edge split modifier in order to make the normals behave like the faces were not connected on the edges.
  
![](../XR%20Assets/DocAssets/Sprint2/RobotSharp.png?0.12468799443429068 )  
![](../XR%20Assets/DocAssets/Sprint2/RobotSharpWire.png?0.17066951057703883 )  
  
Once i was done with making the lense i showed the robot head to the rest of my team for feedback. I continued to make changes based on the feedback until we were satisfied with the profile of the robot assistant.
  
![](../XR%20Assets/DocAssets/Sprint2/Lens1.png?0.7029661945093109 )  
![](../XR%20Assets/DocAssets/Sprint2/Lens2.png?0.2430755988921205 )  
  
//TODO: zet screenshot van laatste lens hier
  
For the wheel i started with a cylinder and applied loop cuts. I then rotated a loop and selected faces to extrude the profile of wheel. I then applied a subdivion service to the mesh to make it more smooth and round.
  
//TODO: zet screenshots van wiel 1 hier
  
After the first wheel prototype was made it was clear that it's geometry would be both too heavy and problematic for shading. Instead of starting with a cylinder i tried out a different approach, i started with a cube and made it round. I was able to do this by selecting the edges i want to make round and applying a transform to sphere, this modified the edges to form a circle. i then gave it a curve to make it feel more like a tire. This seemed to work at first but when inspecting the wheel up close i noticed that the face had problems with rendering properly.
  
![](../XR%20Assets/DocAssets/Sprint2/RobotAssistentWheel2Oof.png?0.2864015378007856 )  
  
When i inspected the edges i saw that the problem happened with faces where the vertices are not on the same plane, causing a folding effect.
  
![](../XR%20Assets/DocAssets/Sprint2/RobotAssistentWheel2OofWire.png?0.2953206950455043 )  
  
I decided to throw away the wheel again and start fresh by using a sphere, the reasoning behind it was that it was already curved in two axes and thus felt more intuitive for me to deform into a wheel. This had the desired effect of having a nice looking wheel.
  
UV mapping the robot was quite the time sink, as there is not one solution for laying it all out. Every now and then i had to unwrap a mesh again, which would reset the all the selected vertices. After looking it up on the internet i found out that by pinning the vertices of an island i can prevent it being unwrapped and moved again, making it easier to plan the layout.
  
Once i was finished with UV mapping i had to texture the robot, i had two options, using a 3rd party tool to create a texture or use the 3d texture tool in Blender. I had to use a little trial and error to get it working, but i was able to figure out how to apply color to my model. I first had to create a new image in the UV editor, then i had to apply that material to the objects i wanted to paint. I was then able to paint directly onto the model, which felt quite intuitive to me. After more trial and error i discorvered that i was able to mask off parts of the mesh by pressing the "paint mask" button and then i was able to manipulate the mask in the "Select menu", this gave me a lot of control over which faces i want to paint.
  
![](../XR%20Assets/DocAssets/Sprint2/PaintMask.png?0.9407138148813492 )  
  
After everything was done i ended up with a robot that both my team and i were satisfied with.
  
![](../XR%20Assets/DocAssets/Sprint2/RobotDone.png?0.14935179457408942 )  
  