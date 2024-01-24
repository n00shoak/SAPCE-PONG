using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class but : MonoBehaviour
{
    public int pv;
    public TextMeshProUGUI Health;
    public BallManager ballManager;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        pv--;
        ballManager.spawnBall();
    }

    private void Update()
    {
        Health.text = pv.ToString();
    }
}
