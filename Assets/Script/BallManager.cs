using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    [SerializeField] private GameObject ball;
    public float timer;

    public GameObject blackHole;
    public float timeA , timeB ;

    private void Start()
    {
        spawnBall();
        StartCoroutine(riseDifficulty());
    }
    public void spawnBall()
    {
        Instantiate(ball);
        StopCoroutine(nextBall());
        //StartCoroutine(nextBall());
    }

    IEnumerator nextBall()
    {
        yield return new WaitForSeconds(timer);
        spawnBall();
        yield return null;
    }

    IEnumerator riseDifficulty()
    {
        yield return new WaitForSeconds(10);
        StartCoroutine(spawBlackHole());
    }

    IEnumerator spawBlackHole()
    {
        yield return new WaitForSeconds(Random.Range(timeA,timeB));
        GameObject _blackHole = Instantiate(blackHole);
        _blackHole.transform.position = new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), 0);
        _blackHole.transform.localScale = new Vector3(Random.Range(0.5f, 1), Random.Range(0.5f, 1), 1);
        StartCoroutine(spawBlackHole());

    }


}
