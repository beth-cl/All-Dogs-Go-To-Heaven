using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class OjectSpawner :MonoBehaviour
{
    public GameObject objectToSpawn; // The object to spawn (assign the prefab in the Inspector)
    //public float spawnInterval = 3f; // Time interval between spawns (in seconds)
    public Vector3 spawnAreaSize = new Vector3(10f, 0f, 10f); // Defines the area where objects will spawn
    public int maxspawnCount = 10;
    public float respawnDelay = 2f;

    private int spawnCount = 0;
    spawncountcheapout cheapout = new spawncountcheapout();
    //int var =  cheapout.GetSpawnCount();



    // funtions for when the spawn count was a private variable
    /*public int GetSpawnCount() // get function for private variable
    {
        return spawnCount;
    }

    public void SetSpawnCount(int PublicCount) // set function for private variable
    {
        spawnCount = PublicCount;
    }

    public void DecreaseSpawnCount() // decrease spawncount
    {
        spawnCount--;
    }

    public void IncreaseSpawnCount() // increase spawncount
    {
        spawnCount++;
    }*/

    private void Update()
    {
        // Start the spawn process
        if (spawnCount < maxspawnCount)
        {
            //InvokeRepeating("SpawnObject", 0f, spawnInterval);  // Spawns objects repeatedly at set intervals
            SpawnObject();
            //IncreaseSpawnCount();
            spawnCount++;
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

    public void OnDestroy()
    {
        //Destroy(objectToSpawn);
        StartCoroutine(RespawnObjectAfterDelay());
        Debug.Log("test onobject destroyed");
    }

    private IEnumerator RespawnObjectAfterDelay()
    {
        yield return new WaitForSeconds(respawnDelay);
        SpawnObject();
    }

}
