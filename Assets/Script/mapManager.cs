using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapManager : MonoBehaviour
{
    [SerializeField] GameObject[] maps;
    public float timer;
    public int index;

    private void Start()
    {
        StartCoroutine(spawnMap());
    }

    IEnumerator spawnMap()
    {
       
        yield return new WaitForSeconds(timer);

        for (int i = 0; i < maps.Length; i++)
        {
            maps[i].SetActive(false);
        }

        if (index > maps.Length) { index = 0; }

        if(index != 0)
        {
            Debug.Log("Prout " + maps.Length);
            maps[index-1].SetActive(true);
           
        }
        index++;

        StartCoroutine(spawnMap());
    }

}
