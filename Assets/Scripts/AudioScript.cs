using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource backgroundJam;
    public AudioSource landingPageJam;
    public AudioSource scoreChime;
    void Start()
    {
        landingPageJam = gameObject.AddComponent<AudioSource>();
        backgroundJam = gameObject.AddComponent<AudioSource>();
        scoreChime = gameObject.AddComponent<AudioSource>();
        scoreChime.playOnAwake = false;
        backgroundJam.playOnAwake = true;
    }



    // Update is called once per frame
    void Update()
    {
        
    }

    void BackgroundJamTag() {
       
        
    }

    void LandingPageJamTag()
    {

    }
    void ScoreChimeTag()
    {
        scoreChime.Play();
    }




}
