  
  
##  XR Development
  
  
###  Sprint 3
  
  
####  Learning Goals
  
* By the end of this sprint...
  I have created an animated shader using shader graph.
  
* By the end of this sprint...
  I have created implemented a system for playing random sounds and looping sound effects with an intro and outro.
####  Process
  
  
We wanted to expand the decor of the training area, one of which ways was to add posters to the area. To stay within the futuristic theme, I decided to make a hologram shader. To start I watched Brackey's tutorial on how to create a holographic in Unity using shader graphs ([HOLOGRAM using Unity Shader Graph](https://www.youtube.com/watch?v=KGGB5LFEejg )).
  
![](../XR%20Development/DocAssets/ShaderGraphCompleet.png?0.9014066673953578 )  
After I had lines and emmission working after the tutorial i decided i wanted to add some grain to add to the holographic look. For this I experimented around with noise generation nodes and settled on using gradient noise as it's pattern works well for simulating the dithering pattern. I made the noise pattern change by changing the UV offset with the time passed.
  
![](../XR%20Development/DocAssets/ShaderGraphExtra.png?0.910749103185353 )  
  
Inside our enviroment we used it to display the safety measures.
  
![](../XR%20Development/DocAssets/hologramPoster.gif?0.9923592740361336 )  
  
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
![](../XR%20Development/DocAssets/addSignalEmitter.png?0.8820584969999301 )  
  
Once I placed my signal on the track I can now pass a parameter that will be given to the receiver.
![](../XR%20Development/DocAssets/signalData.png?0.8264000175025237 )  
  
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
  
![](../XR%20Development/DocAssets/fmodLoop.png?0.28762560891058486 )  
  
To get FMOD working with Unity first I have to install the plugin that has all the needed code and components to make it work. Then i have to go through the set up wizard, which makes me disable the build in audio system and replaces components in the active scene for their FMOD counterpart. Next I need to create an FMOD project and set the build path for the audio banks, the containers of the audio events. In FMOD I can now add audio events with different clips and behaviors and then assign them to a bank. Now when I build the project it will create the banks inside of the Unity project and will be automatically recognised.
  
With the workflow of setting it up I decided to check with a copy of our project if it can be used. A simple test sounded prommising as I was able to hear the song that is plying in our enviroment, but when I was testing it on the Quest there was a lack of audio. I remembered that the Quest runs on Android and might be seen as a mobile device, I added it as a target platform in the FMOD project settings and after building the banks again I was able to hear the song.
  
Now that I knew the basics of FMOD and how to get it running I wanted to first talk to the rest of my team about if we should go in that direction, as it would require to restructure our project a bit to make it work with FMOD. In the end we decided against using it as adding it midway through the project would be more overhead of things to learn and things that could go wrong.
  
After having used it for a bit I can say that it is a handy tool and I would want to use it in any further projects and figure out how to use it in a team.
  
###  Sprint 4
  
  
####  Learning Goal
  
  
* By the end of this sprint...
I have created a system that guides a player on how to use each movement mode of the robot arm.
  
* By the end of this sprint...
I have created and deployed a build to a quest to play it stand alone from a computer.
  
####  Process
  
  
To assist in teaching the controls of the robot arm we want to have the user try to move the robot arm part by part so that they can get a feel for how they need to move the stick to move a specific axis of the robot arm.
  
For linear movement we want the position of the end effector to move to a certain spot.
  
To do this I made use of empty game objects with a sphere collider set to triggers to detect that it has entered the collider, however I want to be able to specify which specific collider of the robot arm I want to be detected. To do this I made a small script that acts as a filter for triggers.
  
```cs
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.Events;
  
[RequireComponent(typeof(Collider))]
public class OnTriggerColliderFilter : MonoBehaviour
{
    [field: SerializeField]
    public Collider Filter { get; set; }
    [SerializeField] private UnityEvent _onTriggerEnter;
    [SerializeField] private UnityEvent _onTriggerExit;
  
    private void OnTriggerEnter(Collider other)
    {
        if (other == Filter)
            _onTriggerEnter.Invoke();
    }
  
    private void OnTriggerExit(Collider other)
    {
        if (other == Filter)
            _onTriggerExit.Invoke();
    }
}
  
```
  
