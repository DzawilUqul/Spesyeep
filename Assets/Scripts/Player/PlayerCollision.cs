using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public static GameManager Instance; //1
    [SerializeField] private GameObject playerEatImage;
    [SerializeField] private GameObject playerNotEatImage;

    private bool isPlayerEat = false;

    private void Start()
    {
        playerEatImage.SetActive(false);
        playerNotEatImage.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.tag == "Food")
        {
            Debug.Log("Eat Food");
            
            Destroy(other.gameObject);
            if (isPlayerEat == false)
            {
                StartCoroutine(PlayerEatImage());
                isPlayerEat = true;
            }
            else
            {
                isPlayerEat = false;
            }


            GameManager.instance.AddScore(1);
        }

    }

    // generate coroutine to delay the player eat image
    private IEnumerator PlayerEatImage()
    {
        playerEatImage.SetActive(true);
        playerNotEatImage.SetActive(false);
        yield return new WaitForSeconds(.5f);
        playerEatImage.SetActive(false);
        playerNotEatImage.SetActive(true);
        isPlayerEat = false;
    }
}
