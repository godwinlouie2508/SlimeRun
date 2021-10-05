using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelect : MonoBehaviour
{
    public static int playerSelect = 1;
    public GameObject sphere;
    public GameObject sphereCamera;
    public GameObject sphereJump;
    public GameObject sphereToggler;
    public GameObject sphereside;
    public GameObject spheretop;
    public GameObject cube;
    public GameObject cubeCamera;
    public GameObject cubeJump;
    public GameObject cubeToggler;
    public GameObject cubeside;
    public GameObject cubetop;

    private void Start()
    {
        PlayerChoose();
    }
    public void PlayerChoose()
    {
        if(playerSelect == 0)
        {
            sphere.SetActive(true);
            sphereCamera.SetActive(true);
            sphereJump.SetActive(true);
            sphereToggler.SetActive(true);
            sphereside.SetActive(true);
            spheretop.SetActive(true);
            cube.SetActive(false);
            cubeCamera.SetActive(false);
            cubeJump.SetActive(false);
            cubeToggler.SetActive(false);
            cubeside.SetActive(false);
            cubetop.SetActive(false);
        }
        if (playerSelect == 1)
        {
            sphere.SetActive(false);
            sphereCamera.SetActive(false);
            sphereJump.SetActive(false);
            sphereToggler.SetActive(false);
            sphereside.SetActive(false);
            spheretop.SetActive(false);
            cube.SetActive(true);
            cubeCamera.SetActive(true);
            cubeJump.SetActive(true);
            cubeToggler.SetActive(true);
            cubeside.SetActive(true);
            cubetop.SetActive(true);
        }
    }
}