To have them be activated in sequence I made a script to handle this:
```cs
using System.Collections;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.Events;
  
public class TutorialGoalPositions : MonoBehaviour
{
    [SerializeField, Min(0)] float timeRequiredInside;
    [SerializeField] OnTriggerColliderFilter[] _colliders;
    [SerializeField] UnityEvent _onBeginSequence;
    [SerializeField] UnityEvent _onAdvancedStep;
    [SerializeField] UnityEvent _onCompletion;
  
    int _currentGoal;
    Coroutine _advanceCoroutine;
  
    /// <summary>
    /// Resets the active goal positions and starts with the first one.
    /// </summary>
    public void Begin()
    {
        Assert.IsTrue(_colliders.Length > 0, $"({this.gameObject.name} {nameof(TutorialGoalPositions)}) Must have at least one collider goal.");
  
#if UNITY_EDITOR
        if(_currentGoal < _colliders.Length)
#else
        Assert.IsTrue(_currentGoal < _colliders.Length, $"{nameof(_currentGoal)} is in an illegal state");
#endif
            _colliders[_currentGoal].gameObject.SetActive(false);
  
        _currentGoal = 0;
        _colliders[0].gameObject.SetActive(true);
  
        _onBeginSequence.Invoke();
    }
  
    /// <summary>
    /// Starts a coroutine to advance to the next goal after a set period of time.
    /// </summary>
    public void QueueAdvance() =>
        _advanceCoroutine = StartCoroutine(Advance());
  
    /// <summary>
    /// Cancels the coroutine to advance to the next goal after a set period of time.
    /// </summary>
    public void CancelAdvance()
    {
        if (_advanceCoroutine != null)
            StopCoroutine(_advanceCoroutine);
    }
  
    /// <summary>
    /// Set the current goal to the next one in line after a set amount of time.
    /// </summary>
    public IEnumerator Advance()
    {
        if (timeRequiredInside > 0)
            yield return new WaitForSeconds(timeRequiredInside);
  
        _colliders[_currentGoal].gameObject.SetActive(false);
  
        _currentGoal++;
  
        // check if this was the last goal
        if (_currentGoal == _colliders.Length)
        {
            _onCompletion.Invoke();
            _currentGoal = default;
        }
        else
        {
            _colliders[_currentGoal].gameObject.SetActive(true);
            _onAdvancedStep.Invoke();
        }
    }
  
    /// <summary>
    /// Set the current goal to the next one in line.
    /// </summary>
    public void AdvanceImmediately()
    {
        _colliders[_currentGoal].gameObject.SetActive(false);
  
        _currentGoal++;
  
        // check if this was the last goal
        if (_currentGoal == _colliders.Length)
        {
            _onCompletion.Invoke();
            _currentGoal = default;
        }
        else
        {
            _colliders[_currentGoal].gameObject.SetActive(true);
            _onAdvancedStep.Invoke();
        }
    }
}
```
  
<figure class="video_container">
  <video controls="true" allowfullscreen="true" poster="path/to/poster_image.png" width="100%">
    <source src="XR Development/DocAssets/Goal Example.mp4" type="video/mp4">
  </video>
</figure>
  
For the manual movent, where the user moves each axis individually, we want to have each axis to one by one show how they have to be rotated. To do this I added a holographic copy of the part.
  
In order to show the rotation the part has to be in I made a script that sets to rotation to the desired rotation.
  
```cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.Events;
  
public class TutorialGoalRotation : MonoBehaviour
{
    [SerializeField] Step[] _steps;
    [SerializeField, Range(0, 180)] float _tollerance;
    [SerializeField, Min(0)] float _timeRequired;
  
    [SerializeField] UnityEvent _onAdvancedStep;
    [SerializeField] UnityEvent _onCompletion;
  
    [System.Serializable]
    public class Step
    {
        [field: SerializeField, Tooltip("The object who's rotation will be observed.")]
        public Transform Observing { get; private set; }
  
        [field: SerializeField, Tooltip("The object acting as a guide for the end position.")]
        public Transform Highlight { get; private set; }
  
        [field: SerializeField, Tooltip("The desired rotation of the axis")]
        public float TargetRotation { get; private set; }
  
        [field: SerializeField, Tooltip("The axis to be tested.")]
        public Axis Axis { get; private set; }
        public ArticulationDrive[] InitialRotations { get; set; }
    }
  
    public enum Axis { X, Y, Z }
}
```
  
With this I can set what axis of the robot arm I want to track, what it's end rotation should be and how long it has to stay in that position before moving on to the next rotation.
  
![](../XR%20Development/DocAssets/rotationInspector.png?0.3601079909701914 )  
  
In order to have the hologram be in the right position I set the local rotation to the target rotation
  
