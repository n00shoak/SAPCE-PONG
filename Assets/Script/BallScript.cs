using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    public float maxSpeed;
    public float dir;

    private void Start()
    {
        if (dir == 0 )
            rb.velocity = Vector2.right * (maxSpeed / 4);
        else if (dir == 1 )
            rb.velocity = Vector2.left * (maxSpeed / 4);
        else if (dir == 2 )
            rb.velocity = Vector2.down * (maxSpeed / 4);
        else
            rb.velocity = Vector2.up * (maxSpeed / 4);
    }
    private void Update()
    {
        if(rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = Vector2.Lerp(Vector2.zero, rb.velocity, 0.5f);
        }
    }
}
