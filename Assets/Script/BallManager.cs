using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    [SerializeField] private GameObject ball;
    [SerializeField] private GameObject arrow;
    public float timer;
    int rnd;

    public GameObject blackHole;
    public float timeA , timeB ;

    private void Start()
    {
        StartCoroutine(spawn());
        StartCoroutine(riseDifficulty());
    }

    public void spawnBall()
    {
        StartCoroutine(spawn());
    }

    IEnumerator spawn()
    {
        rnd = Random.Range(0, 4);
        arrow.transform.rotation = Quaternion.Euler(0, 0, (rnd * 90));
        arrow.SetActive(true);
        yield return new WaitForSeconds(1);
        arrow.SetActive(false);
        GameObject bale = Instantiate(ball);
        BallScript baleScript = bale.GetComponent<BallScript>();
        baleScript.dir = rnd;
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
