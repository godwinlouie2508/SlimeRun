using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DropDownManager : MonoBehaviour
{
    public GameObject ApplyButton;
    public Button Apply;
    public Button ExperimentButton;
    public InputField speedInput;
    public InputField cameraInput;    
    public Dropdown shapeDrop;
    public Toggle selectedToggle;

    void Start()
    {
        Apply.onClick.AddListener(SetSpeed);
        Apply.onClick.AddListener(SetCamera);
        selectedToggle.onValueChanged.AddListener(delegate { UserToggle(selectedToggle); });
    }

    // Update is called once per frame
    public void DebugClick(Button button)
    {
        if(shapeDrop.value == 0 && button.gameObject.name == "ApplyButton")
        {
            //Sphere player
            SceneManager.LoadScene("3_lane_sphere");
            PlayerMove.lane = 3f;
            Time.timeScale = 1f;
        }
        if (shapeDrop.value == 1 && button.gameObject.name == "ApplyButton")
        {
            //Cube player
            SceneManager.LoadScene("3_lane_cube");
            PlayerMove.lane = 3f;
            Time.timeScale = 1f;
        }
        if(button.gameObject.name == "ExperimentButton")
        {
            SceneManager.LoadScene("2_lane_cube");
            PlayerMove.lane = 2f;
            Time.timeScale = 1f;
        }
    }
    
    public void SetSpeed()
    {
        Debug.Log("The speed is " + speedInput.text);
        PlayerMove.speed = int.Parse(speedInput.text);
        Time.timeScale = 1f;
    }
    public void SetCamera()
    {
        CameraMovement.ZOffset = -(int.Parse(cameraInput.text));
        Time.timeScale = 1f;
    }
    public void UserToggle(Toggle togg)
    {

        Debug.Log(togg.isOn);
        JellyToggle.jellytog = togg.isOn;
    }
}
