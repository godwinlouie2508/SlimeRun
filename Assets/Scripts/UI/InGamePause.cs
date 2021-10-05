using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class InGamePause : MonoBehaviour
{
    public GameObject PauseButton;
    public GameObject GamePanel;
    public GameObject PausePanel;
    public GameObject ResumeButtton;
    public GameObject MenuButton;
    public GameObject RestartButton;
    public GameObject ExitButton2;
    void Start()
    {
        PausePanel.SetActive(false);
        GamePanel.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnButtonClick(Button button)
    {
        if (button.gameObject.name == "PauseButton")
        {
            Time.timeScale = 0f;
            PausePanel.SetActive(true);
            GamePanel.SetActive(false);
        }
        if (button.gameObject.name == "ResumeButton")
        {
            PausePanel.SetActive(false);
            GamePanel.SetActive(true);
            Time.timeScale = 1f;
        }
        if (button.gameObject.name == "MenuButton")
        {
            SceneManager.LoadScene("MainMenu");
        }
        if (button.gameObject.name == "RestartButton")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Time.timeScale = 1f;
        }
        if (button.gameObject.name == "ExitButton")
        {
            Application.Quit();
        }
    }
}
