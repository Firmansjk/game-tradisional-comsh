using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1BarController : MonoBehaviour
{
    public Player1ButtonController player1ButtonControllerScript;
    public float speed = 5f; // Adjust the speed as needed
    public float maxRightPosition;
    public float maxLeftPosition;
    public GameObject targetP1;
    public Button buttonP1;
    public bool canPoint;

    private bool movingRight = true;

    private void Update()
    {
        if (movingRight)
        {
            // Move towards the right
            transform.Translate(Vector3.right * speed * Time.deltaTime);

            // Check if the object reached x
            if (transform.position.x >= maxRightPosition)
            {
                movingRight = false; // Change direction
            }
        }
        else
        {
            // Move towards the left
            transform.Translate(Vector3.left * speed * Time.deltaTime);

            // Check if the object reached x=0
            if (transform.position.x <= maxLeftPosition)
            {
                movingRight = true; // Change direction
            }
        }


    }

    public void PointingScoreP1()
    {
        //pointing
        if (canPoint)
        {
            player1ButtonControllerScript.AddScoreP1();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == targetP1)
        {
            canPoint = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject == targetP1)
        {
            canPoint = false;
        }
    }
}
