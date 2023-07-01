using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class VolumeSliderScript : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    // Start is called before the first frame update
    private void Start()
    {
        if (!PlayerPrefs.HasKey("MasterVolume"))
        {
            PlayerPrefs.SetFloat("MasterVolume", 1);
            Load();
        }
        else
        {
            Load();
        }
    }


   

    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;

        Save();

    }

    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("MasterVolume");
    }
    private void Save()
    {
        PlayerPrefs.SetFloat("MasterVolume", volumeSlider.value);
    }
}
