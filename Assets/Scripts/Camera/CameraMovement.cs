using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject target;
    public float xOffset;
    public float yOffsset;
    public float zOffset;
    public static float ZOffset = -7;

    // Update is called once per frame
    void Update()
    {
        zOffset = ZOffset;
        transform.position = target.transform.position + new Vector3(xOffset, yOffsset, zOffset);
        transform.LookAt(target.transform.position);
    }
}
