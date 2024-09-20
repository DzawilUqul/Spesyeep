using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    
    public GameObject gameOver;
    public static int scoreCount;
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1f;
        
    }

    public void ExitGame()
    {
        Debug.Log("Game is exiting...");
        Application.Quit();
    }

    public void RestartLevel()
    {
        Debug.Log("Restarting game");        
        Time.timeScale = 1;
        GameManager.health = 3;

        GameManager.instance.ResetScore();

        // ScoreManager.scoreCount = 0; // gak mau reset score
        gameOver.gameObject.SetActive(false);
        ScoreManager.scoreCount = 0;
    }

    public void ExitToMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
}
