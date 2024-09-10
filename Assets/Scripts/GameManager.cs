using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class GameManager : MonoBehaviour
{
    public int score = 0; 
    public TextMeshProUGUI scoreText;    public static GameManager instance;
    private void Awake()
    {
        // If there is no existing instance of GameManager
        if (instance == null)
        {
            // Set this instance as the active GameManager
            instance = this;
            // Ensure GameManager is not destroyed when loading a new scene
            DontDestroyOnLoad(gameObject); 
        }
        else
        {
            // Destroy the new GameManager instance if one already exists
            Destroy(gameObject); 
        }
    }
    
    public void AddScore(int points)
    {
        score += points;
        scoreText.text = "Score : " + score.ToString();
    }

}
