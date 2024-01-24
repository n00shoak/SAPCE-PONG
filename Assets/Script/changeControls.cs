using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class changeControls : MonoBehaviour
{
    public KeyCode currentKey;
    public TextMeshProUGUI text;
    public bool reading = false;

    public void readKey()
    {
        reading = true;
    }

    void OnGUI()
    {
        
        if(reading)
        {
            Event e = Event.current;
            if (e.isKey)
            {
                currentKey = e.keyCode;
                reading = false;
                text.text = e.keyCode.ToString();
            }
        }

    }
}
