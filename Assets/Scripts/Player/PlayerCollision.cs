using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("Hit Obstacle");
            
            Destroy(other.gameObject);

            GameManager.instance.AddScore(1);
        }

        if (other.gameObject.tag == "Trigger")
        {
            Debug.Log("Trigger Line Reached!");
        }
    }
    
}
