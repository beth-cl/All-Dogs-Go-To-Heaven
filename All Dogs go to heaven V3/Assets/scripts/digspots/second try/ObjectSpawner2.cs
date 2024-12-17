using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner2 : MonoBehaviour
{
    private EventController eventcontroller;

    public GameObject objecttospawn;
    public Vector3 spawnAreaSize = new Vector3(10f, 0f, 10f);
    public float spawndelay = 2f;
    
    // Start is called before the first frame update
    void Start()
    {
        eventcontroller = new EventController(); 
    }

    // Update is called once per frame
    void Update()
    {
        while (eventcontroller.currentspawns < eventcontroller.maxspawns)
        {
            //InvokeRepeating("SpawnObject", 0f, spawnInterval);  // Spawns objects repeatedly at set intervals
            SpawnObject();
            //IncreaseSpawnCount();
            eventcontroller.currentspawns++;
        }
    }
    public void SpawnObject()
    {
        Vector3 randomPosition = transform.position + new Vector3(Random.Range(-spawnAreaSize.x / 2, spawnAreaSize.x / 2), 0f, Random.Range(-spawnAreaSize.z / 2, spawnAreaSize.z / 2));
        Instantiate(objecttospawn, randomPosition, Quaternion.identity);
    }
}
