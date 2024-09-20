using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFoods : MonoBehaviour
{
    [SerializeField] private GameObject[] foodPrefab;
    [SerializeField] private float spawnInterval = 2f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(SpawnFood), 0, spawnInterval);
    }
    
    // Spawns food at random positions
    private void SpawnFood()
    {
        // food spawn random pada x -7 sampai 7 dan y 6
        Vector3 spawnPosition = new Vector3(Random.Range(-27f, -17f), 6f, 0f);
        GameObject spawnedFood = Instantiate(foodPrefab[Random.Range(0, foodPrefab.Length)], spawnPosition, Quaternion.identity);

        // Ensure the spawned object has a Rigidbody2D component
        if (!spawnedFood.TryGetComponent<Rigidbody2D>(out _))
        {
            spawnedFood.AddComponent<Rigidbody2D>();
        }

        spawnedFood.AddComponent<DestroyFood>();
    }
}
