using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DATA : MonoBehaviour
{
    public changeControls[] controls;

    public KeyCode[] j1 = new KeyCode[2];
    public KeyCode[] j2 = new KeyCode[2];
    public KeyCode[] j3 = new KeyCode[2];
    public KeyCode[] j4 = new KeyCode[2];

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    public void readData()
    {
        j1[0] = controls[0].currentKey;
        j1[1] = controls[1].currentKey;

        j2[0] = controls[2].currentKey;
        j2[1] = controls[3].currentKey;

        j3[0] = controls[4].currentKey;
        j3[1] = controls[5].currentKey;

        j4[0] = controls[6].currentKey;
        j4[1] = controls[7].currentKey;
    }
}