```cs
var currentStep = _steps[_currentStepIndex];
  
Quaternion targetRotation = currentStep.Axis switch
{
    Axis.X => Quaternion.Euler(currentStep.TargetRotation, 0, 0),
    Axis.Y => Quaternion.Euler(0, currentStep.TargetRotation, 0),
    Axis.Z => Quaternion.Euler(0, 0, currentStep.TargetRotation),
    _ => throw new System.NotImplementedException()
};
  
currentStep.Highlight.localRotation = targetRotation;
```
  
However this will cause the highlight to spin alongside the axis I want to rotate, instead of standing still. After looking at the documentation for [Quaternion.Inverse](https://docs.unity3d.com/ScriptReference/Quaternion.Inverse.html ) I figured that i could use the parent's rotation to rotate the highlight in such a way that it looks like it is standing still.
  
```cs
// counter rotate the highlight to make it appear as if it is not rotating
currentStep.Highlight.localRotation = Quaternion.Inverse(currentStep.Observing.localRotation) * targetRotation;
```
  
In full the code looks like follows:
```cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.Events;
  
public class TutorialGoalRotation : MonoBehaviour
{
    [SerializeField] Step[] _steps;
    [SerializeField, Range(0, 180)] float _tollerance;
    [SerializeField, Min(0)] float _timeRequired;
  
    [SerializeField] UnityEvent _onAdvancedStep;
    [SerializeField] UnityEvent _onCompletion;
  
    int _currentStepIndex;
    Coroutine _currentCoroutine;
  
    /// <summary>
    /// Resets the active goal rotation and starts with the first one.
    /// </summary>
    public void Begin()
    {
        Assert.IsTrue(_steps.Length > 0, $"({this.gameObject.name} {nameof(TutorialGoalPositions)}) Must have at least one rotation goal.");
  
        this.enabled = true;
  
        _currentStepIndex = default;
  
        // set the first highlight to the goal rotation
        var currentStep = _steps[_currentStepIndex];
        currentStep.Highlight.gameObject.SetActive(true);
        currentStep.Highlight.rotation = currentStep.Axis switch
        {
            Axis.X => Quaternion.Euler(currentStep.TargetRotation, 0, 0),
            Axis.Y => Quaternion.Euler(0, currentStep.TargetRotation, 0),
            Axis.Z => Quaternion.Euler(0, 0, currentStep.TargetRotation),
            _ => throw new System.NotImplementedException()
        };
    }
  
    private void FixedUpdate()
    {
        var currentStep = _steps[_currentStepIndex];
  
        Quaternion targetRotation = currentStep.Axis switch
        {
            Axis.X => Quaternion.Euler(currentStep.TargetRotation, 0, 0),
            Axis.Y => Quaternion.Euler(0, currentStep.TargetRotation, 0),
            Axis.Z => Quaternion.Euler(0, 0, currentStep.TargetRotation),
            _ => throw new System.NotImplementedException()
        };
  
        // counter rotate the highlight to make it appear as if it is not rotating
        currentStep.Highlight.localRotation = Quaternion.Inverse(currentStep.Observing.localRotation) * targetRotation;
  
        var angle = Quaternion.Angle(currentStep.Observing.localRotation, targetRotation);
  
        // if the observed axis rotation is close enough to the step's goal rotation, start advancing to the next step.
        if (angle <= _tollerance)
        {
            if (_currentCoroutine == null)
            {
                _currentCoroutine = StartCoroutine(Advance());
            }
        }
        else
        {
            if (_currentCoroutine != null)
            {
                StopCoroutine(_currentCoroutine);
                _currentCoroutine = null;
            }
        }
    }
  
    /// <summary>
    /// Set the current goal to the next one in line after a set amount of time.
    /// </summary>
    private IEnumerator Advance()
    {
        if (_timeRequired > 0)
            yield return new WaitForSeconds(_timeRequired);
  
        _currentCoroutine = null;
  
        // reset the highlight of the completed step
        var currentStep = _steps[_currentStepIndex];
        currentStep.Highlight.gameObject.SetActive(false);
        currentStep.Highlight.rotation = Quaternion.identity;
  
        _currentStepIndex++;
  
        // check if this was the last goal
        if (_currentStepIndex == _steps.Length)
        {
            _onCompletion.Invoke();
            _currentStepIndex = default;
  
            this.enabled = false;
        }
        else
        {
            currentStep = _steps[_currentStepIndex];
            currentStep.Highlight.gameObject.SetActive(true);
  
            _onAdvancedStep.Invoke();
        }
    }
  
    /// <summary>
    /// Set the current goal to the next one in line.
    /// </summary>
    public void AdvanceImmediately()
    {
        // reset the highlight of the completed step
        var currentStep = _steps[_currentStepIndex];
        currentStep.Highlight.gameObject.SetActive(false);
        currentStep.Highlight.rotation = Quaternion.identity;
  
        _currentStepIndex++;
  
        // check if this was the last goal
        if (_currentStepIndex == _steps.Length)
        {
            _onCompletion.Invoke();
            _currentStepIndex = default;
        }
        else
        {
            currentStep = _steps[_currentStepIndex];
            currentStep.Highlight.gameObject.SetActive(true);
  
            _onAdvancedStep.Invoke();
  
            this.enabled = false;
        }
    }
  
    [System.Serializable]
    public class Step
    {
        [field: SerializeField, Tooltip("The object who's rotation will be observed.")]
        public Transform Observing { get; private set; }
  
        [field: SerializeField, Tooltip("The object acting as a guide for the end position.")]
        public Transform Highlight { get; private set; }
  
        [field: SerializeField, Tooltip("The desired rotation of the axis")]
        public float TargetRotation { get; private set; }
  
        [field: SerializeField, Tooltip("The axis to be tested.")]
        public Axis Axis { get; private set; }
        public ArticulationDrive[] InitialRotations { get; set; }
    }
    public enum Axis { X, Y, Z }
}
```
  
Now I can showcase the rotation per axis one after each other.
  
![](../XR%20Development/DocAssets/rotatebase.png?0.892272465851649 )  
  
![](../XR%20Development/DocAssets/rotatebasearm.png?0.2944451511055177 )  
  
![](../XR%20Development/DocAssets/rotateend.png?0.7816485646499085 )  
  
However if the user manages to put the robot arm in such a position that they are stuck, we want them to be able to reset the position of all axes to the current step so they can try again.
  
To do this I first had to find out how to do this. My first approach was to make a copy of the current rotation of each rotating part of the robot arm, however when I reapplied the rotations it would work for a few frames before being put back into it's position before being reset. Since the robot arm is driven by physics with an articulation body, I decided to look at the documentation for the [articulation body component](https://docs.unity3d.com/2022.1/Documentation/ScriptReference/ArticulationBody.html ). After looking around I found that in order to set the rotation I have to modify the target property of the `xdrive` [ArticulationDrive](https://docs.unity3d.com/2022.1/Documentation/ScriptReference/ArticulationDrive.html ). After confirming this in Unity by changing the value in the inspector I decided to make a copy of the xdrive at each step so that they can be reapplied if there needs to be a reset.
  
```cs
  
[SerializeField] ArticulationBody[] _trackPerStep;
  
private void RecordRotation()
{
    var currentStep = _steps[_currentStepIndex];
  
    currentStep.InitialRotations = new ArticulationDrive[_trackPerStep.Length];
  
    for (int i = 0; i < _trackPerStep.Length; i++)
    {
        currentStep.InitialRotations[i] = _trackPerStep[i].xDrive;
    }
}
  
public void ResetRotation()
{
    var currentStep = _steps[_currentStepIndex];
  
    Assert.IsNotNull(currentStep.Highlight, "Cannot call ResetRotation at this point, as no rotations have been recorded.");
  
    for (int i = 0; i < currentStep.InitialRotations.Length; i++)
    {
        _trackPerStep[i].xDrive = currentStep.InitialRotations[i];
    }
}
```
  
I would call the `RecordRotation` function every time the current step would be changed. Now I can reset it to the position at the beginning of the step.
  
In order to build to a Quest device I have to take different steps compared to a standard PC build. To find out how I need to do it I watched [How To Build a Unity VR project to the Oculus Quest (and other devices)](https://www.youtube.com/watch?v=pNYY1JsS7tY ). This helped me with understanding what I need to do, I need to:
1. Set the build target to Android.
2. Set the minimum API level to Android 6.
  
Then I can detect a target device to deploy the build to, after I hit `Build And Run` it will start building the project and automatically put it on the quest.
  
A minor problem I've found is that it becomes a bit unmanageable to keep track of where the build is. To help me with this I looked for alternatives for how to deploy to the quest and found SideQuest. This program was pretty easy to use, as when I plugged in a Quest I was able to deploy apk's to the headset and even see the apps I put on it directly. It also gave me extra control options to stop and uninstall the app in case it causes problems.
  
After using it I prefer it over the standard way of deploying it to a Quest in Unity.
  