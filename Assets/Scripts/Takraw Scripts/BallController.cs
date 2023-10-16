using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector2 resetPosition;
    public float defaultSpeed = 5.0f;

    private Rigidbody2D rb;
    private float currentSpeed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ResetSpeed();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Paddle"))
        {
            // Calculate the new direction of the ball
            Vector2 hitPoint = collision.contacts[0].point;
            Vector2 paddleCenter = collision.gameObject.transform.position;

            float yOffset = hitPoint.y - paddleCenter.y;

            // Calculate a normalized direction vector based on the Y offset
            Vector2 direction = new Vector2(rb.velocity.x, yOffset).normalized;

            // Increase the speed
            currentSpeed += 1.0f; // You can adjust the increment value as needed

            // Apply the new direction to the ball with the updated speed
            rb.velocity = direction * currentSpeed;
        }
    }

    public void ResetBall()
    {
        transform.position = new Vector3(resetPosition.x, resetPosition.y, 1);
        ResetSpeed();
    }

    private void ResetSpeed()
    {
        currentSpeed = defaultSpeed;
        rb.velocity = new Vector2(defaultSpeed, 0);
    }
}
