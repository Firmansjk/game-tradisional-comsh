using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BallController : MonoBehaviour
{
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

    private void OnCollisionEnter2D(Collision2D other)
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
