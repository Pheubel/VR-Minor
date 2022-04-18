  
  
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
![](../XR%20assets/DocAssets/RobotMoodboard.jpeg?0.9291388009105159 )  
  
First off I made some concepts of the robot's head, I modeled  3 different shapes I envisioned as a possible head.
  
![](../XR%20assets/DocAssets/robohoofden.PNG?0.10698029712078116 )  
  
After showing it to the rest of my team we settle on going with the head on the right, as it looks like a monitor.
  
For the body I tried out a different style of shaping the model. First I made a rough shape by extruding and resizing the edges of a cube.
  
![](../XR%20assets/DocAssets/robo%20lichaam%20base.PNG?0.5450989590988544 )  
  
Once I had the shape I applied a Subdivision Surface to the mesh, this helped round it out.
  
![](../XR%20assets/DocAssets/robo%20lichaam%20vervorming.PNG?0.10770983038311632 )  
  
I made the arms by first creating a few basic shapes and then combining them together into a single mesh with the Boolean modifier on the union setting. This causes the object it filters for to be added to the mesh it was applied on.
  
I then wanted to add an armature to the robot, I followed the steps in https://en.wikibooks.org/wiki/Blender_3D:_Noob_to_Pro/Bones, I added bones starting from the main body and alligned them with the joints of the robot.
  
![](../XR%20assets/DocAssets/Robot%20Bones.PNG?0.4252020105541596 )  
  
###  Sprint 2
  
  
####  Learning Goals
  
* By the end of this sprint...
  I have UV mapped and textured a model to get a more complete set of basic modelling skills.
  
####  Process 
  
  
In this sprint our team has finalized the design of the robot assistent, and I have been itterating over how to make it. For the new design we went with a less humanized look.
  
<img src="../XR%20assets/DocAssets/Sprint2/RobotAssistentSketch.png?0.32228078217317413"  width="300" >
<img src="../XR%20assets/DocAssets/Sprint2/RobotAssistentSketchSide.png?0.39510361640607683"  width="300" >
<img src="../XR%20assets/DocAssets/Sprint2/RobotAssistentSketchFront.jpg?0.7746412688493707"  width="300" >
  
I mocked together the head using basic object shapes and morphing their size a bit, I then combined them with boolean modifiers to get a nice looking shape. However, once I wanted to smooth the model I ran into issues, as it did not want to properly smooth the full head. Things looked worse when I wanted to UV unwrap the head, the vertices were all over the place. I inspected the model closer and found that there were stray vertices inside the head causing bad geometry. The boolean modifiers had left behind artifacts that were annoying to deal with. The best option for me was to start over with a new head and try to create the lense in a different way.
  
![](../XR%20assets/DocAssets/Sprint2/RobotOops.png?0.6305062763081755 )  
  
I started over with a cube once again and beveled it to make the edges smoother. For the lense I tried out a plug-in built into blender: "Edge Loops", it allowed me to transform the edges I selected into a circular shape. Once I changed the edges I could extrude the faces for the lense and went on from there. Once I was done I noticed that when I applied the smooth shading it would cause the lense to be smoothed against the robot head, but I wanted the lense to clearly be a separate part. In order to achieve this I had to mark the edges around the lense as sharp, I  then had to add the edge split modifier in order to make the normals behave like the faces were not connected on the edges.
  
![](../XR%20assets/DocAssets/Sprint2/RobotSharp.png?0.6473573478033845 )  
![](../XR%20assets/DocAssets/Sprint2/RobotSharpWire.png?0.5168809777345298 )  
  
Once I was done with making the lense I showed the robot head to the rest of my team for feedback. I continued to make changes based on the feedback until we were satisfied with the profile of the robot assistant.
  
![](../XR%20assets/DocAssets/Sprint2/Lens1.png?0.032242317528252684 )  
![](../XR%20assets/DocAssets/Sprint2/Lens2.png?0.4076776375560367 )  
  
![](../XR%20assets/DocAssets/Sprint2/RobotNewLens.png?0.8905040168240048 )  
  
For the wheel I started with a cylinder and applied loop cuts. I then rotated a loop and selected faces to extrude the profile of wheel. I then applied a subdivion service to the mesh to make it more smooth and round.
  
![](../XR%20assets/DocAssets/Sprint2/RobotAssistentWheel1.png?0.08311318962962844 )  
  
After the first wheel prototype was made it was clear that it's geometry would be both too heavy and problematic for shading. Instead of starting with a cylinder I tried out a different approach, I started with a cube and made it round. I was able to do this by selecting the edges I want to make round and applying a transform to sphere, this modified the edges to form a circle. I then gave it a curve to make it feel more like a tire. This seemed to work at first but when inspecting the wheel up close I noticed that the face had problems with rendering properly.
  
![](../XR%20assets/DocAssets/Sprint2/RobotAssistentWheel2Oof.png?0.1522871585930048 )  
  
When I inspected the edges I saw that the problem happened with faces where the vertices are not on the same plane, causing a folding effect.
  
![](../XR%20assets/DocAssets/Sprint2/RobotAssistentWheel2OofWire.png?0.7675876068560472 )  
  
I decided to throw away the wheel again and start fresh by using a sphere, the reasoning behind it was that it was already curved in two axes and thus felt more intuitive for me to deform into a wheel. This had the desired effect of having a nice looking wheel.
  
UV mapping the robot was quite the time sink, as there is not one solution for laying it all out. Every now and then I had to unwrap a mesh again, which would reset the all the selected vertices. After looking it up on the internet I found out that by pinning the vertices of an island I can prevent it being unwrapped and moved again, making it easier to plan the layout.
  
Once I was finished with UV mapping I had to texture the robot, I had two options, using a 3rd party tool to create a texture or use the 3d texture tool in Blender. I had to use a little trial and error to get it working, but I was able to figure out how to apply color to my model. I first had to create a new image in the UV editor, then I had to apply that material to the objects I wanted to paint. I was then able to paint directly onto the model, which felt quite intuitive to me. After more trial and error I discorvered that I was able to mask off parts of the mesh by pressing the "paint mask" button and then I was able to manipulate the mask in the "Select menu", this gave me a lot of control over which faces I want to paint.
  
![](../XR%20assets/DocAssets/Sprint2/PaintMask.png?0.5133029674679386 )  
  
After everything was done I ended up with a robot that both my team and I were satisfied with.
  
![](../XR%20assets/DocAssets/Sprint2/RobotDone.png?0.3920687603421147 )  
  