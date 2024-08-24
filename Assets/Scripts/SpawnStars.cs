using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStars : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Spawn stars at random positions
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space key pressed");
            float randomX = Random.Range(-10, 10);
            float randomY = Random.Range(-10, 10);
            Vector3 randomPosition = new Vector3(randomX, randomY, 0);
            Instantiate(gameObject, randomPosition, Quaternion.identity);
        }
    }
}
