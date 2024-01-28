using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuuhRaweBallController : MonoBehaviour
{
    public Vector2 speed;
    public float ballMagnitude;
    public bool canKick;

    private Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = speed;
        canKick = false;
    }

    private void Update()
    {

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
          
    }

    public void speedUpBall()
    {
        if (canKick)
        {
            rb.velocity *= ballMagnitude;
            Invoke("speedDownBall", 5f);
        }
    }

    public void speedDownBall()
    {
        rb.velocity /= ballMagnitude;
    }
}
