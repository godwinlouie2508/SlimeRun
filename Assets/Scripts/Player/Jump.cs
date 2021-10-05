using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public Vector3 jump;
    public float jumpForce = 3.0f;
    public GameObject jumpButton;
    public bool isGrounded;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

    void OnCollisionStay()
    {
        isGrounded = true;
    }

    void Update()
    {
        
        //if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        //{
        //    rb.AddForce(jump * jumpForce, ForceMode.Impulse);
        //    isGrounded = false;
        //}
        
    }
    public void IsJumping()
    {

        if (isGrounded)
        {
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            //rb.AddForce(Vector3.up * 300f);
            isGrounded = false;
        }
    }
}
