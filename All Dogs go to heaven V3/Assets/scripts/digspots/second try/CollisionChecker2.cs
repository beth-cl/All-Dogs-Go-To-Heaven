using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionChecker2 : MonoBehaviour
{
    private EventController eventcontroller;
    private ObjectSpawner2 objectspawner;
    // Start is called before the first frame update
    void Start()
    {
        eventcontroller = new EventController();
        objectspawner = new ObjectSpawner2();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("DigSite"))
        {
            Debug.Log("digsite detected");
            eventcontroller.currentspawns--;
            objectspawner.SpawnObject();
            Destroy(collision.gameObject);
            eventcontroller.getcollision = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("DigSite"))
        {
            Debug.Log("digsite no longer in range");
            eventcontroller.getcollision = true;
        }
    }
}
