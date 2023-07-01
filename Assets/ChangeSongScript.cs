using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    private MusicScript musicScript;

    private void Awake()
    {
        musicScript = FindObjectOfType<MusicScript>();
    }

    public void NextSong()
    {
        

        if (musicScript != null)
        {
            musicScript.ChangeSong();
        }

        FindObjectOfType<AudioManager>().play("ButtonClick");
    }
}
