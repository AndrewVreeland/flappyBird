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
    public Text gameOverText;
    public int highScore;
    public Text highScoreText;
    public GameObject HighScoreGameObject;
    
    

    private void Start()
    {
        LoadPrefs();
        FindObjectOfType<AudioManager>().play("MainTheme");
    }

   

    [ContextMenu("increase score")] 
    public void addScore(int scoreToAdd) {

        FindObjectOfType<AudioManager>().play("ScoreChime");

        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
        SavePrefs();
        LoadPrefs();
    }

    public void RestartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver() {

        if (highScore == playerScore)
        {
            gameOverText.text = "New High Score: " + highScore.ToString();
        }
        else
        {
            gameOverText.text = " Game Over "; 
        }

        GameOverScreen.SetActive(true);

    }

    public void SavePrefs()
    {
        if (playerScore > highScore) {
            highScore = playerScore;
            PlayerPrefs.SetInt("HighScore", highScore);
            PlayerPrefs.Save();
        }

    }

    public void LoadPrefs() {
        highScore = PlayerPrefs.GetInt("HighScore");
        highScoreText.text = highScore.ToString();
        if (highScore > 0) {
            HighScoreGameObject.SetActive(true);  
        }
    }

}
