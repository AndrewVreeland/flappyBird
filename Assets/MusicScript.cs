using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MusicScript : MonoBehaviour
{
    public static MusicScript instance;
    private List<string> songs = new List<string>();
    private int currentSongIndex = 0;

    void Awake()
    {
        songs.Add("LandingTheme");
        songs.Add("MainTheme");
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {


        FindObjectOfType<AudioManager>().play(songs[currentSongIndex]);
    }


    public void ChangeSong()
    {
        // Increment the current song index
        currentSongIndex++;

        // Check if the index is out of bounds
        if (currentSongIndex >= songs.Count)
        {
            // Wrap around to the first song
            currentSongIndex = 0;
        }

        // Stop the currently playing song
        FindObjectOfType<AudioManager>().StopAllSongs();

        // Play the next song
        FindObjectOfType<AudioManager>().play(songs[currentSongIndex]);
    }


}
