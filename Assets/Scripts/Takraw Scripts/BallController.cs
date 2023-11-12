using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BallController : MonoBehaviour
{
    //public Vector2 resetPosition;
    //public float defaultSpeed = 5.0f;

    //private Rigidbody2D rb;
    //private float currentSpeed;

    //void Start()
    //{
    //    rb = GetComponent<Rigidbody2D>();
    //    ResetSpeed();
    //}

    //void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.CompareTag("Paddle"))
    //    {
    //        // Calculate the new direction of the ball
    //        Vector2 hitPoint = collision.contacts[0].point;
    //        Vector2 paddleCenter = collision.gameObject.transform.position;

    //        float yOffset = hitPoint.y - paddleCenter.y;

    //        // Calculate a normalized direction vector based on the Y offset
    //        Vector2 direction = new Vector2(rb.velocity.x, yOffset).normalized;

    //        // Increase the speed
    //        currentSpeed += 1.0f; // You can adjust the increment value as needed

    //        // Apply the new direction to the ball with the updated speed
    //        rb.velocity = direction * currentSpeed;
    //    }
    //}

    //public void ResetBall()
    //{
    //    transform.position = new Vector3(resetPosition.x, resetPosition.y, 1);
    //    ResetSpeed();
    //}

    //private void ResetSpeed()
    //{
    //    currentSpeed = defaultSpeed;
    //    rb.velocity = new Vector2(defaultSpeed, 0);
    //}

    public Vector3 spawnBallP1;
    public Vector3 spawnBallP2;
    public Vector3 paddleP1Respawn;
    public Vector3 paddleP2Respawn;
    public GameObject goalP1;
    public GameObject goalP2;
    public GameObject outP1;
    public GameObject outP2;
    public GameObject paddleP1;
    public GameObject paddleP2;

    public Text p1ScoreText;
    public Text p2ScoreText;
    public int p1Score = 0;
    public int p2Score = 0;
    private Rigidbody2D rb;

    void Start()
    {
        // Get the Rigidbody2D component
        rb = GetComponent<Rigidbody2D>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if Object A collided with another GameObject
        if (other.gameObject == goalP1)
        {
            p2Score += 1;
            p2ScoreText.text = p2Score.ToString();
            // Reset the position of Object A to its initial position
            transform.position = spawnBallP2;
            paddleP1.transform.position = paddleP1Respawn;
            paddleP2.transform.position = paddleP2Respawn;
            rb.Sleep();

        }
        if (other.gameObject == goalP2)
        {
            p1Score += 1;
            p1ScoreText.text = p1Score.ToString();
            // Reset the position of Object A to its initial position
            transform.position = spawnBallP1;
            paddleP1.transform.position = paddleP1Respawn;
            paddleP2.transform.position = paddleP2Respawn;
            rb.Sleep();
        }
        if (other.gameObject == outP1)
        {
            p1Score += 1;
            p1ScoreText.text = p1Score.ToString();
            // Reset the position of Object A to its initial position
            transform.position = spawnBallP1;
            paddleP1.transform.position = paddleP1Respawn;
            paddleP2.transform.position = paddleP2Respawn;
            rb.Sleep();
        }
        if (other.gameObject == outP2)
        {
            p2Score += 1;
            p2ScoreText.text = p2Score.ToString();
            // Reset the position of Object A to its initial position
            transform.position = spawnBallP2;
            paddleP1.transform.position = paddleP1Respawn;
            paddleP2.transform.position = paddleP2Respawn;
            rb.Sleep();
        }
    }
}
