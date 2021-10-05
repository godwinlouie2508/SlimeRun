using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{ 
    public GameObject HomePanel;
    public GameObject DebugPanel;
    public GameObject PlayButton;
    public GameObject DebugButton;
    public GameObject ExitButton;
    
    public GameObject BackButton;
    public GameObject ApplyButton;


    void Start()
    {
        HomePanel.SetActive(true);
        DebugPanel.SetActive(false);
        
    }

    public void OnButtonClick(Button button)
    {        
        if(button.gameObject.name == "PlayButton")
        {
            SceneManager.LoadScene(1);
            Time.timeScale = 1f;
        }
        if (button.gameObject.name == "DebugButton")
        {
            HomePanel.SetActive(false);
            DebugPanel.SetActive(true);
        }
        if (button.gameObject.name == "ExitButton")
        {
            Application.Quit();
        }
        if (button.gameObject.name == "BackButton")
        {
            DebugPanel.SetActive(false);
            HomePanel.SetActive(true);            
        }
        if (button.gameObject.name == "ApplyButton")
        {
            DebugPanel.SetActive(false);
            HomePanel.SetActive(true);
        }
    }
}
