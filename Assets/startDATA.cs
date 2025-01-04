using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startDATA : MonoBehaviour
{
    DATA data;
    [SerializeField] barController[] controller;

    private void Start()
    {
        data = FindObjectOfType<DATA>();
        /*
        controller[0].Left = data.j1[0];
        controller[0].Right = data.j1[1];

        controller[1].Left = data.j2[0];
        controller[1].Right = data.j2[1];

        controller[2].Left = data.j3[0];
        controller[2].Right = data.j3[1];

        controller[3].Left = data.j4[0];
        controller[3].Right = data.j4[1];
        */
    }


}
