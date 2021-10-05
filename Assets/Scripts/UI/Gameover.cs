using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour
{
    public GameObject RestartButton;
    public GameObject ExitButton;
    
    public void OnButtonClick(Button button)
    {
        if(button.gameObject.name == "RestartButton")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Time.timeScale = 1f;
        }
        if(button.gameObject.name == "ExitButton")
        {
            Application.Quit();
        }
    }
}
