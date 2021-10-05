using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    
    public GameObject CreditsButton;
    public GameObject ReplayButton;
    public GameObject MenuButton;
    public GameObject ExitButton;

    public GameObject CreditsPanel;
    public GameObject EndgamePanel;
    public GameObject BackButton;
    
    private void Start()
    {
        CreditsPanel.SetActive(false);
    }

    public void OnButtonClick(Button button)
    {
        if (button.gameObject.name == "CreditsButton")
        {
            CreditsPanel.SetActive(true);
            EndgamePanel.SetActive(false);
            Time.timeScale = 1f;
        }
        if (button.gameObject.name == "ReplayButton")
        {
            SceneManager.LoadScene(1);
            Time.timeScale = 1f;
        }
        if (button.gameObject.name == "MenuButton")
        {
            SceneManager.LoadScene("MainMenu");
            Time.timeScale = 1f;
        }        
        if (button.gameObject.name == "ExitButton")
        {
            Application.Quit();
        }
        if (button.gameObject.name == "BackButton")
        {
            CreditsPanel.SetActive(false);
            EndgamePanel.SetActive(true);
        }
    }
}
