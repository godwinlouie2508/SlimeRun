using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public Text ScoreText;
    public Text HighScoreText;
    private float highscore;
    private float score;

    void Start()
    {
        highscore = PlayerPrefs.GetFloat("HighScore");
        score = PlayerPrefs.GetFloat("Score");

        ScoreText.text = "Score: " + score.ToString();
        HighScoreText.text = "High Score: " + highscore.ToString();
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    
}
