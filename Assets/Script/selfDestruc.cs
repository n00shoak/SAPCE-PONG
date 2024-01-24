using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class selfDestruc : MonoBehaviour
{
    public float timerStart , timerEnd;

    private void Start()
    {
        StartCoroutine(death());
    }
    IEnumerator death()
    {
        yield return new WaitForSeconds(Random.Range(timerStart,timerEnd)); 
        Destroy(gameObject);
    }
}
