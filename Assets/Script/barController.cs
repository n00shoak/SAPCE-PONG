using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class barController : MonoBehaviour
{
    public PhysicsMaterial2D[] bounce;
    public BoxCollider2D coll;
    public Image[] chargeFX;

    [SerializeField] private KeyCode Left;
    [SerializeField] private KeyCode Right;

    public bool v;

    public float speed;
    public float bounceBonus;
    public float bounceMaxCharge;
    [SerializeField] float bounceCharge;

    public float maxDist;
    float LimitDist;

    AudioSource soundSource;

    private void Awake()
    {
        if(v)
            LimitDist = transform.position.y + maxDist;
        else
            LimitDist = transform.position.x + maxDist;

        soundSource = GetComponent<AudioSource>();
    }


    private void Update()
    {
        // bounciness = bounceCharge

        if(Input.GetKey(Left) && Input.GetKey(Right) && bounceCharge < bounceMaxCharge) 
        {
            bounceCharge += bounceBonus * Time.deltaTime;
        }
        else
        {
            if (!v)
            {
                if (Input.GetKey(Left) && transform.position.x > -LimitDist) { transform.position += Vector3.left * speed * Time.deltaTime; }
                if (Input.GetKey(Right) && transform.position.x < LimitDist) { transform.position += Vector3.right * speed * Time.deltaTime; }
            }
            else
            {
               
                if (Input.GetKey(Left) && transform.position.y > -LimitDist) { transform.position += Vector3.down * speed * Time.deltaTime; }
                if (Input.GetKey(Right) && transform.position.y < LimitDist) { transform.position += Vector3.up * speed * Time.deltaTime; }
            }
            

            if(bounceCharge > 0)
            {
                //diminué la charge
                bounceCharge -= bounceBonus * 2 * Time.deltaTime;
            }
        }

        if (bounceCharge > bounceMaxCharge - 0.05f) { coll.sharedMaterial = bounce[3]; }
        else if (bounceCharge > (bounceMaxCharge / 4) * 3) { coll.sharedMaterial = bounce[2]; }
        else if (bounceCharge > bounceMaxCharge / 2) { coll.sharedMaterial = bounce[1]; }
        else if (bounceCharge > bounceMaxCharge / 4) { coll.sharedMaterial = bounce[0]; }

        for(int i = 0; i < chargeFX.Length ; i ++)
        {
            chargeFX[i].fillAmount = bounceCharge / bounceMaxCharge;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        soundSource.Play();
    }
}
