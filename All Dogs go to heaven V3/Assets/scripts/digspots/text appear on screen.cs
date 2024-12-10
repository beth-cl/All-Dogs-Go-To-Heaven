using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class textappearonscreen : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    bool collide;
    private collision col;
    // Start is called before the first frame update
    void Start()
    {
        textMeshPro.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        checkcollision();
    }

    void checkcollision()
    {
        col = new collision();
        collide = col.digCollision;
        if (collide == true)
        {
            textMeshPro.enabled = true;
        }
    }
}
