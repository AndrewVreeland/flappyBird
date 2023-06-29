using UnityEngine.Audio;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    // Start is called before the first frame update
    void Awake()
    {

        foreach (Sound sound in sounds) { 
            sound.audioSource = gameObject.AddComponent<AudioSource>();
            sound.audioSource.clip = sound.clip;
            sound.audioSource.volume = sound.volume;
            sound.audioSource.pitch = sound.pitch;
            sound.audioSource.loop = sound.loop;
        }

    }

    public void play(string name) {
       Sound sound =  Array.Find(sounds, sound => sound.name == name);
        if (sound != null) {
            Debug.Log("The Sound file " + sound + " was not found");
            return; } 
        sound.audioSource.Play();
    }
}
