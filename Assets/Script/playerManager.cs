using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerManager : MonoBehaviour
{
    [SerializeField] GameObject[] murs;
    [SerializeField] GameObject[] player;
    public int[] pv;


    private void Update()
    {
        if (pv[0] <= 0) { murs[0].SetActive(true); player[0].SetActive(false); }
        if (pv[1] <= 0) { murs[1].SetActive(true); player[1].SetActive(false); }
        if (pv[2] <= 0) { murs[2].SetActive(true); player[2].SetActive(false); }
        if (pv[3] <= 0) { murs[3].SetActive(true); player[3].SetActive(false); }
    }
}
