using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;

    

    public static int scoreCount;

    /*private void start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }*/

    void Update()
    {
        scoreText.text = "Score: " + Mathf.Round(scoreCount); 
    }
}
