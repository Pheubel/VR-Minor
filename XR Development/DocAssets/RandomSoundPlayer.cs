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
