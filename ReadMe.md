  
  
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
![](Pressure%20Cooker/DocAssets/moodboard.png?0.34827775351808876 )  
###  Storyboard
  
![](Pressure%20Cooker/DocAssets/storyboard.png?0.1966271092487355 )  
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
![](Pressure%20Cooker/DocAssets/donut%20modeling.png?0.9039159473497931 )  
  
I want to use a reference image in Blender, but i have not used them before. After finding an article online<sup>[2](#pc-asset-fn-2 )</sup> i followed the steps shown there to import images for reference use.
  
I used a reference for a plunger with a good side view.
![](Pressure%20Cooker/DocAssets/referenceInBlender.png?0.7529457909700661 )  
  
When i was done i noticed that I had issues with the mesh having dark spots, this was because of faulty normals, I had duplicate vertices that i had to delete. Afterwards my model looked fine.
  
Later i modeled a steering wheel for my ship. I made use of mirroring to reduce work, but i ran into trouble when dealing with the spokes, as it had overlapping issues. 
![](Pressure%20Cooker/DocAssets/overlapWheel.png?0.6263796724315387 )  
![](Pressure%20Cooker/DocAssets/overlapWheelWireframe.png?0.8720282016554977 )  
  
After much experimentation i removed the overlaps and was able to export it. By combining the overlaps i was able to make in intermediate shape that i could use to cut out a shape in the spokes and was then able to join them together.
![](Pressure%20Cooker/DocAssets/overlapIntermediateShape.png?0.23431232786343137 )  
  
<a name="pc-assets-fn-1">1</a>: "Blender 3.0 Beginner Tutorial - Part 1" - https://www.youtube.com/watch?v=nIoXOplUvAw
<a name="pc-assets-fn-2">2</a>:  - https://www.makeuseof.com/blender-reference-image-guide/ 
  
####  Creation
  
![](Pressure%20Cooker/DocAssets/modeledPlunger.png?0.7340481724463581 )  
![](Pressure%20Cooker/DocAssets/texturedWheel.png?0.8093922506766698 )  
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
![](XR%20Assets/DocAssets/RobotMoodboard.jpeg?0.2592690244811 )  
  
First off I made some concepts of the robot's head, I modeled  3 different shapes I envisioned as a possible head.
  
![](XR%20Assets/DocAssets/robohoofden.PNG?0.3842463415177344 )  
  
After showing it to the rest of my team we settle on going with the head on the right, as it looks like a monitor.
  
For the body I tried out a different style of shaping the model. First I made a rough shape by extruding and resizing the edges of a cube.
  
![](XR%20Assets/DocAssets/robo%20lichaam%20base.PNG?0.07223656144296187 )  
  
Once I had the shape I applied a Subdivision Surface to the mesh, this helped round it out.
  
![](XR%20Assets/DocAssets/robo%20lichaam%20vervorming.PNG?0.9949362941987565 )  
  
I made the arms by first creating a few basic shapes and then combining them together into a single mesh with the Boolean modifier on the union setting. This causes the object it filters for to be added to the mesh it was applied on.
  
I then wanted to add an armature to the robot, I followed the steps in https://en.wikibooks.org/wiki/Blender_3D:_Noob_to_Pro/Bones, I added bones starting from the main body and alligned them with the joints of the robot.
  
![](XR%20Assets/DocAssets/Robotbones.PNG?0.9735411507785232 )  
  
###  Sprint 2
  
  
####  Learning Goals
  
* By the end of this sprint...
  I have UV mapped and textured a model to get a more complete set of basic modelling skills.
  
####  Process 
  
  
In this sprint our team has finalized the design of the robot assistent, and I have been itterating over how to make it. For the new design we went with a less humanized look.
  
<img src="XR%20Assets/DocAssets/Sprint2/RobotAssistentSketch.png?0.5720111829624264"  width="300" >
<img src="XR%20Assets/DocAssets/Sprint2/RobotAssistentSketchSide.png?0.5865278232089923"  width="300" >
<img src="XR%20Assets/DocAssets/Sprint2/RobotAssistentSketchFront.jpg?0.8198911946630962"  width="300" >
  
I mocked together the head using basic object shapes and morphing their size a bit, I then combined them with boolean modifiers to get a nice looking shape. However, once I wanted to smooth the model I ran into issues, as it did not want to properly smooth the full head. Things looked worse when I wanted to UV unwrap the head, the vertices were all over the place. I inspected the model closer and found that there were stray vertices inside the head causing bad geometry. The boolean modifiers had left behind artifacts that were annoying to deal with. The best option for me was to start over with a new head and try to create the lense in a different way.
  
![](XR%20Assets/DocAssets/Sprint2/RobotOops.png?0.18192916052071917 )  
  
I started over with a cube once again and beveled it to make the edges smoother. For the lense I tried out a plug-in built into blender: "Edge Loops", it allowed me to transform the edges I selected into a circular shape. Once I changed the edges I could extrude the faces for the lense and went on from there. Once I was done I noticed that when I applied the smooth shading it would cause the lense to be smoothed against the robot head, but I wanted the lense to clearly be a separate part. In order to achieve this I had to mark the edges around the lense as sharp, I  then had to add the edge split modifier in order to make the normals behave like the faces were not connected on the edges.
  
![](XR%20Assets/DocAssets/Sprint2/RobotSharp.png?0.14449701995765074 )  
![](XR%20Assets/DocAssets/Sprint2/RobotSharpWire.png?0.29452422309780135 )  
  
Once I was done with making the lense I showed the robot head to the rest of my team for feedback. I continued to make changes based on the feedback until we were satisfied with the profile of the robot assistant.
  
![](XR%20Assets/DocAssets/Sprint2/Lens1.png?0.7302615444249145 )  
![](XR%20Assets/DocAssets/Sprint2/Lens2.png?0.8144023576375015 )  
  
![](XR%20Assets/DocAssets/Sprint2/RobotNewLens.png?0.7839071313516246 )  
  
For the wheel I started with a cylinder and applied loop cuts. I then rotated a loop and selected faces to extrude the profile of wheel. I then applied a subdivion service to the mesh to make it more smooth and round.
  
![](XR%20Assets/DocAssets/Sprint2/RobotAssistentWheel1.png?0.20881356934533102 )  
  
After the first wheel prototype was made it was clear that it's geometry would be both too heavy and problematic for shading. Instead of starting with a cylinder I tried out a different approach, I started with a cube and made it round. I was able to do this by selecting the edges I want to make round and applying a transform to sphere, this modified the edges to form a circle. I then gave it a curve to make it feel more like a tire. This seemed to work at first but when inspecting the wheel up close I noticed that the face had problems with rendering properly.
  
![](XR%20Assets/DocAssets/Sprint2/RobotAssistentWheel2Oof.png?0.40658814730109905 )  
  
When I inspected the edges I saw that the problem happened with faces where the vertices are not on the same plane, causing a folding effect.
  
![](XR%20Assets/DocAssets/Sprint2/RobotAssistentWheel2OofWire.png?0.7384117694641936 )  
  
I decided to throw away the wheel again and start fresh by using a sphere, the reasoning behind it was that it was already curved in two axes and thus felt more intuitive for me to deform into a wheel. This had the desired effect of having a nice looking wheel.
  
UV mapping the robot was quite the time sink, as there is not one solution for laying it all out. Every now and then I had to unwrap a mesh again, which would reset the all the selected vertices. After looking it up on the internet I found out that by pinning the vertices of an island I can prevent it being unwrapped and moved again, making it easier to plan the layout.
  
Once I was finished with UV mapping I had to texture the robot, I had two options, using a 3rd party tool to create a texture or use the 3d texture tool in Blender. I had to use a little trial and error to get it working, but I was able to figure out how to apply color to my model. I first had to create a new image in the UV editor, then I had to apply that material to the objects I wanted to paint. I was then able to paint directly onto the model, which felt quite intuitive to me. After more trial and error I discorvered that I was able to mask off parts of the mesh by pressing the "paint mask" button and then I was able to manipulate the mask in the "Select menu", this gave me a lot of control over which faces I want to paint.
  
![](XR%20Assets/DocAssets/Sprint2/PaintMask.png?0.14955067044909964 )  
  
After everything was done I ended up with a robot that both my team and I were satisfied with.
  
![](XR%20Assets/DocAssets/Sprint2/RobotDone.png?0.28076504013736914 )  
  
  
  
  
  
##  XR Development
  
  
###  Sprint 3
  
  
####  Learning Goals
  
* By the end of this sprint...
  I have created an animated shader using shader graph.
  
* By the end of this sprint...
  I have created implemented a system for playing random sounds and looping sound effects with an intro and outro.
####  Process
  
  
We wanted to expand the decor of the training area, one of which ways was to add posters to the area. To stay within the futuristic theme, I decided to make a hologram shader. To start I watched Brackey's tutorial on how to create a holographic in Unity using shader graphs ([HOLOGRAM using Unity Shader Graph](https://www.youtube.com/watch?v=KGGB5LFEejg )).
  
![](XR%20Development/DocAssets/ShaderGraphCompleet.png?0.8416508095662745 )  
After I had lines and emmission working after the tutorial i decided i wanted to add some grain to add to the holographic look. For this I experimented around with noise generation nodes and settled on using gradient noise as it's pattern works well for simulating the dithering pattern. I made the noise pattern change by changing the UV offset with the time passed.
  
![](XR%20Development/DocAssets/ShaderGraphExtra.png?0.7142281710434508 )  
  
Inside our enviroment we used it to display the safety measures.
  
![](XR%20Development/DocAssets/hologramPoster.gif?0.05379991810355733 )  
  
In our training we have a lot of controls and interactions going on, to assist in making the instructions clear we want to have a interactable onboarding. I reacently learned about the timelines asset in Unity and after doing some surface level research on how to use it I felt like it could be used for our onboarding.
  
I watched [How to use Unity3D Timeline in 10 minutes](https://www.youtube.com/watch?v=E5EYO3w-Xco ) to get a basic idea of how to use it.
  
After a bit of experimenting more with different tracks on the timeline it was clear what each track did. Out of the box there are six different tracks:
* Activation track - With this track you can control the active state of a game object.
* Animation track - In this track you can add animation clips for a game object with an animator component, you can also blend animations by having them overlap. Additionally you can override the transform of an object and have sub tracks for finer control.
* Audio track - By dragging a game object with an audio source into this track's control you're able to play audio clips at a specified time, useful for when playing voice lines.
* Signal track - In this track you can add signals, these signals act as events and can be used to trigger other objects in the scene by hooking into the signal receiver.
* Control track - This track allows for other objects with a director and timeline to be nested inside of the current timeline. This works for both scene objects as well as prefabs, allowing for separation of timelines and making it easier to copy paste specific timeline set ups.
* Playable track - This track is a catch-all track that handles any playable clip.
  
This provided us with a good set of tools, but would require a large amount of signal assets in order to have all events in place passing the appropritate parameter. I looked for possible solutions for this and found this blog " [How to make a custom signal receiver with emitter parameter](https://gametorrahod.com/how-to-make-a-custom-signal-receiver-with-emitter-parameter/ )".
  
I implemented the code from the blog, but made an adjustment to the code of the signal receiver. I moved the code for handling notifications to inside the base class to reduce boilerplate code and made the `SignalReceiver` component required. as without this component the parameterized signal receiver would not be able to receive any signal notifications.
  
```cs
using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.Timeline;
  
[RequireComponent(typeof(SignalReceiver))] // hack om het te laten werken
public abstract class ParameterizedSignalReceiver<T> : MonoBehaviour, INotificationReceiver
{
    [field: SerializeField] public SignalAssetEventPair[] SignalAssetEventPairs;
  
    [Serializable]
    public class SignalAssetEventPair
    {
        [field: SerializeField] public SignalAsset SignalAsset { get; set; }
        [field: SerializeField] public ParameterizedEvent Events { get; set; }
  
        [Serializable]
        public class ParameterizedEvent : UnityEvent<T> { }
    }
  
    public void OnNotify(Playable origin, INotification notification, object context)
    {
        if (notification is ParameterizedSignalEmitter<T> emitter)
        {
            foreach (var signalPair in SignalAssetEventPairs)
            {
                if (ReferenceEquals(signalPair.SignalAsset, emitter.asset))
                    signalPair.Events.Invoke(emitter.Parameter);
            }
        }
    }
}
  
```  
  
In order to set up the emitter and receiver of a given type for the timeline you have to go through the following steps
  
First you must create a class that inherits from `ParameterizedSignalEmitter<T>`. This will make it so that you can add this signal emitter from the signal track's context menu.
  
As an example I make a signal that can pass an integer.
```cs
public sealed class IntSignalEmitter : ParameterizedSignalEmitter<int>
{  
}
```
  
I can now add this emitter on my signal track.
![](XR%20Development/DocAssets/addSignalEmitter.png?0.3041310267465671 )  
  
Once I placed my signal on the track I can now pass a parameter that will be given to the receiver.
![](XR%20Development/DocAssets/signalData.png?0.4502305031569256 )  
  
Now to set up my receiver I do the same step as with the emitter, but inherit from `ParameterizedSignalReceiver<T>` instead.
```cs
public sealed class IntSignalReceiver : ParameterizedSignalReceiver<int>
{
}
```
  
I can now add it to an object and set a filter for a specific signal and select which fuction should be called. In order for the parameter to be passed to the function it needs to be a dynamically bound function, for statically bound functions you would add the function argument in the inspector itself on the event. 
  
This gave us the flexibility we needed, but I do feel like there is more to be learned about the timeline asset. It is possible to create your own tracks, but I have not looked at it enough to be able to use it. One possible use for this could be to separate the different signal types, as now it can become cluttered with two or more signals overlap, making it less clear what is going on.
  
I don't have too much experience with audio in Unity and wanted to know more about how to have finer control over the sounds being played. To begin I watched "[What you NEED to know about game audio as a beginner in 2021! Unity3d](https://www.youtube.com/watch?v=B9yxkJuHLek )" and found out about mixers in Unity. They allow for the sounds to be played in a specific channel which can then be adjusted individually, for example the volume for sound effects could be changed while leaving the sounds for character voices as is.
  
Now I wanted to add some simple systems to get more out of my sounds by either playing a random one from a select list or by looping a specific part of the clip.
  
For looping audio i wanted to have a bit more control on how the clip was looped, as some mid sections of a clip could be repeated indefinitely if wanted. This behavior would be well suited for moving the arms of the robot, as in real life you can hear the motor spin up, a whizzing noise when it moves and the brakes engaging when it stops moving.
```cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
  
[RequireComponent(typeof(AudioSource))]
public class LoopingSoundPlayer : MonoBehaviour, ISoundPlayer
{
    private AudioSource _audioSource;
  
    [field: SerializeField] public int IntroEndTime { get; set; }
    [field: SerializeField] public int OutroStartTime { get; set; }
  
    private LoopState _loopState;
  
    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
  
        if (_audioSource.playOnAwake)
            _loopState = LoopState.Intro;
    }
  
    /// <inheritdoc/>
    public void PlayClip()
    {
        Assert.IsNotNull(_audioSource.outputAudioMixerGroup, $"No mixer group in {this.gameObject.name}. Audio source should have a mixer group assigned in order to get the most control out of it.");
        Assert.IsNotNull(_audioSource.clip, $"No audio clip in {this.gameObject.name}.");
  
        // reset the clip to the start
        _audioSource.timeSamples = 0;
  
        _loopState = LoopState.Intro;
        _audioSource.Play();
    }
  
    /// <summary>
    /// Begins the outro of the audio clip.
    /// </summary>
    public void StopClip()
    {
        if (_loopState == LoopState.NotPlaying)
            return;
  
        _loopState = LoopState.Outro;
  
        _audioSource.timeSamples = OutroStartTime;
    }
  
    private void Update()
    {
        if (_audioSource.isPlaying)
        {
            switch (_loopState)
            {
                case LoopState.Intro:
                    if (_audioSource.timeSamples > IntroEndTime)
                        _loopState = LoopState.Main;
                    break;
                case LoopState.Main:
                    if (_audioSource.timeSamples >= OutroStartTime)
                        _audioSource.timeSamples = IntroEndTime;
                    break;
                case LoopState.Outro:
                    if (_audioSource.timeSamples == _audioSource.clip.samples)
                        _loopState = LoopState.NotPlaying;
                    break;
                case LoopState.NotPlaying:
                    // doe niets
                    break;
                default:
                    throw new System.NotImplementedException();
            }
        }
    }
  
    private enum LoopState
    {
        NotPlaying,
        Intro,
        Main,
        Outro
    }
}
  
```  
  
In order to prevent things from sounding the same sometimes different clips should be played when doing the same action. 
```cs
using System.Collections;
using UnityEngine;
using UnityEngine.Assertions;
  
// Alias om verwarring tussen System.Random en UnityEngine te voorkomen
using UnityRandom = UnityEngine.Random;
  
[RequireComponent(typeof(AudioSource))]
public class RandomSoundPlayer : MonoBehaviour, ISoundPlayer
{
    [SerializeField] private AudioClip[] _clips;
  
    private AudioSource _audioSource;
  
    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
  
        Assert.IsNotNull(_audioSource);
    }
  
    /// <summary>
    /// Plays a random clip on the audio source.
    /// </summary>
    public void PlayClip()
    {
        Assert.IsNotNull(_audioSource.outputAudioMixerGroup, $"No mixer group in {this.gameObject.name}. Audio source should have a mixer group assigned in order to get the most control out of it.");
        Assert.IsTrue(_clips.Length > 0, $"No audio clips in {this.name}. ");
  
        _audioSource.clip = _clips[UnityRandom.Range(0, _clips.Length)];
  
        _audioSource.Play();
    }
  
    /// <summary>
    /// Plays a random clip on the audio source and forget about it.
    /// </summary>
    public void PlayClipAndForget()
    {
        Assert.IsNotNull(_audioSource.outputAudioMixerGroup, $"No mixer group in {this.gameObject.name}. Audio source should have a mixer group assigned in order to get the most control out of it.");
        Assert.IsTrue(_clips.Length > 0, $"No audio clips in {this.name}. ");
  
        _audioSource.PlayOneShot(_clips[UnityRandom.Range(0, _clips.Length)]);
    }
  
    public void StopClip()
    {
        _audioSource.Stop();
    }
}
  
```  
  
Something that I noticed pretty quickly is that my systems are quie limited in what they can do and user friendliness. The looping audio for example is clunky to use as it relies on setting the boundaries with the sample number.
  
I looked for a possible alternative and came across FMOD, a tool that can be used to set up audio events that can be played inside of Unity. In order to get an idea of how it worked I read through the [quick start](https://www.fmod.com/resources/documentation-studio?version=2.01&page=quick-start-tutorial.html ) on the FMOD documation website.
  
I was able to recreate the effects I made myself in Unity preatty easily, as in FMOD you can use a multi instrument clip to pick a random one each time it plays and have looping parts in a clip with a loop region in a logic track.
  
To get FMOD working with Unity first I have to install the plugin that has all the needed code and components to make it work. Then i have to go through the set up wizard, which makes me disable the build in audio system and replaces components in the active scene for their FMOD counterpart. Next I need to create an FMOD project and set the build path for the audio banks, the containers of the audio events. In FMOD I can now add audio events with different clips and behaviors and then assign them to a bank. Now when I build the project it will create the banks inside of the Unity project and will be automatically recognised.
  
With the workflow of setting it up I decided to check with a copy of our project if it can be used. A simple test sounded prommising as I was able to hear the song that is plying in our enviroment, but when I was testing it on the Quest there was a lack of audio. I remembered that the Quest runs on Android and might be seen as a mobile device, I added it as a target platform in the FMOD project settings and after building the banks again I was able to hear the song.
  
Now that I knew the basics of FMOD and how to get it running I wanted to first talk to the rest of my team about if we should go in that direction, as it would require to restructure our project a bit to make it work with FMOD. In the end we decided against using it as adding it midway through the project would be more overhead of things to learn and things that could go wrong.
  
After having used it for a bit I can say that it is a handy tool and I would want to use it in any further projects and figure out how to use it in a team.
  
  
  
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
  
  
  