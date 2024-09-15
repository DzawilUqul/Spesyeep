using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class RestartGame : MonoBehaviour
{
    public GameObject gameOver;
    public static int scoreCount;

    public void RestartLevel()
    {
        Debug.Log("Restarting game");        
        Time.timeScale = 1;
        GameManager.health = 3;
        GameManager.instance.ResetScore();
        
        gameOver.gameObject.SetActive(false);
        ScoreManager.scoreCount = 0;
    }
}
