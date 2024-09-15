using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score = 0; 
    public TextMeshProUGUI scoreText;    
    public static GameManager instance;

    public GameObject gameOver, heart1, heart2, heart3;

    public static int health;

    void Start()
    {
        health = 3;
        
        heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        heart3.gameObject.SetActive(true);
        gameOver.gameObject.SetActive(false);
    }

    void Update()    
    {
        switch (health)
        {
            case 3:
                Debug.Log("3");
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                break;
            case 2:
            Debug.Log("2");
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(false);
                break;
            case 1:     
            Debug.Log("1");            
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                break;
            default:
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                gameOver.gameObject.SetActive(true);
                Time.timeScale = 0;
                break;                        
        }
    }
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
