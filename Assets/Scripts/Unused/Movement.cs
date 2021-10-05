using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    CharacterController cc;
    bool canmove = true;
    Vector3 movec = Vector3.zero;
    int lane = 1;
    int targetLane = 1;
    public float speed;

    void Start()
    {
        cc = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //GetComponent<Rigidbody>().AddForce(Vector3.forward * speed * Time.deltaTime);
        Vector3 pos = gameObject.transform.position;
        if (!lane.Equals(targetLane))
        {
            if(targetLane==0 && pos.x < -2)
            {
                gameObject.transform.position = new Vector3(-2f, pos.y, pos.z);
                lane = targetLane;
                canmove = true;
                movec.x = 0;
            }else if(targetLane==1 && (pos.x>0 || pos.x<0))
            {
                if(lane==0 && pos.x > 0)
                {
                    gameObject.transform.position = new Vector3(0, pos.y, pos.z);
                    lane = targetLane;
                    canmove = true;
                    movec.x = 0;
                }else if(lane==2 && pos.x<0)
                {
                    gameObject.transform.position = new Vector3(0, pos.y, pos.z);
                    lane = targetLane;
                    canmove = true;
                    movec.x = 0;
                }
            }else if(targetLane==2 && pos.x > 2)
            {
                gameObject.transform.position = new Vector3(0, pos.y, pos.z);
                lane = targetLane;
                canmove = true;
                movec.x = 0;
            }
        }
        CheckInputs();
        if (!cc.isGrounded){
            movec.y = -4;
        }
        cc.Move(movec * Time.deltaTime);
    }
    void CheckInputs()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && canmove && lane > 0)
        {
            targetLane--;
            canmove = false;
            movec.x = -4;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && canmove && lane < 2)
        {
            targetLane++;
            canmove = false;
            movec.x = 4;
        }
    }
}
