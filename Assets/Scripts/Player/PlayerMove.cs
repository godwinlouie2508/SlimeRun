using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    Touch touch;
    
    public static float speed = 10f;
    public float speedController;    
    public GameObject gameOverPanel;
    public GameObject EndGamePanel;
    public GameObject gamePanel;    
    public static float lane = 3f;
    public AudioSource coin;

   
    void Start()
    {
        speedController = 0.01f;        
        gamePanel.SetActive(true);
        EndGamePanel.SetActive(false);
        gameOverPanel.SetActive(false);
        ScoringSystem.theScore = 0;

    }

    // Update is called once per frame
    void Update()
    {        
        if(SceneManager.GetActiveScene().buildIndex == 1)
        {
            lane = 3f;
        }
        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            lane = 2f;
        }
        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -lane)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < lane)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        //GetComponent<Rigidbody>().AddForce(Vector3.forward * speed * Time.deltaTime);

        // Touch Inputs
        if (Input.touchCount > 0 && transform.position.x >= -lane && transform.position.x <= lane)
        {
            touch = Input.GetTouch(0);
            transform.Translate(touch.deltaPosition.x * speedController, 0, 0);
        }
        else if (transform.position.x > lane)
        {
            transform.position = new Vector3(lane, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -lane)
        {
            transform.position = new Vector3(-lane, transform.position.y, transform.position.z);
        }
    }
    
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {           
            gameOverPanel.SetActive(true);
            gamePanel.SetActive(false);
            Time.timeScale = 0f;
        }
        if(other.gameObject.tag == "Collectible")
        {
            coin.Play();
            ScoringSystem.theScore += 1;
            Destroy(other.gameObject);
        }
        if(other.gameObject.tag == "Finish")
        {
            Time.timeScale = 0f;
            EndGamePanel.SetActive(true);
            gamePanel.SetActive(false);
            Destroy(gameObject);
        }       
    }
}
