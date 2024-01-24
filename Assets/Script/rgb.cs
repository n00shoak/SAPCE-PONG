using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rgb : MonoBehaviour
{

    Color actual, target;
    [SerializeField]SpriteRenderer[] rend;
    float index;

    private void Awake()
    {

        target = new Color(Random.value, Random.value, Random.value);
    }

    private void Update()
    {
        for(int i = 0; i < rend.Length; i++)
        {
            rend[i].color = Color.Lerp(actual, target, index);
        }
        index += 0.002f;

        if(index >= 1)
        {
            index = 0;
            actual = target;
            target = new Color(Random.value, Random.value, Random.value);
        }
    }

}
