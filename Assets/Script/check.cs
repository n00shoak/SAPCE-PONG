using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class check : MonoBehaviour
{
    public bool starting;
    bool jar, jbr, jcr, jdr;
    public TextMeshProUGUI[] texts;
    public GameObject[] begin;
    public GameObject[] ui;

    private void Update()
    {
        if(starting)
        {
            if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D)) { jar = true; texts[0].color = Color.red; }
            if (Input.GetKey(KeyCode.K) && Input.GetKey(KeyCode.L)) { jbr = true; texts[1].color = Color.blue; }
            if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.RightArrow)) { jcr = true; texts[2].color = Color.green; }
            if (Input.GetKey(KeyCode.Keypad2) && Input.GetKey(KeyCode.Keypad3)) { jdr = true; texts[3].color = Color.yellow; }

            if(jar && jbr &&  jcr && jdr) 
            {
                for(int i = 0; i < begin.Length; i++)
                {
                    begin[i].SetActive(true);
                }
                for (int i = 0; i < ui.Length; i++)
                {
                    ui[i].SetActive(false);
                }
            }
        }
    }
}
