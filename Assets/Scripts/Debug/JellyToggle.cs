using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JellyToggle : MonoBehaviour
{
    public static bool jellytog = true;
    public GameObject player;
    void Start()
    {
        changejelly();
    }
    void Update()
    {
        
    }
    // Update is called once per frame
    public void changejelly()
    {
        if (jellytog == true)
        {
            player.GetComponent<JellyMesh>().enabled = true;
        }
        if (jellytog == false)
        {
            player.GetComponent<JellyMesh>().enabled = false;
        }
    }
}
