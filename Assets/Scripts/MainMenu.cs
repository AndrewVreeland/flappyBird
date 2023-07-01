using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    public void PlayGame() {
        FindObjectOfType<AudioManager>().play("ButtonClick");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +2);
    }

    public void QuitGame() {
        FindObjectOfType<AudioManager>().play("ButtonClick");
        Application.Quit();
    }

    public void GoToSettings() {
        FindObjectOfType<AudioManager>().play("ButtonClick");
        SceneManager.LoadScene("SettingsMenu");
    }

    public void GotoMainMenu() {
        FindObjectOfType<AudioManager>().play("ButtonClick");
        SceneManager.LoadScene("MainMenu");
    }

    public void NextSong() {
        FindObjectOfType<AudioManager>().play("ButtonClick");

    }
}
