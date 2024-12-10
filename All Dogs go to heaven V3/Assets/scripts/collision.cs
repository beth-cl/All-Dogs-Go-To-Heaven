using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    bool digCollision = false;
    public OjectSpawner oject;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if the object that collided is a specific object
        if (collision.gameObject.CompareTag("DigSite"))
        {
            Debug.Log("Collision with DigSite detected!");
            Destroy(collision.gameObject);
            //digCollision = true;

            oject.DecreaseSpawnCount();


        }
    }

    void EditSpawnCount()
    {
        OjectSpawner spawner = new OjectSpawner();
        int count = spawner.GetSpawnCount();
    }
}
