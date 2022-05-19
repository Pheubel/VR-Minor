---
markdown:
  path: ReadMe.md

export_on_save:
  markdown: true
---

## XR Development

### Sprint 3

#### Learning Goals
* By the end of this sprint...
  I have created an animated shader using shader graph.

* By the end of this sprint...
  I have created implemented a system for playing random sounds and looping sound effects with an intro and outro.
#### Process

We wanted to expand the decor of the training area, one of which ways was to add posters to the area. To stay within the futuristic theme, I decided to make a hologram shader. To start I watched Brackey's tutorial on how to create a holographic in Unity using shader graphs ([HOLOGRAM using Unity Shader Graph](https://www.youtube.com/watch?v=KGGB5LFEejg)).

@import "./DocAssets/ShaderGraphCompleet.png"
After I had lines and emmission working after the tutorial i decided i wanted to add some grain to add to the holographic look. For this I experimented around with noise generation nodes and settled on using gradient noise as it's pattern works well for simulating the dithering pattern. I made the noise pattern change by changing the UV offset with the time passed.

@import "./DocAssets/ShaderGraphExtra.png"

Inside our enviroment we used it to display the safety measures.

@import "./DocAssets/hologramPoster.gif"

In our training we have a lot of controls and interactions going on, to assist in making the instructions clear we want to have a interactable onboarding. I reacently learned about the timelines asset in Unity and after doing some surface level research on how to use it I felt like it could be used for our onboarding.

I watched [How to use Unity3D Timeline in 10 minutes](https://www.youtube.com/watch?v=E5EYO3w-Xco) to get a basic idea of how to use it.

After a bit of experimenting more with different tracks on the timeline it was clear what each track did. Out of the box there are six different tracks:
* Activation track - With this track you can control the active state of a game object.
* Animation track - In this track you can add animation clips for a game object with an animator component, you can also blend animations by having them overlap. Additionally you can override the transform of an object and have sub tracks for finer control.
* Audio track - By dragging a game object with an audio source into this track's control you're able to play audio clips at a specified time, useful for when playing voice lines.
* Signal track - In this track you can add signals, these signals act as events and can be used to trigger other objects in the scene by hooking into the signal receiver.
* Control track - This track allows for other objects with a director and timeline to be nested inside of the current timeline. This works for both scene objects as well as prefabs, allowing for separation of timelines and making it easier to copy paste specific timeline set ups.
* Playable track - This track is a catch-all track that handles any playable clip.

This provided us with a good set of tools, but would require a large amount of signal assets in order to have all events in place passing the appropritate parameter. I looked for possible solutions for this and found this blog " [How to make a custom signal receiver with emitter parameter](https://gametorrahod.com/how-to-make-a-custom-signal-receiver-with-emitter-parameter/)".

I implemented the code from the blog, but made an adjustment to the code of the signal receiver. I moved the code for handling notifications to inside the base class to reduce boilerplate code and made the `SignalReceiver` component required. as without this component the parameterized signal receiver would not be able to receive any signal notifications.

@import "./DocAssets/ParameterizedSignalReceiver.cs"

In order to set up the emitter and receiver of a given type for the timeline you have to go through the following steps

First you must create a class that inherits from `ParameterizedSignalEmitter<T>`. This will make it so that you can add this signal emitter from the signal track's context menu.

As an example I make a signal that can pass an integer.
```cs
public sealed class IntSignalEmitter : ParameterizedSignalEmitter<int>
{  
}
```

I can now add this emitter on my signal track.
@import "./DocAssets/addSignalEmitter.png"

Once I placed my signal on the track I can now pass a parameter that will be given to the receiver.
@import "./DocAssets/signalData.png"

Now to set up my receiver I do the same step as with the emitter, but inherit from `ParameterizedSignalReceiver<T>` instead.
```cs
public sealed class IntSignalReceiver : ParameterizedSignalReceiver<int>
{
}
```

I can now add it to an object and set a filter for a specific signal and select which fuction should be called. In order for the parameter to be passed to the function it needs to be a dynamically bound function, for statically bound functions you would add the function argument in the inspector itself on the event. 

This gave us the flexibility we needed, but I do feel like there is more to be learned about the timeline asset. It is possible to create your own tracks, but I have not looked at it enough to be able to use it. One possible use for this could be to separate the different signal types, as now it can become cluttered with two or more signals overlap, making it less clear what is going on.

I don't have too much experience with audio in Unity and wanted to know more about how to have finer control over the sounds being played. To begin I watched "[What you NEED to know about game audio as a beginner in 2021! Unity3d](https://www.youtube.com/watch?v=B9yxkJuHLek)" and found out about mixers in Unity. They allow for the sounds to be played in a specific channel which can then be adjusted individually, for example the volume for sound effects could be changed while leaving the sounds for character voices as is.

Now I wanted to add some simple systems to get more out of my sounds by either playing a random one from a select list or by looping a specific part of the clip.

For looping audio i wanted to have a bit more control on how the clip was looped, as some mid sections of a clip could be repeated indefinitely if wanted. This behavior would be well suited for moving the arms of the robot, as in real life you can hear the motor spin up, a whizzing noise when it moves and the brakes engaging when it stops moving.
@import "./DocAssets/LoopingSoundPlayer.cs"

In order to prevent things from sounding the same sometimes different clips should be played when doing the same action. 
@import "./DocAssets/RandomSoundPlayer.cs"

Something that I noticed pretty quickly is that my systems are quie limited in what they can do and user friendliness. The looping audio for example is clunky to use as it relies on setting the boundaries with the sample number.

I looked for a possible alternative and came across FMOD, a tool that can be used to set up audio events that can be played inside of Unity. In order to get an idea of how it worked I read through the [quick start](https://www.fmod.com/resources/documentation-studio?version=2.01&page=quick-start-tutorial.html) on the FMOD documation website.

I was able to recreate the effects I made myself in Unity preatty easily, as in FMOD you can use a multi instrument clip to pick a random one each time it plays and have looping parts in a clip with a loop region in a logic track.

@import "./DocAssets/fmodLoop.png"

To get FMOD working with Unity first I have to install the plugin that has all the needed code and components to make it work. Then i have to go through the set up wizard, which makes me disable the build in audio system and replaces components in the active scene for their FMOD counterpart. Next I need to create an FMOD project and set the build path for the audio banks, the containers of the audio events. In FMOD I can now add audio events with different clips and behaviors and then assign them to a bank. Now when I build the project it will create the banks inside of the Unity project and will be automatically recognised.

With the workflow of setting it up I decided to check with a copy of our project if it can be used. A simple test sounded prommising as I was able to hear the song that is plying in our enviroment, but when I was testing it on the Quest there was a lack of audio. I remembered that the Quest runs on Android and might be seen as a mobile device, I added it as a target platform in the FMOD project settings and after building the banks again I was able to hear the song.

Now that I knew the basics of FMOD and how to get it running I wanted to first talk to the rest of my team about if we should go in that direction, as it would require to restructure our project a bit to make it work with FMOD. In the end we decided against using it as adding it midway through the project would be more overhead of things to learn and things that could go wrong.

After having used it for a bit I can say that it is a handy tool and I would want to use it in any further projects and figure out how to use it in a team.