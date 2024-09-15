using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFood : MonoBehaviour
{
    [SerializeField] private float destroyYThreshold = -6.8f; // The Y threshold for destroying the object

    // Update is called once per frame
    void Update()
    {
        // Check if the object's y position is below the threshold
        if (transform.position.y <= destroyYThreshold)
        {
            Destroy(gameObject); 
            Debug.Log("Food destroyed");
            GameManager.health -= 1;
        }
    }
}
