using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //[SerializeField] private float movespeed = 250f;
    //[SerializeField] private float jumpforce = 200;
    [SerializeField] private Rigidbody rb;

    public GameObject rightPosition, leftPosition;
    public bool changePosition, canJump, startGame = true, playerOnGround = true;
    public float speed;
    public float distanceToGround = 0.05f;

    public bool isGrounded;
    public Vector3 jump;
    public float jumpForce = 2.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(Vector3.forward * speed * Time.deltaTime);
        //var vel = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * movespeed;
        //vel.y = rb.velocity.y;
        //rb.velocity = vel;
        
        if (changePosition == true && startGame == true)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(rightPosition.transform.position.x, transform.position.y, transform.position.z), 10f * Time.deltaTime);
        }
        if (changePosition == false && startGame == true)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(leftPosition.transform.position.x, transform.position.y, transform.position.z), 10f * Time.deltaTime);
        }
        if(Input.GetMouseButtonDown(0) && startGame == true)
        {
            startGame = true;
            if(changePosition==false)
            {
                changePosition = true;
            } else if(changePosition==true)
            {
                changePosition = false;
            }
        }
        
    }
    //bool isGrounded()
    //{
    //    return Physics.Raycast(transform.position, Vector3.down, distanceToGround);
    //}
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {

            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
        //CheckGroundStatus();

        //if (Input.GetMouseButtonDown(1) /*&& playerOnGround*/)
        //{
        //    if (canJump)
        //    {
        //        canJump = false;

        //        rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
        //        //rb.AddForce(Vector3.up * jumpforce);
        //        //playerOnGround = false;
        //    }
        //}


        //if(isGrounded())
        //{
        //    playerOnGround = true;
        //}

    }
    void CheckGroundStatus()
    {
        RaycastHit hit;
        Ray landingRay = new Ray(transform.position, Vector3.down);
        Debug.DrawRay(transform.position, Vector3.down * distanceToGround);
        if(Physics.Raycast(landingRay, out hit, distanceToGround))
        {
            if(hit.collider == null)
            {
                canJump = false;
                Debug.Log(canJump);
            }
            else
            {
                canJump = true;
                Debug.Log(canJump);
            }
        }
    }
    void OnCollisionStay()
    {
        isGrounded = true;
    }
}
