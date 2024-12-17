using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextChange2 : MonoBehaviour
{
    public TextMeshProUGUI textUI; // Drag your TMP Text UI here

    private EventController eventcontroller;

    private void Start()
    {
        eventcontroller = new EventController();

    }

    private void Update()
    {
        
    }

    void ShowText()
    {
        if (eventcontroller.getcollision == true)
        {
            textUI.enabled = true;
        }
    }

    void HideText()
    {
        
    }
}
