using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawncountcheapout
{
    public int spawnCount;

    // funtions for when the spawn count was a private variable
    public int GetSpawnCount() // get function for private variable
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
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
