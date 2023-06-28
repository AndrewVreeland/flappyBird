using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject GameOverScreen;
    public AudioSource myAudioSource;

    [ContextMenu("increase score")] 
    public void addScore(int scoreToAdd) {
        myAudioSource.Play();
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
        
    }

    public void RestartGame() {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver() { 
    GameOverScreen.SetActive(true);
    }

}
