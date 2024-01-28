using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuuhRaweBallController : MonoBehaviour
{
    public Vector2 speed;
    public float ballMagnitude;
    public bool canKick;
    public GameObject kickZone1;
    public GameObject kickZone2;

    private Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = speed;
        canKick = false;
    }

    public void speedUpBall()
    {
        if (canKick)
        {
            rb.velocity *= ballMagnitude;
            canKick = false;
            Invoke("speedDownBall", 2f);
        }
    }

    public void speedDownBall()
    {
        rb.velocity /= ballMagnitude;
    }
}
