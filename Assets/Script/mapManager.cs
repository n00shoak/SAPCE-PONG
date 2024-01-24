using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapManager : MonoBehaviour
{
    [SerializeField] GameObject[] maps;
    [SerializeField] GameObject[] preMaps;
    public float timer;
    public int index;

    private void Start()
    {
        StartCoroutine(spawnMap());
    }

    IEnumerator spawnMap()
    {
        if (index > maps.Length) { index = 0; }

        yield return new WaitForSeconds(timer);

        for (int i = 0; i < maps.Length; i++)
        {
            maps[i].SetActive(false);
            preMaps[i].SetActive(false);
        }

        if (index != 0)
        {
            preMaps[index - 1].SetActive(true);
        }

        yield return new WaitForSeconds(2);

        if(index != 0)
        {
            maps[index-1].SetActive(true);
        }
        index++;

        StartCoroutine(spawnMap());
    }

}
