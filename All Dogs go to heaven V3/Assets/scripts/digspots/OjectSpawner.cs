using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class OjectSpawner : MonoBehaviour
{
    public GameObject objectToSpawn; // The object to spawn (assign the prefab in the Inspector)
    //public float spawnInterval = 3f; // Time interval between spawns (in seconds)
    public Vector3 spawnAreaSize = new Vector3(10f, 0f, 10f); // Defines the area where objects will spawn
    public int maxspawnCount = 10;

     [SerializeField] private int spawnCount = 0;

    public int GetSpawnCount() // get function for private variable
    {
        return spawnCount;
    }

    public void SetSpawnCount(int PublicCount) // set function for private variable
    {
        spawnCount = PublicCount;
    }

    public void DecreaseSpawnCount()
    {
        spawnCount--;
    }

    public void IncreaseSpawnCount()
    {
        spawnCount++;
    }

    private void Start()
    {
        // Start the spawn process
        while (spawnCount < maxspawnCount)
        {
            //InvokeRepeating("SpawnObject", 0f, spawnInterval);  // Spawns objects repeatedly at set intervals
            SpawnObject();
            IncreaseSpawnCount();
            //Debug.Log(spawnCount + " " + maxspawnCount);
        }
        
    }

    private void Update()
    {
        if (spawnCount != maxspawnCount)
        {
            SpawnObject();
            IncreaseSpawnCount();
        }

    }

    void SpawnObject()
    {
        // Randomly position the object in the defined spawn area
        Vector3 randomPosition = transform.position + new Vector3(
            Random.Range(-spawnAreaSize.x / 2, spawnAreaSize.x / 2),
            0f,  // Use 0 for a 2D spawn, or change it for 3D height variation
            Random.Range(-spawnAreaSize.z / 2, spawnAreaSize.z / 2)
        );

        // Instantiate the object at the random position
        Instantiate(objectToSpawn, randomPosition, Quaternion.identity);
    }

}
