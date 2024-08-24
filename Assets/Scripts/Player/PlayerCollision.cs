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
        }

        if (other.gameObject.tag == "FinishLine")
        {
            Debug.Log("Finish Line Reached!");
        }
    }
}
