using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    public GameObject scoreText;
    public GameObject score2Text;
    public static int theScore;    
    
    void Update()
    {
        scoreText.GetComponent<Text>().text = theScore.ToString();
        score2Text.GetComponent<Text>().text = theScore.ToString();
    }
}
