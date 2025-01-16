using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class but : MonoBehaviour
{
    [SerializeField] playerManager plMang;
    public int player;
    public int pv;
    public TextMeshProUGUI Health;
    public BallManager ballManager;
    Color baseColor;
    public SpriteRenderer[] rend;

    int flashIndex;
    int count;

    private void Awake()
    {
        baseColor = Health.color;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        pv--;
        ballManager.spawnBall();
        StartCoroutine(flash());
    }

    private void Update()
    {
        Health.text = pv.ToString();
        plMang.pv[player] = pv;
    }

    IEnumerator flash()
    {

        if(count >= 10)
        {
            count = 0;
            flashIndex++;
        }

        if(flashIndex == 0)
        {
            Health.color = Color.Lerp(Health.color, Color.white, 0.5f);
            rend[0].color = Color.Lerp(Health.color, Color.white, 0.5f);
            rend[1].color = Color.Lerp(Health.color, Color.white, 0.5f);
            count++;
            yield return new WaitForSeconds(0.001f);
        }
        if (flashIndex == 1)
        {
            Health.color = Color.Lerp(Health.color, baseColor, 0.5f);
            rend[0].color = Color.Lerp(Health.color, baseColor, 0.5f);
            rend[1].color = Color.Lerp(Health.color, baseColor, 0.5f);
            count++;
            yield return new WaitForSeconds(0.001f);
        }
        if (flashIndex == 2)
        {
            Health.color = Color.Lerp(Health.color, Color.white, 0.5f);
            rend[0].color = Color.Lerp(Health.color, Color.white, 0.5f);
            rend[1].color = Color.Lerp(Health.color, Color.white, 0.5f);
            count++;
            yield return new WaitForSeconds(0.001f);
        }
        if (flashIndex == 3)
        {
            Health.color = Color.Lerp(Health.color, baseColor, 0.5f);
            rend[0].color = Color.Lerp(Health.color, baseColor, 0.5f);
            rend[1].color = Color.Lerp(Health.color, baseColor, 0.5f);
            count++;
            yield return new WaitForSeconds(0.001f);
        }

        if(flashIndex >= 4)
        {
            flashIndex = 0;
            count = 0;
        }
        else
        {
            StartCoroutine(flash());
        }
    }
}
